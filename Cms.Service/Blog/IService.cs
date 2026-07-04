using Cms.Service.Models;

namespace Cms.Service.Blog;

public interface IService
{
    Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize);
    Task<Response.BlogResponse> GetByIdAsync(Guid id);
    Task<Response.BlogResponse> GetBySlugAsync(string slug);
    Task<Response.BlogResponse> CreateAsync(Request.CreateBlogRequest request);
    Task<Response.BlogResponse> UpdateAsync(Guid id, Request.UpdateBlogRequest request);
    Task<string> DeleteAsync(Guid id);
}
