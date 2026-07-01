namespace Cms.Service.DepartureSchedule;

public class Request
{
    public class CreateDepartureScheduleRequest
    {
        public Guid ServiceId { get; set; }
        public string StartTime { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string AccommodationStandards { get; set; } = string.Empty;
    }

    public class UpdateDepartureScheduleRequest
    {
        public Guid ServiceId { get; set; }
        public string StartTime { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string AccommodationStandards { get; set; } = string.Empty;
    }
}
