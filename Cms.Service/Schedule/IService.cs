namespace Cms.Service.Schedule;

public interface IService
{
    Task<List<Response.ScheduleResponse>> GetAllAsync();
    Task<Response.ScheduleResponse> GetByIdAsync(Guid id);
    Task<Response.ScheduleResponse> CreateAsync(Request.CreateScheduleRequest request);
    Task<Response.ScheduleResponse> UpdateAsync(Guid id, Request.UpdateScheduleRequest request);
    Task<string> DeleteAsync(Guid id);
}
