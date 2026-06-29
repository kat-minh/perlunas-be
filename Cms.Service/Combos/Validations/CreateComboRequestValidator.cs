using FluentValidation;

namespace Cms.Service.Combos.Validations;

public class CreateComboRequestValidator : AbstractValidator<Request.CreateComboRequest>
{
    public CreateComboRequestValidator()
    {
        RuleFor(x => x.Slug).MaximumLength(120).WithMessage("SLUG_MAX_LENGTH").Matches("^[a-z0-9]+(?:-[a-z0-9]+)*$").WithMessage("SLUG_INVALID").When(x => !string.IsNullOrWhiteSpace(x.Slug));
        RuleFor(x => x.HotelId).NotEmpty().WithMessage("HOTEL_REQUIRED");
        RuleFor(x => x.ComboTierId).NotEmpty().WithMessage("COMBO_TIER_REQUIRED");
        RuleFor(x => x.Nights).GreaterThan(0).WithMessage("NIGHTS_MUST_BE_GREATER_THAN_ZERO").LessThanOrEqualTo(365).WithMessage("NIGHTS_MAX_VALUE");
        RuleFor(x => x.Price).NotEmpty().WithMessage("PRICE_REQUIRED").MaximumLength(100).WithMessage("PRICE_MAX_LENGTH").Must(p => !p.TrimStart().StartsWith('-')).WithMessage("PRICE_NOT_NEGATIVE");
        RuleFor(x => x.Cover).MaximumLength(500).WithMessage("COVER_MAX_LENGTH");
    }
}
