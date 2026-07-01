namespace Cms.Service.JwtService;

public class JwtOption
{
    public string Issuer { get; set; } = string.Empty;
    public string Audience { get; set; } = string.Empty;
    public string AccessTokenKey { get; set; } = string.Empty;
    public int AccessTokenExpireMin { get; set; } = 120;
}
