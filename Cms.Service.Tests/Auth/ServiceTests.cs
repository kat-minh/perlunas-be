using Cms.Service.Tests.TestHelper;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Cms.Service.Auth;
using Cms.Service.Exceptions;
using Cms.Service.JwtService;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Moq;

namespace Cms.Service.Tests.Auth;

public class ServiceTests
{
    private const string TestKey = "this-is-a-very-long-super-secret-key-for-jwt-tests-1234567890";

    private static JwtOption ValidJwtOption(int expireMin = 60) => new()
    {
        Issuer = "test-issuer",
        Audience = "test-audience",
        AccessTokenKey = TestKey,
        AccessTokenExpireMin = expireMin
    };

    private static IOptions<JwtOption> ValidOptions(int expireMin = 60) =>
        Microsoft.Extensions.Options.Options.Create(ValidJwtOption(expireMin));

    private static JwtService.IService CreateJwtService(int expireMin = 60) =>
        new Cms.Service.JwtService.Service(ValidOptions(expireMin));

    private static IConfiguration ConfigurationWith(string? username, string? password)
    {
        var dict = new Dictionary<string, string?>();
        if (username is not null) dict["AdminAuth:Username"] = username;
        if (password is not null) dict["AdminAuth:Password"] = password;
        return new DictionaryConfiguration(dict);
    }

    private static Cms.Service.Auth.Service CreateAuth(
        JwtService.IService jwtService,
        IConfiguration? configuration = null,
        int expireMin = 60) =>
        new(jwtService, ValidOptions(expireMin), configuration ?? ConfigurationWith("admin", "secret"));

    private static Request.LoginRequest ValidLogin => new() { Username = "admin", Password = "secret" };

    // ===== Login =====

    [Fact]
    public void Login_WithCorrectCredentials_ShouldReturnToken()
    {
        var jwt = CreateJwtService();
        var svc = CreateAuth(jwt);

        var result = svc.Login(ValidLogin);

        result.Should().NotBeNull();
        result.AccessToken.Should().NotBeNullOrWhiteSpace();
        result.TokenType.Should().Be("Bearer");
        result.ExpiresInMinutes.Should().Be(60);
        // Token phải là JWT hợp lệ (3 phần ngăn bởi dấu chấm).
        result.AccessToken.Split('.').Should().HaveCount(3);
    }

    [Fact]
    public void Login_WithCorrectCredentials_ShouldContainAdminRoleAndSubjectClaims()
    {
        var jwt = CreateJwtService();
        var svc = CreateAuth(jwt);

        var result = svc.Login(ValidLogin);
        var handler = new JwtSecurityTokenHandler();
        var token = handler.ReadJwtToken(result.AccessToken);

        token.Claims.Should().Contain(c => c.Type == ClaimTypes.Role && c.Value == "Admin");
        token.Claims.Should().Contain(c => c.Type == JwtRegisteredClaimNames.Sub && c.Value == "admin");
        token.Claims.Should().Contain(c => c.Type == JwtRegisteredClaimNames.Jti);
        token.Issuer.Should().Be("test-issuer");
        token.Audiences.Should().Contain("test-audience");
    }

    [Fact]
    public void Login_WithWrongPassword_ShouldThrowUnauthorized()
    {
        var jwt = CreateJwtService();
        var svc = CreateAuth(jwt);

        var act = () => svc.Login(new Request.LoginRequest { Username = "admin", Password = "wrong" });

        act.Should().Throw<UnauthorizedException>().WithMessage("Invalid username or password.");
    }

    [Fact]
    public void Login_WithWrongUsername_ShouldThrowUnauthorized()
    {
        var jwt = CreateJwtService();
        var svc = CreateAuth(jwt);

        var act = () => svc.Login(new Request.LoginRequest { Username = "root", Password = "secret" });

        act.Should().Throw<UnauthorizedException>().WithMessage("Invalid username or password.");
    }

    [Fact]
    public void Login_WithBothWrong_ShouldThrowUnauthorized()
    {
        var jwt = CreateJwtService();
        var svc = CreateAuth(jwt);

        var act = () => svc.Login(new Request.LoginRequest { Username = "nope", Password = "nope" });

        act.Should().Throw<UnauthorizedException>();
    }

    [Fact]
    public void Login_WithEmptyCredentials_ShouldThrowUnauthorized()
    {
        var jwt = CreateJwtService();
        var svc = CreateAuth(jwt);

        var act = () => svc.Login(new Request.LoginRequest { Username = "", Password = "" });

        act.Should().Throw<UnauthorizedException>();
    }

    [Fact]
    public void Login_WhenConfigHasNullCredentials_ShouldThrowUnauthorized()
    {
        // Cấu hình thiếu AdminAuth → username/password = null → mọi đăng nhập đều sai.
        var jwt = CreateJwtService();
        var config = ConfigurationWith(null, null);
        var svc = CreateAuth(jwt, config);

        var act = () => svc.Login(ValidLogin);

        act.Should().Throw<UnauthorizedException>();
    }

    [Fact]
    public void Login_ShouldRespectExpireInMinutesFromOptions()
    {
        var jwt = CreateJwtService(expireMin: 15);
        var svc = CreateAuth(jwt, expireMin: 15);

        var result = svc.Login(ValidLogin);

        result.ExpiresInMinutes.Should().Be(15);
    }

    [Fact]
    public void Login_ShouldGenerateUniqueJtiEachCall()
    {
        var jwt = CreateJwtService();
        var svc = CreateAuth(jwt);

        var r1 = svc.Login(ValidLogin);
        var r2 = svc.Login(ValidLogin);

        r1.AccessToken.Should().NotBe(r2.AccessToken);
    }

    // ===== Logout =====

    [Fact]
    public void Logout_ShouldReturnSuccessMessage()
    {
        var jwt = CreateJwtService();
        var svc = CreateAuth(jwt);

        var result = svc.Logout();

        result.Should().NotBeNull();
        result.Message.Should().Be("Logged out successfully.");
    }
}
