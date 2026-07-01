using FluentValidation;

namespace Cms.Service.SiteSetting.Validations;

public class UpdateSiteSettingRequestValidator : AbstractValidator<Request.UpdateSiteSettingRequest>
{
    public UpdateSiteSettingRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("NAME_REQUIRED");
        RuleFor(x => x.LegalName).NotEmpty().WithMessage("LEGAL_NAME_REQUIRED");
        RuleFor(x => x.Tagline).NotEmpty().WithMessage("TAGLINE_REQUIRED");
        RuleFor(x => x.Manifesto).NotEmpty().WithMessage("MANIFESTO_REQUIRED");
        RuleFor(x => x.Description).NotEmpty().WithMessage("DESCRIPTION_REQUIRED");
        RuleFor(x => x.Phone).NotEmpty().WithMessage("PHONE_REQUIRED");
        RuleFor(x => x.Email).NotEmpty().WithMessage("EMAIL_REQUIRED");
        RuleFor(x => x.TaxId).NotEmpty().WithMessage("TAX_ID_REQUIRED");
        RuleFor(x => x.OfficesJson).NotEmpty().WithMessage("OFFICES_JSON_REQUIRED");
        RuleFor(x => x.SocialJson).NotEmpty().WithMessage("SOCIAL_JSON_REQUIRED");
    }
}
