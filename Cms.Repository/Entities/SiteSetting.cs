using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class SiteSetting : BaseEntity<Guid>, IAuditableEntity
{
    public string? Name { get; set; }
    public string? LegalName { get; set; }
    public string? Tagline { get; set; }
    public string? Manifesto { get; set; }
    public string? Description { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? TaxId { get; set; }
    public string? OfficesJson { get; set; }
    public string? SocialJson { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
