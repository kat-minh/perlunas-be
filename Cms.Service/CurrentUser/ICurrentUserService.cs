namespace Cms.Service.CurrentUser;

public interface ICurrentUserService
{
    Guid? UserId { get; }
    string? Email { get; }
    string? FullName { get; }
    string? Avatar { get; }
    bool IsVerified { get; }
    Guid GetRequiredUserId();
}
