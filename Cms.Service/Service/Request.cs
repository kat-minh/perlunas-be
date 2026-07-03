using Cms.Repository.Enums;

namespace Cms.Service.Service;

public class Request
{
    public class ScheduleInline
    {
        public string Day { get; set; } = string.Empty;
        public string Titile { get; set; } = string.Empty;
        public string Sumary { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class ImportantInforInline
    {
        public string Title { get; set; } = string.Empty;
        public string SubTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class DepartureScheduleInline
    {
        public string StartTime { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        /// <summary>Giá gốc (trước giảm) — để trống nếu không có khuyến mãi.</summary>
        public string OriginalPrice { get; set; } = string.Empty;
        public string AccommodationStandards { get; set; } = string.Empty;
    }

    public class RoomCategoryInline
    {
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

    public class CreateTourRequest
    {
        public string Title { get; set; } = string.Empty;
        public int Day { get; set; }
        public int Night { get; set; }
        /// <summary>Thời lượng chuỗi tự do admin nhập (vd "3 ngày 2 đêm", "1 tuần").</summary>
        public string DurationText { get; set; } = string.Empty;
        public List<string> Album { get; set; } = new();
        public string Region { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Infor { get; set; } = string.Empty;
        public List<string> Highlight { get; set; } = new();
        public List<string> Destinations { get; set; } = new();
        public string HighlightContent { get; set; } = string.Empty;
        /// <summary>JSON {"stay","sightsee","food","transport"} — 4 ô "Thông tin chính về chuyến đi".</summary>
        public string TripInfoJson { get; set; } = string.Empty;
        /// <summary>Đơn vị giá tour (vd "/ khách"). Trống → FE dùng mặc định.</summary>
        public string PriceUnit { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
        public bool BestSeller { get; set; }
        /// <summary>Tour: đánh dấu "Sắp ra mắt".</summary>
        public bool ComingSoon { get; set; }
        public List<ScheduleInline> Schedules { get; set; } = new();
        public List<ImportantInforInline> ImportantInfors { get; set; } = new();
        public List<DepartureScheduleInline> DepartureSchedules { get; set; } = new();
    }

    public class CreateComboRequest
    {
        public string Title { get; set; } = string.Empty;
        public int Day { get; set; }
        public int Night { get; set; }
        /// <summary>Thời lượng chuỗi tự do admin nhập (vd "3 ngày 2 đêm", "1 tuần").</summary>
        public string DurationText { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public List<string> Album { get; set; } = new();
        public string Region { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Infor { get; set; } = string.Empty;
        public List<string> Highlight { get; set; } = new();
        /// <summary>Combo: "Điểm nổi bật" dạng richtext (HTML) admin soạn.</summary>
        public string HighlightContent { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string PurposeOfTrip { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public string Form { get; set; } = string.Empty;
        public string Classify { get; set; } = string.Empty;
        /// <summary>JSON 4 ô "Thông tin chính về combo" {"stay","sightsee","food","transport"}.</summary>
        public string TripInfoJson { get; set; } = string.Empty;
        /// <summary>Đơn vị giá combo (vd "/ khách").</summary>
        public string PriceUnit { get; set; } = string.Empty;
        /// <summary>Giá bán gói (chuỗi số, vd "2200000"). Giá của combo ở cấp gói, không ở hạng phòng.</summary>
        public string Price { get; set; } = string.Empty;
        /// <summary>Giá gốc trước giảm (để gạch + tính % giảm). Trống nếu không giảm.</summary>
        public string OriginalPrice { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
        public bool BestSeller { get; set; }
        public List<ScheduleInline> Schedules { get; set; } = new();
        public List<ImportantInforInline> ImportantInfors { get; set; } = new();
        public List<RoomCategoryInline> RoomCategories { get; set; } = new();
    }

    public class CreateHotelRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Introducetion { get; set; } = string.Empty;
        public List<string> Album { get; set; } = new();
        public string Region { get; set; } = string.Empty;
        public string Instruct { get; set; } = string.Empty;
        public string Feature { get; set; } = string.Empty;
        public List<string> Facilities { get; set; } = new();
        public string PurposeOfTrip { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public string Form { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
        public bool BestSeller { get; set; }
        public List<RoomCategoryInline> RoomCategories { get; set; } = new();
    }

    public class UpdateServiceRequest
    {
        public string? Title { get; set; }
        public string? Introducetion { get; set; }
        public int? Day { get; set; }
        public int? Night { get; set; }
        /// <summary>Thời lượng chuỗi tự do (vd "3 ngày 2 đêm", "1 tuần").</summary>
        public string? DurationText { get; set; }
        public string? Label { get; set; }
        public List<string>? Album { get; set; }
        public string? Region { get; set; }
        public string? Description { get; set; }
        public string? Infor { get; set; }
        public List<string>? Highlight { get; set; }
        public List<string>? Destinations { get; set; }
        public List<string>? Facilities { get; set; }
        public string? HighlightContent { get; set; }
        /// <summary>JSON {"stay","sightsee","food","transport"} — 4 ô "Thông tin chính về chuyến đi".</summary>
        public string? TripInfoJson { get; set; }
        /// <summary>Đơn vị giá tour (vd "/ khách").</summary>
        public string? PriceUnit { get; set; }
        /// <summary>Combo: giá bán gói (chuỗi số).</summary>
        public string? Price { get; set; }
        /// <summary>Combo: giá gốc trước giảm.</summary>
        public string? OriginalPrice { get; set; }
        public string? Code { get; set; }
        public string? Instruct { get; set; }
        public string? Feature { get; set; }
        public ServiceType? Type { get; set; }
        public bool? IsPublic { get; set; }
        public bool? BestSeller { get; set; }
        /// <summary>Tour: đánh dấu "Sắp ra mắt".</summary>
        public bool? ComingSoon { get; set; }
        public string? PurposeOfTrip { get; set; }
        public string? Destination { get; set; }
        public string? Form { get; set; }
        public string? Classify { get; set; }
        public List<ScheduleInline>? Schedules { get; set; }
        public List<ImportantInforInline>? ImportantInfors { get; set; }
        public List<DepartureScheduleInline>? DepartureSchedules { get; set; }
        public List<RoomCategoryInline>? RoomCategories { get; set; }
    }
}
