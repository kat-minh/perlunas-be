using Cms.Repository;
using Cms.Service.Exceptions;
using Cms.Service.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.DepartureSchedule;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateDepartureScheduleRequest> _createValidator;
    private readonly IValidator<Request.UpdateDepartureScheduleRequest> _updateValidator;

    public Service(AppDbContext dbContext, IValidator<Request.CreateDepartureScheduleRequest> createValidator, IValidator<Request.UpdateDepartureScheduleRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize)
    {
        pageIndex = pageIndex <= 0 ? 1 : pageIndex;
        pageSize = pageSize <= 0 ? 10 : Math.Min(pageSize, 100);

        var query = _dbContext.DepartureSchedules
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

    public async Task<Response.DepartureScheduleResponse> GetByIdAsync(Guid id)
    {
        var departureSchedule = await _dbContext.DepartureSchedules
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (departureSchedule is null) throw new NotFoundException("Departure schedule not found.");

        return ToResponse(departureSchedule);
    }

    public async Task<Response.DepartureScheduleResponse> CreateAsync(Request.CreateDepartureScheduleRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var serviceExists = await _dbContext.Services.AnyAsync(x => x.Id == request.ServiceId && !x.IsDeleted);
        if (!serviceExists) throw new NotFoundException("Service not found.");

        var now = DateTime.UtcNow;
        var departureSchedule = new Repository.Entities.DepartureSchedule
        {
            Id = Guid.NewGuid(),
            ServiceId = request.ServiceId,
            StartTime = request.StartTime.Trim(),
            Code = request.Code.Trim(),
            Price = request.Price.Trim(),
            AccommodationStandards = request.AccommodationStandards.Trim(),
            CreatedAt = now,
            UpdatedAt = now,
        };

        _dbContext.DepartureSchedules.Add(departureSchedule);
        await _dbContext.SaveChangesAsync();

        return ToResponse(departureSchedule);
    }

    public async Task<Response.DepartureScheduleResponse> UpdateAsync(Guid id, Request.UpdateDepartureScheduleRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var departureSchedule = await _dbContext.DepartureSchedules.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (departureSchedule is null) throw new NotFoundException("Departure schedule not found.");

        var serviceExists = await _dbContext.Services.AnyAsync(x => x.Id == request.ServiceId && !x.IsDeleted);
        if (!serviceExists) throw new NotFoundException("Service not found.");

        departureSchedule.ServiceId = request.ServiceId;
        departureSchedule.StartTime = request.StartTime.Trim();
        departureSchedule.Code = request.Code.Trim();
        departureSchedule.Price = request.Price.Trim();
        departureSchedule.AccommodationStandards = request.AccommodationStandards.Trim();
        departureSchedule.UpdatedAt = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync();

        return ToResponse(departureSchedule);
    }

    public async Task<string> DeleteAsync(Guid id)
    {
        var departureSchedule = await _dbContext.DepartureSchedules.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (departureSchedule is null) throw new NotFoundException("Departure schedule not found.");

        departureSchedule.IsDeleted = true;
        departureSchedule.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();

        return "Departure schedule deleted successfully.";
    }

    private static Response.DepartureScheduleResponse ToResponse(Repository.Entities.DepartureSchedule departureSchedule)
    {
        return new Response.DepartureScheduleResponse
        {
            Id = departureSchedule.Id,
            ServiceId = departureSchedule.ServiceId,
            StartTime = departureSchedule.StartTime ?? string.Empty,
            Code = departureSchedule.Code ?? string.Empty,
            Price = departureSchedule.Price ?? string.Empty,
            AccommodationStandards = departureSchedule.AccommodationStandards ?? string.Empty,
            CreatedAt = departureSchedule.CreatedAt,
            UpdatedAt = departureSchedule.UpdatedAt,
        };
    }
}
