using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class SiteSettingSeed
{
    public static void SeedSiteSetting(this EntityTypeBuilder<SiteSetting> builder)
    {
        builder.HasData(
            new SiteSetting { Id = SeedIds.SiteMain, Name = "Perlunas", LegalName = "Công ty TNHH Du lịch Perlunas", Tagline = "Mỗi hành trình là một viên ngọc dưới ánh trăng", Manifesto = "Sample manifesto.", Description = "Perlunas thiết kế những hành trình du lịch trong nước tinh tế và trọn vẹn: tour trọn gói, đặt phòng khách sạn, gói du lịch, tour đoàn và tour riêng theo yêu cầu.", Phone = "0900 000 000", Email = "xinchao@perlunas.vn", TaxId = "0123456789", OfficesJson = "[]", SocialJson = "{}", CreatedAt = SeedIds.CreatedAt, UpdatedAt = SeedIds.CreatedAt });
    }
}
