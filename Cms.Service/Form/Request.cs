namespace Cms.Service.Form;

public class Request
{
    public class CreateAdviseFormRequest
    {
        public required string Where { get; set; }
        public required string Slug { get; set; }
        public required string Month { get; set; }
        public required string Year { get; set; }
        public string? LongTime { get; set; }
        public string? ComboService { get; set; }
        public string? Note { get; set; }
        public required string FullName { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public string? Website { get; set; }
        public string? ContactName { get; set; }
        public bool PromotionalInformation { get; set; }
        public required Guid ServiceId { get; set; }
    }

    public class CreateTourFormRequest
    {
        public string? Note { get; set; }
        public required string FullName { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public required Guid ServiceId { get; set; }
    }

    public class CreateBookingFormRequest
    {
        public required string FullName { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public int? TotalPrice { get; set; }
        public required Guid ServiceId { get; set; }
        public required List<CreateFormDetailsRequest> FormDetails { get; set; }
    }

    public class CreateFormDetailsRequest
    {
        public required List<string> RoomCategory { get; set; }
        public int? NumberOfRooms { get; set; }
        public string? ReceiveTime { get; set; }
        public string? EndTime { get; set; }
        public int? Adults { get; set; }
        public int? Children { get; set; }
        public int? Baby { get; set; }
        public int? Price { get; set; }
        public string? UnitPrice { get; set; }
    }
}
