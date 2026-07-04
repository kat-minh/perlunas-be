using FluentValidation;

namespace Cms.Service.Form.Validations;

public class CreateAdviseFormRequestValidator : AbstractValidator<Request.CreateAdviseFormRequest>
{
    public CreateAdviseFormRequestValidator()
    {
        RuleFor(x => x.Where).NotEmpty().WithMessage("WHERE_REQUIRED");
        RuleFor(x => x.Slug).NotEmpty().WithMessage("SLUG_REQUIRED");
        RuleFor(x => x.Month).NotEmpty().WithMessage("MONTH_REQUIRED");
        RuleFor(x => x.Year).NotEmpty().WithMessage("YEAR_REQUIRED");
        RuleFor(x => x.FullName).NotEmpty().WithMessage("FULL_NAME_REQUIRED");
        RuleFor(x => x.Phone).NotEmpty().WithMessage("PHONE_REQUIRED");
        RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("EMAIL_REQUIRED");
        RuleFor(x => x.ServiceId).NotEmpty().WithMessage("SERVICE_ID_REQUIRED");
    }
}
