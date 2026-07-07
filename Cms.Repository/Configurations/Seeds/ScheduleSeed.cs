using Cms.Repository.Enums;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

/// <summary>
/// Hành trình (itinerary) từng ngày cho 5 tour VN. Day = nhãn "Ngày N",
/// Sumary = suất ăn trong ngày, Description = mô tả. GUID prefix `cccc000{t}`.
/// </summary>
public static class ScheduleSeed
{
    private static readonly System.Guid DaLat = System.Guid.Parse("af94c02c-15b7-9e87-ba8e-9f5266c55668");
    private static readonly System.Guid PhuQuoc = System.Guid.Parse("6b16f002-c173-9ada-ef84-72abcdda571b");
    private static readonly System.Guid HaNoiSapa = System.Guid.Parse("a3f73676-e4fd-a5e7-f98c-1b46064d1f56");
    private static readonly System.Guid DaNang = System.Guid.Parse("04d243a2-c184-4e32-6ebd-bf055b3d82f3");
    private static readonly System.Guid NhaTrang = System.Guid.Parse("509ea0b0-c67f-5e1f-cdcb-52dd26a40771");

    private static Schedule Day(string id, System.Guid svc, string day, string title, string meals, string desc, int order) => new()
    {
        Id = System.Guid.Parse(id),
        ServiceId = svc,
        Day = day,
        Titile = title,
        Sumary = meals,
        Description = desc,
        SortOrder = order,
        CreatedAt = SeedIds.CreatedAt,
        UpdatedAt = SeedIds.CreatedAt,
    };

