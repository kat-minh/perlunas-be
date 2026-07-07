using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class Schedule : BaseEntity<Guid>, IAuditableEntity
{
    public Guid ServiceId { get; set; }
    public string? Day { get; set; }
    public string? Titile { get; set; }
    public string? Sumary { get; set; }
    public string? Description { get; set; }

    /// <summary>Thứ tự hiển thị (theo mảng admin nhập). Đọc sắp theo cột này để
    /// giữ đúng thứ tự lịch trình sau mỗi lần cập nhật.</summary>
    public int SortOrder { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public Service Service { get; set; } = null!;
}
