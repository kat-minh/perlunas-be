using Cms.Repository;
using Cms.Repository.Enums;
using Cms.Service.Exceptions;
using Cms.Service.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.ImportantInfor;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateImportantInforRequest> _createValidator;
    private readonly IValidator<Request.UpdateImportantInforRequest> _updateValidator;

    public Service(AppDbContext dbContext, IValidator<Request.CreateImportantInforRequest> createValidator, IValidator<Request.UpdateImportantInforRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize)
    {
        pageIndex = pageIndex <= 0 ? 1 : pageIndex;
        pageSize = pageSize <= 0 ? 10 : Math.Min(pageSize, 100);

        var query = _dbContext.ImportantInfors
            .AsNoTracking()
            .Where(x => !x.IsDeleted);

        var totalCount = await query.CountAsync();
        var items = await query
            .OrderByDescending(x => x.CreatedAt)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .Select(x => ToResponse(x))
            .ToListAsync();

        return ApiResponseFactory.BasePagination(items, pageIndex, pageSize, totalCount);
    }

    public async Task<Response.ImportantInforResponse> GetByIdAsync(Guid id)
    {
        var importantInfor = await _dbContext.ImportantInfors
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (importantInfor is null) throw new NotFoundException("Important information not found.");

        return ToResponse(importantInfor);
    }

    public async Task<Response.ImportantInforResponse> CreateAsync(Request.CreateImportantInforRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var service = await _dbContext.Services.FirstOrDefaultAsync(x => x.Id == request.ServiceId && !x.IsDeleted)
            ?? throw new NotFoundException("Service not found.");

        if (service.Type != ServiceType.Tour && service.Type != ServiceType.Combo)
            throw new BadRequestException("Important information is only allowed for Tour or Combo services.");

        var now = DateTime.UtcNow;
        var importantInfor = new Repository.Entities.ImportantInfor
        {
            Id = Guid.NewGuid(),
            ServiceId = request.ServiceId,
            Title = request.Title.Trim(),
            SubTitle = request.SubTitle.Trim(),
            Description = request.Description.Trim(),
            CreatedAt = now,
            UpdatedAt = now,
        };

        _dbContext.ImportantInfors.Add(importantInfor);
        await _dbContext.SaveChangesAsync();

        return ToResponse(importantInfor);
    }

    public async Task<Response.ImportantInforResponse> UpdateAsync(Guid id, Request.UpdateImportantInforRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var importantInfor = await _dbContext.ImportantInfors.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (importantInfor is null) throw new NotFoundException("Important information not found.");

        var service = await _dbContext.Services.FirstOrDefaultAsync(x => x.Id == request.ServiceId && !x.IsDeleted)
            ?? throw new NotFoundException("Service not found.");

        if (service.Type != ServiceType.Tour && service.Type != ServiceType.Combo)
            throw new BadRequestException("Important information is only allowed for Tour or Combo services.");

        importantInfor.ServiceId = request.ServiceId;
        importantInfor.Title = request.Title.Trim();
        importantInfor.SubTitle = request.SubTitle.Trim();
        importantInfor.Description = request.Description.Trim();
        importantInfor.UpdatedAt = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync();

        return ToResponse(importantInfor);
    }

    public async Task<string> DeleteAsync(Guid id)
    {
        var importantInfor = await _dbContext.ImportantInfors
            .Include(x => x.Service)
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (importantInfor is null) throw new NotFoundException("Important information not found.");

        if (importantInfor.Service.Type != ServiceType.Tour && importantInfor.Service.Type != ServiceType.Combo)
            throw new BadRequestException("Important information is only allowed for Tour or Combo services.");

        importantInfor.IsDeleted = true;
        importantInfor.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();

        return "Important information deleted successfully.";
    }

    private static Response.ImportantInforResponse ToResponse(Repository.Entities.ImportantInfor importantInfor)
    {
        return new Response.ImportantInforResponse
        {
            Id = importantInfor.Id,
            ServiceId = importantInfor.ServiceId,
            Title = importantInfor.Title ?? string.Empty,
            SubTitle = importantInfor.SubTitle ?? string.Empty,
            Description = importantInfor.Description ?? string.Empty,
            CreatedAt = importantInfor.CreatedAt,
            UpdatedAt = importantInfor.UpdatedAt,
        };
    }
}
