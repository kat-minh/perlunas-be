using Cms.Service.Models;

namespace Cms.Service.Schedule;

public interface IService
{
    Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize);
    Task<Response.ScheduleResponse> GetByIdAsync(Guid id);
    Task<Response.ScheduleResponse> CreateAsync(Request.CreateScheduleRequest request);
    Task<Response.ScheduleResponse> UpdateAsync(Guid id, Request.UpdateScheduleRequest request);
    Task<string> DeleteAsync(Guid id);
}
