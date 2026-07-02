using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRoomCategoryAndSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PageContents_PageKey_SectionKey",
                table: "PageContents");

            migrationBuilder.DropColumn(
                name: "SubTitile",
                table: "Schedules");

            migrationBuilder.AlterColumn<string>(
                name: "NumberOfBed",
                table: "RoomCategories",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginalPrice",
                table: "RoomCategories",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "RoomCategories",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333331"),
                columns: new[] { "NumberOfBed", "OriginalPrice", "Price", "Unit" },
                values: new object[] { "1", "1500000", "1200000", "đêm" });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333332"),
                columns: new[] { "NumberOfBed", "OriginalPrice", "Price", "Unit" },
                values: new object[] { "2", "4000000", "3500000", "đêm" });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "NumberOfBed", "OriginalPrice", "Unit" },
                values: new object[] { "1", "2200000", "đêm" });

            migrationBuilder.CreateIndex(
                name: "IX_PageContents_PageKey_SectionKey_Key",
                table: "PageContents",
                columns: new[] { "PageKey", "SectionKey", "Key" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PageContents_PageKey_SectionKey_Key",
                table: "PageContents");

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "RoomCategories");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "RoomCategories");

            migrationBuilder.AddColumn<string>(
                name: "SubTitile",
                table: "Schedules",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfBed",
                table: "RoomCategories",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333331"),
                columns: new[] { "NumberOfBed", "Price" },
                values: new object[] { 1, "1200000/night" });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333332"),
                columns: new[] { "NumberOfBed", "Price" },
                values: new object[] { 2, "3500000/night" });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "NumberOfBed",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222221"),
                column: "SubTitile",
                value: "Welcome and check-in");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "SubTitile",
                value: "Main activities");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222223"),
                column: "SubTitile",
                value: "Beach welcome");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222224"),
                column: "SubTitile",
                value: "Flexible city tour");

            migrationBuilder.CreateIndex(
                name: "IX_PageContents_PageKey_SectionKey",
                table: "PageContents",
                columns: new[] { "PageKey", "SectionKey" });
        }
    }
}
