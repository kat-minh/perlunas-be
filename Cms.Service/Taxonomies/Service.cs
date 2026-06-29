using Cms.Repository.Entities;
using Cms.Repository;
using Cms.Repository.Enums;
using Cms.Service.Common;
using Cms.Service.Exceptions;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.Taxonomies;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateTaxonomyRequest> _createValidator;
    private readonly IValidator<Request.UpdateTaxonomyRequest> _updateValidator;

    public Service(AppDbContext dbContext,
        IValidator<Request.CreateTaxonomyRequest> createValidator,
        IValidator<Request.UpdateTaxonomyRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<List<Response.TaxonomyResponse>> GetAllAsync(TaxonomyGroup? group)
    {
        var q = _dbContext.Taxonomies
            .AsNoTracking()
            .Where(x => !x.IsDeleted);

        if (group.HasValue)
        {
            q = q.Where(x => x.Group == group.Value);
        }

        return await q
            .OrderBy(x => x.Group).ThenBy(x => x.SortOrder)
            .Select(x => new Response.TaxonomyResponse
            {
                Id = x.Id,
                Group = x.Group,
                Name = x.Name,
                Slug = x.Slug,
                SortOrder = x.SortOrder,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
            })
            .ToListAsync();
    }

    public async Task<Response.TaxonomyResponse> CreateAsync(Request.CreateTaxonomyRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        if (await _dbContext.Taxonomies.AnyAsync(x => x.Group == request.Group && x.Name == request.Name && !x.IsDeleted))
            throw new ConflictException($"Taxonomy '{request.Name}' with group '{request.Group}' already exists.");

        var slug = SlugHelper.Slugify(request.Slug, request.Name);
        var maxOrder = await _dbContext.Taxonomies
            .Where(x => x.Group == request.Group && !x.IsDeleted)
            .MaxAsync(x => (int?)x.SortOrder) ?? 0;

        var now = DateTime.UtcNow;
        var entity = new Taxonomy
        {
            Id = Guid.NewGuid(),
            Group = request.Group,
            Name = request.Name,
            Slug = slug,
            SortOrder = maxOrder + 1,
            CreatedAt = now,
            UpdatedAt = now,
        };
        _dbContext.Taxonomies.Add(entity);
        await _dbContext.SaveChangesAsync();
        return new Response.TaxonomyResponse
        {
            Id = entity.Id,
            Group = entity.Group,
            Name = entity.Name,
            Slug = entity.Slug,
            SortOrder = entity.SortOrder,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt,
        };
    }

    public async Task<Response.TaxonomyResponse> UpdateAsync(Guid id, Request.UpdateTaxonomyRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var entity = await _dbContext.Taxonomies
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (entity is null) throw new NotFoundException("Taxonomy not found");

        if (await _dbContext.Taxonomies.AnyAsync(x => x.Group == request.Group && x.Name == request.Name && x.Id != id && !x.IsDeleted))
            throw new ConflictException($"Taxonomy '{request.Name}' with group '{request.Group}' already exists.");

        entity.Group = request.Group;
        entity.Name = request.Name;
        entity.Slug = SlugHelper.Slugify(request.Slug, request.Name);
        entity.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();
        return new Response.TaxonomyResponse
        {
            Id = entity.Id,
            Group = entity.Group,
            Name = entity.Name,
            Slug = entity.Slug,
            SortOrder = entity.SortOrder,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt,
        };
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await _dbContext.Taxonomies
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (entity is null) throw new NotFoundException("Taxonomy not found");

        entity.IsDeleted = true;
        entity.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();
    }
}
