using FluentValidation;

namespace Cms.Service.Taxonomy.Validations;

public class UpdateTaxonomyRequestValidator : AbstractValidator<Request.UpdateTaxonomyRequest>
{
    public UpdateTaxonomyRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("NAME_REQUIRED");
    }
}
