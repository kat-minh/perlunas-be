using Cms.Repository.Enums;
using FluentValidation;

namespace Cms.Service.Service.Validations;

public class UpdateServiceRequestValidator : AbstractValidator<Request.UpdateServiceRequest>
{
    public UpdateServiceRequestValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("TITLE_REQUIRED");
        RuleFor(x => x.Type).NotEmpty().WithMessage("TYPE_REQUIRED")
            .IsInEnum().WithMessage("TYPE_MUST_BE_TOUR_COMBO_OR_HOTEL");
        RuleFor(x => x.Album).NotEmpty().WithMessage("ALBUM_REQUIRED");
        RuleFor(x => x.Region).NotEmpty().WithMessage("REGION_REQUIRED");

        RuleFor(x => x.Introducetion).NotEmpty().WithMessage("INTRODUCTION_REQUIRED")
            .When(x => x.Introducetion != null && x.Type != ServiceType.Tour && x.Type != ServiceType.Combo);
        RuleFor(x => x.Day).GreaterThan(0).WithMessage("DAY_MUST_BE_GREATER_THAN_ZERO")
            .When(x => x.Day != null && x.Type != ServiceType.Combo && x.Type != ServiceType.Hotel);
        RuleFor(x => x.Night).GreaterThan(0).WithMessage("NIGHT_MUST_BE_GREATER_THAN_ZERO")
            .When(x => x.Night != null && x.Type != ServiceType.Hotel);
        RuleFor(x => x.Label).NotEmpty().WithMessage("LABEL_REQUIRED")
            .When(x => x.Label != null && x.Type != ServiceType.Tour && x.Type != ServiceType.Hotel);
        RuleFor(x => x.Description).NotEmpty().WithMessage("DESCRIPTION_REQUIRED")
            .When(x => x.Description != null && x.Type != ServiceType.Hotel);
        RuleFor(x => x.Infor).NotEmpty().WithMessage("INFOR_REQUIRED")
            .When(x => x.Infor != null && x.Type != ServiceType.Hotel);
        RuleFor(x => x.Highlight).NotEmpty().WithMessage("HIGHLIGHT_REQUIRED")
            .When(x => x.Highlight != null && x.Type != ServiceType.Hotel);
        RuleFor(x => x.Code).NotEmpty().WithMessage("CODE_REQUIRED")
            .When(x => x.Code != null && x.Type != ServiceType.Hotel);
        RuleFor(x => x.Instruct).NotEmpty().WithMessage("INSTRUCT_REQUIRED")
            .When(x => x.Instruct != null && x.Type != ServiceType.Tour && x.Type != ServiceType.Combo);
        RuleFor(x => x.Feature).NotEmpty().WithMessage("FEATURE_REQUIRED")
            .When(x => x.Feature != null && x.Type != ServiceType.Tour && x.Type != ServiceType.Combo);

        RuleFor(x => x.PurposeOfTrip).NotEmpty().WithMessage("PURPOSE_OF_TRIP_REQUIRED")
            .When(x => x.PurposeOfTrip != null && (x.Type == ServiceType.Combo || x.Type == ServiceType.Hotel));
        RuleFor(x => x.Destination).NotEmpty().WithMessage("DESTINATION_REQUIRED")
            .When(x => x.Destination != null && (x.Type == ServiceType.Combo || x.Type == ServiceType.Hotel));
        RuleFor(x => x.Form).NotEmpty().WithMessage("FORM_REQUIRED")
            .When(x => x.Form != null && (x.Type == ServiceType.Combo || x.Type == ServiceType.Hotel));
        RuleFor(x => x.Classify).NotEmpty().WithMessage("CLASSIFY_REQUIRED")
            .When(x => x.Classify != null && x.Type == ServiceType.Combo);

        RuleFor(x => x.Schedules).NotEmpty().WithMessage("SCHEDULES_REQUIRED")
            .When(x => x.Schedules != null && (x.Type == ServiceType.Tour || x.Type == ServiceType.Combo));
        RuleForEach(x => x.Schedules).ChildRules(s =>
        {
            s.RuleFor(x => x.Titile).NotEmpty().WithMessage("SCHEDULE_TITLE_REQUIRED");
            s.RuleFor(x => x.Description).NotEmpty().WithMessage("SCHEDULE_DESCRIPTION_REQUIRED");
        }).When(x => x.Schedules != null && (x.Type == ServiceType.Tour || x.Type == ServiceType.Combo));
        RuleFor(x => x.ImportantInfors).NotEmpty().WithMessage("IMPORTANT_INFORS_REQUIRED")
            .When(x => x.ImportantInfors != null && (x.Type == ServiceType.Tour || x.Type == ServiceType.Combo));
        RuleForEach(x => x.ImportantInfors).ChildRules(i =>
        {
            i.RuleFor(x => x.Title).NotEmpty().WithMessage("IMPORTANT_INFOR_TITLE_REQUIRED");
            i.RuleFor(x => x.Description).NotEmpty().WithMessage("IMPORTANT_INFOR_DESCRIPTION_REQUIRED");
        }).When(x => x.ImportantInfors != null && (x.Type == ServiceType.Tour || x.Type == ServiceType.Combo));

        RuleFor(x => x.RoomCategories).NotEmpty().WithMessage("ROOM_CATEGORIES_REQUIRED")
            .When(x => x.RoomCategories != null && (x.Type == ServiceType.Combo || x.Type == ServiceType.Hotel));
        RuleForEach(x => x.RoomCategories).ChildRules(r =>
        {
            r.RuleFor(x => x.Titile).NotEmpty().WithMessage("ROOM_CATEGORY_TITLE_REQUIRED");
            r.RuleFor(x => x.Feature).NotEmpty().WithMessage("ROOM_CATEGORY_FEATURE_REQUIRED");
        }).When(x => x.RoomCategories != null && (x.Type == ServiceType.Combo || x.Type == ServiceType.Hotel));
    }
}
