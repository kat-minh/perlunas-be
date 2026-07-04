using Cms.Service.Models;

namespace Cms.Service.Taxonomy;

public interface IService
{
    /// <summary>Danh sách danh mục, lọc theo <paramref name="group"/> nếu có.</summary>
    Task<BaseResponse> GetAllAsync(string? group);
    Task<Response.TaxonomyResponse> GetByIdAsync(Guid id);
    Task<Response.TaxonomyResponse> CreateAsync(Request.CreateTaxonomyRequest request);
    Task<Response.TaxonomyResponse> UpdateAsync(Guid id, Request.UpdateTaxonomyRequest request);
    Task<string> DeleteAsync(Guid id);
}
