using Cms.Service.Models;

namespace Cms.Service.Service;

public interface IService
{
    Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize);
    Task<BasePaginationResponse> GetToursAsync(string? keyword, int pageIndex, int pageSize);
    Task<Response.ServiceResponse> GetByIdAsync(Guid id);
    Task<Response.ServiceResponse> CreateAsync(Request.CreateServiceRequest request);
    Task<Response.ServiceResponse> UpdateAsync(Guid id, Request.UpdateServiceRequest request);
    Task<string> DeleteAsync(Guid id);
}
