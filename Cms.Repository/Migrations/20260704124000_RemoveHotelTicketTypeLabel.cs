using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class RemoveHotelTicketTypeLabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // The hotel booking ticket now shows the hotel NAME (like the mobile bar),
            // not the "Loại hình" type label, so this page-content label is unused.
            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c6278a8c-4a8b-5462-4094-bfdb852d9475"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[] { new Guid("c6278a8c-4a8b-5462-4094-bfdb852d9475"), "Loại hình", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.ticket.type", "text", "Vé: nhãn loại hình", "Chi tiết khách sạn", null, "", 198, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });
        }
    }
}
