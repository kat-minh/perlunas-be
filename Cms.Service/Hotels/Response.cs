namespace Cms.Service.Hotels;

public class Response
{
    public class TaxonomyItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public class HotelListItem
    {
        public Guid Id { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public List<TaxonomyItem> Cities { get; set; } = new();
        public List<TaxonomyItem> StayTypes { get; set; } = new();
        public string Price { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public string Cover { get; set; } = string.Empty;
        public bool Featured { get; set; }
        public int SortOrder { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class HotelDetail
    {
        public Guid Id { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public List<TaxonomyItem> Cities { get; set; } = new();
        public List<TaxonomyItem> StayTypes { get; set; } = new();
        public string Price { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public bool Featured { get; set; }
        public string Cover { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
