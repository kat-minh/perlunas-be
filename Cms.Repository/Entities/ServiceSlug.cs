using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

/// <summary>
/// A URL slug that belongs to a service. Exactly one slug per service is
/// canonical; all other rows preserve previously published URLs.
/// </summary>
public class ServiceSlug : IAuditableEntity
{
    public Guid Id { get; set; }
    public Guid ServiceId { get; set; }
    public string Slug { get; set; } = string.Empty;
    public bool IsCanonical { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? RetiredAt { get; set; }

    public Service Service { get; set; } = null!;
}
