using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class ImportantInfor : BaseEntity<Guid>, IAuditableEntity
{
    public Guid ServiceId { get; set; }
    public string? Title { get; set; }
    public string? SubTitle { get; set; }
    public string? Description { get; set; }

    /// <summary>Thứ tự hiển thị (theo mảng admin nhập) — đọc sắp theo cột này để
    /// giữ đúng thứ tự các khối "Thông tin quan trọng" sau mỗi lần cập nhật.</summary>
    public int SortOrder { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public Service Service { get; set; } = null!;
}
