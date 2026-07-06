using Cms.Repository;
using Cms.Repository.Enums;
using Cms.Service.Exceptions;
using Cms.Service.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Cms.Service.Form;

public class Service : IService
{
    private const string AdminEmail = "duongbilly18012004@gmail.com";
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

        request.Phone = request.Phone.Replace(" ", "");

        var now = DateTime.UtcNow;
        var form = new Repository.Entities.Form
        {
            Id = Guid.NewGuid(),
            Type = FormType.Advise,
            Title = request.Title,
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
            PricePerPerson = request.PricePerPerson,
            CreatedAt = now
        };

        _dbContext.Forms.Add(form);
        await _dbContext.SaveChangesAsync();

        await _mailService.SendMail(new MailService.MailContent
        {
            To = request.Email,
            Subject = "Xác nhận đăng ký tư vấn thành công",
            Body = MailService.MailTemplate.Confirmation(
                heading: "Đã nhận yêu cầu tư vấn",
                fullName: request.FullName,
                intro: "Cảm ơn bạn đã gửi yêu cầu tư vấn cho Perlunas. Chúng tôi đã ghi nhận các thông tin sau:",
                rows: new (string, string?)[]
                {
                    ("Họ tên", request.FullName),
                    ("Số điện thoại", request.Phone),
                    ("Email", request.Email),
                    ("Địa điểm", request.Where),
                    ("Thời gian", $"{request.Month}/{request.Year}"),
                    ("Ghi chú", request.Note),
                },
                closing: "Đội ngũ Perlunas sẽ liên hệ với bạn trong thời gian sớm nhất.")
        });

        await _mailService.SendMail(new MailService.MailContent
        {
            To = AdminEmail,
            Subject = $"[Admin] Yêu cầu tư vấn mới từ {request.FullName}",
            Body = MailService.MailTemplate.Confirmation(
                heading: "Yêu cầu tư vấn mới",
                fullName: request.FullName,
                intro: "Hệ thống ghi nhận một yêu cầu tư vấn mới với thông tin chi tiết bên dưới:",
                rows: new (string, string?)[]
                {
                    ("Họ tên", request.FullName),
                    ("Số điện thoại", request.Phone),
                    ("Email", request.Email),
                    ("Địa điểm", request.Where),
                    ("Thời gian", $"{request.Month}/{request.Year}"),
                    ("Ghi chú", request.Note),
                },
                closing: "Vui lòng liên hệ lại khách hàng sớm nhất.")
        });

