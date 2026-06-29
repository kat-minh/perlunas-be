using FluentValidation;

namespace Cms.Service.ContactMessages.Validations;

public class CreateContactMessageRequestValidator : AbstractValidator<Request.CreateContactMessageRequest>
{
    public CreateContactMessageRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("NAME_REQUIRED").MaximumLength(100).WithMessage("NAME_MAX_LENGTH");
        RuleFor(x => x.Email).NotEmpty().WithMessage("EMAIL_REQUIRED").EmailAddress().WithMessage("EMAIL_INVALID").MaximumLength(254).WithMessage("EMAIL_MAX_LENGTH");
        RuleFor(x => x.Phone).MaximumLength(30).WithMessage("PHONE_MAX_LENGTH").Matches("^[0-9+() .-]*$").WithMessage("PHONE_INVALID").When(x => !string.IsNullOrWhiteSpace(x.Phone));
        RuleFor(x => x.Subject).MaximumLength(200).WithMessage("SUBJECT_MAX_LENGTH");
        RuleFor(x => x.Message).NotEmpty().WithMessage("MESSAGE_REQUIRED").MaximumLength(2000).WithMessage("MESSAGE_MAX_LENGTH");
    }
}
