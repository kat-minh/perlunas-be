using Cms.Repository;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.PageContent;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<List<Request.PageContentUpdate>> _updateValidator;

    public Service(AppDbContext dbContext, IValidator<List<Request.PageContentUpdate>> updateValidator)
    {
        _dbContext = dbContext;
        _updateValidator = updateValidator;
    }

    public async Task<List<Response.PageContentResponse>> GetAllAsync()
    {
        var entities = await _dbContext.PageContents
            .AsNoTracking()
            .Where(x => !x.IsDeleted)
            .OrderBy(x => x.SortOrder)
            .ToListAsync();

        var lookup = entities.ToDictionary(e => e.Id, e => new Response.PageContentResponse
        {
            Id = e.Id,
            Key = e.Key,
            Value = e.Value,
            Label = e.Label,
            Kind = e.Kind,
            SortOrder = e.SortOrder,
            ParentId = e.ParentId,
            CreatedAt = e.CreatedAt,
            UpdatedAt = e.UpdatedAt,
        });

        var roots = new List<Response.PageContentResponse>();
        foreach (var node in lookup.Values)
        {
            if (node.ParentId is Guid parentId && lookup.TryGetValue(parentId, out var parent))
                parent.Children.Add(node);
            else
                roots.Add(node);
        }

        return roots;
    }

    public async Task UpdateValuesAsync(List<Request.PageContentUpdate> updates)
    {
        await _updateValidator.ValidateAndThrowAsync(updates);

        var dict = updates
            .Where(u => !string.IsNullOrWhiteSpace(u.Key))
            .GroupBy(u => u.Key)
            .ToDictionary(g => g.Key, g => g.Last().Value ?? string.Empty);

        var keys = dict.Keys.ToList();
        var rows = await _dbContext.PageContents
            .Where(p => p.Key != null && keys.Contains(p.Key) && !p.IsDeleted)
            .ToListAsync();

        foreach (var row in rows)
        {
            row.Value = dict[row.Key!];
            row.UpdatedAt = DateTime.UtcNow;
        }
        await _dbContext.SaveChangesAsync();
    }
}
