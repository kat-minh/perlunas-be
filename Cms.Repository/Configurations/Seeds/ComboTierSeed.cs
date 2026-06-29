using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class ComboTierSeed
{
    public static void SeedComboTier(this EntityTypeBuilder<ComboTier> builder)
    {
        var now = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        builder.HasData(
            new ComboTier
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000001"),
                Name = "Akoya",
                Tagline = "Khởi đầu tinh tế",
                SortOrder = 1,
                Pearl = "Ngọc Akoya nhỏ nhắn, tròn đều và sáng trong, là dòng ngọc cổ điển làm nên vẻ đẹp thanh lịch quen thuộc.",
                Story = "Gói khởi đầu vừa vặn: gọn gàng, chỉn chu, đủ đầy những điều quan trọng nhất cho một chuyến đi nhẹ nhàng.",
                Includes = new() { "Khách sạn 3-4 sao trung tâm", "Xe đưa đón và di chuyển theo lịch trình", "Ăn sáng mỗi ngày", "Hướng dẫn viên ở các điểm chính", "Vé tham quan cơ bản" },
                CreatedAt = now, UpdatedAt = now,
            },
            new ComboTier
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000002"),
                Name = "Tahiti",
                Tagline = "Trải nghiệm đậm sâu",
                SortOrder = 2,
                Pearl = "Ngọc Tahiti mang sắc huyền bí của biển sâu, ánh lên những tầng màu khó quên, hiếm và cá tính.",
                Story = "Gói trải nghiệm đậm hơn: nhiều khoảnh khắc riêng tư, những trải nghiệm địa phương được chọn lọc kỹ.",
                Includes = new() { "Khách sạn 4-5 sao", "Xe riêng cho nhóm", "Ăn sáng và một số bữa đặc sản", "Hướng dẫn viên xuyên suốt", "Trải nghiệm địa phương riêng (lớp nấu ăn, làng nghề…)" },
                CreatedAt = now, UpdatedAt = now,
            },
            new ComboTier
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000003"),
                Name = "South Sea",
                Tagline = "Trọn vẹn thượng hạng",
                SortOrder = 3,
                Pearl = "Ngọc South Sea là dòng ngọc quý và lớn nhất, ánh vàng hoặc trắng sang trọng, biểu tượng của sự trọn vẹn.",
                Story = "Gói trọn vẹn nhất: chăm chút từng chi tiết, riêng tư và thượng hạng từ đầu đến cuối hành trình.",
                Includes = new() { "Resort/khách sạn 5 sao", "Xe riêng và tài xế suốt hành trình", "Trọn bữa, nhà hàng chọn lọc", "Trải nghiệm độc quyền, vé ưu tiên", "Hỗ trợ concierge 24/7" },
                CreatedAt = now, UpdatedAt = now,
            }
        );
    }
}
