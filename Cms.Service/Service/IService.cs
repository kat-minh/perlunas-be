namespace Cms.Service.Service;

public interface IService
{
    Task<List<Response.ServiceResponse>> GetAllAsync();
    Task<Response.ServiceResponse> GetByIdAsync(Guid id);
    Task<Response.ServiceResponse> CreateAsync(Request.CreateServiceRequest request);
    Task<Response.ServiceResponse> UpdateAsync(Guid id, Request.UpdateServiceRequest request);
    Task<string> DeleteAsync(Guid id);
}
