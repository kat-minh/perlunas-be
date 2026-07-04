using Cms.Repository;
using Cms.Service.Configurations;
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

        var group = request.Group.Trim().ToLower();
        var name = request.Name.Trim();

        if (await _dbContext.Taxonomies.AnyAsync(x => !x.IsDeleted && x.Group == group && x.Name == name))
            throw new ConflictException($"Danh mục \"{name}\" đã tồn tại trong nhóm \"{group}\".");

        var now = DateTime.UtcNow;
        var item = new Repository.Entities.Taxonomy
        {
            Id = Guid.NewGuid(),
            Group = group,
            Name = name,
            Slug = await GenerateUniqueSlugAsync(request.Name),
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

        var oldName = item.Name;
        var newName = request.Name.Trim();

        if (item.Name != newName && await _dbContext.Taxonomies.AnyAsync(x => !x.IsDeleted && x.Id != id && x.Group == item.Group && x.Name == newName))
            throw new ConflictException($"Danh mục \"{newName}\" đã tồn tại trong nhóm \"{item.Group}\".");

        item.Name = newName;
        item.Slug = await GenerateUniqueSlugAsync(request.Name, id);
        item.Color = string.IsNullOrWhiteSpace(request.Color) ? null : request.Color.Trim();
        item.SortOrder = request.SortOrder;
        item.UpdatedAt = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync();

        // Tham chiếu theo Name → khi ĐỔI TÊN, cascade cập nhật vào mọi Service đang
        // dùng tên cũ (đúng field theo Group) để dữ liệu không bị lệch.
        if (!string.IsNullOrEmpty(oldName) && oldName != newName)
            await CascadeRenameAsync(item.Group, oldName, newName);

        return ToResponse(item);
    }

    /// <summary>Đổi tên danh mục cũ→mới trên đúng field Service (bulk update).</summary>
    private async Task CascadeRenameAsync(string group, string oldName, string newName)
    {
        var now = DateTime.UtcNow;
        var q = _dbContext.Services.Where(x => !x.IsDeleted);
        switch (group?.Trim().ToLower())
        {
            case "region":
                await q.Where(x => x.Region == oldName)
                    .ExecuteUpdateAsync(s => s.SetProperty(x => x.Region, newName).SetProperty(x => x.UpdatedAt, now));
                break;
            case "city":
                await q.Where(x => x.Destination == oldName)
                    .ExecuteUpdateAsync(s => s.SetProperty(x => x.Destination, newName).SetProperty(x => x.UpdatedAt, now));
                break;
            case "stay-type":
                await q.Where(x => x.Form == oldName)
                    .ExecuteUpdateAsync(s => s.SetProperty(x => x.Form, newName).SetProperty(x => x.UpdatedAt, now));
                break;
            case "tier":
                await q.Where(x => x.Classify == oldName)
                    .ExecuteUpdateAsync(s => s.SetProperty(x => x.Classify, newName).SetProperty(x => x.UpdatedAt, now));
                break;
            case "purpose":
                await q.Where(x => x.PurposeOfTrip == oldName)
                    .ExecuteUpdateAsync(s => s.SetProperty(x => x.PurposeOfTrip, newName).SetProperty(x => x.UpdatedAt, now));
                break;
        }
    }

    public async Task<string> DeleteAsync(Guid id)
    {
        var item = await _dbContext.Taxonomies.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (item is null) throw new NotFoundException("Taxonomy not found.");

        // Tham chiếu theo GIÁ TRỊ (Name) chứ không phải FK → không dựa vào ràng buộc
        // DB được. Vì vậy chặn ở tầng service: không cho xoá danh mục đang được một
        // Service nào đó dùng (khớp Name theo đúng field ứng với Group).
        var inUse = await CountServicesUsingAsync(item.Group, item.Name);
        if (inUse > 0)
            throw new ConflictException(
                $"Không thể xoá danh mục \"{item.Name}\": đang được {inUse} dịch vụ sử dụng. " +
                "Hãy đổi các dịch vụ đó sang danh mục khác trước khi xoá.");

        item.IsDeleted = true;
        item.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();

        return "Taxonomy deleted successfully.";
    }

    /// <summary>
    /// Đếm số Service (chưa xoá) đang tham chiếu tới taxonomy này. Mỗi Group ứng
    /// với một field string trên Service: region→Region, city→Destination,
    /// stay-type→Form, tier→Classify, purpose→PurposeOfTrip.
    /// </summary>
    private Task<int> CountServicesUsingAsync(string group, string name)
    {
        var q = _dbContext.Services.AsNoTracking().Where(x => !x.IsDeleted);
        return (group?.Trim().ToLower()) switch
        {
            "region" => q.Where(x => x.Region == name).CountAsync(),
            "city" => q.Where(x => x.Destination == name).CountAsync(),
            "stay-type" => q.Where(x => x.Form == name).CountAsync(),
            "tier" => q.Where(x => x.Classify == name).CountAsync(),
            "purpose" => q.Where(x => x.PurposeOfTrip == name).CountAsync(),
            _ => Task.FromResult(0),
        };
    }

    private async Task<string> GenerateUniqueSlugAsync(string name, Guid? excludedId = null)
    {
        var baseSlug = Slug.GenerateSlug(name.Trim());
        if (string.IsNullOrWhiteSpace(baseSlug)) baseSlug = Guid.NewGuid().ToString("N");

        var slug = baseSlug;
        var suffix = 1;

        while (await _dbContext.Taxonomies.AnyAsync(x => !x.IsDeleted && x.Slug == slug && (!excludedId.HasValue || x.Id != excludedId.Value)))
        {
            slug = $"{baseSlug}-{suffix}";
            suffix++;
        }

        return slug;
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
