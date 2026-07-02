using System.Text.Json;
using Cms.Repository;
using Cms.Repository.Enums;
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

    public async Task<BasePaginationResponse> GetToursAsync(string? keyword, int pageIndex, int pageSize)
    {
        pageIndex = pageIndex <= 0 ? 1 : pageIndex;
        pageSize = pageSize <= 0 ? 10 : Math.Min(pageSize, 100);

        var query = _dbContext.Services
            .AsNoTracking()
            .Where(x => !x.IsDeleted && x.Type == ServiceType.Tour);

        if (!string.IsNullOrWhiteSpace(keyword))
        {
            var kw = keyword.Trim().ToLower();
            query = query.Where(x => x.Title != null && x.Title.ToLower().Contains(kw)
                                  || x.Region != null && x.Region.ToLower().Contains(kw));
        }

        var totalCount = await query.CountAsync();
        var items = await query
            .OrderByDescending(x => x.CreatedAt)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .Select(x => ToResponse(x))
            .ToListAsync();

        return ApiResponseFactory.BasePagination(items, pageIndex, pageSize, totalCount);
    }

    public async Task<BasePaginationResponse> GetCombosAsync(string? keyword, string? destination, string? form, string? classify, string? purposeOfTrip, int pageIndex, int pageSize)
    {
        pageIndex = pageIndex <= 0 ? 1 : pageIndex;
        pageSize = pageSize <= 0 ? 10 : Math.Min(pageSize, 100);

        var query = _dbContext.Services
            .AsNoTracking()
            .Where(x => !x.IsDeleted && x.Type == ServiceType.Combo);

        if (!string.IsNullOrWhiteSpace(keyword))
        {
            var kw = keyword.Trim().ToLower();
            query = query.Where(x => x.Title != null && x.Title.ToLower().Contains(kw));
        }

        if (!string.IsNullOrWhiteSpace(destination))
            query = query.Where(x => x.Destination != null && x.Destination.ToLower().Contains(destination.Trim().ToLower()));

        if (!string.IsNullOrWhiteSpace(form))
            query = query.Where(x => x.Form != null && x.Form.ToLower().Contains(form.Trim().ToLower()));

        if (!string.IsNullOrWhiteSpace(classify) && Enum.TryParse<Classify>(classify.Trim(), ignoreCase: true, out var cls))
            query = query.Where(x => x.Classify == cls);

        if (!string.IsNullOrWhiteSpace(purposeOfTrip) && Enum.TryParse<PurposeOfTrip>(purposeOfTrip.Trim(), ignoreCase: true, out var pot))
            query = query.Where(x => x.PurposeOfTrip == pot);

        var totalCount = await query.CountAsync();
        var items = await query
            .OrderByDescending(x => x.CreatedAt)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .Select(x => ToResponse(x))
            .ToListAsync();

        return ApiResponseFactory.BasePagination(items, pageIndex, pageSize, totalCount);
    }

    public async Task<BasePaginationResponse> GetHotelsAsync(string? keyword, string? destination, string? form, string? purposeOfTrip, int pageIndex, int pageSize)
    {
        pageIndex = pageIndex <= 0 ? 1 : pageIndex;
        pageSize = pageSize <= 0 ? 10 : Math.Min(pageSize, 100);

        var query = _dbContext.Services
            .AsNoTracking()
            .Where(x => !x.IsDeleted && x.Type == ServiceType.Hotel);

        if (!string.IsNullOrWhiteSpace(keyword))
        {
            var kw = keyword.Trim().ToLower();
            query = query.Where(x => x.Title != null && x.Title.ToLower().Contains(kw));
        }

        if (!string.IsNullOrWhiteSpace(destination))
            query = query.Where(x => x.Destination != null && x.Destination.ToLower().Contains(destination.Trim().ToLower()));

        if (!string.IsNullOrWhiteSpace(form))
            query = query.Where(x => x.Form != null && x.Form.ToLower().Contains(form.Trim().ToLower()));

        if (!string.IsNullOrWhiteSpace(purposeOfTrip) && Enum.TryParse<PurposeOfTrip>(purposeOfTrip.Trim(), ignoreCase: true, out var pot))
            query = query.Where(x => x.PurposeOfTrip == pot);

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
            Type = request.Type!.Value,
            Album = JsonSerializer.Serialize(request.Album),
            Region = request.Region.Trim(),
            IsPublic = request.IsPublic,
            CreatedAt = now,
            UpdatedAt = now,
        };

        ApplyTypeFields(service, request.Type.Value, request);

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
        service.Type = request.Type!.Value;
        service.Album = JsonSerializer.Serialize(request.Album);
        service.Region = request.Region.Trim();
        service.IsPublic = request.IsPublic;
        service.UpdatedAt = DateTime.UtcNow;

        ApplyTypeFields(service, request.Type.Value, request);

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

    private static void ApplyTypeFields(Repository.Entities.Service service, ServiceType type,
        string? introducetion, int day, int night, string? label,
        string? description, string? infor, string? highlight, string? code,
        string? instruct, string? feature,
        PurposeOfTrip? purposeOfTrip, string? destination, string? form, Classify? classify)
    {
        service.Introducetion = null;
        service.Day = null;
        service.Night = null;
        service.Label = null;
        service.Description = null;
        service.Infor = null;
        service.Highlight = null;
        service.Code = null;
        service.Instruct = null;
        service.Feature = null;
        service.PurposeOfTrip = null;
        service.Destination = null;
        service.Form = null;
        service.Classify = null;

        switch (type)
        {
            case ServiceType.Tour:
                service.Day = day;
                service.Night = night;
                service.Description = description?.Trim();
                service.Infor = infor?.Trim();
                service.Highlight = highlight?.Trim();
                service.Code = code?.Trim();
                break;

            case ServiceType.Combo:
                service.Night = night;
                service.Label = label?.Trim();
                service.Description = description?.Trim();
                service.Infor = infor?.Trim();
                service.Highlight = highlight?.Trim();
                service.Code = code?.Trim();
                service.PurposeOfTrip = purposeOfTrip;
                service.Destination = destination?.Trim();
                service.Form = form?.Trim();
                service.Classify = classify;
                break;

            case ServiceType.Hotel:
                service.Introducetion = introducetion?.Trim();
                service.Instruct = instruct?.Trim();
                service.Feature = feature?.Trim();
                service.PurposeOfTrip = purposeOfTrip;
                service.Destination = destination?.Trim();
                service.Form = form?.Trim();
                break;
        }
    }

    private static void ApplyTypeFields(Repository.Entities.Service service, ServiceType type, Request.CreateServiceRequest request) =>
        ApplyTypeFields(service, type, request.Introducetion, request.Day, request.Night, request.Label,
            request.Description, request.Infor, request.Highlight, request.Code,
            request.Instruct, request.Feature,
            request.PurposeOfTrip, request.Destination, request.Form, request.Classify);

    private static void ApplyTypeFields(Repository.Entities.Service service, ServiceType type, Request.UpdateServiceRequest request) =>
        ApplyTypeFields(service, type, request.Introducetion, request.Day, request.Night, request.Label,
            request.Description, request.Infor, request.Highlight, request.Code,
            request.Instruct, request.Feature,
            request.PurposeOfTrip, request.Destination, request.Form, request.Classify);

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
            Album = DeserializeAlbum(service.Album),
            Region = service.Region ?? string.Empty,
            Description = service.Description ?? string.Empty,
            Infor = service.Infor ?? string.Empty,
            Highlight = service.Highlight ?? string.Empty,
            Code = service.Code ?? string.Empty,
            Instruct = service.Instruct ?? string.Empty,
            Feature = service.Feature ?? string.Empty,
            Type = service.Type,
            IsPublic = service.IsPublic,
            PurposeOfTrip = service.PurposeOfTrip,
            Destination = service.Destination,
            Form = service.Form,
            Classify = service.Classify,
            CreatedAt = service.CreatedAt,
            UpdatedAt = service.UpdatedAt,
        };
    }

    private static List<string> DeserializeAlbum(string? album)
    {
        if (string.IsNullOrWhiteSpace(album)) return new();
        try { return JsonSerializer.Deserialize<List<string>>(album) ?? new(); }
        catch { return new(); }
    }
}
