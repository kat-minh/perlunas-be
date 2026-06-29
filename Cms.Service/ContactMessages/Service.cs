using Cms.Repository.Entities;
using Cms.Repository;
using Cms.Service.Common;
using Cms.Service.Models;
using Cms.Service.Queries;
using Cms.Service.Exceptions;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.ContactMessages;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<MessageQuery> _queryValidator;
    private readonly IValidator<Request.CreateContactMessageRequest> _createValidator;

    public Service(AppDbContext dbContext,
        IValidator<MessageQuery> queryValidator,
        IValidator<Request.CreateContactMessageRequest> createValidator)
    {
        _dbContext = dbContext;
        _queryValidator = queryValidator;
        _createValidator = createValidator;
    }

    public async Task<List<Response.ContactMessageResponse>> GetAllAsync()
    {
        return await _dbContext.ContactMessages
            .AsNoTracking()
            .Where(x => !x.IsDeleted)
            .OrderByDescending(x => x.CreatedAt)
            .Select(x => new Response.ContactMessageResponse
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Phone = x.Phone,
                Subject = x.Subject,
                Message = x.Message,
                IsRead = x.IsRead,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
            })
            .ToListAsync();
    }

    public async Task<BasePaginationResponse> GetPagedAsync(MessageQuery query)
    {
        await _queryValidator.ValidateAndThrowAsync(query);
        var (page, pageSize) = query.Normalized();

        var q = _dbContext.ContactMessages
            .AsNoTracking()
            .Where(x => !x.IsDeleted);

        if (query.Unread == true)
        {
            q = q.Where(m => !m.IsRead);
        }

        if (!string.IsNullOrWhiteSpace(query.Search))
        {
            q = q.Where(m =>
                EF.Functions.ILike(m.Name, $"%{query.Search}%") ||
                EF.Functions.ILike(m.Email, $"%{query.Search}%") ||
                EF.Functions.ILike(m.Subject ?? "", $"%{query.Search}%"));
        }

        var total = await q.CountAsync();
        var items = await q
            .OrderByDescending(m => m.CreatedAt)
            .Skip((page - 1) * pageSize).Take(pageSize)
            .Select(x => new Response.ContactMessageResponse
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Phone = x.Phone,
                Subject = x.Subject,
                Message = x.Message,
                IsRead = x.IsRead,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
            })
            .ToListAsync();

        return ApiResponseFactory.BasePagination(items, page, pageSize, total);
    }

    public Task<int> CountUnreadAsync()
        => _dbContext.ContactMessages.CountAsync(m => !m.IsRead && !m.IsDeleted);

    public async Task<Response.ContactMessageResponse> CreateAsync(Request.CreateContactMessageRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var now = DateTime.UtcNow;
        var msg = new ContactMessage
        {
            Id = Guid.NewGuid(),
            Name = request.Name.Trim(),
            Email = request.Email.Trim(),
            Phone = request.Phone,
            Subject = request.Subject,
            Message = request.Message,
            IsRead = false,
            CreatedAt = now,
            UpdatedAt = now,
        };
        _dbContext.ContactMessages.Add(msg);
        await _dbContext.SaveChangesAsync();
        return new Response.ContactMessageResponse
        {
            Id = msg.Id,
            Name = msg.Name,
            Email = msg.Email,
            Phone = msg.Phone,
            Subject = msg.Subject,
            Message = msg.Message,
            IsRead = msg.IsRead,
            CreatedAt = msg.CreatedAt,
            UpdatedAt = msg.UpdatedAt,
        };
    }

    public async Task<Response.ContactMessageResponse> MarkReadAsync(Guid id)
    {
        var msg = await _dbContext.ContactMessages
            .FirstOrDefaultAsync(m => m.Id == id && !m.IsDeleted);

        if (msg is null) throw new NotFoundException("Message not found");

        msg.IsRead = true;
        msg.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();
        return new Response.ContactMessageResponse
        {
            Id = msg.Id,
            Name = msg.Name,
            Email = msg.Email,
            Phone = msg.Phone,
            Subject = msg.Subject,
            Message = msg.Message,
            IsRead = msg.IsRead,
            CreatedAt = msg.CreatedAt,
            UpdatedAt = msg.UpdatedAt,
        };
    }

    public async Task DeleteAsync(Guid id)
    {
        var msg = await _dbContext.ContactMessages
            .FirstOrDefaultAsync(m => m.Id == id && !m.IsDeleted);

        if (msg is null) throw new NotFoundException("Message not found");

        msg.IsDeleted = true;
        msg.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();
    }
}
