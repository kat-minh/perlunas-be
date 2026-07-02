using System.Text.Json;
using Cms.Repository;
using Cms.Repository.Enums;
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

        var service = await _dbContext.Services.FirstOrDefaultAsync(x => x.Id == request.ServiceId && !x.IsDeleted)
            ?? throw new NotFoundException("Service not found.");

        if (service.Type != ServiceType.Combo && service.Type != ServiceType.Hotel)
            throw new BadRequestException("Room categories are only allowed for Combo or Hotel services.");

        var now = DateTime.UtcNow;
        var roomCategory = new Repository.Entities.RoomCategory
        {
            Id = Guid.NewGuid(),
            ServiceId = request.ServiceId,
            Album = JsonSerializer.Serialize(request.Album),
            Titile = request.Titile.Trim(),
            NumberOfCustomer = request.NumberOfCustomer,
            Acreage = request.Acreage.Trim(),
            NumberOfBed = request.NumberOfBed.Trim(),
            Description = request.Description.Trim(),
            Feature = request.Feature.Trim(),
            Price = service.Type == ServiceType.Combo ? null : request.Price?.Trim(),
            OriginalPrice = request.OriginalPrice?.Trim(),
            Unit = request.Unit?.Trim(),
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

        var service = await _dbContext.Services.FirstOrDefaultAsync(x => x.Id == request.ServiceId && !x.IsDeleted)
            ?? throw new NotFoundException("Service not found.");

        if (service.Type != ServiceType.Combo && service.Type != ServiceType.Hotel)
            throw new BadRequestException("Room categories are only allowed for Combo or Hotel services.");

        roomCategory.ServiceId = request.ServiceId;
        roomCategory.Album = JsonSerializer.Serialize(request.Album);
        roomCategory.Titile = request.Titile.Trim();
        roomCategory.NumberOfCustomer = request.NumberOfCustomer;
        roomCategory.Acreage = request.Acreage.Trim();
        roomCategory.NumberOfBed = request.NumberOfBed.Trim();
        roomCategory.Description = request.Description.Trim();
        roomCategory.Feature = request.Feature.Trim();
        roomCategory.Price = service.Type == ServiceType.Combo ? null : request.Price?.Trim();
        roomCategory.OriginalPrice = request.OriginalPrice?.Trim();
        roomCategory.Unit = request.Unit?.Trim();
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
            Album = DeserializeAlbum(roomCategory.Album),
            Titile = roomCategory.Titile ?? string.Empty,
            NumberOfCustomer = roomCategory.NumberOfCustomer ?? 0,
            Acreage = roomCategory.Acreage ?? string.Empty,
            NumberOfBed = roomCategory.NumberOfBed ?? string.Empty,
            Description = roomCategory.Description ?? string.Empty,
            Feature = roomCategory.Feature ?? string.Empty,
            Price = roomCategory.Price,
            OriginalPrice = roomCategory.OriginalPrice,
            Unit = roomCategory.Unit,
            CreatedAt = roomCategory.CreatedAt,
            UpdatedAt = roomCategory.UpdatedAt,
        };
    }

    private static List<string> DeserializeAlbum(string? album)
    {
        if (string.IsNullOrWhiteSpace(album)) return new();
        try { return JsonSerializer.Deserialize<List<string>>(album) ?? new(); }
        catch { return new(); }
    }
}
