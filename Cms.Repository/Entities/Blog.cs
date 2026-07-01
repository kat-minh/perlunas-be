using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class Blog : BaseEntity<Guid>, IAuditableEntity
{
    public string? Titile { get; set; }
    public string? SubTitile { get; set; }
    public string? Author { get; set; }
    public string? ReadingTime { get; set; }
    public string? Description { get; set; }
    public string? Tag { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
