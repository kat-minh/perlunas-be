using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class DepartureSchedule : BaseEntity<Guid>, IAuditableEntity
{
    public Guid ServiceId { get; set; }
    public string? StartTime { get; set; }
    public string? Code { get; set; }
    public string? Price { get; set; }
    public string? AccommodationStandards { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public Service Service { get; set; } = null!;
}
