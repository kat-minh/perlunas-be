using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddTaxonomyImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("aa11bb22-0000-0000-0000-000000000103"));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Taxonomies",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000001"),
                column: "Image",
                value: "https://picsum.photos/seed/perlunas-place-ha-noi/800/1000");

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000002"),
                column: "Image",
                value: "https://picsum.photos/seed/perlunas-place-ho-chi-minh/800/1000");

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000003"),
                column: "Image",
                value: "https://picsum.photos/seed/perlunas-place-ha-long/800/1000");

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000004"),
                column: "Image",
                value: "https://picsum.photos/seed/perlunas-place-da-lat/800/1000");

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000005"),
                column: "Image",
                value: "https://picsum.photos/seed/perlunas-place-da-nang/800/1000");

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000006"),
                column: "Image",
                value: "https://picsum.photos/seed/perlunas-place-phu-quoc/800/1000");

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000007"),
                column: "Image",
                value: "https://picsum.photos/seed/perlunas-place-nha-trang/800/1000");

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000008"),
                column: "Image",
                value: "https://picsum.photos/seed/perlunas-place-hue/800/1000");

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000009"),
                column: "Image",
                value: "https://picsum.photos/seed/perlunas-place-sa-pa/800/1000");

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000010"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000011"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000012"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000013"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000014"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000015"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000016"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000017"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000018"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000019"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000020"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000021"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000022"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000023"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000024"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Taxonomies",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000025"),
                column: "Image",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Taxonomies");

            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[] { new Guid("aa11bb22-0000-0000-0000-000000000103"), "", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.combos.tiles", "json", "Combo · Ô vùng đất (tên + ảnh — để trống = tự lấy theo tỉnh)", "Trang chủ", null, "", 22, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

        }
    }
}
