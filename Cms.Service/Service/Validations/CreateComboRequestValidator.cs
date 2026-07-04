using Cms.Repository.Enums;
using FluentValidation;

namespace Cms.Service.Service.Validations;

public class CreateComboRequestValidator : AbstractValidator<Request.CreateComboRequest>
{
    public CreateComboRequestValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("TITLE_REQUIRED");
        // Thời lượng giờ là chuỗi tự do (DurationText) → KHÔNG bắt buộc Night > 0.
        RuleFor(x => x.Album).NotEmpty().WithMessage("ALBUM_REQUIRED");
        RuleFor(x => x.Region).NotEmpty().WithMessage("REGION_REQUIRED");
        // Bỏ bắt buộc Label / Description / Infor / Highlight / Code cho combo:
        // các field này không hiển thị trên trang combo (đã gỡ khỏi form).
        RuleFor(x => x.PurposeOfTrip).NotEmpty().WithMessage("PURPOSE_OF_TRIP_REQUIRED");
        RuleFor(x => x.Destination).NotEmpty().WithMessage("DESTINATION_REQUIRED");
        RuleFor(x => x.Form).NotEmpty().WithMessage("FORM_REQUIRED");
        RuleFor(x => x.Classify).NotEmpty().WithMessage("CLASSIFY_REQUIRED");
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
        RuleFor(x => x.RoomCategories).NotEmpty().WithMessage("ROOM_CATEGORIES_REQUIRED");
        RuleForEach(x => x.RoomCategories).ChildRules(r =>
        {
            r.RuleFor(x => x.Titile).NotEmpty().WithMessage("ROOM_CATEGORY_TITLE_REQUIRED");
            r.RuleFor(x => x.Feature).NotEmpty().WithMessage("ROOM_CATEGORY_FEATURE_REQUIRED");
        });
    }
}
