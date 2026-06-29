using FluentValidation;

namespace Cms.Service.Taxonomies.Validations;

public class CreateTaxonomyRequestValidator : AbstractValidator<Request.CreateTaxonomyRequest>
{
    public CreateTaxonomyRequestValidator()
    {
        RuleFor(x => x.Group).IsInEnum().WithMessage("GROUP_INVALID");
        RuleFor(x => x.Name).NotEmpty().WithMessage("NAME_REQUIRED").MaximumLength(100).WithMessage("NAME_MAX_LENGTH");
        RuleFor(x => x.Slug).MaximumLength(120).WithMessage("SLUG_MAX_LENGTH").Matches("^[a-z0-9]+(?:-[a-z0-9]+)*$").WithMessage("SLUG_INVALID").When(x => !string.IsNullOrWhiteSpace(x.Slug));
    }
}
