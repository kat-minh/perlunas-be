using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Cms.Repository;
using Cms.Repository.Entities;
using Cms.Service.CurrentUser;
using Cms.Service.Exceptions;
using Cms.Service.JwtService;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Cms.Repository.Enums;

namespace Cms.Service.Auth;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly JwtService.IService _jwtService;
    private readonly JwtOption _jwtOption;
    private readonly ICurrentUserService _currentUser;
    private readonly IValidator<Request.LoginRequest> _loginValidator;
    private readonly IValidator<Request.RegisterRequest> _registerValidator;

    public Service(AppDbContext dbContext, JwtService.IService jwtService, IOptions<JwtOption> jwtOption, ICurrentUserService currentUser, IValidator<Request.LoginRequest> loginValidator, IValidator<Request.RegisterRequest> registerValidator)
    {
        _dbContext = dbContext;
        _jwtService = jwtService;
        _jwtOption = jwtOption.Value;
        _currentUser = currentUser;
        _loginValidator = loginValidator;
        _registerValidator = registerValidator;
    }

    public async Task<Response.LoginResponse> LoginAsync(Request.LoginRequest request)
    {
        await _loginValidator.ValidateAndThrowAsync(request);

        var user = await _dbContext.Users
            .FirstOrDefaultAsync(u => u.Username == request.Username && !u.IsDeleted);

        if (user is null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
        {
            throw new UnauthorizedException("Invalid username or password.");
        }

        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new(ClaimTypes.Name, user.Username),
            new(ClaimTypes.Email, user.Email),
            new(ClaimTypes.Role, user.Role.ToString()),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };

        var accessToken = _jwtService.GenerateAccessToken(claims);
        var refreshToken = _jwtService.GenerateRefreshToken();

        _dbContext.RefreshTokens.Add(new RefreshToken
        {
            Id = Guid.NewGuid(),
            UserId = user.Id,
            Token = refreshToken,
            ExpiresAt = DateTime.UtcNow.AddDays(_jwtOption.RefreshTokenExpiryDays),
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
        });
        await _dbContext.SaveChangesAsync();

        return new Response.LoginResponse
        {
            AccessToken = accessToken,
            RefreshToken = refreshToken,
            TokenType = "Bearer",
            ExpiresInMinutes = _jwtOption.AccessTokenExpiryMinutes,
        };
    }

    public async Task<Response.LoginResponse> RegisterAsync(Request.RegisterRequest request)
    {
        await _registerValidator.ValidateAndThrowAsync(request);

        if (await _dbContext.Users.AnyAsync(u => u.Username == request.Username))
            throw new ConflictException("Username already exists.");
        if (await _dbContext.Users.AnyAsync(u => u.Email == request.Email))
            throw new ConflictException("Email already exists.");

        var now = DateTime.UtcNow;
        var user = new User
        {
            Id = Guid.NewGuid(),
            Username = request.Username.Trim(),
            Email = request.Email.Trim().ToLower(),
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password, workFactor: 11),
            Role = UserRole.User,
            CreatedAt = now,
            UpdatedAt = now,
        };

        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();

        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new(ClaimTypes.Name, user.Username),
            new(ClaimTypes.Email, user.Email),
            new(ClaimTypes.Role, user.Role.ToString()),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };

        var accessToken = _jwtService.GenerateAccessToken(claims);
        var refreshToken = _jwtService.GenerateRefreshToken();

        _dbContext.RefreshTokens.Add(new RefreshToken
        {
            Id = Guid.NewGuid(),
            UserId = user.Id,
            Token = refreshToken,
            ExpiresAt = DateTime.UtcNow.AddDays(_jwtOption.RefreshTokenExpiryDays),
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
        });
        await _dbContext.SaveChangesAsync();

        return new Response.LoginResponse
        {
            AccessToken = accessToken,
            RefreshToken = refreshToken,
            TokenType = "Bearer",
            ExpiresInMinutes = _jwtOption.AccessTokenExpiryMinutes,
        };
    }

    public async Task<Response.UserProfileResponse> GetProfileAsync()
    {
        var id = _currentUser.GetRequiredUserId();

        var user = await _dbContext.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);

        if (user is null) throw new NotFoundException("User not found");

        return new Response.UserProfileResponse
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            Role = user.Role.ToString(),
        };
    }

    public async Task LogoutAsync()
    {
        var id = _currentUser.GetRequiredUserId();

        var refreshTokens = await _dbContext.RefreshTokens
            .Where(rt => rt.UserId == id && !rt.IsRevoked)
            .ToListAsync();

        foreach (var rt in refreshTokens)
        {
            rt.IsRevoked = true;
            rt.UpdatedAt = DateTime.UtcNow;
        }

        await _dbContext.SaveChangesAsync();
    }
}
