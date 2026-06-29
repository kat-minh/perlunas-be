using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class SiteSetting : BaseEntity<Guid>, IAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string LegalName { get; set; } = string.Empty;
    public string Tagline { get; set; } = string.Empty;
    public string Manifesto { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string TaxId { get; set; } = string.Empty;
    public string OfficesJson { get; set; } = "[]";
    public string SocialJson { get; set; } = "[]";

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
