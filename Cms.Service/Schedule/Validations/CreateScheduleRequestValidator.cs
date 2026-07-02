using FluentValidation;

namespace Cms.Service.Schedule.Validations;

public class CreateScheduleRequestValidator : AbstractValidator<Request.CreateScheduleRequest>
{
    public CreateScheduleRequestValidator()
    {
        RuleFor(x => x.ServiceId).NotEmpty().WithMessage("SERVICE_ID_REQUIRED");
        RuleFor(x => x.Day).NotEmpty().WithMessage("DAY_REQUIRED");
        RuleFor(x => x.Titile).NotEmpty().WithMessage("TITLE_REQUIRED");
        RuleFor(x => x.Sumary).NotEmpty().WithMessage("SUMARY_REQUIRED");
        RuleFor(x => x.Description).NotEmpty().WithMessage("DESCRIPTION_REQUIRED");
    }
}
