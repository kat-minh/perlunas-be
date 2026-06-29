using Cms.Repository.Abtraction;

namespace Cms.Repository.Entities;

public class RefreshToken : BaseEntity<Guid>, IAuditableEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public string Token { get; set; } = string.Empty;
    public DateTime ExpiresAt { get; set; }
    public bool IsRevoked { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
