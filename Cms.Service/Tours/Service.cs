using Cms.Repository.Entities;
using Cms.Repository;
using Cms.Repository.Enums;
using Cms.Service.Common;
using Cms.Service.Models;
using Cms.Service.Queries;
using Cms.Service.Exceptions;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.Tours;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<CatalogQuery> _queryValidator;
    private readonly IValidator<Request.CreateTourRequest> _createValidator;
    private readonly IValidator<Request.UpdateTourRequest> _updateValidator;

    public Service(AppDbContext dbContext,
        IValidator<CatalogQuery> queryValidator,
        IValidator<Request.CreateTourRequest> createValidator,
        IValidator<Request.UpdateTourRequest> updateValidator)
    {
        _dbContext = dbContext;
        _queryValidator = queryValidator;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<List<Response.TourListItem>> GetAllAsync()
    {
        return await _dbContext.Tours
            .AsNoTracking()
            .Where(x => !x.IsDeleted)
            .OrderBy(x => x.SortOrder).ThenByDescending(x => x.UpdatedAt)
            .Select(x => new Response.TourListItem
            {
                Id = x.Id,
                Slug = x.Slug,
                Name = x.Name,
                TaxonomyId = x.TaxonomyId,
                LocationName = x.Taxonomy.Name,
                LocationGroup = x.Taxonomy.Group,
                Nights = x.Nights,
                Price = x.Price,
                Teaser = x.Teaser,
                Highlights = x.Highlights,
                Stays = x.Stays,
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

        var q = _dbContext.Tours
            .AsNoTracking()
            .Where(x => !x.IsDeleted);

        if (!string.IsNullOrWhiteSpace(query.Search))
        {
            q = q.Where(t => EF.Functions.ILike(t.Name, $"%{query.Search}%")
                          || EF.Functions.ILike(t.Taxonomy.Name, $"%{query.Search}%"));
        }

        if (!string.IsNullOrWhiteSpace(query.City))
        {
            q = q.Where(t => t.Taxonomy.Name == query.City
                          && t.Taxonomy.Group == TaxonomyGroup.City);
        }

        if (!string.IsNullOrWhiteSpace(query.Region))
        {
            q = q.Where(t => t.Taxonomy.Name == query.Region
                          && t.Taxonomy.Group == TaxonomyGroup.Region);
        }

        if (query.Featured.HasValue)
        {
            q = q.Where(t => t.Featured == query.Featured.Value);
        }

        var total = await q.CountAsync();
        var items = await q
            .OrderBy(t => t.SortOrder).ThenByDescending(t => t.UpdatedAt)
            .Skip((page - 1) * pageSize).Take(pageSize)
            .Select(x => new Response.TourListItem
            {
                Id = x.Id,
                Slug = x.Slug,
                Name = x.Name,
                TaxonomyId = x.TaxonomyId,
                LocationName = x.Taxonomy.Name,
                LocationGroup = x.Taxonomy.Group,
                Nights = x.Nights,
                Price = x.Price,
                Teaser = x.Teaser,
                Highlights = x.Highlights,
                Stays = x.Stays,
                Cover = x.Cover,
                Featured = x.Featured,
                SortOrder = x.SortOrder,
                UpdatedAt = x.UpdatedAt,
            })
            .ToListAsync();

        return ApiResponseFactory.BasePagination(items, page, pageSize, total);
    }

    public async Task<Response.TourDetail> GetBySlugAsync(string slug)
    {
        var entity = await _dbContext.Tours
            .AsNoTracking()
            .Include(x => x.Taxonomy)
            .FirstOrDefaultAsync(t => t.Slug == slug && !t.IsDeleted);

        if (entity is null) throw new NotFoundException("Tour not found");
        return MapDetail(entity);
    }

    public async Task<Response.TourDetail> CreateAsync(Request.CreateTourRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var slug = SlugHelper.Slugify(request.Slug, request.Name);
        if (await _dbContext.Tours.AnyAsync(t => t.Slug == slug && !t.IsDeleted))
        {
            throw new ConflictException($"Slug '{slug}' already exists.");
        }

        if (!await _dbContext.Taxonomies.AnyAsync(t => t.Id == request.TaxonomyId))
            throw new BadRequestException("Taxonomy not found.");

        var maxOrder = await _dbContext.Tours
            .Where(x => !x.IsDeleted)
            .MaxAsync(x => (int?)x.SortOrder) ?? 0;

        var now = DateTime.UtcNow;
        var entity = new Tour
        {
            Id = Guid.NewGuid(),
            CreatedAt = now,
            UpdatedAt = now,
        };
        Apply(entity, request, slug, maxOrder + 1);

        _dbContext.Tours.Add(entity);
        await _dbContext.SaveChangesAsync();

        await _dbContext.Entry(entity).Reference(x => x.Taxonomy).LoadAsync();

        return MapDetail(entity);
    }

    public async Task<Response.TourDetail> UpdateAsync(string slug, Request.UpdateTourRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var entity = await _dbContext.Tours
            .Include(x => x.Taxonomy)
            .FirstOrDefaultAsync(t => t.Slug == slug && !t.IsDeleted);

        if (entity is null) throw new NotFoundException("Tour not found");

        var newSlug = SlugHelper.Slugify(request.Slug, request.Name);
        if (await _dbContext.Tours.AnyAsync(t => t.Slug == newSlug && t.Id != entity.Id && !t.IsDeleted))
        {
            throw new ConflictException($"Slug '{newSlug}' already in use.");
        }

        if (!await _dbContext.Taxonomies.AnyAsync(t => t.Id == request.TaxonomyId))
            throw new BadRequestException("Taxonomy not found.");

        Apply(entity, request, newSlug, entity.SortOrder);
        entity.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();

        await _dbContext.Entry(entity).Reference(x => x.Taxonomy).LoadAsync();

        return MapDetail(entity);
    }

    public async Task DeleteAsync(string slug)
    {
        var entity = await _dbContext.Tours
            .FirstOrDefaultAsync(t => t.Slug == slug && !t.IsDeleted);

        if (entity is null) throw new NotFoundException("Tour not found");

        entity.IsDeleted = true;
        entity.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();
    }

    private static void Apply(Tour e, dynamic r, string slug, int sortOrder)
    {
        e.Slug = slug;
        e.Name = (r.Name ?? string.Empty).Trim();
        e.TaxonomyId = r.TaxonomyId;
        e.Nights = r.Nights?.Trim() ?? string.Empty;
        e.Price = r.Price?.Trim() ?? string.Empty;
        e.Teaser = r.Teaser ?? string.Empty;
        e.Highlights = ((List<string>?)r.Highlights)?.Where(h => !string.IsNullOrWhiteSpace(h)).ToList() ?? new();
        e.Stays = ((List<string>?)r.Stays)?.Where(s => !string.IsNullOrWhiteSpace(s)).ToList() ?? new();
        e.Cover = r.Cover?.Trim() ?? string.Empty;
        e.Featured = r.Featured;
        e.SortOrder = sortOrder;
    }

    private static Response.TourDetail MapDetail(Tour entity)
    {
        return new Response.TourDetail
        {
            Id = entity.Id,
            Slug = entity.Slug,
            Name = entity.Name,
            TaxonomyId = entity.TaxonomyId,
            LocationName = entity.Taxonomy.Name,
            LocationGroup = entity.Taxonomy.Group,
            Nights = entity.Nights,
            Price = entity.Price,
            Teaser = entity.Teaser,
            Highlights = entity.Highlights,
            Stays = entity.Stays,
            Cover = entity.Cover,
            Featured = entity.Featured,
            SortOrder = entity.SortOrder,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt,
        };
    }
}
