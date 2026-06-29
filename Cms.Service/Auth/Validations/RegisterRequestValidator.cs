using FluentValidation;

namespace Cms.Service.Auth.Validations;

public class RegisterRequestValidator : AbstractValidator<Request.RegisterRequest>
{
    public RegisterRequestValidator()
    {
        RuleFor(x => x.Username).NotEmpty().WithMessage("USERNAME_REQUIRED");
        RuleFor(x => x.Email).NotEmpty().WithMessage("EMAIL_REQUIRED")
            .EmailAddress().WithMessage("EMAIL_INVALID");
        RuleFor(x => x.Password).NotEmpty().WithMessage("PASSWORD_REQUIRED")
            .MinimumLength(6).WithMessage("PASSWORD_MIN_LENGTH");
    }
}
