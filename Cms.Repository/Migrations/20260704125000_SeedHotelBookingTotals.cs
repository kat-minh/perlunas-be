using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedHotelBookingTotals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5bf7543d-2bd7-85f9-edec-3abb1a4f2ab8"), "Tổng cộng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.total", "text", "HotelBooking: nhãn Tổng cộng", "Form liên hệ / đặt", null, "", 320, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("14dbcbb2-e8a3-67d1-385e-05f5bd6b1f0c"), "Chọn ngày nhận và trả phòng để tính thành tiền.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.pricehint", "textarea", "HotelBooking: gợi ý tính giá", "Form liên hệ / đặt", null, "", 321, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            foreach (var id in new[] { "5bf7543d-2bd7-85f9-edec-3abb1a4f2ab8", "14dbcbb2-e8a3-67d1-385e-05f5bd6b1f0c" })
                migrationBuilder.DeleteData(table: "PageContents", keyColumn: "Id", keyValue: new Guid(id));
        }
    }
}
