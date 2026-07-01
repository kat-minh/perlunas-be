using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class PageContent : BaseEntity<Guid>, IAuditableEntity
{
    public Guid? ParentId { get; set; }
    public string? PageKey { get; set; }
    public string? SectionKey { get; set; }
    public string? Key { get; set; }
    public string? ContentValue { get; set; }
    public string? Label { get; set; }
    public string? Kind { get; set; }
    public int? SoftOrder { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public PageContent? Parent { get; set; }
    public ICollection<PageContent> Children { get; set; } = new List<PageContent>();
}
