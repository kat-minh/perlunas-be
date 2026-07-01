namespace Cms.Service.RoomCategory;

public class Request
{
    public class CreateRoomCategoryRequest
    {
        public Guid ServiceId { get; set; }
        public List<string> Album { get; set; } = new();
        public string Titile { get; set; } = string.Empty;
        public int NumberOfCustomer { get; set; }
        public string Acreage { get; set; } = string.Empty;
        public int NumberOfBed { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Feature { get; set; } = string.Empty;
        public string? Price { get; set; }
    }

    public class UpdateRoomCategoryRequest
    {
        public Guid ServiceId { get; set; }
        public List<string> Album { get; set; } = new();
        public string Titile { get; set; } = string.Empty;
        public int NumberOfCustomer { get; set; }
        public string Acreage { get; set; } = string.Empty;
        public int NumberOfBed { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Feature { get; set; } = string.Empty;
        public string? Price { get; set; }
    }
}
