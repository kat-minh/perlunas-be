using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddServiceFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Classify",
                table: "Services",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Services",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Form",
                table: "Services",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PurposeOfTrip",
                table: "Services",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "Classify", "Destination", "Form", "PurposeOfTrip" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111112"),
                columns: new[] { "Classify", "Destination", "Feature", "Form", "Instruct", "Introducetion", "Label", "PurposeOfTrip" },
                values: new object[] { null, "Da Nang Beach", null, "Full-board", null, null, null, "ResortVacation" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111113"),
                columns: new[] { "Classify", "Destination", "Form", "PurposeOfTrip", "Type" },
                values: new object[] { "Akoya", "Hoi An Ancient Town", "Half-board", "Sightseeing", "Combo" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classify",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Form",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "PurposeOfTrip",
                table: "Services");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111112"),
                columns: new[] { "Feature", "Instruct", "Introducetion", "Label" },
                values: new object[] { "Resort, breakfast, pool", "Bring identification for check-in.", "Relaxing resort stay for families.", "Family" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111113"),
                column: "Type",
                value: "PrivateTour");
        }
    }
}
