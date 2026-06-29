using System.Security.Claims;
using Cms.Service.Exceptions;
using Microsoft.AspNetCore.Http;

namespace Cms.Service.CurrentUser;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    private string? Claim(string type) =>
        _httpContextAccessor.HttpContext?.User.FindFirst(type)?.Value;

    public Guid? UserId =>
        Guid.TryParse(Claim(ClaimTypes.NameIdentifier), out var id) ? id : null;

    public string? Email => Claim(ClaimTypes.Email);
    public string? FullName => Claim("FullName");
    public string? Avatar => Claim("Avatar");
    public bool IsVerified => string.Equals(Claim("IsVerified"), "true", StringComparison.OrdinalIgnoreCase);

    public Guid GetRequiredUserId() =>
        UserId ?? throw new UnauthorizedException("User not found");
}
