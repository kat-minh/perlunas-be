using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Cms.Service.Exceptions;
using Cms.Service.JwtService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Cms.Service.Auth;

public class Service : IService
{
    private readonly JwtService.IService _jwtService;
    private readonly JwtOption _jwtOption;
    private readonly IConfiguration _configuration;

    public Service(JwtService.IService jwtService, IOptions<JwtOption> jwtOption, IConfiguration configuration)
    {
        _jwtService = jwtService;
        _jwtOption = jwtOption.Value;
        _configuration = configuration;
    }

    public Response.LoginResponse Login(Request.LoginRequest request)
    {
        var username = _configuration["AdminAuth:Username"];
        var password = _configuration["AdminAuth:Password"];

        if (request.Username != username || request.Password != password)
            throw new UnauthorizedException("Invalid username or password.");

        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, username!),
            new(ClaimTypes.NameIdentifier, username!),
            new(ClaimTypes.Name, username!),
            new(ClaimTypes.Role, "Admin"),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };

        return new Response.LoginResponse
        {
            AccessToken = _jwtService.GenerateAccessToken(claims),
            TokenType = "Bearer",
            ExpiresInMinutes = _jwtOption.AccessTokenExpireMin,
        };
    }

    public Response.LogoutResponse Logout()
    {
        return new Response.LogoutResponse();
    }
}
