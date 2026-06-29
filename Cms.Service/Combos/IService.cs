using Cms.Service.Models;
using Cms.Service.Queries;

namespace Cms.Service.Combos;

public interface IService
{
    Task<List<Response.ComboListItem>> GetAllAsync();
    Task<BasePaginationResponse> GetPagedAsync(CatalogQuery query);
    Task<Response.ComboDetail> GetBySlugAsync(string slug);
    Task<Response.ComboDetail> CreateAsync(Request.CreateComboRequest request);
    Task<Response.ComboDetail> UpdateAsync(string slug, Request.UpdateComboRequest request);
    Task DeleteAsync(string slug);
}