    public static void SeedSchedule(this EntityTypeBuilder<Schedule> builder)
    {
        builder.HasData(
            // ── Đà Lạt (3N2Đ) ──
            Day("cccc0001-0000-0000-0000-000000000001", DaLat, "Ngày 1", "TP.HCM – Đà Lạt", "Ăn trưa, tối",
                "Khởi hành sáng sớm đi Đà Lạt. Nhận phòng, dùng bữa trưa, chiều dạo Quảng trường Lâm Viên và hồ Xuân Hương. Tối tự do khám phá chợ đêm phố núi.", 0),
            Day("cccc0001-0000-0000-0000-000000000002", DaLat, "Ngày 2", "Săn mây Cầu Đất – đồi chè", "Ăn sáng, trưa, tối",
                "Dậy sớm săn mây tại Cầu Đất, tham quan đồi chè và vườn hồng. Chiều ghé làng Cù Lần, thưởng thức cà phê giữa rừng thông.", 1),
            Day("cccc0001-0000-0000-0000-000000000003", DaLat, "Ngày 3", "Đà Lạt – TP.HCM", "Ăn sáng, trưa",
                "Tham quan vườn hoa thành phố, mua đặc sản làm quà. Trả phòng, dùng bữa trưa và khởi hành về TP.HCM, kết thúc hành trình.", 2),

            // ── Phú Quốc (3N2Đ) ──
            Day("cccc0002-0000-0000-0000-000000000001", PhuQuoc, "Ngày 1", "Đến Phú Quốc – Nam đảo", "Ăn trưa, tối",
                "Đón tại sân bay, nhận phòng. Chiều tham quan Nam đảo: nhà thùng nước mắm, cơ sở ngọc trai. Tối dạo chợ đêm hải sản Dương Đông.", 0),
            Day("cccc0002-0000-0000-0000-000000000002", PhuQuoc, "Ngày 2", "Cáp treo Hòn Thơm – lặn san hô", "Ăn sáng, trưa, tối",
                "Trải nghiệm cáp treo Hòn Thơm dài nhất thế giới, tắm biển và lặn ngắm san hô 3 đảo. Chiều ngắm hoàng hôn tại bãi Sao.", 1),
            Day("cccc0002-0000-0000-0000-000000000003", PhuQuoc, "Ngày 3", "Tự do – Tiễn sân bay", "Ăn sáng",
                "Buổi sáng tự do nghỉ dưỡng, tắm biển. Trả phòng, mua đặc sản và ra sân bay, kết thúc chuyến đi.", 2),

            // ── Hà Nội – Sa Pa (4N3Đ) ──
            Day("cccc0003-0000-0000-0000-000000000001", HaNoiSapa, "Ngày 1", "Đến Hà Nội – phố cổ", "Ăn tối",
                "Đón tại sân bay Nội Bài, nhận phòng. Dạo phố cổ Hà Nội, hồ Hoàn Kiếm, thưởng thức ẩm thực 36 phố phường.", 0),
            Day("cccc0003-0000-0000-0000-000000000002", HaNoiSapa, "Ngày 2", "Hà Nội – Sa Pa", "Ăn sáng, trưa, tối",
                "Khởi hành đi Sa Pa theo cao tốc. Nhận phòng, chiều tham quan bản Cát Cát, tìm hiểu văn hoá người Mông.", 1),
            Day("cccc0003-0000-0000-0000-000000000003", HaNoiSapa, "Ngày 3", "Chinh phục Fansipan", "Ăn sáng, trưa, tối",
                "Đi cáp treo chinh phục đỉnh Fansipan 3.143m. Chiều ngắm ruộng bậc thang Mường Hoa, dạo thị trấn trong sương.", 2),
            Day("cccc0003-0000-0000-0000-000000000004", HaNoiSapa, "Ngày 4", "Sa Pa – Hà Nội – tiễn", "Ăn sáng, trưa",
                "Trả phòng, về Hà Nội. Mua quà đặc sản và ra sân bay, kết thúc hành trình Tây Bắc.", 3),

            // ── Đà Nẵng – Hội An (3N2Đ) ──
            Day("cccc0004-0000-0000-0000-000000000001", DaNang, "Ngày 1", "Đến Đà Nẵng – Sơn Trà", "Ăn tối",
                "Đón sân bay, nhận phòng. Chiều tham quan bán đảo Sơn Trà, chùa Linh Ứng. Tối dạo cầu Rồng và sông Hàn.", 0),
            Day("cccc0004-0000-0000-0000-000000000002", DaNang, "Ngày 2", "Bà Nà – Cầu Vàng", "Ăn sáng, trưa, tối",
                "Cả ngày khám phá Bà Nà Hills: Cầu Vàng, Làng Pháp, hầm rượu. Chiều về tắm biển Mỹ Khê.", 1),
            Day("cccc0004-0000-0000-0000-000000000003", DaNang, "Ngày 3", "Phố cổ Hội An – tiễn", "Ăn sáng, trưa",
                "Sáng tham quan phố cổ Hội An, chùa Cầu, thả đèn hoa đăng. Trả phòng, mua đặc sản và ra sân bay.", 2),

            // ── Nha Trang (3N2Đ) ──
            Day("cccc0005-0000-0000-0000-000000000001", NhaTrang, "Ngày 1", "Đến Nha Trang – tắm bùn", "Ăn tối",
                "Đón sân bay Cam Ranh, nhận phòng. Chiều trải nghiệm tắm bùn khoáng nóng, thư giãn. Tối dạo phố biển.", 0),
            Day("cccc0005-0000-0000-0000-000000000002", NhaTrang, "Ngày 2", "Tour 4 đảo – vịnh Nha Trang", "Ăn sáng, trưa, tối",
                "Du thuyền tham quan vịnh Nha Trang, tắm biển và lặn ngắm san hô. Chiều vui chơi tại khu giải trí trên đảo.", 1),
            Day("cccc0005-0000-0000-0000-000000000003", NhaTrang, "Ngày 3", "Tháp Bà – tiễn sân bay", "Ăn sáng",
                "Tham quan Tháp Bà Ponagar, nhà thờ Núi. Trả phòng, mua đặc sản biển và ra sân bay, kết thúc chuyến đi.", 2)
        );

        // ── Combo: lịch trình nghỉ dưỡng theo số ngày mỗi combo ──
        var comboScheds = new System.Collections.Generic.List<Schedule>();
        foreach (var c in ComboSeedData.All)
        {
            for (int d = 1; d <= c.Days; d++)
            {
                string title, meals, desc;
                if (d == 1)
                {
                    title = $"Đến {c.City} – nhận phòng";
                    meals = "Ăn theo tiêu chuẩn gói";
                    desc = $"Quý khách đến {c.City}, làm thủ tục nhận phòng tại {c.Hotel}. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.";
                }
                else if (d == c.Days)
                {
                    title = $"{c.City} – trả phòng";
                    meals = "Ăn sáng tại khách sạn";
                    desc = "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.";
                }
                else
                {
                    title = $"Tự do tại {c.City}";
                    meals = "Ăn sáng tại khách sạn";
                    desc = $"Tự do tận hưởng {c.Hotel} hoặc khám phá {c.City} theo sở thích. Perlunas sẵn sàng gợi ý điểm tham quan, ẩm thực và trải nghiệm địa phương.";
                }
                comboScheds.Add(new Schedule
                {
                    Id = System.Guid.Parse($"cbbb00{c.Ci:D2}-0000-0000-0000-0000000000{d:D2}"),
                    ServiceId = c.Id,
                    Day = $"Ngày {d}",
                    Titile = title,
                    Sumary = meals,
                    Description = desc,
                    SortOrder = d - 1,
                    CreatedAt = SeedIds.CreatedAt,
                    UpdatedAt = SeedIds.CreatedAt,
                });
            }
        }
        builder.HasData(comboScheds);
    }
}
