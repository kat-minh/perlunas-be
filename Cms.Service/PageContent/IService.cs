using Cms.Service.Models;

namespace Cms.Service.PageContent;

public interface IService
{
    Task<BaseResponse> GetAllAsync(string? pageKey, string? sectionKey);
    Task<Response.PageContentResponse> GetByIdAsync(Guid id);
    Task<Response.PageContentResponse> CreateAsync(Request.CreatePageContentRequest request);
    Task<Response.PageContentResponse> UpdateAsync(Guid id, Request.UpdatePageContentRequest request);
    Task<string> DeleteAsync(Guid id);
}
