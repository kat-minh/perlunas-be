using Cms.Repository.Enums;

namespace Cms.Service.Tours;

public class Response
{
    public class TourListItem
    {
        public Guid Id { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public Guid TaxonomyId { get; set; }
        public string LocationName { get; set; } = string.Empty;
        public TaxonomyGroup LocationGroup { get; set; }
        public string Nights { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Teaser { get; set; } = string.Empty;
        public List<string> Highlights { get; set; } = new();
        public List<string> Stays { get; set; } = new();
        public string Cover { get; set; } = string.Empty;
        public bool Featured { get; set; }
        public int SortOrder { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class TourDetail
    {
        public Guid Id { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public Guid TaxonomyId { get; set; }
        public string LocationName { get; set; } = string.Empty;
        public TaxonomyGroup LocationGroup { get; set; }
        public string Nights { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Teaser { get; set; } = string.Empty;
        public List<string> Highlights { get; set; } = new();
        public List<string> Stays { get; set; } = new();
        public string Cover { get; set; } = string.Empty;
        public bool Featured { get; set; }
        public int SortOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
