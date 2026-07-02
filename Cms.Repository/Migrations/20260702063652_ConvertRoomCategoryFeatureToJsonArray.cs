using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ConvertRoomCategoryFeatureToJsonArray : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333331"),
                column: "Feature",
                value: "[\"Balcony\",\"breakfast\",\"sea view\"]");

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333332"),
                column: "Feature",
                value: "[\"Private pool\",\"kitchen\",\"breakfast\"]");

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "Feature",
                value: "[\"Old town view\",\"breakfast\"]");

            migrationBuilder.Sql("""
                UPDATE "RoomCategories"
                SET "Feature" = '["' || replace(replace("Feature", '"', '\\"'), ', ', '","') || '"]'
                WHERE "Feature" IS NOT NULL
                  AND btrim("Feature") <> ''
                  AND btrim("Feature") NOT LIKE '[%';
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333331"),
                column: "Feature",
                value: "Balcony, breakfast, sea view");

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333332"),
                column: "Feature",
                value: "Private pool, kitchen, breakfast");

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "Feature",
                value: "Old town view, breakfast");
        }
    }
}
