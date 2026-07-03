using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddTourDestinationsAndHotelFacilities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<List<string>>(
                name: "Destinations",
                table: "Services",
                type: "text[]",
                nullable: false,
                defaultValue: new List<string>());

            migrationBuilder.AddColumn<List<string>>(
                name: "Facilities",
                table: "Services",
                type: "text[]",
                nullable: false,
                defaultValue: new List<string>());

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string> { "Da Nang Beach" }, new List<string>(), new List<string> { "Sample service highlights." } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111112"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string> { "Private beach", "spa", "local dining" } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111113"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string> { "Flexible route", "private guide" } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222211"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222212"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222213"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222214"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333311"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string> { "Historic sites." } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333312"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string> { "Spectacular bays." } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333313"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string> { "Bangkok and Phuket." } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destinations",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Facilities",
                table: "Services");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "Highlight",
                value: new List<string> { "Sample service highlights." });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111112"),
                column: "Highlight",
                value: new List<string> { "Private beach", "spa", "local dining" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111113"),
                column: "Highlight",
                value: new List<string> { "Flexible route", "private guide" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222211"),
                column: "Highlight",
                value: new List<string>());

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222212"),
                column: "Highlight",
                value: new List<string>());

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222213"),
                column: "Highlight",
                value: new List<string>());

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222214"),
                column: "Highlight",
                value: new List<string>());

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333311"),
                column: "Highlight",
                value: new List<string> { "Historic sites." });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333312"),
                column: "Highlight",
                value: new List<string> { "Spectacular bays." });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333313"),
                column: "Highlight",
                value: new List<string> { "Bangkok and Phuket." });
        }
    }
}
