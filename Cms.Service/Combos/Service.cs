using Cms.Repository.Entities;
using Cms.Repository;
using Cms.Repository.Enums;
using Cms.Service.Common;
using Cms.Service.Models;
using Cms.Service.Queries;
using Cms.Service.Exceptions;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.Combos;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<CatalogQuery> _queryValidator;
    private readonly IValidator<Request.CreateComboRequest> _createValidator;
    private readonly IValidator<Request.UpdateComboRequest> _updateValidator;

    public Service(AppDbContext dbContext,
        IValidator<CatalogQuery> queryValidator,
        IValidator<Request.CreateComboRequest> createValidator,
        IValidator<Request.UpdateComboRequest> updateValidator)
    {
        _dbContext = dbContext;
        _queryValidator = queryValidator;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<List<Response.ComboListItem>> GetAllAsync()
    {
        return await _dbContext.Combos
            .AsNoTracking()
            .Include(x => x.Hotel).ThenInclude(x => x.HotelTaxonomyDetails).ThenInclude(x => x.Taxonomy)
            .Include(x => x.ComboTier)
            .Where(x => !x.IsDeleted)
            .OrderBy(x => x.SortOrder).ThenByDescending(x => x.UpdatedAt)
            .Select(x => new Response.ComboListItem
            {
                Id = x.Id,
                Slug = x.Slug,
                HotelId = x.HotelId,
                HotelName = x.Hotel.Name,
                CityName = x.Hotel.HotelTaxonomyDetails
                    .Where(ht => ht.Taxonomy.Group == TaxonomyGroup.City)
                    .Select(ht => ht.Taxonomy.Name)
                    .FirstOrDefault(),
                ComboTierId = x.ComboTierId,
                Tier = x.ComboTier.Name,
                Nights = x.Nights,
                Price = x.Price,
                Cover = x.Cover,
                Featured = x.Featured,
                SortOrder = x.SortOrder,
                UpdatedAt = x.UpdatedAt,
            })
            .ToListAsync();
    }

    public async Task<BasePaginationResponse> GetPagedAsync(CatalogQuery query)
    {
        await _queryValidator.ValidateAndThrowAsync(query);
        var (page, pageSize) = query.Normalized();

        var q = _dbContext.Combos
            .AsNoTracking()
            .Include(x => x.Hotel).ThenInclude(x => x.HotelTaxonomyDetails).ThenInclude(x => x.Taxonomy)
            .Include(x => x.ComboTier)
            .Where(x => !x.IsDeleted);

        if (!string.IsNullOrWhiteSpace(query.Search))
        {
            q = q.Where(c => EF.Functions.ILike(c.Hotel.Name, $"%{query.Search}%")
                          || c.Hotel.HotelTaxonomyDetails.Any(ht => EF.Functions.ILike(ht.Taxonomy.Name, $"%{query.Search}%")));
        }

        if (!string.IsNullOrWhiteSpace(query.City))
        {
            q = q.Where(c => c.Hotel.HotelTaxonomyDetails.Any(ht =>
                ht.Taxonomy.Group == TaxonomyGroup.City && ht.Taxonomy.Name == query.City));
        }

        if (!string.IsNullOrWhiteSpace(query.Tier))
        {
            q = q.Where(c => c.ComboTier.Name == query.Tier);
        }

        if (query.Featured.HasValue)
        {
            q = q.Where(c => c.Featured == query.Featured.Value);
        }

        var total = await q.CountAsync();
        var items = await q
            .OrderBy(c => c.SortOrder).ThenByDescending(c => c.UpdatedAt)
            .Skip((page - 1) * pageSize).Take(pageSize)
            .Select(x => new Response.ComboListItem
            {
                Id = x.Id,
                Slug = x.Slug,
                HotelId = x.HotelId,
                HotelName = x.Hotel.Name,
                CityName = x.Hotel.HotelTaxonomyDetails
                    .Where(ht => ht.Taxonomy.Group == TaxonomyGroup.City)
                    .Select(ht => ht.Taxonomy.Name)
                    .FirstOrDefault(),
                ComboTierId = x.ComboTierId,
                Tier = x.ComboTier.Name,
                Nights = x.Nights,
                Price = x.Price,
                Cover = x.Cover,
                Featured = x.Featured,
                SortOrder = x.SortOrder,
                UpdatedAt = x.UpdatedAt,
            })
            .ToListAsync();

        return ApiResponseFactory.BasePagination(items, page, pageSize, total);
    }

    public async Task<Response.ComboDetail> GetBySlugAsync(string slug)
    {
        var entity = await _dbContext.Combos
            .AsNoTracking()
            .Include(x => x.Hotel).ThenInclude(x => x.HotelTaxonomyDetails).ThenInclude(x => x.Taxonomy)
            .Include(x => x.ComboTier)
            .FirstOrDefaultAsync(c => c.Slug == slug && !c.IsDeleted);

        if (entity is null) throw new NotFoundException("Combo not found");
        return MapDetail(entity);
    }

    public async Task<Response.ComboDetail> CreateAsync(Request.CreateComboRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var hotel = await _dbContext.Hotels
            .Where(h => h.Id == request.HotelId)
            .Select(h => new { h.Name })
            .FirstOrDefaultAsync();
        if (hotel is null) throw new NotFoundException("Hotel not found");
        if (!await _dbContext.ComboTiers.AnyAsync(ct => ct.Id == request.ComboTierId))
            throw new NotFoundException("Combo tier not found");

        var hotelName = hotel.Name;
        var slug = SlugHelper.Slugify(request.Slug, hotelName);
        if (await _dbContext.Combos.AnyAsync(c => c.Slug == slug && !c.IsDeleted))
        {
            throw new ConflictException($"Slug '{slug}' already exists.");
        }

        var maxOrder = await _dbContext.Combos
            .Where(x => !x.IsDeleted)
            .MaxAsync(x => (int?)x.SortOrder) ?? 0;

        var now = DateTime.UtcNow;
        var entity = new Combo
        {
            Id = Guid.NewGuid(),
            CreatedAt = now,
            UpdatedAt = now,
        };
        Apply(entity, request, slug, maxOrder + 1);

        _dbContext.Combos.Add(entity);
        await _dbContext.SaveChangesAsync();

        await _dbContext.Entry(entity).Reference(x => x.Hotel).Query().Include(h => h.HotelTaxonomyDetails).ThenInclude(ht => ht.Taxonomy).LoadAsync();
        await _dbContext.Entry(entity).Reference(x => x.ComboTier).LoadAsync();

        return MapDetail(entity);
    }

    public async Task<Response.ComboDetail> UpdateAsync(string slug, Request.UpdateComboRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var entity = await _dbContext.Combos
            .Include(x => x.Hotel).ThenInclude(x => x.HotelTaxonomyDetails).ThenInclude(x => x.Taxonomy)
            .Include(x => x.ComboTier)
            .FirstOrDefaultAsync(c => c.Slug == slug && !c.IsDeleted);

        if (entity is null) throw new NotFoundException("Combo not found");

        var hotel = await _dbContext.Hotels
            .Where(h => h.Id == request.HotelId)
            .Select(h => new { h.Name })
            .FirstOrDefaultAsync();
        if (hotel is null) throw new NotFoundException("Hotel not found");
        if (!await _dbContext.ComboTiers.AnyAsync(ct => ct.Id == request.ComboTierId))
            throw new NotFoundException("Combo tier not found");

        var hotelName = hotel.Name;
        var newSlug = SlugHelper.Slugify(request.Slug, hotelName);
        if (await _dbContext.Combos.AnyAsync(c => c.Slug == newSlug && c.Id != entity.Id && !c.IsDeleted))
        {
            throw new ConflictException($"Slug '{newSlug}' already in use.");
        }

        Apply(entity, request, newSlug, entity.SortOrder);
        entity.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();

        await _dbContext.Entry(entity).Reference(x => x.Hotel).Query().Include(h => h.HotelTaxonomyDetails).ThenInclude(ht => ht.Taxonomy).LoadAsync();
        await _dbContext.Entry(entity).Reference(x => x.ComboTier).LoadAsync();

        return MapDetail(entity);
    }

    public async Task DeleteAsync(string slug)
    {
        var entity = await _dbContext.Combos
            .FirstOrDefaultAsync(c => c.Slug == slug && !c.IsDeleted);

        if (entity is null) throw new NotFoundException("Combo not found");

        entity.IsDeleted = true;
        entity.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();
    }

    private static void Apply(Combo e, dynamic r, string slug, int sortOrder)
    {
        e.Slug = slug;
        e.HotelId = r.HotelId;
        e.ComboTierId = r.ComboTierId;
        e.Nights = r.Nights;
        e.Price = r.Price?.Trim() ?? string.Empty;
        e.Featured = r.Featured;
        e.Cover = r.Cover?.Trim() ?? string.Empty;
        e.SortOrder = sortOrder;
    }

    private static Response.ComboDetail MapDetail(Combo entity)
    {
        return new Response.ComboDetail
        {
            Id = entity.Id,
            Slug = entity.Slug,
            HotelId = entity.HotelId,
            HotelName = entity.Hotel?.Name ?? string.Empty,
            CityName = entity.Hotel?.HotelTaxonomyDetails
                .Where(ht => ht.Taxonomy.Group == TaxonomyGroup.City)
                .Select(ht => ht.Taxonomy.Name)
                .FirstOrDefault(),
            ComboTierId = entity.ComboTierId,
            Tier = entity.ComboTier?.Name ?? string.Empty,
            Nights = entity.Nights,
            Price = entity.Price,
            Featured = entity.Featured,
            Cover = entity.Cover,
            SortOrder = entity.SortOrder,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt,
        };
    }
}
