using FluentValidation;

namespace Cms.Service.Form.Validations;

public class CreateTourFormRequestValidator : AbstractValidator<Request.CreateTourFormRequest>
{
    public CreateTourFormRequestValidator()
    {
        RuleFor(x => x.FullName).NotEmpty().WithMessage("FULL_NAME_REQUIRED");
        RuleFor(x => x.Phone).NotEmpty().WithMessage("PHONE_REQUIRED");
        RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("EMAIL_REQUIRED");
        RuleFor(x => x.ServiceId).NotEmpty().WithMessage("SERVICE_ID_REQUIRED");
    }
}
