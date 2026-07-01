namespace Cms.Service.Blog;

public interface IService
{
    Task<List<Response.BlogResponse>> GetAllAsync();
    Task<Response.BlogResponse> GetByIdAsync(Guid id);
    Task<Response.BlogResponse> CreateAsync(Request.CreateBlogRequest request);
    Task<Response.BlogResponse> UpdateAsync(Guid id, Request.UpdateBlogRequest request);
    Task<string> DeleteAsync(Guid id);
}
