using Cms.Repository;
using Cms.Service.Exceptions;
using Cms.Service.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.Taxonomy;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateTaxonomyRequest> _createValidator;
    private readonly IValidator<Request.UpdateTaxonomyRequest> _updateValidator;

    public Service(AppDbContext dbContext, IValidator<Request.CreateTaxonomyRequest> createValidator, IValidator<Request.UpdateTaxonomyRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<BaseResponse> GetAllAsync(string? group)
    {
        var query = _dbContext.Taxonomies.AsNoTracking().Where(x => !x.IsDeleted);

        if (!string.IsNullOrWhiteSpace(group))
        {
            var g = group.Trim().ToLower();
            query = query.Where(x => x.Group.ToLower() == g);
        }

        var items = await query
            .OrderBy(x => x.Group)
            .ThenBy(x => x.SortOrder)
            .ThenBy(x => x.Name)
            .Select(x => ToResponse(x))
            .ToListAsync();

        return ApiResponseFactory.Base(items, true, "", null);
    }

    public async Task<Response.TaxonomyResponse> GetByIdAsync(Guid id)
    {
        var item = await _dbContext.Taxonomies
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (item is null) throw new NotFoundException("Taxonomy not found.");

        return ToResponse(item);
    }

    public async Task<Response.TaxonomyResponse> CreateAsync(Request.CreateTaxonomyRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var now = DateTime.UtcNow;
        var item = new Repository.Entities.Taxonomy
        {
            Id = Guid.NewGuid(),
            Group = request.Group.Trim().ToLower(),
            Name = request.Name.Trim(),
            Slug = string.IsNullOrWhiteSpace(request.Slug) ? null : request.Slug.Trim(),
            Color = string.IsNullOrWhiteSpace(request.Color) ? null : request.Color.Trim(),
            SortOrder = request.SortOrder,
            CreatedAt = now,
            UpdatedAt = now,
        };

        _dbContext.Taxonomies.Add(item);
        await _dbContext.SaveChangesAsync();

        return ToResponse(item);
    }

    public async Task<Response.TaxonomyResponse> UpdateAsync(Guid id, Request.UpdateTaxonomyRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var item = await _dbContext.Taxonomies.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (item is null) throw new NotFoundException("Taxonomy not found.");

        item.Name = request.Name.Trim();
        item.Slug = string.IsNullOrWhiteSpace(request.Slug) ? null : request.Slug.Trim();
        item.Color = string.IsNullOrWhiteSpace(request.Color) ? null : request.Color.Trim();
        item.SortOrder = request.SortOrder;
        item.UpdatedAt = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync();

        return ToResponse(item);
    }

    public async Task<string> DeleteAsync(Guid id)
    {
        var item = await _dbContext.Taxonomies.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (item is null) throw new NotFoundException("Taxonomy not found.");

        item.IsDeleted = true;
        item.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();

        return "Taxonomy deleted successfully.";
    }

    private static Response.TaxonomyResponse ToResponse(Repository.Entities.Taxonomy item)
    {
        return new Response.TaxonomyResponse
        {
            Id = item.Id,
            Group = item.Group,
            Name = item.Name,
            Slug = item.Slug,
            Color = item.Color,
            SortOrder = item.SortOrder,
            CreatedAt = item.CreatedAt,
            UpdatedAt = item.UpdatedAt,
        };
    }
}
