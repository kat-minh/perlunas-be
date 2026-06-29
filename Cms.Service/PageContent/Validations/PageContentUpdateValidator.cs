using FluentValidation;

namespace Cms.Service.PageContent.Validations;

public class PageContentUpdateValidator : AbstractValidator<Request.PageContentUpdate>
{
    public PageContentUpdateValidator()
    {
        RuleFor(x => x.Key).NotEmpty().WithMessage("KEY_REQUIRED").MaximumLength(150).WithMessage("KEY_MAX_LENGTH").Matches("^[a-zA-Z0-9_.:-]+$").WithMessage("KEY_INVALID");
        RuleFor(x => x.Value).MaximumLength(10000).WithMessage("VALUE_MAX_LENGTH");
    }
}
