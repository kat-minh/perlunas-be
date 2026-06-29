using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class ComboTier : BaseEntity<Guid>, IAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Tagline { get; set; } = string.Empty;
    public string Pearl { get; set; } = string.Empty;
    public string Story { get; set; } = string.Empty;
    public List<string> Includes { get; set; } = new();
    public int SortOrder { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public ICollection<Combo> Combos { get; set; } = new List<Combo>();
}
