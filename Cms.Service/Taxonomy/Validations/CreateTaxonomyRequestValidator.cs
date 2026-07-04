using FluentValidation;

namespace Cms.Service.Taxonomy.Validations;

public class CreateTaxonomyRequestValidator : AbstractValidator<Request.CreateTaxonomyRequest>
{
    public CreateTaxonomyRequestValidator()
    {
        RuleFor(x => x.Group).NotEmpty().WithMessage("GROUP_REQUIRED");
        RuleFor(x => x.Name).NotEmpty().WithMessage("NAME_REQUIRED");
    }
}
