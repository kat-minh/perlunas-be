using Cms.Repository.Entities;
using Cms.Repository;
using Cms.Service.Exceptions;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.ComboTiers;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateComboTierRequest> _createValidator;
    private readonly IValidator<Request.UpdateComboTierRequest> _updateValidator;

    public Service(AppDbContext dbContext,
        IValidator<Request.CreateComboTierRequest> createValidator,
        IValidator<Request.UpdateComboTierRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createValidator = createValidator;
        _updateValidator = updateValidator;
    }

    public async Task<List<Response.ComboTierResponse>> GetAllAsync()
    {
        return await _dbContext.ComboTiers
            .AsNoTracking()
            .Where(x => !x.IsDeleted)
            .OrderBy(x => x.SortOrder)
            .Select(x => new Response.ComboTierResponse
            {
                Id = x.Id,
                Name = x.Name,
                Tagline = x.Tagline,
                Pearl = x.Pearl,
                Story = x.Story,
                Includes = x.Includes,
                SortOrder = x.SortOrder,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
            })
            .ToListAsync();
    }

    public async Task<Response.ComboTierResponse> GetByIdAsync(Guid id)
    {
        var entity = await _dbContext.ComboTiers
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (entity is null) throw new NotFoundException("Combo tier not found");
        return new Response.ComboTierResponse
        {
            Id = entity.Id,
            Name = entity.Name,
            Tagline = entity.Tagline,
            Pearl = entity.Pearl,
            Story = entity.Story,
            Includes = entity.Includes,
            SortOrder = entity.SortOrder,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt,
        };
    }

    public async Task<Response.ComboTierResponse> CreateAsync(Request.CreateComboTierRequest request)
    {
        await _createValidator.ValidateAndThrowAsync(request);

        var name = request.Name.Trim();
        if (await _dbContext.ComboTiers.AnyAsync(x => !x.IsDeleted && x.Name.ToLower() == name.ToLower()))
            throw new ConflictException("Combo tier already exists.");

        var maxOrder = await _dbContext.ComboTiers
            .Where(x => !x.IsDeleted)
            .MaxAsync(x => (int?)x.SortOrder) ?? 0;

        var entity = new ComboTier
        {
            Id = Guid.NewGuid(),
            Name = name,
            Tagline = request.Tagline,
            Pearl = request.Pearl,
            Story = request.Story,
            Includes = request.Includes,
            SortOrder =  maxOrder + 1,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
        };
        _dbContext.ComboTiers.Add(entity);
        await _dbContext.SaveChangesAsync();
        return new Response.ComboTierResponse
        {
            Id = entity.Id,
            Name = entity.Name,
            Tagline = entity.Tagline,
            Pearl = entity.Pearl,
            Story = entity.Story,
            Includes = entity.Includes,
            SortOrder = entity.SortOrder,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt,
        };
    }

    public async Task<Response.ComboTierResponse> UpdateAsync(Guid id, Request.UpdateComboTierRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var entity = await _dbContext.ComboTiers
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (entity is null) throw new NotFoundException("Combo tier not found");

        var name = request.Name.Trim();
        if (await _dbContext.ComboTiers.AnyAsync(x => !x.IsDeleted && x.Id != id && x.Name.ToLower() == name.ToLower()))
            throw new ConflictException("Combo tier already exists.");

        entity.Name = name;
        entity.Tagline = request.Tagline;
        entity.Pearl = request.Pearl;
        entity.Story = request.Story;
        entity.Includes = request.Includes;
        entity.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();
        return new Response.ComboTierResponse
        {
            Id = entity.Id,
            Name = entity.Name,
            Tagline = entity.Tagline,
            Pearl = entity.Pearl,
            Story = entity.Story,
            Includes = entity.Includes,
            SortOrder = entity.SortOrder,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt,
        };
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await _dbContext.ComboTiers
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (entity is null) throw new NotFoundException("Combo tier not found");

        entity.IsDeleted = true;
        entity.UpdatedAt = DateTime.UtcNow;
        await _dbContext.SaveChangesAsync();
    }
}
