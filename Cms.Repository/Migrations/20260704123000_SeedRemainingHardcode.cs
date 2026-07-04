using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedRemainingHardcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("e20c9f1e-d83d-2d96-8c6e-b3cf5e2a28c4"), "Blog", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "blog.eyebrow", "text", "Blog: nhãn hero", "Blog", null, "", 400, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9d88fb1d-11b1-d375-be99-a5ac5e705a2f"), "Blog du lịch Perlunas", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "blog.hero.title", "text", "Blog: tiêu đề hero", "Blog", null, "", 401, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5fbabfa0-51cf-f0d5-9d90-9e350859453a"), "Kinh nghiệm điểm đến, mẹo chuẩn bị, ẩm thực và những câu chuyện truyền cảm hứng cho hành trình của bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "blog.hero.intro", "textarea", "Blog: mô tả hero", "Blog", null, "", 402, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d08d45b3-e23e-b4df-87d3-5da734fcb587"), "Blog du lịch Perlunas", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "blog.hero.alt", "text", "Blog: alt ảnh hero", "Blog", null, "", 403, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b395ecf5-4a37-7f04-940b-d394535b5f5a"), "Đọc bài viết", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "blog.readmore", "text", "Blog: nút đọc bài", "Blog", null, "", 404, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5dcffc52-e97b-20db-aed3-2bea395aad21"), "Blog", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "blog.meta.title", "text", "Blog: SEO title", "Blog", null, "", 405, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("18ed1731-be8a-b7fe-2bdf-d9a5b14a7bf9"), "Blog du lịch Perlunas — kinh nghiệm điểm đến, mẹo chuẩn bị, ẩm thực và cảm hứng cho mỗi hành trình.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "blog.meta.desc", "textarea", "Blog: SEO description", "Blog", null, "", 406, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("103bd0da-2abb-ef0f-61ad-75f9fb5f2102"), "Tất cả bài viết", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "blog.back", "text", "Blog: link quay lại", "Blog", null, "", 407, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fc709b17-4a8a-4d81-c58a-4c5462a9ebf5"), "Bài viết khác", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "blog.related.title", "text", "Blog: tiêu đề bài khác", "Blog", null, "", 408, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7d6db0a1-04cf-e259-9ac4-4e5d1ed99185"), "Liên hệ tư vấn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.eyebrow", "text", "QuickEnquiry: nhãn tiêu đề", "Form liên hệ / đặt", null, "", 380, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("244bb1b5-ff16-b532-d344-85f3c6c2877b"), "VD: Nguyễn Thị Lan", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.name.ph", "text", "QuickEnquiry placeholder: họ tên", "Form liên hệ / đặt", null, "", 381, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("00a4d537-a78f-f732-d655-d9a9aa9908d1"), "Gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.tier.prefix", "text", "Combo detail: tiền tố dòng ngọc (Gói …)", "Chi tiết combo", null, "", 260, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a1786ff9-d4ba-e6b7-3383-4a4f5e8cf6a7"), "Lưu trú khác tại", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.related.title", "text", "Hotel detail: tiêu đề lưu trú liên quan", "Chi tiết khách sạn", null, "", 230, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bfbb6ec3-a4d4-979a-a228-b247ce073ccc"), "Tháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourdetail.dep.month", "text", "Tour detail lịch: nhãn Tháng", "Chi tiết tour", null, "", 210, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d55efde7-2278-8e62-28e0-ea6cde50db1c"), "Vui lòng chọn ngày khởi hành bên dưới để xem đúng giá tour.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourdetail.dep.instruction", "textarea", "Tour detail lịch: câu nhắc chọn ngày", "Chi tiết tour", null, "", 211, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("74fde08b-012a-b79d-d030-3d397076ed51"), "Ngày khởi hành", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourdetail.dep.date", "text", "Tour detail lịch: nhãn Ngày khởi hành", "Chi tiết tour", null, "", 212, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7f925e54-5925-f7cc-db9b-3af1b4078f64"), "Mã tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourdetail.dep.code", "text", "Tour detail lịch: nhãn Mã tour", "Chi tiết tour", null, "", 213, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bffacded-867d-b829-1ed5-0a55d27358c2"), "Giá tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourdetail.dep.price", "text", "Tour detail lịch: nhãn Giá tour", "Chi tiết tour", null, "", 214, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ced12a86-529f-62c6-ff91-16b424c36ff4"), "Chuẩn lưu trú", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourdetail.dep.stay", "text", "Tour detail lịch: nhãn Chuẩn lưu trú", "Chi tiết tour", null, "", 215, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4d8ab106-f828-8eaa-4f93-1bb5e8a1fe77"), "Chọn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourdetail.dep.choose", "text", "Tour detail lịch: nhãn cột Chọn", "Chi tiết tour", null, "", 216, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("19dbce70-fa92-6787-baa6-bfd709a0510d"), "Chưa có lịch khởi hành cho tháng này.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourdetail.dep.empty", "text", "Tour detail lịch: khi trống", "Chi tiết tour", null, "", 217, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4bf7beb8-89c1-35dc-6c34-0ef04749ca14"), "Thời lượng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourdetail.dep.duration", "text", "Tour detail lịch: nhãn Thời lượng", "Chi tiết tour", null, "", 218, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e5b6e275-9046-c923-f113-03ea21d71b19"), "Giá từ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourdetail.dep.pricefrom", "text", "Tour detail lịch: nhãn Giá từ", "Chi tiết tour", null, "", 219, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fb51ae84-a6d0-1a37-f873-dc99d495d3c1"), "Điểm nhấn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourdetail.highlights.fallbacktitle", "text", "Tour detail: tiêu đề điểm nhấn (mặc định)", "Chi tiết tour", null, "", 220, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8938dda1-d058-a36c-e5e8-b0b887a82e67"), "Những trải nghiệm và điểm đến nổi bật được chọn lọc cho hành trình của bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourdetail.highlights.fallbackintro", "textarea", "Tour detail: mô tả điểm nhấn (mặc định)", "Chi tiết tour", null, "", 221, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            foreach (var id in new[]
            {
                "e20c9f1e-d83d-2d96-8c6e-b3cf5e2a28c4",
                "9d88fb1d-11b1-d375-be99-a5ac5e705a2f",
                "5fbabfa0-51cf-f0d5-9d90-9e350859453a",
                "d08d45b3-e23e-b4df-87d3-5da734fcb587",
                "b395ecf5-4a37-7f04-940b-d394535b5f5a",
                "5dcffc52-e97b-20db-aed3-2bea395aad21",
                "18ed1731-be8a-b7fe-2bdf-d9a5b14a7bf9",
                "103bd0da-2abb-ef0f-61ad-75f9fb5f2102",
                "fc709b17-4a8a-4d81-c58a-4c5462a9ebf5",
                "7d6db0a1-04cf-e259-9ac4-4e5d1ed99185",
                "244bb1b5-ff16-b532-d344-85f3c6c2877b",
                "00a4d537-a78f-f732-d655-d9a9aa9908d1",
                "a1786ff9-d4ba-e6b7-3383-4a4f5e8cf6a7",
                "bfbb6ec3-a4d4-979a-a228-b247ce073ccc",
                "d55efde7-2278-8e62-28e0-ea6cde50db1c",
                "74fde08b-012a-b79d-d030-3d397076ed51",
                "7f925e54-5925-f7cc-db9b-3af1b4078f64",
                "bffacded-867d-b829-1ed5-0a55d27358c2",
                "ced12a86-529f-62c6-ff91-16b424c36ff4",
                "4d8ab106-f828-8eaa-4f93-1bb5e8a1fe77",
                "19dbce70-fa92-6787-baa6-bfd709a0510d",
                "4bf7beb8-89c1-35dc-6c34-0ef04749ca14",
                "e5b6e275-9046-c923-f113-03ea21d71b19",
                "fb51ae84-a6d0-1a37-f873-dc99d495d3c1",
                "8938dda1-d058-a36c-e5e8-b0b887a82e67",
            })
            {
                migrationBuilder.DeleteData(table: "PageContents", keyColumn: "Id", keyValue: new Guid(id));
            }
        }
    }
}
