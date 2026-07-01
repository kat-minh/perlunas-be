using Cms.Repository;
using Cms.Service.Exceptions;
using Cms.Service.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.RoomCategory;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateRoomCategoryRequest> _createValidator;
    private readonly IValidator<Request.UpdateRoomCategoryRequest> _updateValidator;

    public Service(AppDbContext dbContext, IValidator<Request.CreateRoomCategoryRequest> createValidator, IValidator<Request.UpdateRoomCategoryRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize)
    {
        pageIndex = pageIndex <= 0 ? 1 : pageIndex;
        pageSize = pageSize <= 0 ? 10 : Math.Min(pageSize, 100);

        var query = _dbContext.RoomCategories
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

    public async Task<Response.RoomCategoryResponse> GetByIdAsync(Guid id)
    {
        var roomCategory = await _dbContext.RoomCategories
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (roomCategory is null) throw new NotFoundException("Room category not found.");

        return ToResponse(roomCategory);
    }

    public async Task<Response.RoomCategoryResponse> CreateAsync(Request.CreateRoomCategoryRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var serviceExists = await _dbContext.Services.AnyAsync(x => x.Id == request.ServiceId && !x.IsDeleted);
        if (!serviceExists) throw new NotFoundException("Service not found.");

        var now = DateTime.UtcNow;
        var roomCategory = new Repository.Entities.RoomCategory
        {
            Id = Guid.NewGuid(),
            ServiceId = request.ServiceId,
            Album = request.Album.Trim(),
            Titile = request.Titile.Trim(),
            NumberOfCustomer = request.NumberOfCustomer,
            Acreage = request.Acreage.Trim(),
            NumberOfBed = request.NumberOfBed,
            Description = request.Description.Trim(),
            Feature = request.Feature.Trim(),
            Price = request.Price.Trim(),
            CreatedAt = now,
            UpdatedAt = now,
        };

        _dbContext.RoomCategories.Add(roomCategory);
        await _dbContext.SaveChangesAsync();

        return ToResponse(roomCategory);
    }

    public async Task<Response.RoomCategoryResponse> UpdateAsync(Guid id, Request.UpdateRoomCategoryRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var roomCategory = await _dbContext.RoomCategories.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (roomCategory is null) throw new NotFoundException("Room category not found.");

        var serviceExists = await _dbContext.Services.AnyAsync(x => x.Id == request.ServiceId && !x.IsDeleted);
        if (!serviceExists) throw new NotFoundException("Service not found.");

        roomCategory.ServiceId = request.ServiceId;
        roomCategory.Album = request.Album.Trim();
        roomCategory.Titile = request.Titile.Trim();
        roomCategory.NumberOfCustomer = request.NumberOfCustomer;
        roomCategory.Acreage = request.Acreage.Trim();
        roomCategory.NumberOfBed = request.NumberOfBed;
        roomCategory.Description = request.Description.Trim();
        roomCategory.Feature = request.Feature.Trim();
        roomCategory.Price = request.Price.Trim();
        roomCategory.UpdatedAt = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync();

        return ToResponse(roomCategory);
    }

    public async Task<string> DeleteAsync(Guid id)
    {
        var roomCategory = await _dbContext.RoomCategories.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (roomCategory is null) throw new NotFoundException("Room category not found.");

        roomCategory.IsDeleted = true;
        roomCategory.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();

        return "Room category deleted successfully.";
    }

    private static Response.RoomCategoryResponse ToResponse(Repository.Entities.RoomCategory roomCategory)
    {
        return new Response.RoomCategoryResponse
        {
            Id = roomCategory.Id,
            ServiceId = roomCategory.ServiceId,
            Album = roomCategory.Album ?? string.Empty,
            Titile = roomCategory.Titile ?? string.Empty,
            NumberOfCustomer = roomCategory.NumberOfCustomer ?? 0,
            Acreage = roomCategory.Acreage ?? string.Empty,
            NumberOfBed = roomCategory.NumberOfBed ?? 0,
            Description = roomCategory.Description ?? string.Empty,
            Feature = roomCategory.Feature ?? string.Empty,
            Price = roomCategory.Price ?? string.Empty,
            CreatedAt = roomCategory.CreatedAt,
            UpdatedAt = roomCategory.UpdatedAt,
        };
    }
}
