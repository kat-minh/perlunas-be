using Cms.Repository.Abtraction;
using Cms.Repository.Enums;

namespace Cms.Repository.Entities;

public class User : BaseEntity<Guid>, IAuditableEntity
{
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public UserRole Role { get; set; } = UserRole.Admin;

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
