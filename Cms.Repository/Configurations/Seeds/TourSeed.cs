using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class TourSeed
{
    public static void SeedTour(this EntityTypeBuilder<Tour> builder)
    {
        var now = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        builder.HasData(
            new Tour
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000001"),
                Slug = "da-lat",
                Name = "Đà Lạt mộng mơ",
                TaxonomyId = Guid.Parse("70000000-0000-0000-0000-000000000008"),
                Nights = "3 ngày 2 đêm",
                Price = "từ 2.890.000đ",
                Teaser = "Ba ngày giữa rừng thông và sương sớm trên cao nguyên.",
                Highlights = new() { "Săn mây Cầu Đất lúc bình minh", "Vườn hồng và đồi chè Cầu Đất", "Cà phê giữa rừng thông", "Chợ đêm và ẩm thực phố núi" },
                Stays = new() { "da-lat" },
                Featured = false,
                SortOrder = 1,
                Cover = "https://picsum.photos/seed/da-lat/1200/800",
                CreatedAt = now,
                UpdatedAt = now,
            },
            new Tour
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000002"),
                Slug = "phu-quoc",
                Name = "Phú Quốc đảo ngọc",
                TaxonomyId = Guid.Parse("70000000-0000-0000-0000-00000000000a"),
                Nights = "3 ngày 2 đêm",
                Price = "từ 3.690.000đ",
                Teaser = "Biển trong vắt, san hô và hoàng hôn rực rỡ phương Nam.",
                Highlights = new() { "Cáp treo Hòn Thơm dài nhất thế giới", "Lặn ngắm san hô 3 đảo", "Hoàng hôn bãi Sao", "Chợ đêm hải sản" },
                Stays = new() { "phu-quoc" },
                Featured = false,
                SortOrder = 2,
                Cover = "https://picsum.photos/seed/phu-quoc/1200/800",
                CreatedAt = now,
                UpdatedAt = now,
            },
            new Tour
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000003"),
                Slug = "ha-noi-sapa",
                Name = "Hà Nội Sa Pa",
                TaxonomyId = Guid.Parse("70000000-0000-0000-0000-000000000001"),
                Nights = "4 ngày 3 đêm",
                Price = "từ 4.290.000đ",
                Teaser = "Từ phố cổ ngàn năm tới ruộng bậc thang và đỉnh Fansipan.",
                Highlights = new() { "Phố cổ Hà Nội và Hồ Gươm", "Ruộng bậc thang Mường Hoa", "Cáp treo Fansipan", "Bản làng người Mông, người Dao" },
                Stays = new() { "ha-noi", "sa-pa" },
                Featured = false,
                SortOrder = 3,
                Cover = "https://picsum.photos/seed/ha-noi-sapa/1200/800",
                CreatedAt = now,
                UpdatedAt = now,
            },
            new Tour
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000004"),
                Slug = "da-nang-hoi-an",
                Name = "Đà Nẵng Hội An",
                TaxonomyId = Guid.Parse("70000000-0000-0000-0000-000000000005"),
                Nights = "3 ngày 2 đêm",
                Price = "từ 3.190.000đ",
                Teaser = "Cầu Vàng, phố Hội lồng đèn và bãi biển Mỹ Khê.",
                Highlights = new() { "Cầu Vàng Bà Nà Hills", "Phố cổ Hội An về đêm", "Thả đèn hoa đăng sông Hoài", "Biển Mỹ Khê" },
                Stays = new() { "da-nang" },
                Featured = false,
                SortOrder = 4,
                Cover = "https://picsum.photos/seed/da-nang-hoi-an/1200/800",
                CreatedAt = now,
                UpdatedAt = now,
            },
            new Tour
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000005"),
                Slug = "nha-trang",
                Name = "Nha Trang biển xanh",
                TaxonomyId = Guid.Parse("70000000-0000-0000-0000-000000000009"),
                Nights = "3 ngày 2 đêm",
                Price = "từ 2.990.000đ",
                Teaser = "Vịnh biển trong xanh và những hòn đảo gần bờ.",
                Highlights = new() { "Khám phá đảo Hòn Mun", "Tắm bùn khoáng", "Vịnh Nha Trang", "Ẩm thực biển" },
                Stays = new() { "nha-trang" },
                Featured = false,
                SortOrder = 5,
                Cover = "https://picsum.photos/seed/nha-trang/1200/800",
                CreatedAt = now,
                UpdatedAt = now,
            }
        );
    }
}
