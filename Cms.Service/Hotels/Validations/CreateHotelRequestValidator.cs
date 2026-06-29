using FluentValidation;

namespace Cms.Service.Hotels.Validations;

public class CreateHotelRequestValidator : AbstractValidator<Request.CreateHotelRequest>
{
    public CreateHotelRequestValidator()
    {
        RuleFor(x => x.Slug).MaximumLength(120).WithMessage("SLUG_MAX_LENGTH").Matches("^[a-z0-9]+(?:-[a-z0-9]+)*$").WithMessage("SLUG_INVALID").When(x => !string.IsNullOrWhiteSpace(x.Slug));
        RuleFor(x => x.Name).NotEmpty().WithMessage("NAME_REQUIRED").MaximumLength(200).WithMessage("NAME_MAX_LENGTH");
        RuleFor(x => x.CityIds).NotNull().WithMessage("CITY_IDS_REQUIRED");
        RuleForEach(x => x.CityIds).NotEmpty().WithMessage("CITY_ID_INVALID");
        RuleFor(x => x.StayTypeIds).NotNull().WithMessage("STAY_TYPE_IDS_REQUIRED");
        RuleForEach(x => x.StayTypeIds).NotEmpty().WithMessage("STAY_TYPE_ID_INVALID");
        RuleFor(x => x.Price).MaximumLength(100).WithMessage("PRICE_MAX_LENGTH").Must(p => string.IsNullOrWhiteSpace(p) || !p.TrimStart().StartsWith('-')).WithMessage("PRICE_NOT_NEGATIVE");
        RuleFor(x => x.Desc).MaximumLength(3000).WithMessage("DESC_MAX_LENGTH");
        RuleFor(x => x.Cover).MaximumLength(500).WithMessage("COVER_MAX_LENGTH");
    }
}
