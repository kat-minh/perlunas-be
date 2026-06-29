using FluentValidation;

namespace Cms.Service.Tours.Validations;

public class CreateTourRequestValidator : AbstractValidator<Request.CreateTourRequest>
{
    public CreateTourRequestValidator()
    {
        RuleFor(x => x.Slug).MaximumLength(120).WithMessage("SLUG_MAX_LENGTH").Matches("^[a-z0-9]+(?:-[a-z0-9]+)*$").WithMessage("SLUG_INVALID").When(x => !string.IsNullOrWhiteSpace(x.Slug));
        RuleFor(x => x.Name).NotEmpty().WithMessage("NAME_REQUIRED").MaximumLength(200).WithMessage("NAME_MAX_LENGTH");
        RuleFor(x => x.TaxonomyId).NotEmpty().WithMessage("TAXONOMY_REQUIRED");
        RuleFor(x => x.Nights).MaximumLength(50).WithMessage("NIGHTS_MAX_LENGTH").Must(n => string.IsNullOrWhiteSpace(n) || !n.TrimStart().StartsWith('-')).WithMessage("NIGHTS_NOT_NEGATIVE");
        RuleFor(x => x.Price).MaximumLength(100).WithMessage("PRICE_MAX_LENGTH").Must(p => string.IsNullOrWhiteSpace(p) || !p.TrimStart().StartsWith('-')).WithMessage("PRICE_NOT_NEGATIVE");
        RuleFor(x => x.Teaser).MaximumLength(1000).WithMessage("TEASER_MAX_LENGTH");
        RuleFor(x => x.Highlights).NotNull().WithMessage("HIGHLIGHTS_REQUIRED").Must(x => x is not null && x.Count <= 50).WithMessage("HIGHLIGHTS_MAX_COUNT");
        RuleForEach(x => x.Highlights).NotEmpty().WithMessage("HIGHLIGHT_REQUIRED").MaximumLength(300).WithMessage("HIGHLIGHT_MAX_LENGTH");
        RuleFor(x => x.Stays).NotNull().WithMessage("STAYS_REQUIRED").Must(x => x is not null && x.Count <= 50).WithMessage("STAYS_MAX_COUNT");
        RuleForEach(x => x.Stays).NotEmpty().WithMessage("STAY_REQUIRED").MaximumLength(300).WithMessage("STAY_MAX_LENGTH");
        RuleFor(x => x.Cover).MaximumLength(500).WithMessage("COVER_MAX_LENGTH");
    }
}
