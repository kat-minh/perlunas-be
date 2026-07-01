namespace Cms.Service.Auth;

public interface IService
{
    Response.LoginResponse Login(Request.LoginRequest request);
    Response.LogoutResponse Logout();
}
