using FluentValidation;

namespace Cms.Service.PageContent.Validations;

public class UpdatePageContentRequestValidator : AbstractValidator<Request.UpdatePageContentRequest>
{
    public UpdatePageContentRequestValidator()
    {
        RuleFor(x => x.PageKey).NotEmpty().WithMessage("PAGE_KEY_REQUIRED");
        RuleFor(x => x.SectionKey).NotEmpty().WithMessage("SECTION_KEY_REQUIRED");
        RuleFor(x => x.Key).NotEmpty().WithMessage("KEY_REQUIRED");
        RuleFor(x => x.ContentValue).NotEmpty().WithMessage("CONTENT_VALUE_REQUIRED");
        RuleFor(x => x.Label).NotEmpty().WithMessage("LABEL_REQUIRED");
        RuleFor(x => x.Kind).NotEmpty().WithMessage("KIND_REQUIRED");
        RuleFor(x => x.SoftOrder).GreaterThanOrEqualTo(0).WithMessage("SOFT_ORDER_MUST_BE_GREATER_THAN_OR_EQUAL_ZERO");
    }
}
