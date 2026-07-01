namespace Cms.Service.SiteSetting;

public interface IService
{
    Task<List<Response.SiteSettingResponse>> GetAllAsync();
    Task<Response.SiteSettingResponse> GetByIdAsync(Guid id);
    Task<Response.SiteSettingResponse> CreateAsync(Request.CreateSiteSettingRequest request);
    Task<Response.SiteSettingResponse> UpdateAsync(Guid id, Request.UpdateSiteSettingRequest request);
    Task<string> DeleteAsync(Guid id);
}
