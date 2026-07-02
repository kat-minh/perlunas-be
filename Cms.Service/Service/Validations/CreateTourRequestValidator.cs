using FluentValidation;

namespace Cms.Service.Service.Validations;

public class CreateTourRequestValidator : AbstractValidator<Request.CreateTourRequest>
{
    public CreateTourRequestValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("TITLE_REQUIRED");
        RuleFor(x => x.Day).GreaterThan(0).WithMessage("DAY_MUST_BE_GREATER_THAN_ZERO");
        RuleFor(x => x.Night).GreaterThan(0).WithMessage("NIGHT_MUST_BE_GREATER_THAN_ZERO");
        RuleFor(x => x.Album).NotEmpty().WithMessage("ALBUM_REQUIRED");
        RuleFor(x => x.Region).NotEmpty().WithMessage("REGION_REQUIRED");
        RuleFor(x => x.Description).NotEmpty().WithMessage("DESCRIPTION_REQUIRED");
        RuleFor(x => x.Infor).NotEmpty().WithMessage("INFOR_REQUIRED");
        RuleFor(x => x.Highlight).NotEmpty().WithMessage("HIGHLIGHT_REQUIRED");
        RuleFor(x => x.Code).NotEmpty().WithMessage("CODE_REQUIRED");
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
            d.RuleFor(x => x.AccommodationStandards).NotEmpty().WithMessage("DEPARTURE_ACCOMMODATION_STANDARDS_REQUIRED");
        });
    }
}
