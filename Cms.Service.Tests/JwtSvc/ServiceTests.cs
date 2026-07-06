using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Cms.Service.JwtService;
using FluentAssertions;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Cms.Service.Tests.JwtSvc;

public class ServiceTests
{
    private const string TestKey = "this-is-a-very-long-super-secret-key-for-jwt-tests-1234567890";

    private static JwtOption Option(string? key = TestKey, int expire = 60,
        string issuer = "test-issuer", string audience = "test-audience") => new()
    {
        Issuer = issuer,
        Audience = audience,
        AccessTokenKey = key ?? string.Empty,
        AccessTokenExpireMin = expire
    };

    private static Cms.Service.JwtService.Service CreateService(JwtOption opt) =>
        new(Options.Create(opt));

    private static List<Claim> SampleClaims() => new()
    {
        new(JwtRegisteredClaimNames.Sub, "admin"),
        new(ClaimTypes.NameIdentifier, "admin"),
        new(ClaimTypes.Role, "Admin"),
        new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
    };

    // ===== GenerateAccessToken =====

    [Fact]
    public void GenerateAccessToken_WithValidClaims_ShouldReturnJwtString()
    {
        var svc = CreateService(Option());

        var token = svc.GenerateAccessToken(SampleClaims());

        token.Should().NotBeNullOrWhiteSpace();
        token.Split('.').Should().HaveCount(3); // header.payload.signature
    }

    [Fact]
    public void GenerateAccessToken_ShouldEncodeIssuerAudienceAndClaims()
    {
        var svc = CreateService(Option(issuer: "my-issuer", audience: "my-audience"));

        var token = svc.GenerateAccessToken(SampleClaims());
        var jwt = new JwtSecurityTokenHandler().ReadJwtToken(token);

        jwt.Issuer.Should().Be("my-issuer");
        jwt.Audiences.Should().Contain("my-audience");
        jwt.Claims.Should().Contain(c => c.Type == ClaimTypes.Role && c.Value == "Admin");
        jwt.Claims.Should().Contain(c => c.Type == JwtRegisteredClaimNames.Sub && c.Value == "admin");
    }

    [Fact]
    public void GenerateAccessToken_ShouldSetExpiryFromOption()
    {
        var svc = CreateService(Option(expire: 120));
        var before = DateTime.UtcNow;

        var token = svc.GenerateAccessToken(SampleClaims());
        var jwt = new JwtSecurityTokenHandler().ReadJwtToken(token);

        jwt.ValidTo.Should().BeCloseTo(before.AddMinutes(120), TimeSpan.FromSeconds(5));
    }

    [Fact]
    public void GenerateAccessToken_WithEmptyClaims_ShouldStillProduceToken()
    {
        var svc = CreateService(Option());

        var token = svc.GenerateAccessToken(new List<Claim>());

        token.Should().NotBeNullOrWhiteSpace();
        token.Split('.').Should().HaveCount(3);
    }

    [Fact]
    public void GenerateAccessToken_ShouldUseHmacSha256Algorithm()
    {
        var svc = CreateService(Option());

        var token = svc.GenerateAccessToken(SampleClaims());
        var jwt = new JwtSecurityTokenHandler().ReadJwtToken(token);

        jwt.Header.Alg.Should().Be("HS256");
    }

    [Fact]
    public void GenerateAccessToken_WithShortKey_ShouldThrow()
    {
        // HmacSha256 cần key dài (>= 128 bit). Key quá ngắn → SymmetricSecurityKey ném.
        var svc = CreateService(Option(key: "short"));

        var act = () => svc.GenerateAccessToken(SampleClaims());

        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void GenerateAccessToken_WithEmptyKey_ShouldThrow()
    {
        var svc = CreateService(Option(key: ""));

        var act = () => svc.GenerateAccessToken(SampleClaims());

        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void GenerateAccessToken_ShouldProduceDifferentTokensForDifferentClaims()
    {
        var svc = CreateService(Option());

        var t1 = svc.GenerateAccessToken(new List<Claim> { new("x", "1") });
        var t2 = svc.GenerateAccessToken(new List<Claim> { new("x", "2") });

        t1.Should().NotBe(t2);
    }

    [Fact]
    public void GenerateAccessToken_ShouldBeVerifiableWithSameKey()
    {
        var opt = Option();
        var svc = CreateService(opt);

        var token = svc.GenerateAccessToken(SampleClaims());

        var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(opt.AccessTokenKey));
        var handler = new JwtSecurityTokenHandler();
        var principal = handler.ValidateToken(token, new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = opt.Issuer,
            ValidateAudience = true,
            ValidAudience = opt.Audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = key,
            ValidateLifetime = false
        }, out _);

        principal.Should().NotBeNull();
        principal!.FindFirst(ClaimTypes.Role)?.Value.Should().Be("Admin");
    }

    [Fact]
    public void GenerateAccessToken_WithNullClaims_ShouldProduceTokenWithEmptyClaims()
    {
        // JwtSecurityToken constructor xử lý claims: null bằng enumerable rỗng — không ném.
        // Token vẫn sinh ra hợp lệ (chỉ thiếu custom claims, vẫn có exp/iss/aud/jti mặc định).
        var svc = CreateService(Option());

        var token = svc.GenerateAccessToken(null!);

        token.Should().NotBeNullOrWhiteSpace();
        token.Split('.').Should().HaveCount(3);
    }
}
