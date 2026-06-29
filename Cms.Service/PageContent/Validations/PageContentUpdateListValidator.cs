using FluentValidation;

namespace Cms.Service.PageContent.Validations;

public class PageContentUpdateListValidator : AbstractValidator<List<Request.PageContentUpdate>>
{
    public PageContentUpdateListValidator()
    {
        RuleFor(x => x).NotNull().WithMessage("UPDATES_REQUIRED");
        RuleFor(x => x).Must(x => x is not null && x.Count > 0).WithMessage("UPDATES_REQUIRED");
        RuleFor(x => x).Must(x => x is not null && x.Count <= 200).WithMessage("UPDATES_MAX_COUNT");
        RuleFor(x => x).Must(x => x is not null && x.Select(i => i.Key).Distinct(StringComparer.OrdinalIgnoreCase).Count() == x.Count).WithMessage("KEY_DUPLICATED");
        RuleForEach(x => x).SetValidator(new PageContentUpdateValidator());
    }
}
