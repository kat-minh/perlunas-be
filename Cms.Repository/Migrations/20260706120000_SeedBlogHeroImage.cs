using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <summary>
    /// Thêm 1 key page-content "blog.hero.image" (kind=image) cho ảnh hero lớn đầu
    /// trang /blog. Trước đây hero mượn ảnh của bài nổi bật (featured.cover) nên
    /// admin không chỉnh riêng được; giờ có field riêng ở tab Blog (/content), site
    /// gọi pc("blog.hero.image") và fallback featured.cover khi trống. Data-only.
    /// </summary>
    public partial class SeedBlogHeroImage : Migration
    {
        private const string RowId = "e3c8a03d-49bc-44a7-a177-0f4eaf2a15dc";

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // IDEMPOTENT: xoá trước để chèn lại không đụng PK nếu DB đã có (ParentId=null,
            // không phải cha row nào nên xoá an toàn).
            migrationBuilder.DeleteData(table: "PageContents", keyColumn: "Id", keyValue: new Guid(RowId));

            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[] { new Guid(RowId), "https://images.unsplash.com/photo-1500835556837-99ac94a94552?fm=jpg&q=60&w=2000&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "blog.hero.image", "image", "Blog: ảnh hero (ảnh lớn đầu trang)", "Blog", null, "", 409, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(table: "PageContents", keyColumn: "Id", keyValue: new Guid(RowId));
        }
    }
}
