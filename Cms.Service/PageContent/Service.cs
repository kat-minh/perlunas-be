using Cms.Repository;
using Cms.Service.Exceptions;
using Cms.Service.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.PageContent;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreatePageContentRequest> _createValidator;
    private readonly IValidator<Request.UpdatePageContentRequest> _updateValidator;

    public Service(AppDbContext dbContext, IValidator<Request.CreatePageContentRequest> createValidator, IValidator<Request.UpdatePageContentRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize)
    {
        pageIndex = pageIndex <= 0 ? 1 : pageIndex;
        pageSize = pageSize <= 0 ? 10 : Math.Min(pageSize, 100);

        var query = _dbContext.PageContents
            .AsNoTracking()
            .Where(x => !x.IsDeleted);

        var totalCount = await query.CountAsync();
        var items = await query
            .OrderBy(x => x.PageKey)
            .ThenBy(x => x.SectionKey)
            .ThenBy(x => x.SoftOrder)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .Select(x => ToResponse(x))
            .ToListAsync();

        return ApiResponseFactory.BasePagination(items, pageIndex, pageSize, totalCount);
    }

    public async Task<Response.PageContentResponse> GetByIdAsync(Guid id)
    {
        var all = await _dbContext.PageContents
            .AsNoTracking()
            .Where(x => !x.IsDeleted)
            .OrderBy(x => x.PageKey)
            .ThenBy(x => x.SectionKey)
            .ThenBy(x => x.SoftOrder)
            .ToListAsync();

        var item = all.FirstOrDefault(x => x.Id == id);
        if (item is null) throw new NotFoundException("Page content not found.");

        var response = ToResponse(item);
        response.Children = BuildTree(all, id);
        return response;
    }

    public async Task<Response.PageContentResponse> CreateAsync(Request.CreatePageContentRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        if (request.ParentId.HasValue)
        {
            var parentExists = await _dbContext.PageContents.AnyAsync(x => x.Id == request.ParentId && !x.IsDeleted);
            if (!parentExists) throw new NotFoundException("Parent page content not found.");
        }

        var now = DateTime.UtcNow;
        var pageContent = new Repository.Entities.PageContent
        {
            Id = Guid.NewGuid(),
            ParentId = request.ParentId,
            PageKey = request.PageKey.Trim(),
            SectionKey = request.SectionKey.Trim(),
            Key = request.Key.Trim(),
            ContentValue = request.ContentValue.Trim(),
            Label = request.Label.Trim(),
            Kind = request.Kind.Trim(),
            SoftOrder = request.SoftOrder,
            CreatedAt = now,
            UpdatedAt = now,
        };

        _dbContext.PageContents.Add(pageContent);
        await _dbContext.SaveChangesAsync();

        return ToResponse(pageContent);
    }

    public async Task<Response.PageContentResponse> UpdateAsync(Guid id, Request.UpdatePageContentRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        if (request.ParentId.HasValue)
        {
            var parentExists = await _dbContext.PageContents.AnyAsync(x => x.Id == request.ParentId && !x.IsDeleted);
            if (!parentExists) throw new NotFoundException("Parent page content not found.");
        }

        var pageContent = await _dbContext.PageContents.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (pageContent is null) throw new NotFoundException("Page content not found.");

        pageContent.ParentId = request.ParentId;
        pageContent.PageKey = request.PageKey.Trim();
        pageContent.SectionKey = request.SectionKey.Trim();
        pageContent.Key = request.Key.Trim();
        pageContent.ContentValue = request.ContentValue.Trim();
        pageContent.Label = request.Label.Trim();
        pageContent.Kind = request.Kind.Trim();
        pageContent.SoftOrder = request.SoftOrder;
        pageContent.UpdatedAt = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync();

        return ToResponse(pageContent);
    }

    public async Task<string> DeleteAsync(Guid id)
    {
        var all = await _dbContext.PageContents
            .Where(x => !x.IsDeleted)
            .ToListAsync();

        var toDelete = new List<Repository.Entities.PageContent>();
        CollectDescendants(all, id, toDelete);

        if (toDelete.Count == 0) throw new NotFoundException("Page content not found.");

        var now = DateTime.UtcNow;
        foreach (var item in toDelete)
        {
            item.IsDeleted = true;
            item.UpdatedAt = now;
        }

        await _dbContext.SaveChangesAsync();

        return "Page content deleted successfully.";
    }

    private static List<Response.PageContentResponse> BuildTree(List<Repository.Entities.PageContent> all, Guid? parentId)
    {
        return all
            .Where(x => x.ParentId == parentId)
            .Select(x =>
            {
                var r = ToResponse(x);
                r.Children = BuildTree(all, x.Id);
                return r;
            })
            .ToList();
    }

    private static void CollectDescendants(List<Repository.Entities.PageContent> all, Guid parentId, List<Repository.Entities.PageContent> result)
    {
        var children = all.Where(x => x.ParentId == parentId).ToList();
        foreach (var child in children)
        {
            result.Add(child);
            CollectDescendants(all, child.Id, result);
        }
    }

    private static Response.PageContentResponse ToResponse(Repository.Entities.PageContent pageContent)
    {
        return new Response.PageContentResponse
        {
            Id = pageContent.Id,
            ParentId = pageContent.ParentId,
            PageKey = pageContent.PageKey ?? string.Empty,
            SectionKey = pageContent.SectionKey ?? string.Empty,
            Key = pageContent.Key ?? string.Empty,
            ContentValue = pageContent.ContentValue ?? string.Empty,
            Label = pageContent.Label ?? string.Empty,
            Kind = pageContent.Kind ?? string.Empty,
            SoftOrder = pageContent.SoftOrder ?? 0,
            CreatedAt = pageContent.CreatedAt,
            UpdatedAt = pageContent.UpdatedAt,
        };
    }
}
