namespace Cms.Service.RoomCategory;

public class Response
{
    public class RoomCategoryResponse
    {
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }
        public List<string> Album { get; set; } = new();
        public string Titile { get; set; } = string.Empty;
        public int NumberOfCustomer { get; set; }
        public string Acreage { get; set; } = string.Empty;
        public int NumberOfBed { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Feature { get; set; } = string.Empty;
        public string? Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
