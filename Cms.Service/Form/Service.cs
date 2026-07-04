using Cms.Repository;
using Cms.Repository.Enums;
using Cms.Service.Exceptions;
using Cms.Service.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using ServiceResponseDto = Cms.Service.Service.Response.ServiceResponse;

namespace Cms.Service.Form;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly IValidator<Request.CreateAdviseFormRequest> _createAdviseValidator;
    private readonly IValidator<Request.CreateTourFormRequest> _createTourValidator;
    private readonly IValidator<Request.CreateBookingFormRequest> _createBookingValidator;
    private readonly MailService.IService _mailService;

    public Service(AppDbContext dbContext,
        IValidator<Request.CreateAdviseFormRequest> createAdviseValidator,
        IValidator<Request.CreateTourFormRequest> createTourValidator,
        IValidator<Request.CreateBookingFormRequest> createBookingValidator,
        MailService.IService mailService)
    {
        _dbContext = dbContext;
        _createAdviseValidator = createAdviseValidator;
        _createTourValidator = createTourValidator;
        _createBookingValidator = createBookingValidator;
        _mailService = mailService;
    }

    public async Task<string> CreateAdviseAsync(Request.CreateAdviseFormRequest request)
    {
        await _createAdviseValidator.ValidateAndThrowAsync(request);

        var serviceExists = await _dbContext.Services.AnyAsync(x => x.Id == request.ServiceId);
        if (!serviceExists) throw new NotFoundException("Service not found.");

        var now = DateTime.UtcNow;
        var form = new Repository.Entities.Form
        {
            Id = Guid.NewGuid(),
            Type = FormType.Advise,
            Where = request.Where,
            Slug = request.Slug,
            Month = request.Month,
            Year = request.Year,
            LongTime = request.LongTime,
            ComboService = request.ComboService,
            Note = request.Note,
            FullName = request.FullName,
            Phone = request.Phone,
            Email = request.Email,
            Website = request.Website,
            ContactName = request.ContactName,
            PromotionalInformation = request.PromotionalInformation,
            ServiceId = request.ServiceId,
            CreatedAt = now
        };

        _dbContext.Forms.Add(form);
        await _dbContext.SaveChangesAsync();

        await _mailService.SendMail(new MailService.MailContent
        {
            To = request.Email,
            Subject = "Xác nhận đăng ký tư vấn thành công",
            Body = $@"
                <!DOCTYPE html>
                <html lang=""vi"">
                <head><meta charset=""UTF-8""></head>
                <body style=""font-family: Arial, sans-serif; padding: 20px;"">
                    <h2>Cảm ơn bạn đã đăng ký tư vấn!</h2>
                    <p>Chào {request.FullName},</p>
                    <p>Chúng tôi đã nhận được yêu cầu tư vấn của bạn. Thông tin chi tiết:</p>
                    <ul>
                        <li><strong>Họ tên:</strong> {request.FullName}</li>
                        <li><strong>Số điện thoại:</strong> {request.Phone}</li>
                        <li><strong>Email:</strong> {request.Email}</li>
                        <li><strong>Địa điểm:</strong> {request.Where}</li>
                        <li><strong>Thời gian:</strong> {request.Month}/{request.Year}</li>
                    </ul>
                    <p>Chúng tôi sẽ liên hệ với bạn trong thời gian sớm nhất.</p>
                    <p>Trân trọng,<br>Đội ngũ hỗ trợ khách hàng</p>
                </body>
                </html>"
        });

        return "CREATE_ADVISE_FORM_SUCCESS";
    }

    public async Task<string> CreateTourAsync(Request.CreateTourFormRequest request)
    {
        await _createTourValidator.ValidateAndThrowAsync(request);

        var serviceExists = await _dbContext.Services.AnyAsync(x => x.Id == request.ServiceId);
        if (!serviceExists) throw new NotFoundException("Service not found.");

        var now = DateTime.UtcNow;
        var form = new Repository.Entities.Form
        {
            Id = Guid.NewGuid(),
            Type = FormType.Tour,
            Note = request.Note,
            FullName = request.FullName,
            Phone = request.Phone,
            Email = request.Email,
            ServiceId = request.ServiceId,
            CreatedAt = now
        };

        _dbContext.Forms.Add(form);
        await _dbContext.SaveChangesAsync();

        return "CREATE_TOUR_FORM_SUCCESS";
    }

    public async Task<string> CreateComboAsync(Request.CreateBookingFormRequest request)
    {
        await _createBookingValidator.ValidateAndThrowAsync(request);

        var service = await _dbContext.Services
            .FirstOrDefaultAsync(x => x.Id == request.ServiceId);
        if (service is null) throw new NotFoundException("Service not found.");
        if (service.Type != ServiceType.Combo)
            throw new BadRequestException("SERVICE_MUST_BE_COMBO_TYPE");

        var validRoomCategoryTitles = await _dbContext.RoomCategories
            .Where(x => x.ServiceId == request.ServiceId)
            .Select(x => x.Titile)
            .ToListAsync();

        foreach (var detail in request.FormDetails)
        {
            var invalidTitles = detail.RoomCategory
                .Where(rc => !validRoomCategoryTitles.Contains(rc))
                .ToList();
            if (invalidTitles.Any())
                throw new BadRequestException($"INVALID_ROOM_CATEGORY: {string.Join(", ", invalidTitles)}");
        }

        var now = DateTime.UtcNow;
        var formId = Guid.NewGuid();
        var form = new Repository.Entities.Form
        {
            Id = formId,
            Type = FormType.Combo,
            FullName = request.FullName,
            Phone = request.Phone,
            Email = request.Email,
            TotalPrice = request.TotalPrice,
            ServiceId = request.ServiceId,
            CreatedAt = now
        };

        form.FormDetails = request.FormDetails.Select(d => new Repository.Entities.FormDetails
        {
            Id = Guid.NewGuid(),
            RoomCategory = d.RoomCategory,
            NumberOfRooms = d.NumberOfRooms,
            ReceiveTime = d.ReceiveTime,
            EndTime = d.EndTime,
            Adults = d.Adults,
            Children = d.Children,
            Baby = d.Baby,
            Price = d.Price,
            UnitPrice = d.UnitPrice,
            ServiceId = request.ServiceId,
            FormId = formId,
            CreatedAt = now
        }).ToList();

        _dbContext.Forms.Add(form);
        await _dbContext.SaveChangesAsync();

        return "CREATE_COMBO_FORM_SUCCESS";
    }

    public async Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize, FormType? type)
    {
        pageIndex = pageIndex <= 0 ? 1 : pageIndex;
        pageSize = pageSize <= 0 ? 10 : Math.Min(pageSize, 100);

        var query = _dbContext.Forms
            .AsNoTracking()
            .Include(x => x.Service)
            .Include(x => x.FormDetails)
            .Where(x => !x.IsDeleted);

        if (type.HasValue)
        {
            query = query.Where(x => x.Type == type.Value);
        }

        var totalCount = await query.CountAsync();
        var items = await query
            .OrderByDescending(x => x.CreatedAt)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        var responseItems = items.Select(form => (object)MapForm(form)).ToList();

        return ApiResponseFactory.BasePagination(responseItems, pageIndex, pageSize, totalCount);
    }

    public async Task<Response.FormResponse> GetByKeyAsync(string key)
    {
        var isGuid = Guid.TryParse(key, out var id);

        var form = await _dbContext.Forms
            .AsNoTracking()
            .Include(x => x.Service)
            .Include(x => x.FormDetails)
            .FirstOrDefaultAsync(x => !x.IsDeleted && ((isGuid && x.Id == id) || x.Slug == key));

        if (form is null) throw new NotFoundException("Form not found.");

        return MapForm(form);
    }

    private static Response.FormResponse MapForm(Repository.Entities.Form form)
    {
        if (form.Type == FormType.Advise)
        {
            return new Response.AdviseFormResponse
            {
                Id = form.Id,
                Type = form.Type,
                Where = form.Where,
                Slug = form.Slug,
                Month = form.Month,
                Year = form.Year,
                LongTime = form.LongTime,
                ComboService = form.ComboService,
                Note = form.Note,
                FullName = form.FullName,
                Phone = form.Phone,
                Email = form.Email,
                Website = form.Website,
                ContactName = form.ContactName,
                PromotionalInformation = form.PromotionalInformation,
                ServiceId = form.ServiceId,
                Service = MapService(form.Service),
                CreatedAt = form.CreatedAt,
                UpdatedAt = form.UpdatedAt
            };
        }
        else if (form.Type == FormType.Tour)
        {
            return new Response.TourFormResponse
            {
                Id = form.Id,
                Type = form.Type,
                Note = form.Note,
                FullName = form.FullName,
                Phone = form.Phone,
                Email = form.Email,
                ServiceId = form.ServiceId,
                Service = MapService(form.Service),
                CreatedAt = form.CreatedAt,
                UpdatedAt = form.UpdatedAt
            };
        }
        else // Combo or Hotel
        {
            return new Response.BookingFormResponse
            {
                Id = form.Id,
                Type = form.Type,
                FullName = form.FullName,
                Phone = form.Phone,
                Email = form.Email,
                TotalPrice = form.TotalPrice,
                ServiceId = form.ServiceId,
                Service = MapService(form.Service),
                FormDetails = form.FormDetails.Select(d => new Response.FormDetailsResponse
                {
                    Id = d.Id,
                    RoomCategory = d.RoomCategory,
                    NumberOfRooms = d.NumberOfRooms,
                    ReceiveTime = d.ReceiveTime,
                    EndTime = d.EndTime,
                    Adults = d.Adults,
                    Children = d.Children,
                    Baby = d.Baby,
                    Price = d.Price,
                    UnitPrice = d.UnitPrice,
                    ServiceId = d.ServiceId,
                    FormId = d.FormId,
                    CreatedAt = d.CreatedAt,
                    UpdatedAt = d.UpdatedAt
                }).ToList(),
                CreatedAt = form.CreatedAt,
                UpdatedAt = form.UpdatedAt
            };
        }
    }

    private static ServiceResponseDto? MapService(Repository.Entities.Service? service)
    {
        if (service == null) return null;
        return new ServiceResponseDto
        {
            Id = service.Id,
            Title = service.Title ?? string.Empty,
            Slug = service.Slug ?? string.Empty,
            BestSeller = service.BestSeller,
            Introducetion = service.Introducetion ?? string.Empty,
            Day = service.Day ?? 0,
            Night = service.Night ?? 0,
            Label = service.Label ?? string.Empty,
            Region = service.Region ?? string.Empty,
            Description = service.Description ?? string.Empty,
            Infor = service.Infor ?? string.Empty,
            Highlight = service.Highlight ?? new(),
            Destinations = service.Destinations ?? new(),
            Facilities = service.Facilities ?? new(),
            HighlightContent = service.HighlightContent ?? string.Empty,
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
            UpdatedAt = service.UpdatedAt
        };
    }
}
