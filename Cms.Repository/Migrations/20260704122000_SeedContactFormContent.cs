using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedContactFormContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Contact page aside (phone/email/channel names) + enquiry form strings
            // (success screen, placeholders, select empty-labels, channel labels,
            // privacy line) as page-content so the whole contact page is editable.
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            foreach (var id in new[]
            {
                "acafd321-b84f-8bed-9a3c-1e80802b2edd",
                "a19a011f-f60e-54db-26cd-561705679b26",
                "2730b789-76bd-57c9-e13b-1c9c79f1d7aa",
                "6776027c-8553-dbaa-242e-091f2ab89311",
                "f8fd4eed-f9f6-eda1-fb6b-dc4a041692b6",
                "5db48b1b-0075-5c1b-13ea-a25a394c8d16",
                "30af64e2-e13d-d3c3-d65e-045b7a8f126d",
                "cf751648-8250-34e4-fd7c-024005948b99",
                "98674d01-7bad-f6cd-b031-7df8692fa305",
                "dfb9f819-19f8-e6a9-6944-4d1d1b377b8e",
                "7883ab8b-f60d-e61a-b2fd-cb03c2b19c8a",
                "2ef9550c-eb97-98db-f04a-5be26505ce83",
                "d81c4391-e16e-48b0-c9c0-08c970044d28",
                "d265d2f5-97d0-4964-7127-488026b17d63",
                "87fdbcce-b4b4-1ed4-28e0-e1ed68b90170",
                "401a90d0-0830-a25b-2cd4-a46fef8439f3",
                "e01224b3-059f-9cc2-efd8-8b8d14cae8b4",
                "553f60fb-a0c6-b765-c2a7-ca0b58ae243e",
                "dd971565-33c5-7d27-cf23-3280ab52dac2",
                "04ef71bf-683b-cafb-bd00-c3887d1734c2",
                "a7455191-3e3e-eaf9-6548-bc2b0c24021d",
                "fd8a2df7-2e91-1064-08fa-cce5de9499a0",
                "23b26806-1270-d65d-a3ec-d25584b0f57f",
                "ee719abd-8d18-75e5-fd95-93dfc10b7f3c",
                "e36a839f-3dbb-4d8b-17a1-5df3e4577125",
            })
            {
                migrationBuilder.DeleteData(table: "PageContents", keyColumn: "Id", keyValue: new Guid(id));
            }
        }
    }
}
