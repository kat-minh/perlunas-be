using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class ContactMessageSeed
{
    public static void SeedContactMessage(this EntityTypeBuilder<ContactMessage> builder)
    {
        var now = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        builder.HasData(
            new ContactMessage { Id = Guid.Parse("a0000000-0000-0000-0000-000000000001"), Name = "Nguyễn Văn An", Email = "an.nguyen@example.com", Phone = "0901234567", Subject = "Tư vấn tour Hà Giang tháng 11", Message = "Chào Perlunas, gia đình mình 4 người muốn đi Hà Giang mùa hoa tam giác mạch tháng 11.", IsRead = false, CreatedAt = now.AddHours(-2) },
            new ContactMessage { Id = Guid.Parse("a0000000-0000-0000-0000-000000000002"), Name = "Trần Thị Bình", Email = "binh.tran@example.com", Phone = "0938111222", Subject = "Đặt combo Phú Quốc cho 2 người", Message = "Mình muốn đặt combo Phú Quốc 3 ngày 2 đêm cho 2 người vào cuối tháng này.", IsRead = false, CreatedAt = now.AddDays(-1) },
            new ContactMessage { Id = Guid.Parse("a0000000-0000-0000-0000-000000000003"), Name = "Lê Hoàng Cường", Email = "cuong.le@example.com", Phone = "0977333444", Subject = "Tour team building cho công ty 30 người", Message = "Công ty mình cần tổ chức team building biển đảo cho khoảng 30 nhân viên.", IsRead = true, CreatedAt = now.AddDays(-3) }
        );
    }
}
