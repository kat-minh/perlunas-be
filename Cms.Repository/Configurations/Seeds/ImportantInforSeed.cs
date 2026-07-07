using Cms.Repository.Enums;
using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

/// <summary>
/// Thông tin quan trọng (điều khoản) cho 5 tour VN. Mỗi tour dùng chung 5 khối
/// chuẩn ngành; Description "mỗi dòng một ý" (FE tách dòng thành gạch đầu dòng).
/// GUID prefix `eeee000{t}` theo tour.
/// </summary>
public static class ImportantInforSeed
{
    private static readonly (System.Guid Id, int T)[] Tours =
    {
        (System.Guid.Parse("af94c02c-15b7-9e87-ba8e-9f5266c55668"), 1), // da-lat
        (System.Guid.Parse("6b16f002-c173-9ada-ef84-72abcdda571b"), 2), // phu-quoc
        (System.Guid.Parse("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), 3), // ha-noi-sapa
        (System.Guid.Parse("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), 4), // da-nang-hoi-an
        (System.Guid.Parse("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), 5), // nha-trang
    };

    private static readonly (string Title, string Desc)[] Blocks =
    {
        ("Giá bao gồm",
            "Xe du lịch đời mới đưa đón theo chương trình\n" +
            "Khách sạn/resort theo tiêu chuẩn đã chọn (2 khách/phòng)\n" +
            "Các bữa ăn theo chương trình\n" +
            "Vé tham quan các điểm ghi trong lịch trình\n" +
            "Hướng dẫn viên nhiệt tình, kinh nghiệm\n" +
            "Bảo hiểm du lịch theo quy định"),
        ("Giá không bao gồm",
            "Vé máy bay khứ hồi (nếu có)\n" +
            "Chi phí cá nhân, đồ uống ngoài chương trình\n" +
            "Phụ thu phòng đơn\n" +
            "Tiền tip cho hướng dẫn viên và tài xế\n" +
            "Thuế VAT xuất hoá đơn (nếu khách yêu cầu)"),
        ("Chính sách trẻ em",
            "Trẻ dưới 5 tuổi: miễn phí, gia đình tự lo chi phí (ngủ ghép cùng bố mẹ)\n" +
            "Trẻ 5–10 tuổi: tính 50% giá tour, ngủ ghép cùng bố mẹ\n" +
            "Trẻ từ 11 tuổi: tính như người lớn, tiêu chuẩn đầy đủ\n" +
            "Hai người lớn chỉ kèm 1 trẻ dưới 10 tuổi; trẻ thứ hai tính thêm"),
        ("Lưu ý & điều kiện",
            "Mang theo CCCD/hộ chiếu bản gốc còn hạn khi khởi hành\n" +
            "Có mặt tại điểm đón trước giờ khởi hành 15 phút\n" +
            "Chương trình có thể thay đổi thứ tự điểm đến tuỳ thời tiết, đảm bảo đủ điểm tham quan\n" +
            "Perlunas không chịu trách nhiệm với sự cố bất khả kháng (thiên tai, dịch bệnh…)"),
        ("Thanh toán & huỷ tour",
            "Đặt cọc 50% giá tour khi đăng ký, thanh toán đủ trước khởi hành 7 ngày\n" +
            "Huỷ trước 15 ngày: hoàn 90% tiền cọc\n" +
            "Huỷ trước 7–14 ngày: phí huỷ 50% giá tour\n" +
            "Huỷ trong vòng 7 ngày: phí huỷ 100% giá tour"),
    };

    private static readonly (string Title, string Desc)[] ComboBlocks =
    {
        ("Giá gói bao gồm",
            "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\n" +
            "Ăn sáng mỗi ngày tại khách sạn\n" +
            "Các dịch vụ và tiện ích theo chương trình gói\n" +
            "Ưu đãi/quà tặng đi kèm gói (nếu có)"),
        ("Giá gói chưa bao gồm",
            "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\n" +
            "Chi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\n" +
            "Các bữa ăn và dịch vụ không liệt kê trong gói\n" +
            "Phụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\n" +
            "Thuế VAT xuất hoá đơn (nếu khách yêu cầu)"),
        ("Chính sách trẻ em",
            "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\n" +
            "Trẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\n" +
            "Trẻ từ 12 tuổi: tính tiêu chuẩn như người lớn"),
        ("Điều kiện đăng ký & thanh toán",
            "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\n" +
            "Thanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\n" +
            "Cung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký"),
        ("Điều kiện đổi & huỷ",
            "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\n" +
            "Huỷ trước 7 – 14 ngày: phí 50% giá gói\n" +
            "Huỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\n" +
            "Ngày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn"),
        ("Trường hợp bất khả kháng",
            "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\n" +
            "Perlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói"),
    };

    public static void SeedImportantInfor(this EntityTypeBuilder<ImportantInfor> builder)
    {
        var rows = new System.Collections.Generic.List<ImportantInfor>();
        foreach (var (svc, t) in Tours)
        {
            for (int b = 0; b < Blocks.Length; b++)
            {
                rows.Add(new ImportantInfor
                {
                    Id = System.Guid.Parse($"eeee000{t}-0000-0000-0000-00000000000{b + 1}"),
                    ServiceId = svc,
                    Title = Blocks[b].Title,
                    SubTitle = null,
                    Description = Blocks[b].Desc,
                    SortOrder = b,
                    CreatedAt = SeedIds.CreatedAt,
                    UpdatedAt = SeedIds.CreatedAt,
                });
            }
        }
        // ── Combo: 6 khối điều khoản chuẩn cho mỗi combo ──
        foreach (var c in ComboSeedData.All)
        {
            for (int b = 0; b < ComboBlocks.Length; b++)
            {
                rows.Add(new ImportantInfor
                {
                    Id = System.Guid.Parse($"cccf00{c.Ci:D2}-0000-0000-0000-0000000000{b + 1:D2}"),
                    ServiceId = c.Id,
                    Title = ComboBlocks[b].Title,
                    SubTitle = null,
                    Description = ComboBlocks[b].Desc,
                    SortOrder = b,
                    CreatedAt = SeedIds.CreatedAt,
                    UpdatedAt = SeedIds.CreatedAt,
                });
            }
        }

        builder.HasData(rows);
    }
}
