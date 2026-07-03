using Cms.Repository.Abtraction;
using Cms.Repository.Enums;

namespace Cms.Repository.Entities;

public class Service : BaseEntity<Guid>, IAuditableEntity
{
    public string? Title { get; set; }
    public string Slug { get; set; } = string.Empty;
    public bool BestSeller { get; set; }
    /// <summary>Tour: đánh dấu "Sắp ra mắt" — chưa cho xem chi tiết / hiện nhãn ở list.</summary>
    public bool ComingSoon { get; set; }
    public string? Introducetion { get; set; }
    public int? Day { get; set; }
    public int? Night { get; set; }
    /// <summary>
    /// Thời lượng dạng CHUỖI TỰ DO admin nhập (vd "3 ngày 2 đêm", "1 tuần",
    /// "cuối tuần"). Hiển thị nguyên văn trên site; Day/Night chỉ là parse phụ trợ.
    /// </summary>
    public string? DurationText { get; set; }
    public string? Label { get; set; }
    public string? Album { get; set; }
    public string? Region { get; set; }
    public string? Description { get; set; }
    public string? Infor { get; set; }
    public List<string> Highlight { get; set; } = new();
    /// <summary>Tour: các điểm đến (tên/slug tỉnh) — để gợi ý khách sạn tại nơi đến.</summary>
    public List<string> Destinations { get; set; } = new();
    /// <summary>Hotel: tiện nghi nổi bật (Wifi, Hồ bơi…) cấp khách sạn.</summary>
    public List<string> Facilities { get; set; } = new();
    /// <summary>Tour: nội dung "Điểm nổi bật" dạng richtext (HTML) admin tự soạn.</summary>
    public string? HighlightContent { get; set; }
    /// <summary>
    /// Tour: nội dung 4 ô "Thông tin chính về chuyến đi" (Lưu trú/Tham quan/Ăn uống/
    /// Di chuyển) — lưu JSON {"stay","sightsee","food","transport"}. Tiêu đề 4 ô là
    /// cố định (page-content); chỉ phần nội dung khác nhau theo từng tour.
    /// </summary>
    public string? TripInfoJson { get; set; }
    /// <summary>Giá hiển thị dạng chuỗi (vd "từ 2.890.000đ") — dùng cho thẻ/vé.</summary>
    public string? PriceText { get; set; }
    /// <summary>Tour: đơn vị giá admin nhập (vd "/ khách", "/ đoàn"). Trống → FE dùng mặc định.</summary>
    public string? PriceUnit { get; set; }
    /// <summary>
    /// Combo: giá bán gói (chuỗi số, vd "2200000"). Combo bán theo GÓI nên có giá
    /// riêng ở cấp dịch vụ — hạng phòng của combo chỉ mô tả, KHÔNG mang giá.
    /// </summary>
    public string? Price { get; set; }
    /// <summary>Combo: giá gốc trước giảm (để gạch ngang + tính % giảm). Trống nếu không giảm.</summary>
    public string? OriginalPrice { get; set; }
    public string? Code { get; set; }
    public string? Instruct { get; set; }
    public string? Feature { get; set; }
    public ServiceType Type { get; set; }
    public bool IsPublic { get; set; }
    /// <summary>Tham chiếu danh mục nhóm "purpose" (theo Name). Trước là enum.</summary>
    public string? PurposeOfTrip { get; set; }
    /// <summary>Tham chiếu danh mục nhóm "city" (theo Name).</summary>
    public string? Destination { get; set; }
    /// <summary>Tham chiếu danh mục nhóm "stay-type" (theo Name).</summary>
    public string? Form { get; set; }
    /// <summary>Tham chiếu danh mục nhóm "tier" (theo Name). Trước là enum.</summary>
    public string? Classify { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
    public ICollection<RoomCategory> RoomCategories { get; set; } = new List<RoomCategory>();
    public ICollection<DepartureSchedule> DepartureSchedules { get; set; } = new List<DepartureSchedule>();
    public ICollection<ImportantInfor> ImportantInfors { get; set; } = new List<ImportantInfor>();
}
