namespace Cms.Service.Combos;

public class Request
{
    public class CreateComboRequest
    {
        public string Slug { get; set; } = string.Empty;
        public Guid HotelId { get; set; }
        public Guid ComboTierId { get; set; }
        public int Nights { get; set; }
        public string Price { get; set; } = string.Empty;
        public bool Featured { get; set; }
        public string Cover { get; set; } = string.Empty;
    }

    public class UpdateComboRequest
    {
        public string Slug { get; set; } = string.Empty;
        public Guid HotelId { get; set; }
        public Guid ComboTierId { get; set; }
        public int Nights { get; set; }
        public string Price { get; set; } = string.Empty;
        public bool Featured { get; set; }
        public string Cover { get; set; } = string.Empty;
    }
}
