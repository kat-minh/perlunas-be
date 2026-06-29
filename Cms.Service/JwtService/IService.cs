using System.Security.Claims;

namespace Cms.Service.JwtService;

public interface IService
{
    string GenerateAccessToken(List<Claim> claims);
    string GenerateRefreshToken();
}
