using Cms.Repository.Enums;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

/// <summary>
/// Lịch khởi hành mẫu cho 5 tour VN. Price/OriginalPrice là chuỗi số (đồng),
/// FE tự format; OriginalPrice != null → giá gạch (khuyến mãi). Giá thấp nhất
/// mỗi tour khớp với PriceText "từ …" ở ServiceSeed. GUID prefix `dddd000{t}`
/// theo tour (1=da-lat 2=phu-quoc 3=ha-noi-sapa 4=da-nang-hoi-an 5=nha-trang).
/// </summary>
public static class DepartureScheduleSeed
{
    private static readonly System.Guid DaLat = System.Guid.Parse("af94c02c-15b7-9e87-ba8e-9f5266c55668");
    private static readonly System.Guid PhuQuoc = System.Guid.Parse("6b16f002-c173-9ada-ef84-72abcdda571b");
    private static readonly System.Guid HaNoiSapa = System.Guid.Parse("a3f73676-e4fd-a5e7-f98c-1b46064d1f56");
    private static readonly System.Guid DaNang = System.Guid.Parse("04d243a2-c184-4e32-6ebd-bf055b3d82f3");
    private static readonly System.Guid NhaTrang = System.Guid.Parse("509ea0b0-c67f-5e1f-cdcb-52dd26a40771");

    private static DepartureSchedule Dep(string id, System.Guid svc, string date, string code,
        string price, string? originalPrice, string stay) => new()
    {
        Id = System.Guid.Parse(id),
        ServiceId = svc,
        StartTime = date,
        Code = code,
        Price = price,
        OriginalPrice = originalPrice,
        AccommodationStandards = stay,
        CreatedAt = SeedIds.CreatedAt,
        UpdatedAt = SeedIds.CreatedAt,
    };

    public static void SeedDepartureSchedule(this EntityTypeBuilder<DepartureSchedule> builder)
    {
        builder.HasData(
            // ── Đà Lạt (từ 2.890.000đ) ──
            Dep("dddd0001-0000-0000-0000-000000000001", DaLat, "2026-07-12", "PL-DL-0712", "2890000", null, "Khách sạn 3 sao"),
            Dep("dddd0001-0000-0000-0000-000000000002", DaLat, "2026-08-09", "PL-DL-0809", "2990000", "3290000", "Khách sạn 4 sao"),
            Dep("dddd0001-0000-0000-0000-000000000003", DaLat, "2026-09-13", "PL-DL-0913", "3190000", "3490000", "Resort 4 sao"),
            Dep("dddd0001-0000-0000-0000-000000000004", DaLat, "2026-10-11", "PL-DL-1011", "3390000", null, "Resort 4 sao"),
            Dep("dddd0001-0000-0000-0000-000000000005", DaLat, "2026-11-08", "PL-DL-1108", "2890000", "3190000", "Khách sạn 4 sao"),

            // ── Phú Quốc (từ 3.690.000đ) ──
            Dep("dddd0002-0000-0000-0000-000000000001", PhuQuoc, "2026-07-19", "PL-PQ-0719", "3690000", null, "Khách sạn 4 sao"),
            Dep("dddd0002-0000-0000-0000-000000000002", PhuQuoc, "2026-08-16", "PL-PQ-0816", "3890000", "4290000", "Resort 4 sao"),
            Dep("dddd0002-0000-0000-0000-000000000003", PhuQuoc, "2026-09-20", "PL-PQ-0920", "3690000", "4090000", "Resort 4 sao"),
            Dep("dddd0002-0000-0000-0000-000000000004", PhuQuoc, "2026-10-18", "PL-PQ-1018", "4190000", null, "Resort 5 sao"),
            Dep("dddd0002-0000-0000-0000-000000000005", PhuQuoc, "2026-11-15", "PL-PQ-1115", "3990000", "4490000", "Resort 5 sao"),

            // ── Hà Nội – Sa Pa (từ 4.290.000đ, 4N3Đ) ──
            Dep("dddd0003-0000-0000-0000-000000000001", HaNoiSapa, "2026-07-24", "PL-HS-0724", "4290000", null, "Khách sạn 3 sao"),
            Dep("dddd0003-0000-0000-0000-000000000002", HaNoiSapa, "2026-08-21", "PL-HS-0821", "4490000", "4890000", "Khách sạn 4 sao"),
            Dep("dddd0003-0000-0000-0000-000000000003", HaNoiSapa, "2026-09-18", "PL-HS-0918", "4690000", "5090000", "Khách sạn 4 sao"),
            Dep("dddd0003-0000-0000-0000-000000000004", HaNoiSapa, "2026-10-16", "PL-HS-1016", "4990000", null, "Resort 4 sao"),
            Dep("dddd0003-0000-0000-0000-000000000005", HaNoiSapa, "2026-11-13", "PL-HS-1113", "4290000", "4790000", "Khách sạn 4 sao"),

            // ── Đà Nẵng – Hội An (từ 3.190.000đ) ──
            Dep("dddd0004-0000-0000-0000-000000000001", DaNang, "2026-07-17", "PL-DN-0717", "3190000", null, "Khách sạn 4 sao"),
            Dep("dddd0004-0000-0000-0000-000000000002", DaNang, "2026-08-14", "PL-DN-0814", "3390000", "3790000", "Resort 4 sao"),
            Dep("dddd0004-0000-0000-0000-000000000003", DaNang, "2026-09-11", "PL-DN-0911", "3190000", "3590000", "Resort 4 sao"),
            Dep("dddd0004-0000-0000-0000-000000000004", DaNang, "2026-10-09", "PL-DN-1009", "3690000", null, "Resort 5 sao"),
            Dep("dddd0004-0000-0000-0000-000000000005", DaNang, "2026-11-06", "PL-DN-1106", "3290000", "3690000", "Resort 4 sao"),

            // ── Nha Trang (từ 2.990.000đ) ──
            Dep("dddd0005-0000-0000-0000-000000000001", NhaTrang, "2026-07-11", "PL-NT-0711", "2990000", null, "Khách sạn 4 sao"),
            Dep("dddd0005-0000-0000-0000-000000000002", NhaTrang, "2026-08-08", "PL-NT-0808", "3190000", "3590000", "Resort 4 sao"),
            Dep("dddd0005-0000-0000-0000-000000000003", NhaTrang, "2026-09-12", "PL-NT-0912", "2990000", "3390000", "Resort 4 sao"),
            Dep("dddd0005-0000-0000-0000-000000000004", NhaTrang, "2026-10-10", "PL-NT-1010", "3490000", null, "Resort 5 sao"),
            Dep("dddd0005-0000-0000-0000-000000000005", NhaTrang, "2026-11-07", "PL-NT-1107", "3090000", "3490000", "Resort 4 sao")
        );
    }
}
