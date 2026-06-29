using System.Text.Json;
using Cms.Repository.Entities;
using Cms.Repository;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.SiteSettings;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.UpdateSiteSettingRequest> _updateValidator;
    private static readonly JsonSerializerOptions JsonOpts = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

    public Service(AppDbContext dbContext, IValidator<Request.UpdateSiteSettingRequest> updateValidator)
    {
        _dbContext = dbContext;
        _updateValidator = updateValidator;
    }

    public async Task<Response.SiteSettingResponse> GetAsync()
    {
        var s = await _dbContext.SiteSettings
            .AsNoTracking()
            .FirstOrDefaultAsync(x => !x.IsDeleted);

        if (s is null) return new Response.SiteSettingResponse();

        List<Response.Office> offices;
        try { offices = JsonSerializer.Deserialize<List<Response.Office>>(s.OfficesJson, JsonOpts) ?? new(); }
        catch { offices = new(); }

        List<Response.SocialLink> social;
        try { social = JsonSerializer.Deserialize<List<Response.SocialLink>>(s.SocialJson, JsonOpts) ?? new(); }
        catch { social = new(); }

        return new Response.SiteSettingResponse
        {
            UpdatedAt = s.UpdatedAt,
            Name = s.Name,
            LegalName = s.LegalName,
            Tagline = s.Tagline,
            Manifesto = s.Manifesto,
            Description = s.Description,
            Phone = s.Phone,
            Email = s.Email,
            TaxId = s.TaxId,
            Offices = offices,
            Social = social,
        };
    }

    public async Task<Response.SiteSettingResponse> UpdateAsync(Request.UpdateSiteSettingRequest dto)
    {
        await _updateValidator.ValidateAndThrowAsync(dto);

        var existing = await _dbContext.SiteSettings.FirstOrDefaultAsync(x => !x.IsDeleted);
        var entity = existing ?? new SiteSetting { Id = Guid.NewGuid(), CreatedAt = DateTime.UtcNow };

        entity.Name = dto.Name;
        entity.LegalName = dto.LegalName;
        entity.Tagline = dto.Tagline;
        entity.Manifesto = dto.Manifesto;
        entity.Description = dto.Description;
        entity.Phone = dto.Phone;
        entity.Email = dto.Email;
        entity.TaxId = dto.TaxId;
        entity.OfficesJson = JsonSerializer.Serialize(dto.Offices ?? new(), JsonOpts);
        entity.SocialJson = JsonSerializer.Serialize(dto.Social ?? new(), JsonOpts);
        entity.UpdatedAt = DateTime.UtcNow;

        if (existing is null)
            _dbContext.SiteSettings.Add(entity);
        else
            _dbContext.Entry(existing).CurrentValues.SetValues(entity);

        await _dbContext.SaveChangesAsync();

        List<Response.Office> offices;
        try { offices = JsonSerializer.Deserialize<List<Response.Office>>(entity.OfficesJson, JsonOpts) ?? new(); }
        catch { offices = new(); }

        List<Response.SocialLink> social;
        try { social = JsonSerializer.Deserialize<List<Response.SocialLink>>(entity.SocialJson, JsonOpts) ?? new(); }
        catch { social = new(); }

        return new Response.SiteSettingResponse
        {
            UpdatedAt = entity.UpdatedAt,
            Name = entity.Name,
            LegalName = entity.LegalName,
            Tagline = entity.Tagline,
            Manifesto = entity.Manifesto,
            Description = entity.Description,
            Phone = entity.Phone,
            Email = entity.Email,
            TaxId = entity.TaxId,
            Offices = offices,
            Social = social,
        };
    }
}
