using FluentValidation;

namespace Cms.Service.Blog.Validations;

public class UpdateBlogRequestValidator : AbstractValidator<Request.UpdateBlogRequest>
{
    public UpdateBlogRequestValidator()
    {
        RuleFor(x => x.Titile).NotEmpty().WithMessage("TITLE_REQUIRED");
        RuleFor(x => x.SubTitile).NotEmpty().WithMessage("SUB_TITLE_REQUIRED");
        RuleFor(x => x.Author).NotEmpty().WithMessage("AUTHOR_REQUIRED");
        RuleFor(x => x.ReadingTime).NotEmpty().WithMessage("READING_TIME_REQUIRED");
        RuleFor(x => x.Description).NotEmpty().WithMessage("DESCRIPTION_REQUIRED");
        RuleFor(x => x.Tag).NotEmpty().WithMessage("TAG_REQUIRED");
    }
}
