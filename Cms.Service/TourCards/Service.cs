using Cms.Repository;
using Cms.Repository.Entities;
using Cms.Repository.Enums;
using Cms.Service.Exceptions;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.TourCards;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateTourCardRequest> _createValidator;
    private readonly IValidator<Request.UpdateTourCardRequest> _updateValidator;

    public Service(AppDbContext dbContext,
        IValidator<Request.CreateTourCardRequest> createValidator,
        IValidator<Request.UpdateTourCardRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<List<Response.TourCardResponse>> GetAllAsync(TourCardType? type = null)
    {
        var query = _dbContext.Set<TourCard>()
            .AsNoTracking()
            .Where(x => !x.IsDeleted);

        if (type.HasValue)
            query = query.Where(x => x.Type == type.Value);

        return await query
            .OrderBy(x => x.SortOrder)
            .Select(x => new Response.TourCardResponse
            {
                Id = x.Id,
                Type = x.Type,
                Title = x.Title,
                Image = x.Image,
                Description = x.Description,
                SortOrder = x.SortOrder,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
            })
            .ToListAsync();
    }

    public async Task<Response.TourCardResponse> GetByIdAsync(Guid id, TourCardType? expectedType = null)
    {
        var query = _dbContext.Set<TourCard>()
            .AsNoTracking()
            .Where(x => x.Id == id && !x.IsDeleted);

        if (expectedType.HasValue)
            query = query.Where(x => x.Type == expectedType.Value);

        var entity = await query.FirstOrDefaultAsync();

        if (entity is null) throw new NotFoundException("Tour card not found");
        return new Response.TourCardResponse
        {
            Id = entity.Id,
            Type = entity.Type,
            Title = entity.Title,
            Image = entity.Image,
            Description = entity.Description,
            SortOrder = entity.SortOrder,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt,
        };
    }

    public async Task<Response.TourCardResponse> CreateAsync(Request.CreateTourCardRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var title = request.Title.Trim();
        if (await _dbContext.Set<TourCard>().AnyAsync(x => !x.IsDeleted && x.Type == request.Type && x.Title.ToLower() == title.ToLower()))
            throw new ConflictException("Tour card title already exists.");

        var maxOrder = await _dbContext.Set<TourCard>()
            .Where(x => !x.IsDeleted && x.Type == request.Type)
            .MaxAsync(x => (int?)x.SortOrder) ?? 0;

        var entity = new TourCard
        {
            Id = Guid.NewGuid(),
            Type = request.Type,
            Title = title,
            Image = request.Image,
            Description = request.Description,
            SortOrder = maxOrder + 1,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
        };
        _dbContext.Set<TourCard>().Add(entity);
        await _dbContext.SaveChangesAsync();
        return new Response.TourCardResponse
        {
            Id = entity.Id,
            Type = entity.Type,
            Title = entity.Title,
            Image = entity.Image,
            Description = entity.Description,
            SortOrder = entity.SortOrder,
            CreatedAt = entity.CreatedAt,
        };
    }

    public async Task<Response.TourCardResponse> UpdateAsync(Guid id, Request.UpdateTourCardRequest request, TourCardType? expectedType = null)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var query = _dbContext.Set<TourCard>()
            .Where(x => x.Id == id && !x.IsDeleted);

        if (expectedType.HasValue)
            query = query.Where(x => x.Type == expectedType.Value);

        var entity = await query.FirstOrDefaultAsync();

        if (entity is null) throw new NotFoundException("Tour card not found");

        var title = request.Title.Trim();
        if (await _dbContext.Set<TourCard>().AnyAsync(x => !x.IsDeleted && x.Id != id && x.Type == entity.Type && x.Title.ToLower() == title.ToLower()))
            throw new ConflictException("Tour card title already exists.");

        entity.Title = title;
        entity.Image = request.Image;
        entity.Description = request.Description;
        entity.UpdatedAt = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync();
        return new Response.TourCardResponse
        {
            Id = entity.Id,
            Type = entity.Type,
            Title = entity.Title,
            Image = entity.Image,
            Description = entity.Description,
            SortOrder = entity.SortOrder,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt,
        };
    }

    public async Task DeleteAsync(Guid id, TourCardType? expectedType = null)
    {
        var query = _dbContext.Set<TourCard>()
            .Where(x => x.Id == id && !x.IsDeleted);

        if (expectedType.HasValue)
            query = query.Where(x => x.Type == expectedType.Value);

        var entity = await query.FirstOrDefaultAsync();

        if (entity is null) throw new NotFoundException("Tour card not found");

        entity.IsDeleted = true;
        entity.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();
    }
}
