using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class Tour : BaseEntity<Guid>, IAuditableEntity
{
    public string Slug { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Nights { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Teaser { get; set; } = string.Empty;
    public List<string> Highlights { get; set; } = new();
    public List<string> Stays { get; set; } = new();
    public string Cover { get; set; } = string.Empty;
    public bool Featured { get; set; }
    public int SortOrder { get; set; }

    public Guid TaxonomyId { get; set; }
    public Taxonomy Taxonomy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
