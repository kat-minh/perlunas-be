using Cms.Repository.Enums;

namespace Cms.Service.TourCards;

public class Response
{
    public class TourCardResponse
    {
        public Guid Id { get; set; }
        public TourCardType Type { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
