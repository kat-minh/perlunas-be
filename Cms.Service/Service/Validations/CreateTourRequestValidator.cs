using FluentValidation;

namespace Cms.Service.Service.Validations;

public class CreateTourRequestValidator : AbstractValidator<Request.CreateTourRequest>
{
    public CreateTourRequestValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("TITLE_REQUIRED");
        // Thời lượng giờ là chuỗi tự do (DurationText) → KHÔNG bắt buộc Day/Night > 0.
        RuleFor(x => x.Album).NotEmpty().WithMessage("ALBUM_REQUIRED");
        RuleFor(x => x.Region).NotEmpty().WithMessage("REGION_REQUIRED");
        RuleFor(x => x.Description).NotEmpty().WithMessage("DESCRIPTION_REQUIRED");
        // Bỏ bắt buộc Infor / Highlight / Code cho tour: các field này không hiển thị
        // trên trang tour (không nhập ở form nữa) — xem admin ServiceForm.
        RuleFor(x => x.Schedules).NotEmpty().WithMessage("SCHEDULES_REQUIRED");
        RuleForEach(x => x.Schedules).ChildRules(s =>
        {
            s.RuleFor(x => x.Titile).NotEmpty().WithMessage("SCHEDULE_TITLE_REQUIRED");
            s.RuleFor(x => x.Description).NotEmpty().WithMessage("SCHEDULE_DESCRIPTION_REQUIRED");
        });
        RuleFor(x => x.ImportantInfors).NotEmpty().WithMessage("IMPORTANT_INFORS_REQUIRED");
        RuleForEach(x => x.ImportantInfors).ChildRules(i =>
        {
            i.RuleFor(x => x.Title).NotEmpty().WithMessage("IMPORTANT_INFOR_TITLE_REQUIRED");
            i.RuleFor(x => x.Description).NotEmpty().WithMessage("IMPORTANT_INFOR_DESCRIPTION_REQUIRED");
        });
        RuleFor(x => x.DepartureSchedules).NotEmpty().WithMessage("DEPARTURE_SCHEDULES_REQUIRED");
        RuleForEach(x => x.DepartureSchedules).ChildRules(d =>
        {
            d.RuleFor(x => x.StartTime).NotEmpty().WithMessage("DEPARTURE_START_TIME_REQUIRED");
            d.RuleFor(x => x.Code).NotEmpty().WithMessage("DEPARTURE_CODE_REQUIRED");
            d.RuleFor(x => x.Price).NotEmpty().WithMessage("DEPARTURE_PRICE_REQUIRED");
            // "Chuẩn lưu trú" (AccommodationStandards) không bắt buộc — có thể để trống.
        });
    }
}
