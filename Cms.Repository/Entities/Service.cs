using Cms.Repository.Abtraction;
using Cms.Repository.Enums;

namespace Cms.Repository.Entities;

public class Service : BaseEntity<Guid>, IAuditableEntity
{
    public string? Title { get; set; }
    public string Slug { get; set; } = string.Empty;
    public bool BestSeller { get; set; }
    public string? Introducetion { get; set; }
    public int? Day { get; set; }
    public int? Night { get; set; }
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
    /// <summary>Giá hiển thị dạng chuỗi (vd "từ 2.890.000đ") — dùng cho thẻ/vé.</summary>
    public string? PriceText { get; set; }
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
    
    public ICollection<Form>  Forms { get; set; } = new List<Form>();
}
