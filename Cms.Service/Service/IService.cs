using Cms.Service.Models;

namespace Cms.Service.Service;

public interface IService
{
    Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize);
    Task<BasePaginationResponse> GetToursAsync(string? keyword, string? destination, int pageIndex, int pageSize);
    Task<BasePaginationResponse> GetCombosAsync(string? keyword, string? destination, string? form, string? classify, string? purposeOfTrip, int pageIndex, int pageSize);
    Task<BasePaginationResponse> GetHotelsAsync(string? keyword, string? destination, string? form, string? purposeOfTrip, int pageIndex, int pageSize);
    Task<Response.ServiceResponse> GetByKeyAsync(string key);
    Task<Response.ServiceResponse> CreateTourAsync(Request.CreateTourRequest request);
    Task<Response.ServiceResponse> CreateComboAsync(Request.CreateComboRequest request);
    Task<Response.ServiceResponse> CreateHotelAsync(Request.CreateHotelRequest request);
    Task<Response.ServiceResponse> UpdateAsync(Guid id, Request.UpdateServiceRequest request);
    Task<string> DeleteAsync(Guid id);
}
