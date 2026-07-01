using Cms.Service.Models;

namespace Cms.Service.DepartureSchedule;

public interface IService
{
    Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize);
    Task<Response.DepartureScheduleResponse> GetByIdAsync(Guid id);
    Task<Response.DepartureScheduleResponse> CreateAsync(Request.CreateDepartureScheduleRequest request);
    Task<Response.DepartureScheduleResponse> UpdateAsync(Guid id, Request.UpdateDepartureScheduleRequest request);
    Task<string> DeleteAsync(Guid id);
}
