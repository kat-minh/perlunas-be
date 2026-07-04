using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedMissingPageContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Keys present in the FE page-content defaults but never seeded in BE, so
            // admin had no field to edit them (they looked hardcoded). Seed them.
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("24dcbeea-a39f-5d1b-33b3-0853c524dbbd"), "Tour đoàn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.eyebrow", "text", "Tour đoàn · Nhãn", "Trang chủ", null, "", 21, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d4b34839-e57b-d977-7328-01267ae62a4b"), "Lưu trú", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.ticketbar.name", "text", "Vé (mobile): nhãn tên lưu trú", "Chi tiết khách sạn", null, "", 197, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            foreach (var id in new[]
            {
                "24dcbeea-a39f-5d1b-33b3-0853c524dbbd",
                "d4b34839-e57b-d977-7328-01267ae62a4b",
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
