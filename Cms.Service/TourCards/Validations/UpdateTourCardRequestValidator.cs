using FluentValidation;

namespace Cms.Service.TourCards.Validations;

public class UpdateTourCardRequestValidator : AbstractValidator<Request.UpdateTourCardRequest>
{
    public UpdateTourCardRequestValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("TITLE_REQUIRED").MaximumLength(200).WithMessage("TITLE_MAX_LENGTH");
        RuleFor(x => x.Image).NotEmpty().WithMessage("IMAGE_REQUIRED").MaximumLength(500).WithMessage("IMAGE_MAX_LENGTH");
        RuleFor(x => x.Description).NotEmpty().WithMessage("DESCRIPTION_REQUIRED").MaximumLength(1000).WithMessage("DESCRIPTION_MAX_LENGTH");
    }
}
