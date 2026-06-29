using FluentValidation;

namespace Cms.Service.Queries.Validations;

public class CatalogQueryValidator : AbstractValidator<CatalogQuery>
{
    public CatalogQueryValidator()
    {
        RuleFor(x => x.Page).GreaterThanOrEqualTo(1).WithMessage("PAGE_INVALID");
        RuleFor(x => x.PageSize).InclusiveBetween(1, 200).WithMessage("PAGE_SIZE_INVALID");
        RuleFor(x => x.Search).MaximumLength(100).WithMessage("SEARCH_MAX_LENGTH");
        RuleFor(x => x.Region).MaximumLength(100).WithMessage("REGION_MAX_LENGTH");
        RuleFor(x => x.City).MaximumLength(100).WithMessage("CITY_MAX_LENGTH");
        RuleFor(x => x.Type).MaximumLength(100).WithMessage("TYPE_MAX_LENGTH");
        RuleFor(x => x.Tier).MaximumLength(100).WithMessage("TIER_MAX_LENGTH");
        RuleFor(x => x.StayType).MaximumLength(100).WithMessage("STAY_TYPE_MAX_LENGTH");
    }
}
