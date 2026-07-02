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
        public string NumberOfBed { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Feature { get; set; } = new();
        public string? Price { get; set; }
        public string? OriginalPrice { get; set; }
        public string? Unit { get; set; }
    }

    public class UpdateRoomCategoryRequest
    {
        public Guid ServiceId { get; set; }
        public List<string> Album { get; set; } = new();
        public string Titile { get; set; } = string.Empty;
        public int NumberOfCustomer { get; set; }
        public string Acreage { get; set; } = string.Empty;
        public string NumberOfBed { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Feature { get; set; } = new();
        public string? Price { get; set; }
        public string? OriginalPrice { get; set; }
        public string? Unit { get; set; }
    }
}
