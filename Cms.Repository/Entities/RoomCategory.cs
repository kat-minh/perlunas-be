using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class RoomCategory : BaseEntity<Guid>, IAuditableEntity
{
    public Guid ServiceId { get; set; }
    public string? Album { get; set; }
    public string? Titile { get; set; }
    public int? NumberOfCustomer { get; set; }
    public string? Acreage { get; set; }
    public string? NumberOfBed { get; set; }
    public string? Description { get; set; }
    public string? Feature { get; set; }
    public string? Price { get; set; }
    public string? OriginalPrice { get; set; }
    public string? Unit { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public Service Service { get; set; } = null!;
}
