using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class SiteSettingSeed
{
    public static void SeedSiteSetting(this EntityTypeBuilder<SiteSetting> builder)
    {
        var now = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        builder.HasData(
            new SiteSetting
            {
                Id = Guid.Parse("20000000-0000-0000-0000-000000000001"),
                Name = "Perlunas",
                LegalName = "CÔNG TY DU LỊCH PERLUNAS",
                Tagline = "Mỗi hành trình là một viên ngọc dưới ánh trăng",
                Manifesto = "Chúng tôi không chỉ bán tour — chúng tôi tạo nên những kỷ niệm lấp lánh.",
                Description = "Perlunas là công ty du lịch Việt Nam chuyên thiết kế tour trọn gói, combo nghỉ dưỡng và đặt phòng khách sạn cao cấp.",
                Phone = "0900 000 000",
                Email = "xinchao@perlunas.vn",
                TaxId = "",
                OfficesJson = """[{"label":"Văn phòng TP.HCM","address":"123 Nguyễn Huệ, Phường Bến Nghé, Quận 1, TP.HCM"}]""",
                SocialJson = """[{"label":"Facebook","href":"https://facebook.com"},{"label":"Zalo","href":"https://zalo.me/0900000000"}]""",
                CreatedAt = now,
                UpdatedAt = now,
            }
        );
    }
}