        return "CREATE_ADVISE_FORM_SUCCESS";
    }

    public async Task<string> CreateTourAsync(Request.CreateTourFormRequest request)
    {
        await _createTourValidator.ValidateAndThrowAsync(request);

        request.Phone = request.Phone.Replace(" ", "");

        var service = await _dbContext.Services
            .Include(x => x.DepartureSchedules)
            .FirstOrDefaultAsync(x => x.Id == request.ServiceId);
        if (service is null) throw new NotFoundException("Service not found.");

        var activeSchedules = service.DepartureSchedules != null
            ? service.DepartureSchedules.Where(x => !x.IsDeleted).ToList()
            : new List<Repository.Entities.DepartureSchedule>();

        string? tourCode = null;
        if (activeSchedules.Any())
        {
            var matched = activeSchedules.FirstOrDefault(s =>
                (!string.IsNullOrEmpty(s.Code) && (request.Note?.Contains(s.Code) == true || request.Title?.Contains(s.Code) == true)) ||
                (!string.IsNullOrEmpty(s.StartTime) && (request.Note?.Contains(s.StartTime) == true || request.Title?.Contains(s.StartTime) == true))
            );
            tourCode = matched?.Code ?? activeSchedules.First().Code;
        }

        var now = DateTime.UtcNow;
        var form = new Repository.Entities.Form
        {
            Id = Guid.NewGuid(),
            Type = FormType.Tour,
            Title = request.Title,
            Note = request.Note,
            FullName = request.FullName,
            Phone = request.Phone,
            Email = request.Email,
            ServiceId = request.ServiceId,
            CreatedAt = now
        };

        _dbContext.Forms.Add(form);
        await _dbContext.SaveChangesAsync();

        await _mailService.SendMail(new MailService.MailContent
        {
            To = request.Email,
            Subject = "Xác nhận đăng ký tour thành công",
            Body = MailService.MailTemplate.Confirmation(
                heading: "Đã nhận đăng ký tour",
                fullName: request.FullName,
                intro: "Cảm ơn bạn đã đăng ký tour cùng Perlunas. Chúng tôi đã nhận được yêu cầu của bạn với thông tin sau:",
                rows: new (string, string?)[]
                {
                    ("Họ tên", request.FullName),
                    ("Số điện thoại", request.Phone),
                    ("Email", request.Email),
                    ("Tour", request.Title),
                    ("Chi tiết đặt", request.Note),
                },
                closing: "Đội ngũ Perlunas sẽ liên hệ với bạn trong thời gian sớm nhất để xác nhận tour.")
        });

        await _mailService.SendMail(new MailService.MailContent
        {
            To = AdminEmail,
            Subject = $"[Admin] Yêu cầu đặt tour mới từ {request.FullName}",
            Body = MailService.MailTemplate.Confirmation(
                heading: "Yêu cầu đặt tour mới",
                fullName: request.FullName,
                intro: "Hệ thống ghi nhận một yêu cầu đặt tour mới với thông tin chi tiết bên dưới:",
                rows: new (string, string?)[]
                {
                    ("Họ tên", request.FullName),
                    ("Số điện thoại", request.Phone),
                    ("Email", request.Email),
                    ("Tour", request.Title),
                    ("Mã tour", tourCode),
                    ("Chi tiết đặt", request.Note),
                },
                closing: "Vui lòng liên hệ lại khách hàng để xác nhận.")
        });

        return "CREATE_TOUR_FORM_SUCCESS";
    }

    public async Task<string> CreateComboAsync(Request.CreateBookingFormRequest request)
    {
        await _createBookingValidator.ValidateAndThrowAsync(request);

        request.Phone = request.Phone.Replace(" ", "");

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
            Title = request.Title,
            FullName = request.FullName,
            Phone = request.Phone,
            Email = request.Email,
            TotalPrice = request.TotalPrice,
            Region = request.Region,
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

        await _mailService.SendMail(new MailService.MailContent
        {
            To = request.Email,
            Subject = "Xác nhận đặt combo thành công",
            Body = MailService.MailTemplate.Confirmation(
                heading: "Đã nhận đặt combo",
                fullName: request.FullName,
                intro: "Cảm ơn bạn đã đặt gói combo cùng Perlunas. Chúng tôi đã ghi nhận yêu cầu với thông tin sau:",
                rows: new (string, string?)[]
                {
                    ("Họ tên", request.FullName),
                    ("Số điện thoại", request.Phone),
                    ("Email", request.Email),
                    ("Tổng tiền", $"{request.TotalPrice:N0} VNĐ"),
                },
                closing: "Đội ngũ Perlunas sẽ liên hệ với bạn trong thời gian sớm nhất để xác nhận.")
        });

        await _mailService.SendMail(new MailService.MailContent
        {
            To = AdminEmail,
            Subject = $"[Admin] Yêu cầu đặt combo mới từ {request.FullName}",
            Body = MailService.MailTemplate.Confirmation(
                heading: "Yêu cầu đặt combo mới",
                fullName: request.FullName,
                intro: "Hệ thống ghi nhận một yêu cầu đặt combo mới với thông tin chi tiết bên dưới:",
                rows: new (string, string?)[]
                {
                    ("Họ tên", request.FullName),
                    ("Số điện thoại", request.Phone),
                    ("Email", request.Email),
                    ("Tên combo", service.Title),
                    ("Phân loại", service.Classify),
                    ("Tổng tiền", $"{request.TotalPrice:N0} VNĐ"),
                },
                closing: "Vui lòng liên hệ lại khách hàng để xác nhận combo.")
        });

        return "CREATE_COMBO_FORM_SUCCESS";
    }

    public async Task<string> CreateHotelAsync(Request.CreateBookingFormRequest request)
    {
        await _createBookingValidator.ValidateAndThrowAsync(request);

        request.Phone = request.Phone.Replace(" ", "");

        var service = await _dbContext.Services
            .FirstOrDefaultAsync(x => x.Id == request.ServiceId);
        if (service is null) throw new NotFoundException("Service not found.");
        if (service.Type != ServiceType.Hotel)
            throw new BadRequestException("SERVICE_MUST_BE_HOTEL_TYPE");

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
            Type = FormType.Hotel,
            Title = request.Title,
            FullName = request.FullName,
            Phone = request.Phone,
            Email = request.Email,
            TotalPrice = request.TotalPrice,
            Region = request.Region,
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

        var roomCategories = string.Join(", ", request.FormDetails.SelectMany(d => d.RoomCategory ?? Enumerable.Empty<string>()).Distinct());

        await _mailService.SendMail(new MailService.MailContent
        {
            To = request.Email,
            Subject = "Xác nhận đặt phòng thành công",
            Body = MailService.MailTemplate.Confirmation(
                heading: "Đã nhận đặt phòng",
                fullName: request.FullName,
                intro: "Cảm ơn bạn đã đặt phòng qua Perlunas. Chúng tôi đã ghi nhận yêu cầu với thông tin sau:",
                rows: new (string, string?)[]
                {
                    ("Họ tên", request.FullName),
                    ("Số điện thoại", request.Phone),
                    ("Email", request.Email),
                    ("Tổng tiền", $"{request.TotalPrice:N0} VNĐ"),
                },
                closing: "Đội ngũ Perlunas sẽ liên hệ với bạn trong thời gian sớm nhất để xác nhận.")
        });

        await _mailService.SendMail(new MailService.MailContent
        {
            To = AdminEmail,
            Subject = $"[Admin] Yêu cầu đặt phòng mới từ {request.FullName}",
            Body = MailService.MailTemplate.Confirmation(
                heading: "Yêu cầu đặt phòng mới",
                fullName: request.FullName,
                intro: "Hệ thống ghi nhận một yêu cầu đặt phòng mới với thông tin chi tiết bên dưới:",
                rows: new (string, string?)[]
                {
                    ("Họ tên", request.FullName),
                    ("Số điện thoại", request.Phone),
                    ("Email", request.Email),
                    ("Tên phòng", service.Title),
                    ("Hạng phòng", roomCategories),
                    ("Tổng tiền", $"{request.TotalPrice:N0} VNĐ"),
                },
                closing: "Vui lòng liên hệ lại khách hàng để xác nhận đặt phòng.")
        });

        return "CREATE_HOTEL_FORM_SUCCESS";
    }

    public async Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize, FormType? type, string? search)
    {
        pageIndex = pageIndex <= 0 ? 1 : pageIndex;
        pageSize = pageSize <= 0 ? 10 : Math.Min(pageSize, 100);

        var query = _dbContext.Forms
            .AsNoTracking()
            .Include(x => x.FormDetails)
            .Include(x => x.Service)
            .Where(x => !x.IsDeleted);

        if (type.HasValue)
        {
            query = query.Where(x => x.Type == type.Value);
        }

        if (!string.IsNullOrWhiteSpace(search))
        {
            var s = search.Trim().ToLower();
            query = query.Where(x =>
                (x.Email != null && x.Email.ToLower().Contains(s)) ||
                (x.FullName != null && x.FullName.ToLower().Contains(s)) ||
                (x.Phone != null && x.Phone.Contains(s)));
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
            .Include(x => x.FormDetails)
            .Include(x => x.Service)
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
                Slug = form.Slug,
                Title = form.Title,
                Where = form.Where,
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
                PricePerPerson = form.PricePerPerson,
                ServiceId = form.ServiceId,
                ServiceName = form.Service != null ? form.Service.Title : null,
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
                Slug = form.Slug,
                Title = form.Title,
                Note = form.Note,
                FullName = form.FullName,
                Phone = form.Phone,
                Email = form.Email,
                ServiceId = form.ServiceId,
                ServiceName = form.Service != null ? form.Service.Title : null,
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
                Slug = form.Slug,
                Title = form.Title,
                FullName = form.FullName,
                Phone = form.Phone,
                Email = form.Email,
                TotalPrice = form.TotalPrice,
                Region = form.Region,
                ServiceId = form.ServiceId,
                ServiceName = form.Service != null ? form.Service.Title : null,
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
}
