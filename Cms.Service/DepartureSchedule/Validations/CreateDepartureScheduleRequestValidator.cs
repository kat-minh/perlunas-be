using FluentValidation;

namespace Cms.Service.DepartureSchedule.Validations;

public class CreateDepartureScheduleRequestValidator : AbstractValidator<Request.CreateDepartureScheduleRequest>
{
    public CreateDepartureScheduleRequestValidator()
    {
        RuleFor(x => x.ServiceId).NotEmpty().WithMessage("SERVICE_ID_REQUIRED");
        RuleFor(x => x.StartTime).NotEmpty().WithMessage("START_TIME_REQUIRED");
        RuleFor(x => x.Code).NotEmpty().WithMessage("CODE_REQUIRED");
        RuleFor(x => x.Price).NotEmpty().WithMessage("PRICE_REQUIRED");
        RuleFor(x => x.AccommodationStandards).NotEmpty().WithMessage("ACCOMMODATION_STANDARDS_REQUIRED");
    }
}
