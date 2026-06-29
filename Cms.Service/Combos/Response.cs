namespace Cms.Service.Combos;

public class Response
{
    public class ComboListItem
    {
        public Guid Id { get; set; }
        public string Slug { get; set; } = string.Empty;
        public Guid HotelId { get; set; }
        public string HotelName { get; set; } = string.Empty;
        public string? CityName { get; set; }
        public Guid ComboTierId { get; set; }
        public string Tier { get; set; } = string.Empty;
        public int Nights { get; set; }
        public string Price { get; set; } = string.Empty;
        public string Cover { get; set; } = string.Empty;
        public bool Featured { get; set; }
        public int SortOrder { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class ComboDetail
    {
        public Guid Id { get; set; }
        public string Slug { get; set; } = string.Empty;
        public Guid HotelId { get; set; }
        public string HotelName { get; set; } = string.Empty;
        public string? CityName { get; set; }
        public Guid ComboTierId { get; set; }
        public string Tier { get; set; } = string.Empty;
        public int Nights { get; set; }
        public string Price { get; set; } = string.Empty;
        public bool Featured { get; set; }
        public string Cover { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
