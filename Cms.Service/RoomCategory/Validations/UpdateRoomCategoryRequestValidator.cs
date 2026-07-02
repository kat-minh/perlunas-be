using FluentValidation;

namespace Cms.Service.RoomCategory.Validations;

public class UpdateRoomCategoryRequestValidator : AbstractValidator<Request.UpdateRoomCategoryRequest>
{
    public UpdateRoomCategoryRequestValidator()
    {
        RuleFor(x => x.ServiceId).NotEmpty().WithMessage("SERVICE_ID_REQUIRED");
        RuleFor(x => x.Album).NotEmpty().WithMessage("ALBUM_REQUIRED");
        RuleFor(x => x.Titile).NotEmpty().WithMessage("TITLE_REQUIRED");
        RuleFor(x => x.NumberOfCustomer).GreaterThan(0).WithMessage("NUMBER_OF_CUSTOMER_MUST_BE_GREATER_THAN_ZERO");
        RuleFor(x => x.Acreage).NotEmpty().WithMessage("ACREAGE_REQUIRED");
        RuleFor(x => x.NumberOfBed).NotEmpty().WithMessage("NUMBER_OF_BED_REQUIRED");
        RuleFor(x => x.Description).NotEmpty().WithMessage("DESCRIPTION_REQUIRED");
        RuleFor(x => x.Feature).NotEmpty().WithMessage("FEATURE_REQUIRED");
    }
}
