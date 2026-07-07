namespace Cms.Service.Schedule;

public class Response
{
    public class ScheduleResponse
    {
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }
        public string Day { get; set; } = string.Empty;
        public string Titile { get; set; } = string.Empty;
        public string Sumary { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
