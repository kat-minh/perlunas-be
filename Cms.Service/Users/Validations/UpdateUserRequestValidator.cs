using Cms.Repository.Enums;
using FluentValidation;

namespace Cms.Service.Users.Validations;

public class UpdateUserRequestValidator : AbstractValidator<Request.UpdateUserRequest>
{
    public UpdateUserRequestValidator()
    {
        RuleFor(x => x.Username).NotEmpty().WithMessage("USERNAME_REQUIRED").Length(3, 100).WithMessage("USERNAME_LENGTH").Matches("^[a-zA-Z0-9._-]+$").WithMessage("USERNAME_INVALID");
        RuleFor(x => x.Email).NotEmpty().WithMessage("EMAIL_REQUIRED").EmailAddress().WithMessage("EMAIL_INVALID").MaximumLength(254).WithMessage("EMAIL_MAX_LENGTH");
        RuleFor(x => x.Role).NotEmpty().WithMessage("ROLE_REQUIRED").Must(r => Enum.TryParse<UserRole>(r, true, out _)).WithMessage("ROLE_INVALID");
        RuleFor(x => x.Password).MinimumLength(6).WithMessage("PASSWORD_MIN_LENGTH").MaximumLength(256).WithMessage("PASSWORD_MAX_LENGTH").When(x => !string.IsNullOrWhiteSpace(x.Password));
    }
}
