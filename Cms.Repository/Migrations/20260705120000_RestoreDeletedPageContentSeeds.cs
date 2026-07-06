using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <summary>
    /// Khôi phục 73 row page-content bị mất khi merge nhánh bạn BE (đã xoá 8 migration
    /// seed cuối 20260704121600–130000 nhưng không đưa InsertData vào migration mới; seed
    /// dùng HasData→InsertData, runtime chỉ chạy Up() nên DB dựng mới bị thiếu nhóm này).
    /// Gộp nguyên văn Up() của: SeedFooterInfo, SeedMissingPageContent, SeedHeaderFooterNav,
    /// SeedContactFormContent, SeedRemainingHardcode, RemoveHotelTicketTypeLabel (xoá 1 key),
    /// SeedHotelBookingTotals, SeedContactSocialUrls. Đi kèm file .Designer.cs
    /// (BuildTargetModel) để InsertData/DeleteData resolve được kiểu cột.
    /// </summary>
    public partial class RestoreDeletedPageContentSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // IDEMPOTENT: DB mới thì đây là no-op; DB đã có sẵn 73 row (vd Railway đã chạy
            // các migration seed cũ trước khi bị xoá) thì xoá trước để chèn lại không đụng
            // PK_PageContents. Các row này ParentId=null, không phải cha của row nào nên xoá an toàn.
            foreach (var id in RestoredIds)
                migrationBuilder.DeleteData(table: "PageContents", keyColumn: "Id", keyValue: new Guid(id));

            // --- SeedFooterInfo (footer.brand/contact/social) ---
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0a67d369-c817-5732-907c-ca4ab2896bc2"), "Perlunas", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.brand.name", "text", "Tên thương hiệu", "Footer", null, "", 340, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("003c42fe-ae4e-58ec-90aa-788014ab3cde"), "Công ty TNHH Du lịch Perlunas", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.brand.legal", "text", "Tên công ty (pháp lý)", "Footer", null, "", 341, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("78c851f2-7cbf-51d1-9ae5-38cdee297961"), "0123456789", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.brand.taxid", "text", "Mã số thuế", "Footer", null, "", 342, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a211247d-d00c-5ee4-ace0-ec6cb684e180"), "0900 000 000", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.contact.phone", "text", "Hotline / Điện thoại", "Footer", null, "", 343, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cf3cec90-6bbc-5aa2-b603-83b60809f536"), "xinchao@perlunas.vn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.contact.email", "text", "Email", "Footer", null, "", 344, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c1ad34c2-b9e6-59b3-b6ff-4cfd34271d62"), "https://zalo.me/0900000000", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.social.zalo", "text", "Link Zalo", "Footer", null, "", 345, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("52539440-77ba-594e-92eb-cd4bcc5a6a6c"), "https://m.me/perlunas", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.social.messenger", "text", "Link Messenger", "Footer", null, "", 346, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c1b3c38a-ad18-5798-8462-cdf91d3cf9b7"), "2014", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.brand.foundedyear", "text", "Năm thành lập", "Footer", null, "", 347, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            // --- SeedMissingPageContent ---
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("24dcbeea-a39f-5d1b-33b3-0853c524dbbd"), "Tour đoàn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.eyebrow", "text", "Tour đoàn · Nhãn", "Trang chủ", null, "", 21, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d4b34839-e57b-d977-7328-01267ae62a4b"), "Lưu trú", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.ticketbar.name", "text", "Vé (mobile): nhãn tên lưu trú", "Chi tiết khách sạn", null, "", 197, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            // --- SeedHeaderFooterNav (nav.* + footer.nav.*) ---
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("81edc307-cf64-69b0-eb11-2d0c7a410aed"), "Perlunas", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "nav.brand", "text", "Nav: Tên thương hiệu (header)", "Điều hướng (nav)", null, "", 318, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1f0622c2-5d71-b811-789c-1a7942db7b15"), "0900 000 000", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "nav.hotline", "text", "Nav: Hotline (header)", "Điều hướng (nav)", null, "", 319, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d5a137aa-a093-fc20-0255-124c73196b85"), "Tour ghép lẻ trọn gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.nav.tour", "text", "Footer link: Tour ghép lẻ trọn gói", "Footer", null, "", 330, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("36245b96-baf7-bc68-ab44-c0304143b1c4"), "Lưu trú cao cấp", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.nav.hotel", "text", "Footer link: Lưu trú cao cấp", "Footer", null, "", 331, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("83e4f96e-8152-95b4-8080-31eaa3a663c4"), "Gói du lịch", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.nav.combo", "text", "Footer link: Gói du lịch", "Footer", null, "", 332, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f569f3d7-a847-bff0-d7ae-6b7004c46f3b"), "Tour đoàn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.nav.group", "text", "Footer link: Tour đoàn", "Footer", null, "", 333, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7ec0ff38-ddbb-e6a4-71e5-b370d0603c29"), "Tour riêng tư", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.nav.private", "text", "Footer link: Tour riêng tư", "Footer", null, "", 334, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("be821323-e0d9-9afe-8200-9f7c3d8cf889"), "Về chúng tôi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.nav.about", "text", "Footer link: Về chúng tôi", "Footer", null, "", 335, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ce750de2-9028-11c4-e0a1-26dbc4c0c47a"), "Blog", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.nav.blog", "text", "Footer link: Blog", "Footer", null, "", 336, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            // --- SeedContactFormContent (contact.* + lf.*) ---
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("acafd321-b84f-8bed-9a3c-1e80802b2edd"), "0900 000 000", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.call.phone", "text", "Liên hệ: Số điện thoại (giá trị)", "Liên hệ", null, "", 90, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a19a011f-f60e-54db-26cd-561705679b26"), "Zalo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.message.zalo", "text", "Liên hệ: nhãn link Zalo", "Liên hệ", null, "", 91, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2730b789-76bd-57c9-e13b-1c9c79f1d7aa"), "Messenger", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.message.messenger", "text", "Liên hệ: nhãn link Messenger", "Liên hệ", null, "", 92, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6776027c-8553-dbaa-242e-091f2ab89311"), "xinchao@perlunas.vn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.message.email", "text", "Liên hệ: Email (giá trị)", "Liên hệ", null, "", 93, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f8fd4eed-f9f6-eda1-fb6b-dc4a041692b6"), "Sau khi bạn gửi, Perlunas sẽ liên hệ sớm để tư vấn và lên kế hoạch qua Zalo, điện thoại hoặc gặp trực tiếp. Cần trao đổi ngay, bạn gọi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.intro", "textarea", "LeadForm: đoạn mở đầu", "Form liên hệ / đặt", null, "", 355, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5db48b1b-0075-5c1b-13ea-a25a394c8d16"), "0900 000 000", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.intro.phone", "text", "LeadForm: SĐT ở đoạn mở đầu", "Form liên hệ / đặt", null, "", 356, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("30af64e2-e13d-d3c3-d65e-045b7a8f126d"), "Đã nhận thông tin", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.success.title", "text", "LeadForm: tiêu đề màn gửi thành công", "Form liên hệ / đặt", null, "", 357, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cf751648-8250-34e4-fd7c-024005948b99"), "Cảm ơn bạn. Perlunas sẽ liên hệ qua Zalo hoặc Messenger trong thời gian sớm nhất để tư vấn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.success.body", "textarea", "LeadForm: nội dung màn gửi thành công", "Form liên hệ / đặt", null, "", 358, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("98674d01-7bad-f6cd-b031-7df8692fa305"), "VD: Đà Lạt, Phú Quốc, Hà Nội…", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.where.ph", "text", "LeadForm placeholder: nơi đến", "Form liên hệ / đặt", null, "", 359, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dfb9f819-19f8-e6a9-6944-4d1d1b377b8e"), "Tháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.month.empty", "text", "LeadForm: nhãn ô trống Tháng", "Form liên hệ / đặt", null, "", 360, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7883ab8b-f60d-e61a-b2fd-cb03c2b19c8a"), "Năm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.year.empty", "text", "LeadForm: nhãn ô trống Năm", "Form liên hệ / đặt", null, "", 361, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2ef9550c-eb97-98db-f04a-5be26505ce83"), "VD: 3 ngày 2 đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.duration.ph", "text", "LeadForm placeholder: thời lượng", "Form liên hệ / đặt", null, "", 362, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d81c4391-e16e-48b0-c9c0-08c970044d28"), "Chọn số người…", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.group.empty", "text", "LeadForm: nhãn ô trống số người", "Form liên hệ / đặt", null, "", 363, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d265d2f5-97d0-4964-7127-488026b17d63"), "Chọn mức…", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.budget.empty", "text", "LeadForm: nhãn ô trống ngân sách", "Form liên hệ / đặt", null, "", 364, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("87fdbcce-b4b4-1ed4-28e0-e1ed68b90170"), "Chọn dịch vụ…", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.service.empty", "text", "LeadForm: nhãn ô trống dịch vụ", "Form liên hệ / đặt", null, "", 365, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("401a90d0-0830-a25b-2cd4-a46fef8439f3"), "Dịp đặc biệt, điều bạn muốn hoặc muốn tránh…", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.note.ph", "text", "LeadForm placeholder: ghi chú", "Form liên hệ / đặt", null, "", 366, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e01224b3-059f-9cc2-efd8-8b8d14cae8b4"), "VD: Nguyễn Thị Lan", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.name.ph", "text", "LeadForm placeholder: họ tên", "Form liên hệ / đặt", null, "", 367, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("553f60fb-a0c6-b765-c2a7-ca0b58ae243e"), "0901 234 567", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.phone.ph", "text", "LeadForm placeholder: SĐT", "Form liên hệ / đặt", null, "", 368, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dd971565-33c5-7d27-cf23-3280ab52dac2"), "ban@email.com", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.email.ph", "text", "LeadForm placeholder: email", "Form liên hệ / đặt", null, "", 369, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("04ef71bf-683b-cafb-bd00-c3887d1734c2"), "Chọn…", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.source.empty", "text", "LeadForm: nhãn ô trống nguồn", "Form liên hệ / đặt", null, "", 370, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a7455191-3e3e-eaf9-6548-bc2b0c24021d"), "Tư vấn qua", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.channel.label", "text", "LeadForm: nhãn Tư vấn qua", "Form liên hệ / đặt", null, "", 371, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fd8a2df7-2e91-1064-08fa-cce5de9499a0"), "Zalo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.channel.zalo", "text", "LeadForm kênh: Zalo", "Form liên hệ / đặt", null, "", 372, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("23b26806-1270-d65d-a3ec-d25584b0f57f"), "Messenger", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.channel.messenger", "text", "LeadForm kênh: Messenger", "Form liên hệ / đặt", null, "", 373, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ee719abd-8d18-75e5-fd95-93dfc10b7f3c"), "Gọi điện", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.channel.call", "text", "LeadForm kênh: Gọi điện", "Form liên hệ / đặt", null, "", 374, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e36a839f-3dbb-4d8b-17a1-5df3e4577125"), "Chúng tôi giữ kín thông tin của bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.privacy", "textarea", "LeadForm: dòng bảo mật", "Form liên hệ / đặt", null, "", 375, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            // --- SeedRemainingHardcode (blog.* + qe.* + tourdetail.dep.* ...) ---
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

            // --- RemoveHotelTicketTypeLabel: xoá key không dùng (vé KS hiện tên KS) ---
            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c6278a8c-4a8b-5462-4094-bfdb852d9475"));

            // --- SeedHotelBookingTotals (hb.total, hb.pricehint) ---
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5bf7543d-2bd7-85f9-edec-3abb1a4f2ab8"), "Tổng cộng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.total", "text", "HotelBooking: nhãn Tổng cộng", "Form liên hệ / đặt", null, "", 320, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("14dbcbb2-e8a3-67d1-385e-05f5bd6b1f0c"), "Chọn ngày nhận và trả phòng để tính thành tiền.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.pricehint", "textarea", "HotelBooking: gợi ý tính giá", "Form liên hệ / đặt", null, "", 321, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            // --- SeedContactSocialUrls (contact.message.zalo/messenger.url) ---
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("cfc69857-e9fa-f5be-7b39-5fbfe403deab"), "https://zalo.me/0900000000", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.message.zalo.url", "text", "Liên hệ: URL link Zalo", "Liên hệ", null, "", 94, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55d8d588-b7b1-b34a-17ad-04935f9269d9"), "https://m.me/perlunas", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.message.messenger.url", "text", "Liên hệ: URL link Messenger", "Liên hệ", null, "", 95, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Khôi phục lại key ticket.type đã xoá ở Up()
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[] { new Guid("c6278a8c-4a8b-5462-4094-bfdb852d9475"), "Loại hình", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.ticket.type", "text", "Vé: nhãn loại hình", "Chi tiết khách sạn", null, "", 198, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            foreach (var id in RestoredIds)
                migrationBuilder.DeleteData(table: "PageContents", keyColumn: "Id", keyValue: new Guid(id));
        }

        private static readonly string[] RestoredIds =
        {
            "003c42fe-ae4e-58ec-90aa-788014ab3cde",
            "00a4d537-a78f-f732-d655-d9a9aa9908d1",
            "04ef71bf-683b-cafb-bd00-c3887d1734c2",
            "0a67d369-c817-5732-907c-ca4ab2896bc2",
            "103bd0da-2abb-ef0f-61ad-75f9fb5f2102",
            "14dbcbb2-e8a3-67d1-385e-05f5bd6b1f0c",
            "18ed1731-be8a-b7fe-2bdf-d9a5b14a7bf9",
            "19dbce70-fa92-6787-baa6-bfd709a0510d",
            "1f0622c2-5d71-b811-789c-1a7942db7b15",
            "23b26806-1270-d65d-a3ec-d25584b0f57f",
            "244bb1b5-ff16-b532-d344-85f3c6c2877b",
            "24dcbeea-a39f-5d1b-33b3-0853c524dbbd",
            "2730b789-76bd-57c9-e13b-1c9c79f1d7aa",
            "2ef9550c-eb97-98db-f04a-5be26505ce83",
            "30af64e2-e13d-d3c3-d65e-045b7a8f126d",
            "36245b96-baf7-bc68-ab44-c0304143b1c4",
            "401a90d0-0830-a25b-2cd4-a46fef8439f3",
            "4bf7beb8-89c1-35dc-6c34-0ef04749ca14",
            "4d8ab106-f828-8eaa-4f93-1bb5e8a1fe77",
            "52539440-77ba-594e-92eb-cd4bcc5a6a6c",
            "553f60fb-a0c6-b765-c2a7-ca0b58ae243e",
            "55d8d588-b7b1-b34a-17ad-04935f9269d9",
            "5bf7543d-2bd7-85f9-edec-3abb1a4f2ab8",
            "5db48b1b-0075-5c1b-13ea-a25a394c8d16",
            "5dcffc52-e97b-20db-aed3-2bea395aad21",
            "5fbabfa0-51cf-f0d5-9d90-9e350859453a",
            "6776027c-8553-dbaa-242e-091f2ab89311",
            "74fde08b-012a-b79d-d030-3d397076ed51",
            "7883ab8b-f60d-e61a-b2fd-cb03c2b19c8a",
            "78c851f2-7cbf-51d1-9ae5-38cdee297961",
            "7d6db0a1-04cf-e259-9ac4-4e5d1ed99185",
            "7ec0ff38-ddbb-e6a4-71e5-b370d0603c29",
            "7f925e54-5925-f7cc-db9b-3af1b4078f64",
            "81edc307-cf64-69b0-eb11-2d0c7a410aed",
            "83e4f96e-8152-95b4-8080-31eaa3a663c4",
            "87fdbcce-b4b4-1ed4-28e0-e1ed68b90170",
            "8938dda1-d058-a36c-e5e8-b0b887a82e67",
            "98674d01-7bad-f6cd-b031-7df8692fa305",
            "9d88fb1d-11b1-d375-be99-a5ac5e705a2f",
            "a1786ff9-d4ba-e6b7-3383-4a4f5e8cf6a7",
            "a19a011f-f60e-54db-26cd-561705679b26",
            "a211247d-d00c-5ee4-ace0-ec6cb684e180",
            "a7455191-3e3e-eaf9-6548-bc2b0c24021d",
            "acafd321-b84f-8bed-9a3c-1e80802b2edd",
            "b395ecf5-4a37-7f04-940b-d394535b5f5a",
            "be821323-e0d9-9afe-8200-9f7c3d8cf889",
            "bfbb6ec3-a4d4-979a-a228-b247ce073ccc",
            "bffacded-867d-b829-1ed5-0a55d27358c2",
            "c1ad34c2-b9e6-59b3-b6ff-4cfd34271d62",
            "c1b3c38a-ad18-5798-8462-cdf91d3cf9b7",
            "ce750de2-9028-11c4-e0a1-26dbc4c0c47a",
            "ced12a86-529f-62c6-ff91-16b424c36ff4",
            "cf3cec90-6bbc-5aa2-b603-83b60809f536",
            "cf751648-8250-34e4-fd7c-024005948b99",
            "cfc69857-e9fa-f5be-7b39-5fbfe403deab",
            "d08d45b3-e23e-b4df-87d3-5da734fcb587",
            "d265d2f5-97d0-4964-7127-488026b17d63",
            "d4b34839-e57b-d977-7328-01267ae62a4b",
            "d55efde7-2278-8e62-28e0-ea6cde50db1c",
            "d5a137aa-a093-fc20-0255-124c73196b85",
            "d81c4391-e16e-48b0-c9c0-08c970044d28",
            "dd971565-33c5-7d27-cf23-3280ab52dac2",
            "dfb9f819-19f8-e6a9-6944-4d1d1b377b8e",
            "e01224b3-059f-9cc2-efd8-8b8d14cae8b4",
            "e20c9f1e-d83d-2d96-8c6e-b3cf5e2a28c4",
            "e36a839f-3dbb-4d8b-17a1-5df3e4577125",
            "e5b6e275-9046-c923-f113-03ea21d71b19",
            "ee719abd-8d18-75e5-fd95-93dfc10b7f3c",
            "f569f3d7-a847-bff0-d7ae-6b7004c46f3b",
            "f8fd4eed-f9f6-eda1-fb6b-dc4a041692b6",
            "fb51ae84-a6d0-1a37-f873-dc99d495d3c1",
            "fc709b17-4a8a-4d81-c58a-4c5462a9ebf5",
            "fd8a2df7-2e91-1064-08fa-cce5de9499a0",
        };
    }
}
