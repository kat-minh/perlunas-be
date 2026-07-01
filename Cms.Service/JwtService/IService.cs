using System.Security.Claims;

namespace Cms.Service.JwtService;

public interface IService
{
    string GenerateAccessToken(IEnumerable<Claim> claims);
}
