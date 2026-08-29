using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <summary>
    /// Thêm 2 key page-content cho tab "Chia sẻ link" trong admin: `share.title` và
    /// `share.desc` = tiêu đề + mô tả trên thẻ xem trước khi dán link vào Zalo /
    /// Facebook / Messenger (og:title, og:description). Trước đây fix cứng trong
    /// ver3/src/lib/site.ts. Không có 2 row này thì web vẫn hiện đúng (FE fallback về
    /// page-content.json) nhưng admin không thấy ô để sửa.
    /// Đi kèm file .Designer.cs (BuildTargetModel) để InsertData/DeleteData resolve được kiểu cột.
    /// </summary>
    public partial class SeedShareCardKeys : Migration
    {
        private static readonly string[] SeededIds =
        {
            "aa11bb22-0000-0000-0000-000000000110",
            "aa11bb22-0000-0000-0000-000000000111"
        };

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // IDEMPOTENT: DB mới thì đây là no-op; DB đã có sẵn row (chạy lại, hoặc seed tay)
            // thì xoá trước để chèn lại không đụng PK_PageContents. ParentId = null nên xoá không vướng FK.
            foreach (var id in SeededIds)
                migrationBuilder.DeleteData(table: "PageContents", keyColumn: "Id", keyValue: new Guid(id));

            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("aa11bb22-0000-0000-0000-000000000110"), "Perlunas, Mỗi hành trình là một viên ngọc dưới ánh trăng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "share.title", "text", "Tiêu đề (dòng đậm trên thẻ)", "Chia sẻ link", null, "", 300, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("aa11bb22-0000-0000-0000-000000000111"), "Perlunas thiết kế những hành trình du lịch trong nước tinh tế và trọn vẹn: tour trọn gói, đặt phòng khách sạn, gói du lịch, tour đoàn và tour riêng theo yêu cầu.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "share.desc", "textarea", "Mô tả (dòng chữ xám dưới tiêu đề)", "Chia sẻ link", null, "", 301, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            foreach (var id in SeededIds)
                migrationBuilder.DeleteData(table: "PageContents", keyColumn: "Id", keyValue: new Guid(id));
        }
    }
}
