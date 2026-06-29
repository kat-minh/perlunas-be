namespace Cms.Service.SiteSettings;

public interface IService
{
    Task<Response.SiteSettingResponse> GetAsync();
    Task<Response.SiteSettingResponse> UpdateAsync(Request.UpdateSiteSettingRequest request);
}
