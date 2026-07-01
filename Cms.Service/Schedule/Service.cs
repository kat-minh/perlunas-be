using Cms.Repository;
using Cms.Service.Exceptions;
using Cms.Service.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.Schedule;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateScheduleRequest> _createValidator;
    private readonly IValidator<Request.UpdateScheduleRequest> _updateValidator;

    public Service(AppDbContext dbContext, IValidator<Request.CreateScheduleRequest> createValidator, IValidator<Request.UpdateScheduleRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize)
    {
        pageIndex = pageIndex <= 0 ? 1 : pageIndex;
        pageSize = pageSize <= 0 ? 10 : Math.Min(pageSize, 100);

        var query = _dbContext.Schedules
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

    public async Task<Response.ScheduleResponse> GetByIdAsync(Guid id)
    {
        var schedule = await _dbContext.Schedules
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (schedule is null) throw new NotFoundException("Schedule not found.");

        return ToResponse(schedule);
    }

    public async Task<Response.ScheduleResponse> CreateAsync(Request.CreateScheduleRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var serviceExists = await _dbContext.Services.AnyAsync(x => x.Id == request.ServiceId && !x.IsDeleted);
        if (!serviceExists) throw new NotFoundException("Service not found.");

        var now = DateTime.UtcNow;
        var schedule = new Repository.Entities.Schedule
        {
            Id = Guid.NewGuid(),
            ServiceId = request.ServiceId,
            Day = request.Day.Trim(),
            Titile = request.Titile.Trim(),
            SubTitile = request.SubTitile.Trim(),
            Sumary = request.Sumary.Trim(),
            Description = request.Description.Trim(),
            CreatedAt = now,
            UpdatedAt = now,
        };

        _dbContext.Schedules.Add(schedule);
        await _dbContext.SaveChangesAsync();

        return ToResponse(schedule);
    }

    public async Task<Response.ScheduleResponse> UpdateAsync(Guid id, Request.UpdateScheduleRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var schedule = await _dbContext.Schedules.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (schedule is null) throw new NotFoundException("Schedule not found.");

        var serviceExists = await _dbContext.Services.AnyAsync(x => x.Id == request.ServiceId && !x.IsDeleted);
        if (!serviceExists) throw new NotFoundException("Service not found.");

        schedule.ServiceId = request.ServiceId;
        schedule.Day = request.Day.Trim();
        schedule.Titile = request.Titile.Trim();
        schedule.SubTitile = request.SubTitile.Trim();
        schedule.Sumary = request.Sumary.Trim();
        schedule.Description = request.Description.Trim();
        schedule.UpdatedAt = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync();

        return ToResponse(schedule);
    }

    public async Task<string> DeleteAsync(Guid id)
    {
        var schedule = await _dbContext.Schedules.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (schedule is null) throw new NotFoundException("Schedule not found.");

        schedule.IsDeleted = true;
        schedule.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();

        return "Schedule deleted successfully.";
    }

    private static Response.ScheduleResponse ToResponse(Repository.Entities.Schedule schedule)
    {
        return new Response.ScheduleResponse
        {
            Id = schedule.Id,
            ServiceId = schedule.ServiceId,
            Day = schedule.Day ?? string.Empty,
            Titile = schedule.Titile ?? string.Empty,
            SubTitile = schedule.SubTitile ?? string.Empty,
            Sumary = schedule.Sumary ?? string.Empty,
            Description = schedule.Description ?? string.Empty,
            CreatedAt = schedule.CreatedAt,
            UpdatedAt = schedule.UpdatedAt,
        };
    }
}
