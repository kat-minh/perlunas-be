namespace Cms.Service.Auth;

public interface IService
{
    Task<Response.LoginResponse> LoginAsync(Request.LoginRequest request);
    Task<Response.LoginResponse> RegisterAsync(Request.RegisterRequest request);
    Task<Response.UserProfileResponse> GetProfileAsync();
    Task LogoutAsync();
}
