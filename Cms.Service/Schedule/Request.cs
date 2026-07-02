namespace Cms.Service.Schedule;

public class Request
{
    public class CreateScheduleRequest
    {
        public Guid ServiceId { get; set; }
        public string Day { get; set; } = string.Empty;
        public string Titile { get; set; } = string.Empty;
        public string Sumary { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class UpdateScheduleRequest
    {
        public Guid ServiceId { get; set; }
        public string Day { get; set; } = string.Empty;
        public string Titile { get; set; } = string.Empty;
        public string Sumary { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
