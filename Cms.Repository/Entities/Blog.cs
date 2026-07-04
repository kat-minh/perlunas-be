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

    /// <summary>Slug để mở bài viết theo URL (/blog/{slug}).</summary>
    public string? Slug { get; set; }
    /// <summary>Ảnh bìa bài viết.</summary>
    public string? Cover { get; set; }
    /// <summary>Nội dung bài viết dạng richtext (HTML) — admin soạn.</summary>
    public string? Content { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
