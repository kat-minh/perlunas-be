using Cms.Repository.Enums;
using FluentValidation;

namespace Cms.Service.Service.Validations;

public class CreateHotelRequestValidator : AbstractValidator<Request.CreateHotelRequest>
{
    public CreateHotelRequestValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("TITLE_REQUIRED");
        RuleFor(x => x.Introducetion).NotEmpty().WithMessage("INTRODUCTION_REQUIRED");
        RuleFor(x => x.Album).NotEmpty().WithMessage("ALBUM_REQUIRED");
        RuleFor(x => x.Region).NotEmpty().WithMessage("REGION_REQUIRED");
        RuleFor(x => x.Instruct).NotEmpty().WithMessage("INSTRUCT_REQUIRED");
        RuleFor(x => x.Feature).NotEmpty().WithMessage("FEATURE_REQUIRED");
        RuleFor(x => x.PurposeOfTrip).NotEmpty().WithMessage("PURPOSE_OF_TRIP_REQUIRED");
        RuleFor(x => x.Destination).NotEmpty().WithMessage("DESTINATION_REQUIRED");
        RuleFor(x => x.Form).NotEmpty().WithMessage("FORM_REQUIRED");
        RuleFor(x => x.RoomCategories).NotEmpty().WithMessage("ROOM_CATEGORIES_REQUIRED");
        RuleForEach(x => x.RoomCategories).ChildRules(r =>
        {
            r.RuleFor(x => x.Titile).NotEmpty().WithMessage("ROOM_CATEGORY_TITLE_REQUIRED");
            r.RuleFor(x => x.Feature).NotEmpty().WithMessage("ROOM_CATEGORY_FEATURE_REQUIRED");
        });
    }
}
