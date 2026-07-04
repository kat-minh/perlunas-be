using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class DepartureSchedule : BaseEntity<Guid>, IAuditableEntity
{
    public Guid ServiceId { get; set; }
    public string? StartTime { get; set; }
    public string? Code { get; set; }
    /// <summary>Giá bán (sau giảm) — hiển thị chính.</summary>
    public string? Price { get; set; }
    /// <summary>Giá gốc (trước giảm) — gạch ngang khi có khuyến mãi; null khi không giảm.</summary>
    public string? OriginalPrice { get; set; }
    public string? AccommodationStandards { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public Service Service { get; set; } = null!;
}
