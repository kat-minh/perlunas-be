using Cms.Repository.Entities;
using Cms.Repository;
using Cms.Repository.Enums;
using Cms.Service.Common;
using Cms.Service.Models;
using Cms.Service.Queries;
using Cms.Service.Exceptions;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.Hotels;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<CatalogQuery> _queryValidator;
    private readonly IValidator<Request.CreateHotelRequest> _createValidator;
    private readonly IValidator<Request.UpdateHotelRequest> _updateValidator;

    public Service(AppDbContext dbContext,
        IValidator<CatalogQuery> queryValidator,
        IValidator<Request.CreateHotelRequest> createValidator,
        IValidator<Request.UpdateHotelRequest> updateValidator)
    {
        _dbContext = dbContext;
        _queryValidator = queryValidator;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<List<Response.HotelListItem>> GetAllAsync()
    {
        return await _dbContext.Hotels
            .AsNoTracking()
            .Where(x => !x.IsDeleted)
            .OrderBy(x => x.SortOrder).ThenByDescending(x => x.UpdatedAt)
            .Select(x => new Response.HotelListItem
            {
                Id = x.Id,
                Slug = x.Slug,
                Name = x.Name,
                Price = x.Price,
                Desc = x.Desc,
                Cover = x.Cover,
                Featured = x.Featured,
                SortOrder = x.SortOrder,
                UpdatedAt = x.UpdatedAt,
                Cities = x.HotelTaxonomyDetails
                    .Where(ht => ht.Taxonomy.Group == TaxonomyGroup.City)
                    .Select(ht => new Response.TaxonomyItem { Id = ht.TaxonomyId, Name = ht.Taxonomy.Name })
                    .ToList(),
                StayTypes = x.HotelTaxonomyDetails
                    .Where(ht => ht.Taxonomy.Group == TaxonomyGroup.StayType)
                    .Select(ht => new Response.TaxonomyItem { Id = ht.TaxonomyId, Name = ht.Taxonomy.Name })
                    .ToList(),
            })
            .ToListAsync();
    }

    public async Task<BasePaginationResponse> GetPagedAsync(CatalogQuery query)
    {
        await _queryValidator.ValidateAndThrowAsync(query);
        var (page, pageSize) = query.Normalized();

        var q = _dbContext.Hotels
            .AsNoTracking()
            .Where(x => !x.IsDeleted);

        if (!string.IsNullOrWhiteSpace(query.Search))
        {
            q = q.Where(h => EF.Functions.ILike(h.Name, $"%{query.Search}%")
                          || h.HotelTaxonomyDetails.Any(ht => EF.Functions.ILike(ht.Taxonomy.Name, $"%{query.Search}%")));
        }

        if (!string.IsNullOrWhiteSpace(query.City))
        {
            q = q.Where(h => h.HotelTaxonomyDetails.Any(ht =>
                ht.Taxonomy.Group == TaxonomyGroup.City && ht.Taxonomy.Name == query.City));
        }

        if (!string.IsNullOrWhiteSpace(query.Type))
        {
            q = q.Where(h => h.HotelTaxonomyDetails.Any(ht =>
                ht.Taxonomy.Group == TaxonomyGroup.StayType && ht.Taxonomy.Name == query.Type));
        }

        if (query.Featured.HasValue)
        {
            q = q.Where(h => h.Featured == query.Featured.Value);
        }

        var total = await q.CountAsync();
        var items = await q
            .OrderBy(h => h.SortOrder).ThenByDescending(h => h.UpdatedAt)
            .Skip((page - 1) * pageSize).Take(pageSize)
            .Select(x => new Response.HotelListItem
            {
                Id = x.Id,
                Slug = x.Slug,
                Name = x.Name,
                Price = x.Price,
                Desc = x.Desc,
                Cover = x.Cover,
                Featured = x.Featured,
                SortOrder = x.SortOrder,
                UpdatedAt = x.UpdatedAt,
                Cities = x.HotelTaxonomyDetails
                    .Where(ht => ht.Taxonomy.Group == TaxonomyGroup.City)
                    .Select(ht => new Response.TaxonomyItem { Id = ht.TaxonomyId, Name = ht.Taxonomy.Name })
                    .ToList(),
                StayTypes = x.HotelTaxonomyDetails
                    .Where(ht => ht.Taxonomy.Group == TaxonomyGroup.StayType)
                    .Select(ht => new Response.TaxonomyItem { Id = ht.TaxonomyId, Name = ht.Taxonomy.Name })
                    .ToList(),
            })
            .ToListAsync();

        return ApiResponseFactory.BasePagination(items, page, pageSize, total);
    }

    public async Task<Response.HotelDetail> GetBySlugAsync(string slug)
    {
        var entity = await _dbContext.Hotels
            .AsNoTracking()
            .Include(x => x.HotelTaxonomyDetails).ThenInclude(x => x.Taxonomy)
            .FirstOrDefaultAsync(h => h.Slug == slug && !h.IsDeleted);

        if (entity is null) throw new NotFoundException("Hotel not found");
        return MapDetail(entity);
    }

    public async Task<Response.HotelDetail> CreateAsync(Request.CreateHotelRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var slug = SlugHelper.Slugify(request.Slug, request.Name);
        if (await _dbContext.Hotels.AnyAsync(h => h.Slug == slug && !h.IsDeleted))
        {
            throw new ConflictException($"Slug '{slug}' already exists.");
        }

        var allIds = request.CityIds.Concat(request.StayTypeIds).Distinct().ToList();
        if (allIds.Count != 0)
        {
            var validCount = await _dbContext.Taxonomies.CountAsync(t => allIds.Contains(t.Id));
            if (validCount != allIds.Count)
                throw new ValidationExceptionError("One or more taxonomy IDs are invalid.");
        }

        var maxOrder = await _dbContext.Hotels
            .Where(x => !x.IsDeleted)
            .MaxAsync(x => (int?)x.SortOrder) ?? 0;

        var now = DateTime.UtcNow;
        var entity = new Hotel
        {
            Id = Guid.NewGuid(),
            CreatedAt = now,
            UpdatedAt = now,
        };
        Apply(entity, request, slug, maxOrder + 1);

        var addedIds = new HashSet<Guid>();
        foreach (var id in request.CityIds)
            if (addedIds.Add(id))
                entity.HotelTaxonomyDetails.Add(new HotelTaxonomyDetails { HotelId = entity.Id, TaxonomyId = id });
        foreach (var id in request.StayTypeIds)
            if (addedIds.Add(id))
                entity.HotelTaxonomyDetails.Add(new HotelTaxonomyDetails { HotelId = entity.Id, TaxonomyId = id });

        _dbContext.Hotels.Add(entity);
        await _dbContext.SaveChangesAsync();

        await _dbContext.Entry(entity).Collection(x => x.HotelTaxonomyDetails).Query().Include(ht => ht.Taxonomy).LoadAsync();

        return MapDetail(entity);
    }

    public async Task<Response.HotelDetail> UpdateAsync(string slug, Request.UpdateHotelRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var entity = await _dbContext.Hotels
            .Include(x => x.HotelTaxonomyDetails)
            .FirstOrDefaultAsync(h => h.Slug == slug && !h.IsDeleted);

        if (entity is null) throw new NotFoundException("Hotel not found");

        var newSlug = SlugHelper.Slugify(request.Slug, request.Name);
        if (await _dbContext.Hotels.AnyAsync(h => h.Slug == newSlug && h.Id != entity.Id && !h.IsDeleted))
        {
            throw new ConflictException($"Slug '{newSlug}' already in use.");
        }

        var allIds = request.CityIds.Concat(request.StayTypeIds).Distinct().ToList();
        if (allIds.Count != 0)
        {
            var validCount = await _dbContext.Taxonomies.CountAsync(t => allIds.Contains(t.Id));
            if (validCount != allIds.Count)
                throw new ValidationExceptionError("One or more taxonomy IDs are invalid.");
        }

        entity.HotelTaxonomyDetails.Clear();
        var addedIds = new HashSet<Guid>();
        foreach (var id in request.CityIds)
            if (addedIds.Add(id))
                entity.HotelTaxonomyDetails.Add(new HotelTaxonomyDetails { HotelId = entity.Id, TaxonomyId = id });
        foreach (var id in request.StayTypeIds)
            if (addedIds.Add(id))
                entity.HotelTaxonomyDetails.Add(new HotelTaxonomyDetails { HotelId = entity.Id, TaxonomyId = id });

        Apply(entity, request, newSlug, entity.SortOrder);
        entity.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();

        await _dbContext.Entry(entity).Collection(x => x.HotelTaxonomyDetails).Query().Include(ht => ht.Taxonomy).LoadAsync();

        return MapDetail(entity);
    }

    public async Task DeleteAsync(string slug)
    {
        var entity = await _dbContext.Hotels
            .FirstOrDefaultAsync(h => h.Slug == slug && !h.IsDeleted);

        if (entity is null) throw new NotFoundException("Hotel not found");

        entity.IsDeleted = true;
        entity.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();
    }

    private static void Apply(Hotel e, dynamic r, string slug, int sortOrder)
    {
        e.Slug = slug;
        e.Name = (r.Name ?? string.Empty).Trim();
        e.Price = r.Price?.Trim() ?? string.Empty;
        e.Desc = r.Desc ?? string.Empty;
        e.Featured = r.Featured;
        e.Cover = r.Cover?.Trim() ?? string.Empty;
        e.SortOrder = sortOrder;
    }

    private static Response.HotelDetail MapDetail(Hotel entity)
    {
        return new Response.HotelDetail
        {
            Id = entity.Id,
            Slug = entity.Slug,
            Name = entity.Name,
            Price = entity.Price,
            Desc = entity.Desc,
            Featured = entity.Featured,
            Cover = entity.Cover,
            SortOrder = entity.SortOrder,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt,
            Cities = entity.HotelTaxonomyDetails
                .Where(ht => ht.Taxonomy.Group == TaxonomyGroup.City)
                .Select(ht => new Response.TaxonomyItem { Id = ht.TaxonomyId, Name = ht.Taxonomy.Name })
                .ToList(),
            StayTypes = entity.HotelTaxonomyDetails
                .Where(ht => ht.Taxonomy.Group == TaxonomyGroup.StayType)
                .Select(ht => new Response.TaxonomyItem { Id = ht.TaxonomyId, Name = ht.Taxonomy.Name })
                .ToList(),
        };
    }
}
