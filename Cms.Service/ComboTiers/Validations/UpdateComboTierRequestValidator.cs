using FluentValidation;

namespace Cms.Service.ComboTiers.Validations;

public class UpdateComboTierRequestValidator : AbstractValidator<Request.UpdateComboTierRequest>
{
    public UpdateComboTierRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("NAME_REQUIRED").MaximumLength(100).WithMessage("NAME_MAX_LENGTH");
        RuleFor(x => x.Tagline).MaximumLength(300).WithMessage("TAGLINE_MAX_LENGTH");
        RuleFor(x => x.Pearl).MaximumLength(500).WithMessage("PEARL_MAX_LENGTH");
        RuleFor(x => x.Story).MaximumLength(2000).WithMessage("STORY_MAX_LENGTH");
        RuleFor(x => x.Includes).NotNull().WithMessage("INCLUDES_REQUIRED").Must(x => x is not null && x.Count <= 50).WithMessage("INCLUDES_MAX_COUNT");
        RuleForEach(x => x.Includes).NotEmpty().WithMessage("INCLUDE_REQUIRED").MaximumLength(200).WithMessage("INCLUDE_MAX_LENGTH");
    }
}
