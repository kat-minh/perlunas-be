using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class PageContent : BaseEntity<Guid>, IAuditableEntity
{
    public string? Key { get; set; }
    public string Value { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public string Kind { get; set; } = "text";
    public int SortOrder { get; set; }

    public Guid? ParentId { get; set; }
    public PageContent? Parent { get; set; }
    public ICollection<PageContent> Children { get; set; } = new List<PageContent>();

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
