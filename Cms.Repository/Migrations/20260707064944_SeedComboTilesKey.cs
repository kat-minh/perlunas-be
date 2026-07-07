using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedComboTilesKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[] { new Guid("aa11bb22-0000-0000-0000-000000000103"), "", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.combos.tiles", "json", "Combo · Ô vùng đất (tên + ảnh — để trống = tự lấy theo tỉnh)", "Trang chủ", null, "", 22, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("aa11bb22-0000-0000-0000-000000000103"));

        }
    }
}
