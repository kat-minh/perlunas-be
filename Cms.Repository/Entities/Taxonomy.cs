using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

/// <summary>
/// Danh mục dùng chung cho các ô chọn (selection) của site — gom mọi nhóm vào 1
/// bảng, phân biệt bằng <see cref="Group"/>: "city" | "region" | "stay-type" |
/// "tier" | "purpose". Admin quản lý danh sách; Service tham chiếu theo Name.
/// </summary>
public class Taxonomy : BaseEntity<Guid>, IAuditableEntity
{
    /// <summary>Nhóm danh mục: city | region | stay-type | tier | purpose.</summary>
    public string Group { get; set; } = string.Empty;

    /// <summary>Tên hiển thị, vd "Đà Nẵng", "Miền Trung", "Resort", "Akoya".</summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>Slug — chỉ nhóm "city" cần (deep-link ?noi-den=da-nang).</summary>
    public string? Slug { get; set; }

    /// <summary>Màu chip — chỉ nhóm "purpose" cần, vd "#3F9D6B".</summary>
    public string? Color { get; set; }

    /// <summary>Ảnh — chỉ nhóm "city" cần (ô "vùng đất" ở trang chủ).</summary>
    public string? Image { get; set; }

    public int SortOrder { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
