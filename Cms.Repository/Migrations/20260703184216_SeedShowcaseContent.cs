using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedShowcaseContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("045276a2-57b3-5c36-816a-dcee18d7368d"), "Nhóm bạn thân khám phá", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.3.title", "text", "Dự án 3 · Tiêu đề", "Tour riêng tư", null, "", 547, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("051baefb-5598-5fa4-a6be-51a3659db22e"), "https://images.unsplash.com/photo-1475503572774-15a45e5d60b9?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.2.image", "image", "Dự án 2 · Ảnh", "Tour riêng tư", null, "", 546, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0e9fb41a-9044-57ff-998e-bd54605abd54"), "https://images.unsplash.com/photo-1487412720507-e7ab37603c6f?fm=jpg&q=60&w=400&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.1.avatar", "image", "Cảm nhận 1 · Ảnh đại diện", "Tour riêng tư", null, "", 563, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("116d8950-4c97-5737-a6d6-f8e631c44ca5"), "FPT Software\nTechcombank\nVietcombank\nViettel\nVNG\nMasan Group\nShopee\nPNJ\nVinamilk\nMB Bank", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.clients.list", "list", "Khách hàng đã hợp tác (mỗi dòng 1 tên)", "Tour đoàn", null, "", 519, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("18cd9135-0e7f-507a-8dd8-78e2e306c3e9"), "Nha Trang · Du thuyền riêng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.6.meta", "text", "Dự án 6 · Chú thích", "Tour riêng tư", null, "", 557, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2517dc8a-2e62-53f8-bd70-dafbc0320e6e"), "Đà Lạt · Retreat giữa rừng thông", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.4.meta", "text", "Dự án 4 · Chú thích", "Tour riêng tư", null, "", 551, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("304d8e05-4d4d-5ef4-aee6-1644ca23d2bd"), "Team building bãi biển", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.2.title", "text", "Dự án 2 · Tiêu đề", "Tour đoàn", null, "", 504, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("368ff9c1-7b5f-5f41-86fc-d4aae64165c4"), "Chuyến đi gia đình · Đà Nẵng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.1.role", "text", "Cảm nhận 1 · Vai trò", "Tour riêng tư", null, "", 562, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3725d776-d5cf-5f96-9f11-c8a4c8387c0a"), "Nhóm bạn thân · Hà Giang", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.3.role", "text", "Cảm nhận 3 · Vai trò", "Tour riêng tư", null, "", 570, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3a538cae-37e9-5387-956a-342a5be907de"), "Khen thưởng đại lý", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.6.title", "text", "Dự án 6 · Tiêu đề", "Tour đoàn", null, "", 516, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3e622a28-aac3-5b7e-84a2-174cf817fc60"), "Hội nghị kết hợp tham quan, lịch dày nhưng Perlunas điều phối rất chỉn chu. Đối tác của công ty đều hài lòng.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.3.quote", "textarea", "Cảm nhận 3 · Nội dung", "Tour đoàn", null, "", 528, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40bf8375-2d38-5b05-bb55-672fb441d770"), "Gala dinner 300 khách", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.1.title", "text", "Dự án 1 · Tiêu đề", "Tour đoàn", null, "", 501, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("44e155d5-78b4-5f8e-ac5d-1680222d4910"), "Chị Mai Linh", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.3.name", "text", "Cảm nhận 3 · Tên khách", "Tour đoàn", null, "", 529, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("48949a71-1bc0-5f43-b437-7dcb289808dd"), "Trưởng phòng HR · Doanh nghiệp công nghệ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.1.role", "text", "Cảm nhận 1 · Vai trò", "Tour đoàn", null, "", 522, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("500156c4-e967-5459-a9da-098acb6f8105"), "Trưởng ban tổ chức sự kiện", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.3.role", "text", "Cảm nhận 3 · Vai trò", "Tour đoàn", null, "", 530, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5485f70c-dc87-53f9-a573-78c5ef925688"), "https://images.unsplash.com/photo-1539635278303-d4002c07eae3?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.4.image", "image", "Dự án 4 · Ảnh", "Tour đoàn", null, "", 512, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5b455304-6c71-5950-a4bd-5979dadba345"), "https://images.unsplash.com/photo-1530789253388-582c481c54b0?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.6.image", "image", "Dự án 6 · Ảnh", "Tour riêng tư", null, "", 558, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5e82e12d-1206-5ea0-97a9-c26e926c2820"), "Chị Thu Hà", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.1.name", "text", "Cảm nhận 1 · Tên khách", "Tour đoàn", null, "", 521, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5e9bdea3-8222-58f7-ad1e-7254046e4e9d"), "Đoàn gần 300 người mà mọi thứ chạy mượt từ đưa đón tới gala. Một đầu mối lo trọn, tụi mình chỉ việc tận hưởng.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.1.quote", "textarea", "Cảm nhận 1 · Nội dung", "Tour đoàn", null, "", 520, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5ed71978-3611-5087-b8c2-7429cd0bbbcf"), "https://images.unsplash.com/photo-1521119989659-a83eee488004?fm=jpg&q=60&w=400&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.2.avatar", "image", "Cảm nhận 2 · Ảnh đại diện", "Tour riêng tư", null, "", 567, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6444708f-9962-5f91-9102-d91f31c7ff24"), "https://images.unsplash.com/photo-1768881618157-2cc24f7493c6?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.1.image", "image", "Dự án 1 · Ảnh", "Tour đoàn", null, "", 503, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("66b40832-5ac5-52d6-ab88-53a8dba754bb"), "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?fm=jpg&q=60&w=400&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.3.avatar", "image", "Cảm nhận 3 · Ảnh đại diện", "Tour riêng tư", null, "", 571, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("66d50670-85dd-57b6-a522-818960f032a9"), "Đà Nẵng · Hội An", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.2.meta", "text", "Dự án 2 · Chú thích", "Tour riêng tư", null, "", 545, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6719b1dc-5fe2-599e-abc2-096c909ab7d4"), "Phú Quốc · 150 người", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.2.meta", "text", "Dự án 2 · Chú thích", "Tour đoàn", null, "", 505, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6db60d15-3ce4-5a47-a59b-9472da4545a5"), "Lịch trình được may đo đúng nhịp của gia đình mình, có người già và trẻ nhỏ. Đi mà thấy nhẹ nhõm, không phải lo gì.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.1.quote", "textarea", "Cảm nhận 1 · Nội dung", "Tour riêng tư", null, "", 560, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("780aba51-aa25-5471-b05f-feb6f4aa3f6a"), "Trăng mật · Phú Quốc", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.2.role", "text", "Cảm nhận 2 · Vai trò", "Tour riêng tư", null, "", 566, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7b095469-63f3-588b-95d3-95680e643470"), "Hà Nội · Sa Pa", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.3.meta", "text", "Dự án 3 · Chú thích", "Tour đoàn", null, "", 508, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7c32400e-9d71-5609-aaaf-3326e1bc950b"), "Đà Nẵng · Doanh nghiệp", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.1.meta", "text", "Dự án 1 · Chú thích", "Tour đoàn", null, "", 502, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("808eaa94-ddad-5494-b495-0b9dcc28493c"), "Kịch bản team building được thiết kế riêng, gắn kết thật chứ không rập khuôn. Anh em về vẫn còn nhắc.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.2.quote", "textarea", "Cảm nhận 2 · Nội dung", "Tour đoàn", null, "", 524, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8357fc6d-6c93-5bd1-a373-838fb45facd6"), "https://images.unsplash.com/photo-1566759996874-04d713cc224a?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.4.image", "image", "Dự án 4 · Ảnh", "Tour riêng tư", null, "", 552, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("84d2b0a2-b513-527c-bac8-d466e106c3a3"), "Company trip cuối năm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.4.title", "text", "Dự án 4 · Tiêu đề", "Tour đoàn", null, "", 510, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("857c626f-d03c-5165-9048-9ce75e5a95b4"), "Hạ Long · Du thuyền", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.6.meta", "text", "Dự án 6 · Chú thích", "Tour đoàn", null, "", 517, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8d587550-d2f1-50a1-bba3-314aa4aed5af"), "https://images.unsplash.com/photo-1529156069898-49953e39b3ac?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.2.image", "image", "Dự án 2 · Ảnh", "Tour đoàn", null, "", 506, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("976a0ea2-b899-570c-ab63-1ff36222f00b"), "Hà Giang · Cao nguyên đá", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.3.meta", "text", "Dự án 3 · Chú thích", "Tour riêng tư", null, "", 548, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9dd07420-12e0-5f64-b0d3-c9f173ded159"), "https://images.unsplash.com/photo-1511795409834-ef04bbd61622?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.3.image", "image", "Dự án 3 · Ảnh", "Tour đoàn", null, "", 509, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9df489c9-4892-5739-b4b1-b3cae2548ece"), "Đà Lạt · Gala & team building", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.5.meta", "text", "Dự án 5 · Chú thích", "Tour đoàn", null, "", 514, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a4f0f0f7-c859-5ec7-a1af-a2bdff66416b"), "Một chuyến đi riêng tư, linh hoạt từng ngày. Cảm giác như có người bạn bản địa lo hết mọi thứ cho mình.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.3.quote", "textarea", "Cảm nhận 3 · Nội dung", "Tour riêng tư", null, "", 568, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a781a2f8-63dc-536a-82aa-fff730652680"), "Anh Trung Kiên", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.3.name", "text", "Cảm nhận 3 · Tên khách", "Tour riêng tư", null, "", 569, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b1a4737d-c022-5939-a545-89b2ca3be849"), "Ninh Bình · Wellness", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.5.meta", "text", "Dự án 5 · Chú thích", "Tour riêng tư", null, "", 554, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b6329f5f-afda-5b19-828f-ab9d9d2f45b9"), "https://images.unsplash.com/photo-1528127269322-539801943592?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.5.image", "image", "Dự án 5 · Ảnh", "Tour riêng tư", null, "", 555, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bd3370e3-c7b6-53ef-8858-e0d2e851bf8b"), "Gia đình ba thế hệ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.2.title", "text", "Dự án 2 · Tiêu đề", "Tour riêng tư", null, "", 544, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c5ed3f29-dfbe-516d-98f0-75bf66bcadc8"), "https://images.unsplash.com/photo-1501555088652-021faa106b9b?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.3.image", "image", "Dự án 3 · Ảnh", "Tour riêng tư", null, "", 549, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c9b25dd6-41c9-54fa-a54e-127f98784550"), "https://images.unsplash.com/photo-1566073771259-6a8506099945?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.6.image", "image", "Dự án 6 · Ảnh", "Tour đoàn", null, "", 518, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cce5d6b6-080c-5e6f-a0af-00547f6f510e"), "https://images.unsplash.com/photo-1494790108377-be9c29b29330?fm=jpg&q=60&w=400&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.3.avatar", "image", "Cảm nhận 3 · Ảnh đại diện", "Tour đoàn", null, "", 531, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cd773326-c0c0-5620-a6c0-e3256dd51f5d"), "Vợ chồng Nam · Trang", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.2.name", "text", "Cảm nhận 2 · Tên khách", "Tour riêng tư", null, "", 565, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cef1642b-7c18-5f78-8680-416cb3cd9038"), "Hành trình chữa lành", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.5.title", "text", "Dự án 5 · Tiêu đề", "Tour riêng tư", null, "", 553, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d3f501b7-db64-5d60-af9b-f29e61bc596a"), "Chị Bích Ngọc", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.1.name", "text", "Cảm nhận 1 · Tên khách", "Tour riêng tư", null, "", 561, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d534e0ae-e51c-5ba3-a2e6-a8637043afd4"), "https://images.unsplash.com/photo-1648538923547-074724ca7a18?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.1.image", "image", "Dự án 1 · Ảnh", "Tour riêng tư", null, "", 543, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d99da33a-f8a1-5bd2-b938-53b0c72366d7"), "Giám đốc kinh doanh", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.2.role", "text", "Cảm nhận 2 · Vai trò", "Tour đoàn", null, "", 526, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dbaa95a5-d49c-55cd-bd62-57ee86f18896"), "Hội nghị kết hợp tham quan", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.3.title", "text", "Dự án 3 · Tiêu đề", "Tour đoàn", null, "", 507, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e1f0675d-c03b-5b88-8433-418304a04dcb"), "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?fm=jpg&q=60&w=400&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.2.avatar", "image", "Cảm nhận 2 · Ảnh đại diện", "Tour đoàn", null, "", 527, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e1fad425-0751-5dc2-87f3-7b165c62a8b8"), "Kỳ nghỉ riêng tư cặp đôi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.4.title", "text", "Dự án 4 · Tiêu đề", "Tour riêng tư", null, "", 550, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e23f678e-af5e-57a6-8de8-d7bf0a6b16da"), "Lễ kỷ niệm thành lập", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.5.title", "text", "Dự án 5 · Tiêu đề", "Tour đoàn", null, "", 513, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e5e459e8-9561-55b0-950a-1438e25061d4"), "Tụi mình chỉ nói mong muốn, Perlunas đề xuất rồi chỉnh tới khi vừa ý. Trăng mật trọn vẹn hơn cả tưởng tượng.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.2.quote", "textarea", "Cảm nhận 2 · Nội dung", "Tour riêng tư", null, "", 564, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e92db5a5-8192-5818-8b5f-6a030cfe0d13"), "Cặp đôi · 4 ngày 3 đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.1.meta", "text", "Dự án 1 · Chú thích", "Tour riêng tư", null, "", 542, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ec1661f8-af7b-5c9e-bd77-5ac3dff2671a"), "Trăng mật Phú Quốc", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.1.title", "text", "Dự án 1 · Tiêu đề", "Tour riêng tư", null, "", 541, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f6b2b734-be07-5ed1-8e83-561e8a7c29d1"), "https://images.unsplash.com/photo-1774599661329-d9a2f999d1c4?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.5.image", "image", "Dự án 5 · Ảnh", "Tour đoàn", null, "", 515, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f7e06c5a-987e-5343-9187-71e0cb735d99"), "Nha Trang · 4 ngày 3 đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.4.meta", "text", "Dự án 4 · Chú thích", "Tour đoàn", null, "", 511, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f935de41-83da-5246-adfe-acd7adfcd941"), "Anh Quốc Anh", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.2.name", "text", "Cảm nhận 2 · Tên khách", "Tour đoàn", null, "", 525, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fb287791-dbaf-56aa-96c8-3ba14486836d"), "https://images.unsplash.com/photo-1544005313-94ddf0286df2?fm=jpg&q=60&w=400&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.1.avatar", "image", "Cảm nhận 1 · Ảnh đại diện", "Tour đoàn", null, "", 523, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ff2199e4-db02-5d8f-8e48-6260703e3f6b"), "Sinh nhật bất ngờ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.6.title", "text", "Dự án 6 · Tiêu đề", "Tour riêng tư", null, "", 556, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
                    }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("045276a2-57b3-5c36-816a-dcee18d7368d"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("051baefb-5598-5fa4-a6be-51a3659db22e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("0e9fb41a-9044-57ff-998e-bd54605abd54"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("116d8950-4c97-5737-a6d6-f8e631c44ca5"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("18cd9135-0e7f-507a-8dd8-78e2e306c3e9"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("2517dc8a-2e62-53f8-bd70-dafbc0320e6e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("304d8e05-4d4d-5ef4-aee6-1644ca23d2bd"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("368ff9c1-7b5f-5f41-86fc-d4aae64165c4"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("3725d776-d5cf-5f96-9f11-c8a4c8387c0a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("3a538cae-37e9-5387-956a-342a5be907de"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("3e622a28-aac3-5b7e-84a2-174cf817fc60"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("40bf8375-2d38-5b05-bb55-672fb441d770"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("44e155d5-78b4-5f8e-ac5d-1680222d4910"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("48949a71-1bc0-5f43-b437-7dcb289808dd"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("500156c4-e967-5459-a9da-098acb6f8105"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5485f70c-dc87-53f9-a573-78c5ef925688"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5b455304-6c71-5950-a4bd-5979dadba345"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5e82e12d-1206-5ea0-97a9-c26e926c2820"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5e9bdea3-8222-58f7-ad1e-7254046e4e9d"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5ed71978-3611-5087-b8c2-7429cd0bbbcf"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6444708f-9962-5f91-9102-d91f31c7ff24"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("66b40832-5ac5-52d6-ab88-53a8dba754bb"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("66d50670-85dd-57b6-a522-818960f032a9"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6719b1dc-5fe2-599e-abc2-096c909ab7d4"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6db60d15-3ce4-5a47-a59b-9472da4545a5"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("780aba51-aa25-5471-b05f-feb6f4aa3f6a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7b095469-63f3-588b-95d3-95680e643470"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7c32400e-9d71-5609-aaaf-3326e1bc950b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("808eaa94-ddad-5494-b495-0b9dcc28493c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8357fc6d-6c93-5bd1-a373-838fb45facd6"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("84d2b0a2-b513-527c-bac8-d466e106c3a3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("857c626f-d03c-5165-9048-9ce75e5a95b4"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8d587550-d2f1-50a1-bba3-314aa4aed5af"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("976a0ea2-b899-570c-ab63-1ff36222f00b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9dd07420-12e0-5f64-b0d3-c9f173ded159"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9df489c9-4892-5739-b4b1-b3cae2548ece"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a4f0f0f7-c859-5ec7-a1af-a2bdff66416b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a781a2f8-63dc-536a-82aa-fff730652680"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b1a4737d-c022-5939-a545-89b2ca3be849"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b6329f5f-afda-5b19-828f-ab9d9d2f45b9"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("bd3370e3-c7b6-53ef-8858-e0d2e851bf8b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c5ed3f29-dfbe-516d-98f0-75bf66bcadc8"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c9b25dd6-41c9-54fa-a54e-127f98784550"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("cce5d6b6-080c-5e6f-a0af-00547f6f510e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("cd773326-c0c0-5620-a6c0-e3256dd51f5d"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("cef1642b-7c18-5f78-8680-416cb3cd9038"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d3f501b7-db64-5d60-af9b-f29e61bc596a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d534e0ae-e51c-5ba3-a2e6-a8637043afd4"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d99da33a-f8a1-5bd2-b938-53b0c72366d7"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("dbaa95a5-d49c-55cd-bd62-57ee86f18896"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e1f0675d-c03b-5b88-8433-418304a04dcb"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e1fad425-0751-5dc2-87f3-7b165c62a8b8"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e23f678e-af5e-57a6-8de8-d7bf0a6b16da"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e5e459e8-9561-55b0-950a-1438e25061d4"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e92db5a5-8192-5818-8b5f-6a030cfe0d13"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ec1661f8-af7b-5c9e-bd77-5ac3dff2671a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("f6b2b734-be07-5ed1-8e83-561e8a7c29d1"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("f7e06c5a-987e-5343-9187-71e0cb735d99"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("f935de41-83da-5246-adfe-acd7adfcd941"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("fb287791-dbaf-56aa-96c8-3ba14486836d"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ff2199e4-db02-5d8f-8e48-6260703e3f6b"));

            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
                    }
    }
}
