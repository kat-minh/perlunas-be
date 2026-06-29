using Cms.Repository.Entities;
using Cms.Repository.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class UserSeed
{
    public static void SeedUser(this EntityTypeBuilder<User> builder)
    {
        var now = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        builder.HasData(
            new User
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                Username = "admin",
                Email = "admin@perlunas.com",
                Role = UserRole.Admin,
                PasswordHash = "$2a$11$ZZdiHZrfp0DAW7P8s1Ww.exs3cFk.2bxXqyYJaKIE0yKAndch2A.i",
                CreatedAt = now,
                UpdatedAt = now,
            }
        );
    }
}
