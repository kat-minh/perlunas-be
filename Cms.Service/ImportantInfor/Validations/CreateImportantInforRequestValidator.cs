using FluentValidation;

namespace Cms.Service.ImportantInfor.Validations;

public class CreateImportantInforRequestValidator : AbstractValidator<Request.CreateImportantInforRequest>
{
    public CreateImportantInforRequestValidator()
    {
        RuleFor(x => x.ServiceId).NotEmpty().WithMessage("SERVICE_ID_REQUIRED");
        RuleFor(x => x.Title).NotEmpty().WithMessage("TITLE_REQUIRED");
        RuleFor(x => x.SubTitle).NotEmpty().WithMessage("SUB_TITLE_REQUIRED");
        RuleFor(x => x.Description).NotEmpty().WithMessage("DESCRIPTION_REQUIRED");
    }
}
