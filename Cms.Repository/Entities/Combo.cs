using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class Combo : BaseEntity<Guid>, IAuditableEntity
{
    public string Slug { get; set; } = string.Empty;

    public Guid HotelId { get; set; }
    public Hotel Hotel { get; set; } = null!;

    public Guid ComboTierId { get; set; }
    public ComboTier ComboTier { get; set; } = null!;

    public int Nights { get; set; }
    public string Price { get; set; } = string.Empty;
    public bool Featured { get; set; }
    public string Cover { get; set; } = string.Empty;
    public int SortOrder { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
