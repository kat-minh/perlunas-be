namespace Cms.Service.Hotels;

public class Request
{
    public class CreateHotelRequest
    {
        public string Slug { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public List<Guid> CityIds { get; set; } = new();
        public List<Guid> StayTypeIds { get; set; } = new();
        public string Price { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public bool Featured { get; set; }
        public string Cover { get; set; } = string.Empty;
    }

    public class UpdateHotelRequest
    {
        public string Slug { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public List<Guid> CityIds { get; set; } = new();
        public List<Guid> StayTypeIds { get; set; } = new();
        public string Price { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public bool Featured { get; set; }
        public string Cover { get; set; } = string.Empty;
    }
}
