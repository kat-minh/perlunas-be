using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class TaxonomySeed
{
    // Id cố định cho HasData — prefix 9999…, hai số cuối chạy 01..25.
    private static Guid Id(int n) => Guid.Parse($"99999999-9999-9999-9999-0000000000{n:D2}");

    private static Taxonomy Row(int n, string group, string name, int sort, string? slug = null, string? color = null) =>
        new()
        {
            Id = Id(n),
            Group = group,
            Name = name,
            Slug = slug,
            Color = color,
            // Nhóm "city": ảnh placeholder tạm (theo slug) — admin đổi ảnh thật sau.
            Image = group == "city" && slug != null ? $"https://picsum.photos/seed/perlunas-place-{slug}/800/1000" : null,
            SortOrder = sort,
            CreatedAt = SeedIds.CreatedAt,
            UpdatedAt = SeedIds.CreatedAt,
        };

    public static void SeedTaxonomy(this EntityTypeBuilder<Taxonomy> builder)
    {
        builder.HasData(
            // ── city (kèm slug cho deep-link ?noi-den=) ──
            Row(1, "city", "Hà Nội", 1, slug: "ha-noi"),
            Row(2, "city", "TP. Hồ Chí Minh", 2, slug: "ho-chi-minh"),
            Row(3, "city", "Hạ Long", 3, slug: "ha-long"),
            Row(4, "city", "Đà Lạt", 4, slug: "da-lat"),
            Row(5, "city", "Đà Nẵng", 5, slug: "da-nang"),
            Row(6, "city", "Phú Quốc", 6, slug: "phu-quoc"),
            Row(7, "city", "Nha Trang", 7, slug: "nha-trang"),
            Row(8, "city", "Huế", 8, slug: "hue"),
            Row(9, "city", "Sa Pa", 9, slug: "sa-pa"),

            // ── region ──
            Row(10, "region", "Miền Bắc", 1),
            Row(11, "region", "Miền Trung", 2),
            Row(12, "region", "Miền Nam", 3),
            Row(13, "region", "Tây Nguyên", 4),

            // ── stay-type ──
            Row(14, "stay-type", "Hotel", 1),
            Row(15, "stay-type", "Resort", 2),
            Row(16, "stay-type", "Retreat", 3),
            Row(17, "stay-type", "Wellness", 4),
            Row(18, "stay-type", "Boutique Hotel", 5),

            // ── tier (dòng ngọc) ──
            Row(19, "tier", "Akoya", 1),
            Row(20, "tier", "Tahiti", 2),
            Row(21, "tier", "South Sea", 3),

            // ── purpose (kèm màu chip) ──
            Row(22, "purpose", "Nghỉ dưỡng", 1, color: "#3F9D6B"),
            Row(23, "purpose", "Tham quan", 2, color: "#D6A12B"),
            Row(24, "purpose", "Công tác", 3, color: "#C24A33"),
            Row(25, "purpose", "Thăm thân", 4, color: "#8159A6")
        );
    }
}
