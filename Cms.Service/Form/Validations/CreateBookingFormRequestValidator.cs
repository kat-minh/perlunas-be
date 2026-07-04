using FluentValidation;

namespace Cms.Service.Form.Validations;

public class CreateBookingFormRequestValidator : AbstractValidator<Request.CreateBookingFormRequest>
{
    public CreateBookingFormRequestValidator()
    {
        RuleFor(x => x.FullName).NotEmpty().WithMessage("FULL_NAME_REQUIRED");
        RuleFor(x => x.Phone).NotEmpty().WithMessage("PHONE_REQUIRED");
        RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("EMAIL_REQUIRED");
        RuleFor(x => x.ServiceId).NotEmpty().WithMessage("SERVICE_ID_REQUIRED");
        RuleFor(x => x.FormDetails).NotEmpty().WithMessage("FORM_DETAILS_REQUIRED");
        RuleForEach(x => x.FormDetails).ChildRules(d =>
        {
            d.RuleFor(x => x.RoomCategory).NotEmpty().WithMessage("ROOM_CATEGORY_REQUIRED");
            d.RuleFor(x => x.Adults).GreaterThan(0).WithMessage("ADULTS_MUST_BE_GREATER_THAN_ZERO");
        });
    }
}
