using FluentValidation;

namespace Cms.Service.Queries.Validations;

public class MessageQueryValidator : AbstractValidator<MessageQuery>
{
    public MessageQueryValidator()
    {
        RuleFor(x => x.Page).GreaterThanOrEqualTo(1).WithMessage("PAGE_INVALID");
        RuleFor(x => x.PageSize).InclusiveBetween(1, 100).WithMessage("PAGE_SIZE_INVALID");
        RuleFor(x => x.Search).MaximumLength(100).WithMessage("SEARCH_MAX_LENGTH");
    }
}
