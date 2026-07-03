using System.Text.Json;
using System.Text.RegularExpressions;
using Cms.Repository;
using Cms.Repository.Enums;
using Cms.Service.Configurations;
using Cms.Service.Exceptions;
using Cms.Service.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using SchedResponse = Cms.Service.Schedule.Response.ScheduleResponse;
using ImpInforResponse = Cms.Service.ImportantInfor.Response.ImportantInforResponse;
using DepSchedResponse = Cms.Service.DepartureSchedule.Response.DepartureScheduleResponse;
using RoomCatResponse = Cms.Service.RoomCategory.Response.RoomCategoryResponse;

namespace Cms.Service.Service;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateTourRequest> _createTourValidator;
    private readonly IValidator<Request.CreateComboRequest> _createComboValidator;
    private readonly IValidator<Request.CreateHotelRequest> _createHotelValidator;
    private readonly IValidator<Request.UpdateServiceRequest> _updateValidator;

    public Service(AppDbContext dbContext,
        IValidator<Request.CreateTourRequest> createTourValidator,
        IValidator<Request.CreateComboRequest> createComboValidator,
        IValidator<Request.CreateHotelRequest> createHotelValidator,
        IValidator<Request.UpdateServiceRequest> updateValidator)
    {
        _dbContext = dbContext;
        _createTourValidator = createTourValidator;
        _createComboValidator = createComboValidator;
        _createHotelValidator = createHotelValidator;
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
        var entities = await query
            .Include(x => x.DepartureSchedules)
            .Include(x => x.RoomCategories)
            .OrderByDescending(x => x.CreatedAt)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        var items = entities.Select(ToListItemResponse).ToList();

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
        var entities = await query
            .Include(x => x.DepartureSchedules)
            .Include(x => x.RoomCategories)
            .OrderByDescending(x => x.CreatedAt)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        var items = entities.Select(ToListItemResponse).ToList();

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

        if (!string.IsNullOrWhiteSpace(classify))
        {
            var cls = classify.Trim().ToLower();
            query = query.Where(x => x.Classify != null && x.Classify.ToLower() == cls);
        }

        if (!string.IsNullOrWhiteSpace(purposeOfTrip))
        {
            var pot = purposeOfTrip.Trim().ToLower();
            query = query.Where(x => x.PurposeOfTrip != null && x.PurposeOfTrip.ToLower().Contains(pot));
        }

        var totalCount = await query.CountAsync();
        var entities = await query
            .Include(x => x.DepartureSchedules)
            .Include(x => x.RoomCategories)
            .OrderByDescending(x => x.CreatedAt)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        var items = entities.Select(ToListItemResponse).ToList();

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

        if (!string.IsNullOrWhiteSpace(purposeOfTrip))
        {
            var pot = purposeOfTrip.Trim().ToLower();
            query = query.Where(x => x.PurposeOfTrip != null && x.PurposeOfTrip.ToLower().Contains(pot));
        }

        var totalCount = await query.CountAsync();
        var entities = await query
            .Include(x => x.DepartureSchedules)
            .Include(x => x.RoomCategories)
            .OrderByDescending(x => x.CreatedAt)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        var items = entities.Select(ToListItemResponse).ToList();

        return ApiResponseFactory.BasePagination(items, pageIndex, pageSize, totalCount);
    }

    public async Task<Response.ServiceResponse> GetByKeyAsync(string key)
    {
        var normalizedKey = key.Trim();
        var idMatched = Guid.TryParse(normalizedKey, out var id);
        var slug = normalizedKey.ToLower();

        var service = await _dbContext.Services
            .AsNoTracking()
            .Include(x => x.Schedules)
            .Include(x => x.ImportantInfors)
            .Include(x => x.DepartureSchedules)
            .Include(x => x.RoomCategories)
            .FirstOrDefaultAsync(x => !x.IsDeleted && (idMatched ? x.Id == id : x.Slug.ToLower() == slug));

        if (service is null) throw new NotFoundException("Service not found.");

        var response = ToResponse(service);

        if (service.Type == ServiceType.Tour)
        {
            // 1. Find related tours (max 3)
            var currentTourPrice = service.DepartureSchedules
                .Where(d => !d.IsDeleted && !string.IsNullOrEmpty(d.Price))
                .Select(d => ParseNumericPrice(d.Price))
                .Where(p => p > 0)
                .DefaultIfEmpty(0)
                .Min();

            var otherTours = await _dbContext.Services
                .AsNoTracking()
                .Include(x => x.DepartureSchedules)
                .Where(x => !x.IsDeleted && x.IsPublic && x.Type == ServiceType.Tour && x.Id != service.Id)
                .ToListAsync();

            var targetRegion = service.Region?.Trim().ToLower();

            var sameRegionTours = otherTours
                .Where(x => !string.IsNullOrEmpty(x.Region) && !string.IsNullOrEmpty(targetRegion) && x.Region.Trim().ToLower() == targetRegion)
                .OrderByDescending(x => x.CreatedAt)
                .ToList();

            var selectedTours = sameRegionTours.Take(3).ToList();

            if (selectedTours.Count < 3)
            {
                var needed = 3 - selectedTours.Count;
                var differentRegionTours = otherTours
                    .Where(x => string.IsNullOrEmpty(x.Region) || string.IsNullOrEmpty(targetRegion) || x.Region.Trim().ToLower() != targetRegion)
                    .Select(x => {
                        var price = x.DepartureSchedules
                            .Where(d => !d.IsDeleted && !string.IsNullOrEmpty(d.Price))
                            .Select(d => ParseNumericPrice(d.Price))
                            .Where(p => p > 0)
                            .DefaultIfEmpty(0)
                            .Min();
                        return new { Tour = x, PriceDiff = Math.Abs(price - currentTourPrice) };
                    })
                    .OrderBy(x => x.PriceDiff)
                    .ThenByDescending(x => x.Tour.CreatedAt)
                    .Select(x => x.Tour)
                    .Take(needed)
                    .ToList();

                selectedTours.AddRange(differentRegionTours);
            }

            response.RelatedTours = selectedTours.Select(t => ToResponse(t)).ToList();

            // 2. Find related hotels (max 3) based on region/location
            if (!string.IsNullOrWhiteSpace(service.Region))
            {
                var relatedHotels = await _dbContext.Services
                    .AsNoTracking()
                    .Include(x => x.RoomCategories)
                    .Where(x => !x.IsDeleted && x.IsPublic && x.Type == ServiceType.Hotel && x.Region != null && x.Region.Trim().ToLower() == targetRegion)
                    .OrderByDescending(x => x.CreatedAt)
                    .Take(3)
                    .ToListAsync();

                response.RelatedHotels = relatedHotels.Select(h => ToResponse(h)).ToList();
            }
            else
            {
                response.RelatedHotels = new List<Response.ServiceResponse>();
            }
        }
        else if (service.Type == ServiceType.Hotel)
        {
            // Khách sạn liên quan: cùng "nơi đến" (Destination), tối đa 3, loại chính nó.
            var targetDest = service.Destination?.Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(targetDest))
            {
                var relatedHotels = await _dbContext.Services
                    .AsNoTracking()
                    .Include(x => x.RoomCategories)
                    .Where(x => !x.IsDeleted && x.IsPublic && x.Type == ServiceType.Hotel && x.Id != service.Id
                        && x.Destination != null && x.Destination.Trim().ToLower() == targetDest)
                    .OrderByDescending(x => x.CreatedAt)
                    .Take(3)
                    .ToListAsync();

                response.RelatedHotels = relatedHotels.Select(h => ToResponse(h)).ToList();
            }
            else
            {
                response.RelatedHotels = new List<Response.ServiceResponse>();
            }
        }

        return response;
    }

    private static decimal ParseNumericPrice(string? priceStr)
    {
        if (string.IsNullOrWhiteSpace(priceStr)) return 0;
        var digits = Regex.Replace(priceStr, @"[^\d]", "");
        if (decimal.TryParse(digits, out var val)) return val;
        return 0;
    }

    public async Task<Response.ServiceResponse> CreateTourAsync(Request.CreateTourRequest request)
    {
        await _createTourValidator.ValidateAndThrowAsync(request);

        var now = DateTime.UtcNow;
        var serviceId = Guid.NewGuid();
        var service = new Repository.Entities.Service
        {
            Id = serviceId,
            Title = request.Title.Trim(),
            Slug = Slug.GenerateSlug(request.Title),
            BestSeller = request.BestSeller,
            Type = ServiceType.Tour,
            Day = request.Day,
            Night = request.Night,
            DurationText = string.IsNullOrWhiteSpace(request.DurationText) ? null : request.DurationText.Trim(),
            Album = JsonSerializer.Serialize(request.Album),
            Region = request.Region.Trim(),
            Description = request.Description.Trim(),
            Infor = request.Infor.Trim(),
            Highlight = request.Highlight.Select(h => h.Trim()).ToList(),
            Destinations = request.Destinations.Select(d => d.Trim()).ToList(),
            HighlightContent = request.HighlightContent.Trim(),
            TripInfoJson = string.IsNullOrWhiteSpace(request.TripInfoJson) ? null : request.TripInfoJson.Trim(),
            PriceUnit = string.IsNullOrWhiteSpace(request.PriceUnit) ? null : request.PriceUnit.Trim(),
            Code = request.Code.Trim(),
            IsPublic = request.IsPublic,
            CreatedAt = now,
            UpdatedAt = now,
        };
        _dbContext.Services.Add(service);

        var schedules = request.Schedules.Select(s => new Repository.Entities.Schedule
        {
            Id = Guid.NewGuid(),
            ServiceId = serviceId,
            Day = s.Day.Trim(),
            Titile = s.Titile.Trim(),
            Sumary = s.Sumary.Trim(),
            Description = s.Description.Trim(),
            CreatedAt = now,
            UpdatedAt = now,
        }).ToList();
        _dbContext.Schedules.AddRange(schedules);

        var importantInfors = request.ImportantInfors.Select(i => new Repository.Entities.ImportantInfor
        {
            Id = Guid.NewGuid(),
            ServiceId = serviceId,
            Title = i.Title.Trim(),
            SubTitle = i.SubTitle.Trim(),
            Description = i.Description.Trim(),
            CreatedAt = now,
            UpdatedAt = now,
        }).ToList();
        _dbContext.ImportantInfors.AddRange(importantInfors);

        var departureSchedules = request.DepartureSchedules.Select(d => new Repository.Entities.DepartureSchedule
        {
            Id = Guid.NewGuid(),
            ServiceId = serviceId,
            StartTime = d.StartTime.Trim(),
            Code = d.Code.Trim(),
            Price = d.Price.Trim(),
            OriginalPrice = string.IsNullOrWhiteSpace(d.OriginalPrice) ? null : d.OriginalPrice.Trim(),
            AccommodationStandards = d.AccommodationStandards.Trim(),
            CreatedAt = now,
            UpdatedAt = now,
        }).ToList();
        _dbContext.DepartureSchedules.AddRange(departureSchedules);

        await _dbContext.SaveChangesAsync();

        var response = ToResponse(service);
        response.Schedules = schedules.Select(s => new SchedResponse
        {
            Id = s.Id,
            ServiceId = s.ServiceId,
            Day = s.Day ?? string.Empty,
            Titile = s.Titile ?? string.Empty,
            Sumary = s.Sumary ?? string.Empty,
            Description = s.Description ?? string.Empty,
            CreatedAt = s.CreatedAt,
            UpdatedAt = s.UpdatedAt,
        }).ToList();
        response.ImportantInfors = importantInfors.Select(i => new ImpInforResponse
        {
            Id = i.Id,
            ServiceId = i.ServiceId,
            Title = i.Title ?? string.Empty,
            SubTitle = i.SubTitle ?? string.Empty,
            Description = i.Description ?? string.Empty,
            CreatedAt = i.CreatedAt,
            UpdatedAt = i.UpdatedAt,
        }).ToList();
        response.DepartureSchedules = departureSchedules.Select(d => new DepSchedResponse
        {
            Id = d.Id,
            ServiceId = d.ServiceId,
            StartTime = d.StartTime ?? string.Empty,
            Code = d.Code ?? string.Empty,
            Price = d.Price ?? string.Empty,
            OriginalPrice = d.OriginalPrice ?? string.Empty,
            AccommodationStandards = d.AccommodationStandards ?? string.Empty,
            CreatedAt = d.CreatedAt,
            UpdatedAt = d.UpdatedAt,
        }).ToList();
        return response;
    }

    public async Task<Response.ServiceResponse> CreateComboAsync(Request.CreateComboRequest request)
    {
        await _createComboValidator.ValidateAndThrowAsync(request);

        var now = DateTime.UtcNow;
        var serviceId = Guid.NewGuid();
        var service = new Repository.Entities.Service
        {
            Id = serviceId,
            Title = request.Title.Trim(),
            Slug = Slug.GenerateSlug(request.Title),
            BestSeller = request.BestSeller,
            Type = ServiceType.Combo,
            Day = request.Day > 0 ? request.Day : (int?)null,
            Night = request.Night,
            DurationText = string.IsNullOrWhiteSpace(request.DurationText) ? null : request.DurationText.Trim(),
            Label = request.Label.Trim(),
            Album = JsonSerializer.Serialize(request.Album),
            Region = request.Region.Trim(),
            Description = request.Description.Trim(),
            Infor = request.Infor.Trim(),
            Highlight = request.Highlight.Select(h => h.Trim()).ToList(),
            HighlightContent = string.IsNullOrWhiteSpace(request.HighlightContent) ? null : request.HighlightContent.Trim(),
            Code = request.Code.Trim(),
            PurposeOfTrip = request.PurposeOfTrip.Trim(),
            Destination = request.Destination.Trim(),
            Form = request.Form.Trim(),
            Classify = request.Classify.Trim(),
            TripInfoJson = string.IsNullOrWhiteSpace(request.TripInfoJson) ? null : request.TripInfoJson.Trim(),
            PriceUnit = string.IsNullOrWhiteSpace(request.PriceUnit) ? null : request.PriceUnit.Trim(),
            // Combo: giá bán theo GÓI ở cấp dịch vụ (không ở hạng phòng).
            Price = string.IsNullOrWhiteSpace(request.Price) ? null : request.Price.Trim(),
            OriginalPrice = string.IsNullOrWhiteSpace(request.OriginalPrice) ? null : request.OriginalPrice.Trim(),
            IsPublic = request.IsPublic,
            CreatedAt = now,
            UpdatedAt = now,
        };
        _dbContext.Services.Add(service);

        var schedules = request.Schedules.Select(s => new Repository.Entities.Schedule
        {
            Id = Guid.NewGuid(),
            ServiceId = serviceId,
            Day = s.Day.Trim(),
            Titile = s.Titile.Trim(),
            Sumary = s.Sumary.Trim(),
            Description = s.Description.Trim(),
            CreatedAt = now,
            UpdatedAt = now,
        }).ToList();
        _dbContext.Schedules.AddRange(schedules);

        var importantInfors = request.ImportantInfors.Select(i => new Repository.Entities.ImportantInfor
        {
            Id = Guid.NewGuid(),
            ServiceId = serviceId,
            Title = i.Title.Trim(),
            SubTitle = i.SubTitle.Trim(),
            Description = i.Description.Trim(),
            CreatedAt = now,
            UpdatedAt = now,
        }).ToList();
        _dbContext.ImportantInfors.AddRange(importantInfors);

        var roomCategories = request.RoomCategories.Select(r => new Repository.Entities.RoomCategory
        {
            Id = Guid.NewGuid(),
            ServiceId = serviceId,
            Album = JsonSerializer.Serialize(r.Album),
            Titile = r.Titile.Trim(),
            NumberOfCustomer = r.NumberOfCustomer,
            Acreage = r.Acreage.Trim(),
            NumberOfBed = r.NumberOfBed.Trim(),
            Description = r.Description.Trim(),
            Feature = JsonSerializer.Serialize(r.Feature),
            // Combo: hạng phòng CHỈ mô tả (không giá) — giá nằm ở cấp gói (service.Price).
            Price = null,
            OriginalPrice = null,
            Unit = null,
            CreatedAt = now,
            UpdatedAt = now,
        }).ToList();
        _dbContext.RoomCategories.AddRange(roomCategories);

        await _dbContext.SaveChangesAsync();

        var response = ToResponse(service);
        response.Schedules = schedules.Select(s => new SchedResponse
        {
            Id = s.Id,
            ServiceId = s.ServiceId,
            Day = s.Day ?? string.Empty,
            Titile = s.Titile ?? string.Empty,
            Sumary = s.Sumary ?? string.Empty,
            Description = s.Description ?? string.Empty,
            CreatedAt = s.CreatedAt,
            UpdatedAt = s.UpdatedAt,
        }).ToList();
        response.ImportantInfors = importantInfors.Select(i => new ImpInforResponse
        {
            Id = i.Id,
            ServiceId = i.ServiceId,
            Title = i.Title ?? string.Empty,
            SubTitle = i.SubTitle ?? string.Empty,
            Description = i.Description ?? string.Empty,
            CreatedAt = i.CreatedAt,
            UpdatedAt = i.UpdatedAt,
        }).ToList();
        response.RoomCategories = roomCategories.Select(r => new RoomCatResponse
        {
            Id = r.Id,
            ServiceId = r.ServiceId,
            Album = DeserializeAlbum(r.Album),
            Titile = r.Titile ?? string.Empty,
            NumberOfCustomer = r.NumberOfCustomer ?? 0,
            Acreage = r.Acreage ?? string.Empty,
            NumberOfBed = r.NumberOfBed ?? string.Empty,
            Description = r.Description ?? string.Empty,
            Feature = DeserializeFeature(r.Feature),
            Price = r.Price,
            OriginalPrice = r.OriginalPrice,
            Unit = r.Unit,
            CreatedAt = r.CreatedAt,
            UpdatedAt = r.UpdatedAt,
        }).ToList();
        return response;
    }

    public async Task<Response.ServiceResponse> CreateHotelAsync(Request.CreateHotelRequest request)
    {
        await _createHotelValidator.ValidateAndThrowAsync(request);

        var now = DateTime.UtcNow;
        var service = new Repository.Entities.Service
        {
            Id = Guid.NewGuid(),
            Title = request.Title.Trim(),
            Slug = Slug.GenerateSlug(request.Title),
            BestSeller = request.BestSeller,
            Type = ServiceType.Hotel,
            Introducetion = request.Introducetion.Trim(),
            Album = JsonSerializer.Serialize(request.Album),
            Region = request.Region.Trim(),
            Instruct = request.Instruct.Trim(),
            Feature = request.Feature.Trim(),
            Facilities = request.Facilities.Select(f => f.Trim()).ToList(),
            PurposeOfTrip = request.PurposeOfTrip.Trim(),
            Destination = request.Destination.Trim(),
            Form = request.Form.Trim(),
            IsPublic = request.IsPublic,
            CreatedAt = now,
            UpdatedAt = now,
        };

        _dbContext.Services.Add(service);

        var roomCategories = request.RoomCategories.Select(r => new Repository.Entities.RoomCategory
        {
            Id = Guid.NewGuid(),
            ServiceId = service.Id,
            Album = JsonSerializer.Serialize(r.Album),
            Titile = r.Titile.Trim(),
            NumberOfCustomer = r.NumberOfCustomer,
            Acreage = r.Acreage.Trim(),
            NumberOfBed = r.NumberOfBed.Trim(),
            Description = r.Description.Trim(),
            Feature = JsonSerializer.Serialize(r.Feature),
            Price = r.Price?.Trim(),
            OriginalPrice = r.OriginalPrice?.Trim(),
            Unit = r.Unit?.Trim(),
            CreatedAt = now,
            UpdatedAt = now,
        }).ToList();
        _dbContext.RoomCategories.AddRange(roomCategories);

        await _dbContext.SaveChangesAsync();

        var response = ToResponse(service);
        response.RoomCategories = roomCategories.Select(r => new RoomCatResponse
        {
            Id = r.Id,
            ServiceId = r.ServiceId,
            Album = DeserializeAlbum(r.Album),
            Titile = r.Titile ?? string.Empty,
            NumberOfCustomer = r.NumberOfCustomer ?? 0,
            Acreage = r.Acreage ?? string.Empty,
            NumberOfBed = r.NumberOfBed ?? string.Empty,
            Description = r.Description ?? string.Empty,
            Feature = DeserializeFeature(r.Feature),
            Price = r.Price,
            OriginalPrice = r.OriginalPrice,
            Unit = r.Unit,
            CreatedAt = r.CreatedAt,
            UpdatedAt = r.UpdatedAt,
        }).ToList();
        return response;
    }

    public async Task<Response.ServiceResponse> UpdateAsync(Guid id, Request.UpdateServiceRequest request)
    {
        await _updateValidator.ValidateAndThrowAsync(request);

        var service = await _dbContext.Services.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (service is null) throw new NotFoundException("Service not found.");

        var now = DateTime.UtcNow;
        var type = request.Type!.Value;

        service.Title = request.Title!.Trim();
        // GIỮ NGUYÊN slug khi sửa (slug chỉ sinh 1 lần lúc tạo) — đổi title không
        // đổi URL, tránh vỡ link/bookmark/ISR đã build.
        service.Album = JsonSerializer.Serialize(request.Album!);
        service.Region = request.Region!.Trim();
        service.IsPublic = request.IsPublic ?? service.IsPublic;
        if (request.BestSeller.HasValue)
        {
            service.BestSeller = request.BestSeller.Value;
        }

        service.Type = type;
        ApplyTypeFields(service, type, request);

        if (request.Schedules is not null && (type == ServiceType.Tour || type == ServiceType.Combo))
        {
            var oldSchedules = await _dbContext.Schedules
                .Where(x => x.ServiceId == id && !x.IsDeleted).ToListAsync();
            foreach (var s in oldSchedules) { s.IsDeleted = true; s.UpdatedAt = now; }

            _dbContext.Schedules.AddRange(request.Schedules.Select(s => new Repository.Entities.Schedule
            {
                Id = Guid.NewGuid(), ServiceId = id,
                Day = s.Day.Trim(), Titile = s.Titile.Trim(),
                Sumary = s.Sumary.Trim(), Description = s.Description.Trim(),
                CreatedAt = now, UpdatedAt = now,
            }));
        }

        if (request.ImportantInfors is not null && (type == ServiceType.Tour || type == ServiceType.Combo))
        {
            var oldInfors = await _dbContext.ImportantInfors
                .Where(x => x.ServiceId == id && !x.IsDeleted).ToListAsync();
            foreach (var i in oldInfors) { i.IsDeleted = true; i.UpdatedAt = now; }

            _dbContext.ImportantInfors.AddRange(request.ImportantInfors.Select(i => new Repository.Entities.ImportantInfor
            {
                Id = Guid.NewGuid(), ServiceId = id,
                Title = i.Title.Trim(), SubTitle = i.SubTitle.Trim(),
                Description = i.Description.Trim(), CreatedAt = now, UpdatedAt = now,
            }));
        }

        if (request.DepartureSchedules is not null && type == ServiceType.Tour)
        {
            var oldDepScheds = await _dbContext.DepartureSchedules
                .Where(x => x.ServiceId == id && !x.IsDeleted).ToListAsync();
            foreach (var d in oldDepScheds) { d.IsDeleted = true; d.UpdatedAt = now; }

            _dbContext.DepartureSchedules.AddRange(request.DepartureSchedules.Select(d => new Repository.Entities.DepartureSchedule
            {
                Id = Guid.NewGuid(), ServiceId = id,
                StartTime = d.StartTime.Trim(), Code = d.Code.Trim(),
                Price = d.Price.Trim(),
                OriginalPrice = string.IsNullOrWhiteSpace(d.OriginalPrice) ? null : d.OriginalPrice.Trim(),
                AccommodationStandards = d.AccommodationStandards.Trim(),
                CreatedAt = now, UpdatedAt = now,
            }));
        }

        if (request.RoomCategories is not null && (type == ServiceType.Combo || type == ServiceType.Hotel))
        {
            var oldRoomCats = await _dbContext.RoomCategories
                .Where(x => x.ServiceId == id && !x.IsDeleted).ToListAsync();
            foreach (var r in oldRoomCats) { r.IsDeleted = true; r.UpdatedAt = now; }

            _dbContext.RoomCategories.AddRange(request.RoomCategories.Select(r => new Repository.Entities.RoomCategory
            {
                Id = Guid.NewGuid(), ServiceId = id,
                Album = JsonSerializer.Serialize(r.Album),
                Titile = r.Titile.Trim(), NumberOfCustomer = r.NumberOfCustomer,
                Acreage = r.Acreage.Trim(), NumberOfBed = r.NumberOfBed.Trim(),
                Description = r.Description.Trim(), Feature = JsonSerializer.Serialize(r.Feature),
                // Combo: hạng phòng không mang giá (giá ở cấp gói); khách sạn thì giữ giá phòng.
                Price = type == ServiceType.Combo ? null : r.Price?.Trim(),
                OriginalPrice = type == ServiceType.Combo ? null : r.OriginalPrice?.Trim(),
                Unit = type == ServiceType.Combo ? null : r.Unit?.Trim(),
                CreatedAt = now, UpdatedAt = now,
            }));
        }

        service.UpdatedAt = now;
        await _dbContext.SaveChangesAsync();

        var response = ToResponse(service);
        response.Schedules = (await _dbContext.Schedules
            .AsNoTracking()
            .Where(x => x.ServiceId == id && !x.IsDeleted)
            .ToListAsync())
            .Select(s => new SchedResponse
            {
                Id = s.Id, ServiceId = s.ServiceId, Day = s.Day ?? string.Empty,
                Titile = s.Titile ?? string.Empty, Sumary = s.Sumary ?? string.Empty,
                Description = s.Description ?? string.Empty, CreatedAt = s.CreatedAt, UpdatedAt = s.UpdatedAt,
            }).ToList();
        response.ImportantInfors = (await _dbContext.ImportantInfors
            .AsNoTracking()
            .Where(x => x.ServiceId == id && !x.IsDeleted)
            .ToListAsync())
            .Select(i => new ImpInforResponse
            {
                Id = i.Id, ServiceId = i.ServiceId, Title = i.Title ?? string.Empty,
                SubTitle = i.SubTitle ?? string.Empty, Description = i.Description ?? string.Empty,
                CreatedAt = i.CreatedAt, UpdatedAt = i.UpdatedAt,
            }).ToList();
        response.DepartureSchedules = (await _dbContext.DepartureSchedules
            .AsNoTracking()
            .Where(x => x.ServiceId == id && !x.IsDeleted)
            .ToListAsync())
            .Select(d => new DepSchedResponse
            {
                Id = d.Id, ServiceId = d.ServiceId, StartTime = d.StartTime ?? string.Empty,
                Code = d.Code ?? string.Empty, Price = d.Price ?? string.Empty,
                AccommodationStandards = d.AccommodationStandards ?? string.Empty,
                CreatedAt = d.CreatedAt, UpdatedAt = d.UpdatedAt,
            }).ToList();
        response.RoomCategories = (await _dbContext.RoomCategories
            .AsNoTracking()
            .Where(x => x.ServiceId == id && !x.IsDeleted)
            .ToListAsync())
            .Select(r => new RoomCatResponse
            {
                Id = r.Id, ServiceId = r.ServiceId,
                Album = DeserializeAlbum(r.Album),
                Titile = r.Titile ?? string.Empty, NumberOfCustomer = r.NumberOfCustomer ?? 0,
                Acreage = r.Acreage ?? string.Empty, NumberOfBed = r.NumberOfBed ?? string.Empty,
                Description = r.Description ?? string.Empty,
                Feature = DeserializeFeature(r.Feature),
                Price = r.Price, OriginalPrice = r.OriginalPrice, Unit = r.Unit,
                CreatedAt = r.CreatedAt, UpdatedAt = r.UpdatedAt,
            }).ToList();
        return response;
    }

    public async Task<string> DeleteAsync(Guid id)
    {
        var service = await _dbContext.Services.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (service is null) throw new NotFoundException("Service not found.");

        var now = DateTime.UtcNow;
        service.IsDeleted = true;
        service.UpdatedAt = now;

        foreach (var s in await _dbContext.Schedules.Where(x => x.ServiceId == id && !x.IsDeleted).ToListAsync())
        { s.IsDeleted = true; s.UpdatedAt = now; }

        foreach (var i in await _dbContext.ImportantInfors.Where(x => x.ServiceId == id && !x.IsDeleted).ToListAsync())
        { i.IsDeleted = true; i.UpdatedAt = now; }

        foreach (var r in await _dbContext.RoomCategories.Where(x => x.ServiceId == id && !x.IsDeleted).ToListAsync())
        { r.IsDeleted = true; r.UpdatedAt = now; }

        foreach (var d in await _dbContext.DepartureSchedules.Where(x => x.ServiceId == id && !x.IsDeleted).ToListAsync())
        { d.IsDeleted = true; d.UpdatedAt = now; }

        await _dbContext.SaveChangesAsync();

        return "Service deleted successfully.";
    }

    private static void ApplyTypeFields(Repository.Entities.Service service, ServiceType type,
        string? introducetion, int? day, int? night, string? label,
        string? description, string? infor, List<string>? highlight, string? code,
        string? instruct, string? feature,
        string? purposeOfTrip, string? destination, string? form, string? classify,
        List<string>? destinations, List<string>? facilities, string? highlightContent,
        string? tripInfoJson, string? priceUnit, string? price, string? originalPrice, string? durationText)
    {
        switch (type)
        {
            case ServiceType.Tour:
                service.Introducetion = null;
                service.Label = null;
                service.Instruct = null;
                service.Feature = null;
                service.PurposeOfTrip = null;
                service.Destination = null;
                service.Form = null;
                service.Classify = null;
                service.Price = null; // giá gói chỉ dành cho combo
                service.OriginalPrice = null;
                service.Facilities = new List<string>(); // tiện nghi chỉ dành cho hotel

                if (day.HasValue) service.Day = day.Value;
                if (night.HasValue) service.Night = night.Value;
                if (durationText is not null) service.DurationText = string.IsNullOrWhiteSpace(durationText) ? null : durationText.Trim();
                if (description is not null) service.Description = description.Trim();
                if (infor is not null) service.Infor = infor.Trim();
                if (highlight is not null) service.Highlight = highlight.Select(h => h.Trim()).ToList();
                if (destinations is not null) service.Destinations = destinations.Select(d => d.Trim()).ToList();
                if (highlightContent is not null) service.HighlightContent = highlightContent.Trim();
                if (tripInfoJson is not null) service.TripInfoJson = string.IsNullOrWhiteSpace(tripInfoJson) ? null : tripInfoJson.Trim();
                if (priceUnit is not null) service.PriceUnit = string.IsNullOrWhiteSpace(priceUnit) ? null : priceUnit.Trim();
                if (code is not null) service.Code = code.Trim();
                break;

            case ServiceType.Combo:
                service.Introducetion = null;
                service.Instruct = null;
                service.Feature = null;
                service.Destinations = new List<string>(); // combo không có điểm đến kiểu tour
                service.Facilities = new List<string>();
                // Day + HighlightContent: combo CÓ dùng (thời lượng "x ngày y đêm" +
                // "Điểm nổi bật") — set từ request bên dưới, KHÔNG null hoá.

                if (day.HasValue) service.Day = day.Value;
                if (night.HasValue) service.Night = night.Value;
                if (durationText is not null) service.DurationText = string.IsNullOrWhiteSpace(durationText) ? null : durationText.Trim();
                if (highlightContent is not null) service.HighlightContent = highlightContent.Trim();
                if (label is not null) service.Label = label.Trim();
                if (description is not null) service.Description = description.Trim();
                if (infor is not null) service.Infor = infor.Trim();
                if (highlight is not null) service.Highlight = highlight.Select(h => h.Trim()).ToList();
                if (code is not null) service.Code = code.Trim();
                if (purposeOfTrip is not null) service.PurposeOfTrip = purposeOfTrip.Trim();
                if (destination is not null) service.Destination = destination.Trim();
                if (form is not null) service.Form = form.Trim();
                if (classify is not null) service.Classify = classify.Trim();
                if (tripInfoJson is not null) service.TripInfoJson = string.IsNullOrWhiteSpace(tripInfoJson) ? null : tripInfoJson.Trim();
                if (priceUnit is not null) service.PriceUnit = string.IsNullOrWhiteSpace(priceUnit) ? null : priceUnit.Trim();
                // Combo: giá bán theo gói ở cấp dịch vụ (Price/OriginalPrice).
                if (price is not null) service.Price = string.IsNullOrWhiteSpace(price) ? null : price.Trim();
                if (originalPrice is not null) service.OriginalPrice = string.IsNullOrWhiteSpace(originalPrice) ? null : originalPrice.Trim();
                break;

            case ServiceType.Hotel:
                service.Day = null;
                service.Night = null;
                service.DurationText = null; // khách sạn không có thời lượng
                service.Label = null;
                service.Description = null;
                service.Infor = null;
                service.Highlight = new List<string>();
                service.Code = null;
                service.Classify = null;
                service.Destinations = new List<string>(); // điểm đến chỉ dành cho tour
                service.HighlightContent = null; // richtext điểm nổi bật chỉ dành cho tour
                service.TripInfoJson = null; // 4 ô "Thông tin chính" chỉ dành cho tour
                service.PriceUnit = null; // đơn vị giá tour chỉ dành cho tour
                service.Price = null; // giá gói chỉ dành cho combo
                service.OriginalPrice = null;

                if (introducetion is not null) service.Introducetion = introducetion.Trim();
                if (instruct is not null) service.Instruct = instruct.Trim();
                if (feature is not null) service.Feature = feature.Trim();
                if (facilities is not null) service.Facilities = facilities.Select(f => f.Trim()).ToList();
                if (purposeOfTrip is not null) service.PurposeOfTrip = purposeOfTrip.Trim();
                if (destination is not null) service.Destination = destination.Trim();
                if (form is not null) service.Form = form.Trim();
                break;
        }
    }

    private static void ApplyTypeFields(Repository.Entities.Service service, ServiceType type, Request.UpdateServiceRequest request) =>
        ApplyTypeFields(service, type, request.Introducetion, request.Day, request.Night, request.Label,
            request.Description, request.Infor, request.Highlight, request.Code,
            request.Instruct, request.Feature,
            request.PurposeOfTrip, request.Destination, request.Form, request.Classify,
            request.Destinations, request.Facilities, request.HighlightContent, request.TripInfoJson, request.PriceUnit,
            request.Price, request.OriginalPrice, request.DurationText);

    private static Response.ServiceResponse ToResponse(Repository.Entities.Service service)
    {
        var response = new Response.ServiceResponse
        {
            Id = service.Id,
            Title = service.Title ?? string.Empty,
            Slug = service.Slug ?? string.Empty,
            BestSeller = service.BestSeller,
            Introducetion = service.Introducetion ?? string.Empty,
            Day = service.Day ?? 0,
            Night = service.Night ?? 0,
            DurationText = service.DurationText ?? string.Empty,
            Label = service.Label ?? string.Empty,
            Album = DeserializeAlbum(service.Album),
            Region = service.Region ?? string.Empty,
            Description = service.Description ?? string.Empty,
            Infor = service.Infor ?? string.Empty,
            Highlight = service.Highlight ?? new(),
            Destinations = service.Destinations ?? new(),
            Facilities = service.Facilities ?? new(),
            HighlightContent = service.HighlightContent ?? string.Empty,
            TripInfoJson = service.TripInfoJson ?? string.Empty,
            PriceUnit = service.PriceUnit ?? string.Empty,
            Price = service.Price ?? string.Empty,
            OriginalPrice = service.OriginalPrice ?? string.Empty,
            PriceText = service.PriceText ?? string.Empty,
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

        if (service.Schedules != null && service.Schedules.Any())
        {
            response.Schedules = service.Schedules.Where(s => !s.IsDeleted).Select(s => new SchedResponse
            {
                Id = s.Id,
                ServiceId = s.ServiceId,
                Day = s.Day ?? string.Empty,
                Titile = s.Titile ?? string.Empty,
                Sumary = s.Sumary ?? string.Empty,
                Description = s.Description ?? string.Empty,
                CreatedAt = s.CreatedAt,
                UpdatedAt = s.UpdatedAt,
            }).ToList();
        }

        if (service.ImportantInfors != null && service.ImportantInfors.Any())
        {
            response.ImportantInfors = service.ImportantInfors.Where(i => !i.IsDeleted).Select(i => new ImpInforResponse
            {
                Id = i.Id,
                ServiceId = i.ServiceId,
                Title = i.Title ?? string.Empty,
                SubTitle = i.SubTitle ?? string.Empty,
                Description = i.Description ?? string.Empty,
                CreatedAt = i.CreatedAt,
                UpdatedAt = i.UpdatedAt,
            }).ToList();
        }

        if (service.DepartureSchedules != null && service.DepartureSchedules.Any())
        {
            response.DepartureSchedules = service.DepartureSchedules.Where(d => !d.IsDeleted).Select(d => new DepSchedResponse
            {
                Id = d.Id,
                ServiceId = d.ServiceId,
                StartTime = d.StartTime ?? string.Empty,
                Code = d.Code ?? string.Empty,
                Price = d.Price ?? string.Empty,
                OriginalPrice = d.OriginalPrice ?? string.Empty,
                AccommodationStandards = d.AccommodationStandards ?? string.Empty,
                CreatedAt = d.CreatedAt,
                UpdatedAt = d.UpdatedAt,
            }).ToList();
        }

        if (service.RoomCategories != null && service.RoomCategories.Any())
        {
            response.RoomCategories = service.RoomCategories.Where(r => !r.IsDeleted).Select(r => new RoomCatResponse
            {
                Id = r.Id,
                ServiceId = r.ServiceId,
                Album = DeserializeAlbum(r.Album),
                Titile = r.Titile ?? string.Empty,
                NumberOfCustomer = r.NumberOfCustomer ?? 0,
                Acreage = r.Acreage ?? string.Empty,
                NumberOfBed = r.NumberOfBed ?? string.Empty,
                Description = r.Description ?? string.Empty,
                Feature = DeserializeFeature(r.Feature),
                Price = r.Price,
                OriginalPrice = r.OriginalPrice,
                Unit = r.Unit,
                CreatedAt = r.CreatedAt,
                UpdatedAt = r.UpdatedAt,
            }).ToList();
        }

        response.PriceFrom = ComputePriceFrom(service);

        return response;
    }

    /// <summary>
    /// Giá "từ" = giá thấp nhất > 0 gộp từ lịch khởi hành (tour) và hạng phòng
    /// (khách sạn/combo). Combo có hạng phòng chỉ có OriginalPrice (Price = null)
    /// nên fallback sang OriginalPrice khi không có Price nào hợp lệ.
    /// </summary>
    private static decimal? ComputePriceFrom(Repository.Entities.Service service)
    {
        // Combo: giá bán theo GÓI ở cấp dịch vụ (không gộp từ hạng phòng nữa).
        if (service.Type == ServiceType.Combo)
        {
            var comboPrice = ParseNumericPrice(service.Price);
            if (comboPrice > 0) return comboPrice;
            var comboOrig = ParseNumericPrice(service.OriginalPrice);
            return comboOrig > 0 ? comboOrig : (decimal?)null;
        }

        var prices = new List<decimal>();

        if (service.DepartureSchedules != null)
            prices.AddRange(service.DepartureSchedules
                .Where(d => !d.IsDeleted)
                .Select(d => ParseNumericPrice(d.Price)));

        if (service.RoomCategories != null)
            prices.AddRange(service.RoomCategories
                .Where(r => !r.IsDeleted)
                .Select(r => ParseNumericPrice(r.Price)));

        var positive = prices.Where(p => p > 0).ToList();

        if (positive.Count == 0 && service.RoomCategories != null)
            positive = service.RoomCategories
                .Where(r => !r.IsDeleted)
                .Select(r => ParseNumericPrice(r.OriginalPrice))
                .Where(p => p > 0)
                .ToList();

        return positive.Count > 0 ? positive.Min() : (decimal?)null;
    }

    /// <summary>
    /// Map cho THẺ LIST: giữ PriceFrom (đã tính trong ToResponse) nhưng bỏ các
    /// bảng con nặng (lịch trình/hạng phòng/lịch khởi hành) mà thẻ list không cần.
    /// </summary>
    private static Response.ServiceResponse ToListItemResponse(Repository.Entities.Service service)
    {
        var response = ToResponse(service);
        response.Schedules = new();
        response.ImportantInfors = new();
        response.DepartureSchedules = new();
        response.RoomCategories = new();
        return response;
    }

    private static List<string> DeserializeAlbum(string? album)
    {
        if (string.IsNullOrWhiteSpace(album)) return new();
        try { return JsonSerializer.Deserialize<List<string>>(album) ?? new(); }
        catch { return new(); }
    }

    private static List<string> DeserializeFeature(string? feature)
    {
        if (string.IsNullOrWhiteSpace(feature)) return new();
        try { return JsonSerializer.Deserialize<List<string>>(feature) ?? new(); }
        catch { return new(); }
    }
}
