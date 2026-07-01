using FluentValidation;

namespace Cms.Service.Service.Validations;

public class CreateServiceRequestValidator : AbstractValidator<Request.CreateServiceRequest>
{
    public CreateServiceRequestValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("TITLE_REQUIRED");
        RuleFor(x => x.Introducetion).NotEmpty().WithMessage("INTRODUCTION_REQUIRED");
        RuleFor(x => x.Day).GreaterThan(0).WithMessage("DAY_MUST_BE_GREATER_THAN_ZERO");
        RuleFor(x => x.Night).GreaterThan(0).WithMessage("NIGHT_MUST_BE_GREATER_THAN_ZERO");
        RuleFor(x => x.Label).NotEmpty().WithMessage("LABEL_REQUIRED");
        RuleFor(x => x.Album).NotEmpty().WithMessage("ALBUM_REQUIRED");
        RuleFor(x => x.Region).NotEmpty().WithMessage("REGION_REQUIRED");
        RuleFor(x => x.Description).NotEmpty().WithMessage("DESCRIPTION_REQUIRED");
        RuleFor(x => x.Infor).NotEmpty().WithMessage("INFOR_REQUIRED");
        RuleFor(x => x.Highlight).NotEmpty().WithMessage("HIGHLIGHT_REQUIRED");
        RuleFor(x => x.Code).NotEmpty().WithMessage("CODE_REQUIRED");
        RuleFor(x => x.Instruct).NotEmpty().WithMessage("INSTRUCT_REQUIRED");
        RuleFor(x => x.Feature).NotEmpty().WithMessage("FEATURE_REQUIRED");
        RuleFor(x => x.Type).NotEmpty().WithMessage("TYPE_REQUIRED");
    }
}
