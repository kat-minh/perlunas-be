using Cms.Repository.Enums;

namespace Cms.Service.Service;

public class Response
{
    public class ServiceResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public bool BestSeller { get; set; }
        public string Introducetion { get; set; } = string.Empty;
        public int Day { get; set; }
        public int Night { get; set; }
        public string Label { get; set; } = string.Empty;
        public List<string> Album { get; set; } = new();
        public string Region { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Infor { get; set; } = string.Empty;
        public List<string> Highlight { get; set; } = new();
        /// <summary>Tour: điểm đến (tên/slug tỉnh) để gợi ý khách sạn tại nơi đến.</summary>
        public List<string> Destinations { get; set; } = new();
        /// <summary>Hotel: tiện nghi nổi bật cấp khách sạn.</summary>
        public List<string> Facilities { get; set; } = new();
        /// <summary>Tour: "Điểm nổi bật" dạng richtext (HTML) admin tự soạn.</summary>
        public string HighlightContent { get; set; } = string.Empty;
        /// <summary>Giá hiển thị dạng chuỗi (vd "từ 2.890.000đ").</summary>
        public string PriceText { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Instruct { get; set; } = string.Empty;
        public string Feature { get; set; } = string.Empty;
        public ServiceType Type { get; set; }
        public bool IsPublic { get; set; }
        public string? PurposeOfTrip { get; set; }
        public string? Destination { get; set; }
        public string? Form { get; set; }
        public string? Classify { get; set; }
        /// <summary>
        /// Giá thấp nhất (VND) gộp từ DepartureSchedules (tour) và RoomCategories
        /// (khách sạn/combo) để thẻ list hiển thị "từ X đ". null khi chưa có giá.
        /// </summary>
        public decimal? PriceFrom { get; set; }
        public List<Schedule.Response.ScheduleResponse> Schedules { get; set; } = new();
        public List<ImportantInfor.Response.ImportantInforResponse> ImportantInfors { get; set; } = new();
        public List<DepartureSchedule.Response.DepartureScheduleResponse> DepartureSchedules { get; set; } = new();
        public List<RoomCategory.Response.RoomCategoryResponse> RoomCategories { get; set; } = new();
        public List<ServiceResponse>? RelatedTours { get; set; }
        public List<ServiceResponse>? RelatedHotels { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
