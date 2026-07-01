namespace Cms.Service.DepartureSchedule;

public class Response
{
    public class DepartureScheduleResponse
    {
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }
        public string StartTime { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string AccommodationStandards { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
