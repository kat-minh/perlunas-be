using Cms.Repository.Enums;
using FluentValidation;

namespace Cms.Service.Service.Validations;

public class CreateServiceRequestValidator : AbstractValidator<Request.CreateServiceRequest>
{
    public CreateServiceRequestValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("TITLE_REQUIRED");
        RuleFor(x => x.Type).NotEmpty().WithMessage("TYPE_REQUIRED")
            .IsInEnum().WithMessage("TYPE_MUST_BE_TOUR_COMBO_OR_HOTEL");

        RuleFor(x => x.Introducetion).NotEmpty().WithMessage("INTRODUCTION_REQUIRED")
            .When(x => x.Type != ServiceType.Tour && x.Type != ServiceType.Combo);
        RuleFor(x => x.Day).GreaterThan(0).WithMessage("DAY_MUST_BE_GREATER_THAN_ZERO")
            .When(x => x.Type != ServiceType.Combo && x.Type != ServiceType.Hotel);
        RuleFor(x => x.Night).GreaterThan(0).WithMessage("NIGHT_MUST_BE_GREATER_THAN_ZERO")
            .When(x => x.Type != ServiceType.Hotel);
        RuleFor(x => x.Label).NotEmpty().WithMessage("LABEL_REQUIRED")
            .When(x => x.Type != ServiceType.Tour && x.Type != ServiceType.Hotel);
        RuleFor(x => x.Album).NotEmpty().WithMessage("ALBUM_REQUIRED");
        RuleFor(x => x.Region).NotEmpty().WithMessage("REGION_REQUIRED");
        RuleFor(x => x.Description).NotEmpty().WithMessage("DESCRIPTION_REQUIRED")
            .When(x => x.Type != ServiceType.Hotel);
        RuleFor(x => x.Infor).NotEmpty().WithMessage("INFOR_REQUIRED")
            .When(x => x.Type != ServiceType.Hotel);
        RuleFor(x => x.Highlight).NotEmpty().WithMessage("HIGHLIGHT_REQUIRED")
            .When(x => x.Type != ServiceType.Hotel);
        RuleFor(x => x.Code).NotEmpty().WithMessage("CODE_REQUIRED")
            .When(x => x.Type != ServiceType.Hotel);
        RuleFor(x => x.Instruct).NotEmpty().WithMessage("INSTRUCT_REQUIRED")
            .When(x => x.Type != ServiceType.Tour && x.Type != ServiceType.Combo);
        RuleFor(x => x.Feature).NotEmpty().WithMessage("FEATURE_REQUIRED")
            .When(x => x.Type != ServiceType.Tour && x.Type != ServiceType.Combo);

        RuleFor(x => x.PurposeOfTrip).NotEmpty().WithMessage("PURPOSE_OF_TRIP_REQUIRED")
            .IsInEnum().WithMessage("PURPOSE_OF_TRIP_INVALID")
            .When(x => x.Type == ServiceType.Combo || x.Type == ServiceType.Hotel);
        RuleFor(x => x.Destination).NotEmpty().WithMessage("DESTINATION_REQUIRED")
            .When(x => x.Type == ServiceType.Combo || x.Type == ServiceType.Hotel);
        RuleFor(x => x.Form).NotEmpty().WithMessage("FORM_REQUIRED")
            .When(x => x.Type == ServiceType.Combo || x.Type == ServiceType.Hotel);
        RuleFor(x => x.Classify).NotEmpty().WithMessage("CLASSIFY_REQUIRED")
            .IsInEnum().WithMessage("CLASSIFY_INVALID")
            .When(x => x.Type == ServiceType.Combo);
    }
}
