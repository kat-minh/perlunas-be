using Cms.Repository.Abtraction;
using Cms.Repository.Enums;

namespace Cms.Repository.Entities;

public class Taxonomy : BaseEntity<Guid>, IAuditableEntity
{
    public TaxonomyGroup Group { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public int SortOrder { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public ICollection<HotelTaxonomyDetails> HotelTaxonomyDetails { get; set; } = new List<HotelTaxonomyDetails>();
    public ICollection<Tour> Tours { get; set; } = new List<Tour>();
}
