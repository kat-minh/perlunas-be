using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedHeaderFooterNav : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Header brand+hotline (nav.*) and footer link labels (footer.nav.*) as
            // their OWN keys so header is edited in the nav tab and footer in the
            // Footer tab -- editing one does not change the other.
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            foreach (var id in new[]
            {
                "81edc307-cf64-69b0-eb11-2d0c7a410aed",
                "1f0622c2-5d71-b811-789c-1a7942db7b15",
                "d5a137aa-a093-fc20-0255-124c73196b85",
                "36245b96-baf7-bc68-ab44-c0304143b1c4",
                "83e4f96e-8152-95b4-8080-31eaa3a663c4",
                "f569f3d7-a847-bff0-d7ae-6b7004c46f3b",
                "7ec0ff38-ddbb-e6a4-71e5-b370d0603c29",
                "be821323-e0d9-9afe-8200-9f7c3d8cf889",
                "ce750de2-9028-11c4-e0a1-26dbc4c0c47a",
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
