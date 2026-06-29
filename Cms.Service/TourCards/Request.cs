using Cms.Repository.Enums;

namespace Cms.Service.TourCards;

public class Request
{
    public class CreateTourCardRequest
    {
        public TourCardType Type { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class UpdateTourCardRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
