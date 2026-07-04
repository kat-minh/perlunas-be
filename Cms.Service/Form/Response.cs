using Cms.Repository.Enums;

namespace Cms.Service.Form;

public class Response
{
    public abstract class FormResponse
    {
        public Guid Id { get; set; }
        public FormType Type { get; set; }
        public string? Title { get; set; }
        public string? Slug { get; set; }
        public Guid? ServiceId { get; set; }
        /// <summary>Tên dịch vụ liên kết (tour/khách sạn/combo) — để admin biết đặt cái nào.</summary>
        public string? ServiceName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class AdviseFormResponse : FormResponse
    {
        public string? Where { get; set; }
        public string? Month { get; set; }
        public string? Year { get; set; }
        public string? LongTime { get; set; }
        public string? ComboService { get; set; }
        public string? Note { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? ContactName { get; set; }
        public bool PromotionalInformation { get; set; }
        public string? PricePerPerson { get; set; }
    }

    public class TourFormResponse : FormResponse
    {
        public string? Note { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }

    public class BookingFormResponse : FormResponse
    {
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int? TotalPrice { get; set; }
        public string? Region { get; set; }
        public ICollection<FormDetailsResponse> FormDetails { get; set; } = new List<FormDetailsResponse>();
    }

    public class FormDetailsResponse
    {
        public Guid Id { get; set; }
        public List<string>? RoomCategory { get; set; }
        public int? NumberOfRooms { get; set; }
        public string? ReceiveTime { get; set; }
        public string? EndTime { get; set; }
        public int? Adults { get; set; }
        public int? Children { get; set; }
        public int? Baby { get; set; }
        public int? Price { get; set; }
        public string? UnitPrice { get; set; }
        public Guid ServiceId { get; set; }
        public Guid FormId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
