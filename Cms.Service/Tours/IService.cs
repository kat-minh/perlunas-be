using Cms.Service.Models;
using Cms.Service.Queries;

namespace Cms.Service.Tours;

public interface IService
{
    Task<List<Response.TourListItem>> GetAllAsync();
    Task<BasePaginationResponse> GetPagedAsync(CatalogQuery query);
    Task<Response.TourDetail> GetBySlugAsync(string slug);
    Task<Response.TourDetail> CreateAsync(Request.CreateTourRequest request);
    Task<Response.TourDetail> UpdateAsync(string slug, Request.UpdateTourRequest request);
    Task DeleteAsync(string slug);
}
