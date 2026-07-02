using Cms.Repository;
using Cms.Service.Exceptions;
using Cms.Service.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.SiteSetting;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateSiteSettingRequest> _createValidator;
    private readonly IValidator<Request.UpdateSiteSettingRequest> _updateValidator;

    public Service(AppDbContext dbContext, IValidator<Request.CreateSiteSettingRequest> createValidator, IValidator<Request.UpdateSiteSettingRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<BaseResponse> GetAllAsync(Guid? id, string? name, string? tagline)
    {
        var query = _dbContext.SiteSettings
            .AsNoTracking()
            .Where(x => !x.IsDeleted);

        if (id.HasValue)
            query = query.Where(x => x.Id == id.Value);

        if (!string.IsNullOrWhiteSpace(name))
            query = query.Where(x => x.Name != null && x.Name.Contains(name));

        if (!string.IsNullOrWhiteSpace(tagline))
            query = query.Where(x => x.Tagline != null && x.Tagline.Contains(tagline));

        var items = await query
            .OrderByDescending(x => x.CreatedAt)
            .Select(x => ToResponse(x))
            .ToListAsync();

        return ApiResponseFactory.Base(items);
    }

    public async Task<Response.SiteSettingResponse> GetByIdAsync(Guid id)
    {
        var siteSetting = await _dbContext.SiteSettings
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (siteSetting is null) throw new NotFoundException("Site setting not found.");

        return ToResponse(siteSetting);
    }

    public async Task<Response.SiteSettingResponse> CreateAsync(Request.CreateSiteSettingRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var now = DateTime.UtcNow;
        var siteSetting = new Repository.Entities.SiteSetting
        {
            Id = Guid.NewGuid(),
            Name = request.Name.Trim(),
            LegalName = request.LegalName.Trim(),
            Tagline = request.Tagline.Trim(),
            Manifesto = request.Manifesto.Trim(),
            Description = request.Description.Trim(),
            Phone = request.Phone.Trim(),
            Email = request.Email.Trim(),
            TaxId = request.TaxId.Trim(),
            OfficesJson = request.OfficesJson.Trim(),
            SocialJson = request.SocialJson.Trim(),
            CreatedAt = now,
            UpdatedAt = now,
        };

        _dbContext.SiteSettings.Add(siteSetting);
        await _dbContext.SaveChangesAsync();

        return ToResponse(siteSetting);
    }

    public async Task<Response.SiteSettingResponse> UpdateAsync(Guid id, Request.UpdateSiteSettingRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var siteSetting = await _dbContext.SiteSettings.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (siteSetting is null) throw new NotFoundException("Site setting not found.");

        siteSetting.Name = request.Name.Trim();
        siteSetting.LegalName = request.LegalName.Trim();
        siteSetting.Tagline = request.Tagline.Trim();
        siteSetting.Manifesto = request.Manifesto.Trim();
        siteSetting.Description = request.Description.Trim();
        siteSetting.Phone = request.Phone.Trim();
        siteSetting.Email = request.Email.Trim();
        siteSetting.TaxId = request.TaxId.Trim();
        siteSetting.OfficesJson = request.OfficesJson.Trim();
        siteSetting.SocialJson = request.SocialJson.Trim();
        siteSetting.UpdatedAt = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync();

        return ToResponse(siteSetting);
    }

    public async Task<string> DeleteAsync(Guid id)
    {
        var siteSetting = await _dbContext.SiteSettings.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (siteSetting is null) throw new NotFoundException("Site setting not found.");

        siteSetting.IsDeleted = true;
        siteSetting.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();

        return "Site setting deleted successfully.";
    }

    private static Response.SiteSettingResponse ToResponse(Repository.Entities.SiteSetting siteSetting)
    {
        return new Response.SiteSettingResponse
        {
            Id = siteSetting.Id,
            Name = siteSetting.Name ?? string.Empty,
            LegalName = siteSetting.LegalName ?? string.Empty,
            Tagline = siteSetting.Tagline ?? string.Empty,
            Manifesto = siteSetting.Manifesto ?? string.Empty,
            Description = siteSetting.Description ?? string.Empty,
            Phone = siteSetting.Phone ?? string.Empty,
            Email = siteSetting.Email ?? string.Empty,
            TaxId = siteSetting.TaxId ?? string.Empty,
            OfficesJson = siteSetting.OfficesJson ?? string.Empty,
            SocialJson = siteSetting.SocialJson ?? string.Empty,
            CreatedAt = siteSetting.CreatedAt,
            UpdatedAt = siteSetting.UpdatedAt,
        };
    }
}
