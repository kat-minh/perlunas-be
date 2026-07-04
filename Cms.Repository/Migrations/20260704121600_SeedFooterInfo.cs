using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedFooterInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Footer business info (brand / contact / social) as its own editable
            // page-content group so it is edited IN the Footer tab, not a shared
            // "site info" form. Values mirror the previous site.* defaults.
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            foreach (var id in new[]
            {
                "0a67d369-c817-5732-907c-ca4ab2896bc2",
                "003c42fe-ae4e-58ec-90aa-788014ab3cde",
                "78c851f2-7cbf-51d1-9ae5-38cdee297961",
                "a211247d-d00c-5ee4-ace0-ec6cb684e180",
                "cf3cec90-6bbc-5aa2-b603-83b60809f536",
                "c1ad34c2-b9e6-59b3-b6ff-4cfd34271d62",
                "52539440-77ba-594e-92eb-cd4bcc5a6a6c",
                "c1b3c38a-ad18-5798-8462-cdf91d3cf9b7",
            })
            {
                migrationBuilder.DeleteData(
                    table: "PageContents",
                    keyColumn: "Id",
                    keyValue: new Guid(id));
            }
        }
    }
}
