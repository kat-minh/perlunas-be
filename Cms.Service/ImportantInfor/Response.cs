namespace Cms.Service.ImportantInfor;

public class Response
{
    public class ImportantInforResponse
    {
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string SubTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
