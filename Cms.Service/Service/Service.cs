using Cms.Repository;
using Cms.Service.Exceptions;
using Cms.Service.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.Service;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateServiceRequest> _createValidator;
    private readonly IValidator<Request.UpdateServiceRequest> _updateValidator;

    public Service(AppDbContext dbContext, IValidator<Request.CreateServiceRequest> createValidator, IValidator<Request.UpdateServiceRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize)
    {
        pageIndex = pageIndex <= 0 ? 1 : pageIndex;
        pageSize = pageSize <= 0 ? 10 : Math.Min(pageSize, 100);

        var query = _dbContext.Services
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

    public async Task<Response.ServiceResponse> GetByIdAsync(Guid id)
    {
        var service = await _dbContext.Services
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (service is null) throw new NotFoundException("Service not found.");

        return ToResponse(service);
    }

    public async Task<Response.ServiceResponse> CreateAsync(Request.CreateServiceRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var now = DateTime.UtcNow;
        var service = new Repository.Entities.Service
        {
            Id = Guid.NewGuid(),
            Title = request.Title.Trim(),
            Introducetion = request.Introducetion.Trim(),
            Day = request.Day,
            Night = request.Night,
            Label = request.Label.Trim(),
            Album = request.Album.Trim(),
            Region = request.Region.Trim(),
            Description = request.Description.Trim(),
            Infor = request.Infor.Trim(),
            Highlight = request.Highlight.Trim(),
            Code = request.Code.Trim(),
            Instruct = request.Instruct.Trim(),
            Feature = request.Feature.Trim(),
            Type = request.Type.Trim(),
            IsPublic = request.IsPublic,
            CreatedAt = now,
            UpdatedAt = now,
        };

        _dbContext.Services.Add(service);
        await _dbContext.SaveChangesAsync();

        return ToResponse(service);
    }

    public async Task<Response.ServiceResponse> UpdateAsync(Guid id, Request.UpdateServiceRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var service = await _dbContext.Services.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (service is null) throw new NotFoundException("Service not found.");

        service.Title = request.Title.Trim();
        service.Introducetion = request.Introducetion.Trim();
        service.Day = request.Day;
        service.Night = request.Night;
        service.Label = request.Label.Trim();
        service.Album = request.Album.Trim();
        service.Region = request.Region.Trim();
        service.Description = request.Description.Trim();
        service.Infor = request.Infor.Trim();
        service.Highlight = request.Highlight.Trim();
        service.Code = request.Code.Trim();
        service.Instruct = request.Instruct.Trim();
        service.Feature = request.Feature.Trim();
        service.Type = request.Type.Trim();
        service.IsPublic = request.IsPublic;
        service.UpdatedAt = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync();

        return ToResponse(service);
    }

    public async Task<string> DeleteAsync(Guid id)
    {
        var service = await _dbContext.Services.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (service is null) throw new NotFoundException("Service not found.");

        service.IsDeleted = true;
        service.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();

        return "Service deleted successfully.";
    }

    private static Response.ServiceResponse ToResponse(Repository.Entities.Service service)
    {
        return new Response.ServiceResponse
        {
            Id = service.Id,
            Title = service.Title ?? string.Empty,
            Introducetion = service.Introducetion ?? string.Empty,
            Day = service.Day ?? 0,
            Night = service.Night ?? 0,
            Label = service.Label ?? string.Empty,
            Album = service.Album ?? string.Empty,
            Region = service.Region ?? string.Empty,
            Description = service.Description ?? string.Empty,
            Infor = service.Infor ?? string.Empty,
            Highlight = service.Highlight ?? string.Empty,
            Code = service.Code ?? string.Empty,
            Instruct = service.Instruct ?? string.Empty,
            Feature = service.Feature ?? string.Empty,
            Type = service.Type ?? string.Empty,
            IsPublic = service.IsPublic,
            CreatedAt = service.CreatedAt,
            UpdatedAt = service.UpdatedAt,
        };
    }
}
