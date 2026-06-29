using FluentValidation;

namespace Cms.Service.Auth.Validations;

public class LoginRequestValidator : AbstractValidator<Request.LoginRequest>
{
    public LoginRequestValidator()
    {
        RuleFor(x => x.Username).NotEmpty().WithMessage("USERNAME_REQUIRED").MaximumLength(100).WithMessage("USERNAME_MAX_LENGTH");
        RuleFor(x => x.Password).NotEmpty().WithMessage("PASSWORD_REQUIRED").MaximumLength(256).WithMessage("PASSWORD_MAX_LENGTH");
    }
}
