using Cms.Repository.Entities;
using Cms.Repository;
using Cms.Repository.Enums;
using Cms.Service.Exceptions;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.Users;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateUserRequest> _createValidator;
    private readonly IValidator<Request.UpdateUserRequest> _updateValidator;

    public Service(AppDbContext dbContext,
        IValidator<Request.CreateUserRequest> createValidator,
        IValidator<Request.UpdateUserRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<List<Response.UserResponse>> GetAllAsync()
    {
        return await _dbContext.Users
            .AsNoTracking()
            .Where(x => !x.IsDeleted)
            .OrderBy(x => x.Username)
            .Select(x => new Response.UserResponse
            {
                Id = x.Id,
                Username = x.Username,
                Email = x.Email,
                Role = x.Role,
            })
            .ToListAsync();
    }

    public async Task<Response.UserResponse> CreateAsync(Request.CreateUserRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        if (await _dbContext.Users.AnyAsync(u =>
            (u.Username == request.Username.Trim() || u.Email == request.Email.Trim()) && !u.IsDeleted))
        {
            throw new ConflictException("Username or email already exists.");
        }
        if (!Enum.TryParse<UserRole>(request.Role, true, out var role))
            throw new BadRequestException($"Invalid role: {request.Role}");

        var user = new User
        {
            Id = Guid.NewGuid(),
            Username = request.Username.Trim(),
            Email = request.Email.Trim(),
            Role = role,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
        };
        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();
        return new Response.UserResponse
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            Role = user.Role,
        };
    }

    public async Task<Response.UserResponse> UpdateAsync(Guid id, Request.UpdateUserRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var user = await _dbContext.Users
            .FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);

        if (user is null) throw new NotFoundException("User not found.");

        var username = request.Username.Trim();
        var email = request.Email.Trim();

        if (await _dbContext.Users.AnyAsync(u =>
            u.Id != id && (u.Username == username || u.Email == email) && !u.IsDeleted))
        {
            throw new ConflictException("Username or email already exists.");
        }

        user.Username = username;
        user.Email = email;
        user.Role = Enum.Parse<UserRole>(request.Role, true);
        if (!string.IsNullOrWhiteSpace(request.Password))
        {
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);
        }
        user.UpdatedAt = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync();
        return new Response.UserResponse
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            Role = user.Role,
        };
    }

    public async Task DeleteAsync(Guid id)
    {
        var user = await _dbContext.Users
            .FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);

        if (user is null) throw new NotFoundException("User not found.");

        user.IsDeleted = true;
        user.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();
    }
}
