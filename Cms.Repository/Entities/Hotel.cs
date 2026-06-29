using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class Hotel : BaseEntity<Guid>, IAuditableEntity
{
    public string Slug { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;

    public string Price { get; set; } = string.Empty;
    public string Desc { get; set; } = string.Empty;
    public bool Featured { get; set; }
    public string Cover { get; set; } = string.Empty;
    public int SortOrder { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public ICollection<Combo> Combos { get; set; } = new List<Combo>();
    public ICollection<HotelTaxonomyDetails> HotelTaxonomyDetails { get; set; } = new List<HotelTaxonomyDetails>();
}
