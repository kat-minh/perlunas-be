namespace Cms.Service.Users;

public interface IService
{
    Task<List<Response.UserResponse>> GetAllAsync();
    Task<Response.UserResponse> CreateAsync(Request.CreateUserRequest request);
    Task<Response.UserResponse> UpdateAsync(Guid id, Request.UpdateUserRequest request);
    Task<Response.UserResponse> DeleteAsync(Guid id);
}
