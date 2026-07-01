using Cms.Repository;
using Cms.Service.Exceptions;
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

    public async Task<List<Response.ImportantInforResponse>> GetAllAsync()
    {
        return await _dbContext.ImportantInfors
            .AsNoTracking()
            .Where(x => !x.IsDeleted)
            .OrderByDescending(x => x.CreatedAt)
            .Select(x => ToResponse(x))
            .ToListAsync();
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

        var serviceExists = await _dbContext.Services.AnyAsync(x => x.Id == request.ServiceId && !x.IsDeleted);
        if (!serviceExists) throw new NotFoundException("Service not found.");

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

        var serviceExists = await _dbContext.Services.AnyAsync(x => x.Id == request.ServiceId && !x.IsDeleted);
        if (!serviceExists) throw new NotFoundException("Service not found.");

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
        var importantInfor = await _dbContext.ImportantInfors.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (importantInfor is null) throw new NotFoundException("Important information not found.");

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
