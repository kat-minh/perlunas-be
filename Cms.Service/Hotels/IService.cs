using Cms.Service.Models;
using Cms.Service.Queries;

namespace Cms.Service.Hotels;

public interface IService
{
    Task<List<Response.HotelListItem>> GetAllAsync();
    Task<BasePaginationResponse> GetPagedAsync(CatalogQuery query);
    Task<Response.HotelDetail> GetBySlugAsync(string slug);
    Task<Response.HotelDetail> CreateAsync(Request.CreateHotelRequest request);
    Task<Response.HotelDetail> UpdateAsync(string slug, Request.UpdateHotelRequest request);
    Task DeleteAsync(string slug);
}
