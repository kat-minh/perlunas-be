using Cms.Repository.Entities;
using Cms.Repository.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class TourCardSeed
{
    public static void SeedTourCard(this EntityTypeBuilder<TourCard> builder)
    {
        var now = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        builder.HasData(
            // Group tours
            new TourCard { Id = Guid.Parse("80000000-0000-0000-0000-000000000001"), Type = TourCardType.Group, Title = "Tour đoàn doanh nghiệp (Team Building)", Image = "https://picsum.photos/seed/group-teambuilding/1200/800", Description = "Chương trình team building biển đảo, gắn kết đội ngũ với các hoạt động vận động và gala dinner.", SortOrder = 1, CreatedAt = now, UpdatedAt = now },
            new TourCard { Id = Guid.Parse("80000000-0000-0000-0000-000000000002"), Type = TourCardType.Group, Title = "Tour đoàn học sinh – sinh viên", Image = "https://picsum.photos/seed/group-student/1200/800", Description = "Hành trình trải nghiệm giáo dục, về nguồn và khám phá di sản phù hợp cho các trường học.", SortOrder = 2, CreatedAt = now, UpdatedAt = now },
            new TourCard { Id = Guid.Parse("80000000-0000-0000-0000-000000000003"), Type = TourCardType.Group, Title = "Tour đoàn tri ân khách hàng", Image = "https://picsum.photos/seed/group-vip/1200/800", Description = "Lịch trình nghỉ dưỡng cao cấp dành cho các chương trình tri ân, hội nghị khách hàng quy mô lớn.", SortOrder = 3, CreatedAt = now, UpdatedAt = now },
            // Private tours
            new TourCard { Id = Guid.Parse("90000000-0000-0000-0000-000000000001"), Type = TourCardType.Private, Title = "Tour riêng tư cặp đôi (Honeymoon)", Image = "https://picsum.photos/seed/private-honeymoon/1200/800", Description = "Hành trình lãng mạn được thiết kế riêng cho các cặp đôi với dịch vụ trọn gói và không gian riêng tư.", SortOrder = 1, CreatedAt = now, UpdatedAt = now },
            new TourCard { Id = Guid.Parse("90000000-0000-0000-0000-000000000002"), Type = TourCardType.Private, Title = "Tour riêng tư gia đình", Image = "https://picsum.photos/seed/private-family/1200/800", Description = "Lịch trình linh hoạt phù hợp mọi lứa tuổi, có hướng dẫn viên và xe riêng cho cả gia đình.", SortOrder = 2, CreatedAt = now, UpdatedAt = now },
            new TourCard { Id = Guid.Parse("90000000-0000-0000-0000-000000000003"), Type = TourCardType.Private, Title = "Tour riêng tư cao cấp (Luxury)", Image = "https://picsum.photos/seed/private-luxury/1200/800", Description = "Trải nghiệm thượng lưu với khách sạn 5 sao, chuyên cơ và quản gia riêng cho hành trình đẳng cấp.", SortOrder = 3, CreatedAt = now, UpdatedAt = now },
            new TourCard { Id = Guid.Parse("90000000-0000-0000-0000-000000000004"), Type = TourCardType.Private, Title = "Tour riêng tư khám phá (Adventure)", Image = "https://picsum.photos/seed/private-adventure/1200/800", Description = "Dành cho người ưa mạo hiểm: trekking, chèo kayak và cắm trại tại những điểm đến hoang sơ.", SortOrder = 4, CreatedAt = now, UpdatedAt = now }
        );
    }
}
