using FluentValidation;

namespace Cms.Service.SiteSettings.Validations;

public class UpdateSiteSettingRequestValidator : AbstractValidator<Request.UpdateSiteSettingRequest>
{
    public UpdateSiteSettingRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("NAME_REQUIRED").MaximumLength(150).WithMessage("NAME_MAX_LENGTH");
        RuleFor(x => x.LegalName).MaximumLength(200).WithMessage("LEGAL_NAME_MAX_LENGTH");
        RuleFor(x => x.Tagline).MaximumLength(300).WithMessage("TAGLINE_MAX_LENGTH");
        RuleFor(x => x.Manifesto).MaximumLength(3000).WithMessage("MANIFESTO_MAX_LENGTH");
        RuleFor(x => x.Description).MaximumLength(3000).WithMessage("DESCRIPTION_MAX_LENGTH");
        RuleFor(x => x.Phone).MaximumLength(30).WithMessage("PHONE_MAX_LENGTH").Matches("^[0-9+() .-]*$").WithMessage("PHONE_INVALID").When(x => !string.IsNullOrWhiteSpace(x.Phone));
        RuleFor(x => x.Email).EmailAddress().WithMessage("EMAIL_INVALID").MaximumLength(254).WithMessage("EMAIL_MAX_LENGTH").When(x => !string.IsNullOrWhiteSpace(x.Email));
        RuleFor(x => x.TaxId).MaximumLength(50).WithMessage("TAX_ID_MAX_LENGTH");
        RuleFor(x => x.Offices).NotNull().WithMessage("OFFICES_REQUIRED").Must(x => x is not null && x.Count <= 20).WithMessage("OFFICES_MAX_COUNT");
        RuleForEach(x => x.Offices).ChildRules(o =>
        {
            o.RuleFor(x => x.Label).NotEmpty().WithMessage("OFFICE_LABEL_REQUIRED").MaximumLength(100).WithMessage("OFFICE_LABEL_MAX_LENGTH");
            o.RuleFor(x => x.Address).NotEmpty().WithMessage("OFFICE_ADDRESS_REQUIRED").MaximumLength(500).WithMessage("OFFICE_ADDRESS_MAX_LENGTH");
        });
        RuleFor(x => x.Social).NotNull().WithMessage("SOCIAL_REQUIRED").Must(x => x is not null && x.Count <= 20).WithMessage("SOCIAL_MAX_COUNT");
        RuleForEach(x => x.Social).ChildRules(s =>
        {
            s.RuleFor(x => x.Label).NotEmpty().WithMessage("SOCIAL_LABEL_REQUIRED").MaximumLength(100).WithMessage("SOCIAL_LABEL_MAX_LENGTH");
            s.RuleFor(x => x.Href).NotEmpty().WithMessage("SOCIAL_HREF_REQUIRED").MaximumLength(500).WithMessage("SOCIAL_HREF_MAX_LENGTH").Must(h => Uri.TryCreate(h, UriKind.Absolute, out _)).WithMessage("SOCIAL_HREF_INVALID");
        });
    }
}
