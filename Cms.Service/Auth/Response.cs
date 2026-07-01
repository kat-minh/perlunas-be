namespace Cms.Service.Auth;

public class Response
{
    public class LoginResponse
    {
        public string AccessToken { get; set; } = string.Empty;
        public string TokenType { get; set; } = "Bearer";
        public int ExpiresInMinutes { get; set; }
    }

    public class LogoutResponse
    {
        public string Message { get; set; } = "Logged out successfully.";
    }
}
