using FluentValidation;

namespace Cms.Service.Service.Validations;

public class CreateTourRequestValidator : AbstractValidator<Request.CreateTourRequest>
{
    public CreateTourRequestValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("TITLE_REQUIRED");
        RuleFor(x => x.Day).GreaterThan(0).WithMessage("DAY_MUST_BE_GREATER_THAN_ZERO");
        RuleFor(x => x.Night).GreaterThan(0).WithMessage("NIGHT_MUST_BE_GREATER_THAN_ZERO");
        RuleFor(x => x.Album).NotEmpty().WithMessage("ALBUM_REQUIRED");
        RuleFor(x => x.Region).NotEmpty().WithMessage("REGION_REQUIRED");
        RuleFor(x => x.Description).NotEmpty().WithMessage("DESCRIPTION_REQUIRED");
        RuleFor(x => x.Infor).NotEmpty().WithMessage("INFOR_REQUIRED");
        RuleFor(x => x.Highlight).NotEmpty().WithMessage("HIGHLIGHT_REQUIRED");
        RuleFor(x => x.Code).NotEmpty().WithMessage("CODE_REQUIRED");
    }
}
