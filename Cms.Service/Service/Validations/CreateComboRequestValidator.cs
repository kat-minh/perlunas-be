using Cms.Repository.Enums;
using FluentValidation;

namespace Cms.Service.Service.Validations;

public class CreateComboRequestValidator : AbstractValidator<Request.CreateComboRequest>
{
    public CreateComboRequestValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("TITLE_REQUIRED");
        RuleFor(x => x.Night).GreaterThan(0).WithMessage("NIGHT_MUST_BE_GREATER_THAN_ZERO");
        RuleFor(x => x.Label).NotEmpty().WithMessage("LABEL_REQUIRED");
        RuleFor(x => x.Album).NotEmpty().WithMessage("ALBUM_REQUIRED");
        RuleFor(x => x.Region).NotEmpty().WithMessage("REGION_REQUIRED");
        RuleFor(x => x.Description).NotEmpty().WithMessage("DESCRIPTION_REQUIRED");
        RuleFor(x => x.Infor).NotEmpty().WithMessage("INFOR_REQUIRED");
        RuleFor(x => x.Highlight).NotEmpty().WithMessage("HIGHLIGHT_REQUIRED");
        RuleFor(x => x.Code).NotEmpty().WithMessage("CODE_REQUIRED");
        RuleFor(x => x.PurposeOfTrip).IsInEnum().WithMessage("PURPOSE_OF_TRIP_INVALID");
        RuleFor(x => x.Destination).NotEmpty().WithMessage("DESTINATION_REQUIRED");
        RuleFor(x => x.Form).NotEmpty().WithMessage("FORM_REQUIRED");
        RuleFor(x => x.Classify).IsInEnum().WithMessage("CLASSIFY_INVALID");
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
