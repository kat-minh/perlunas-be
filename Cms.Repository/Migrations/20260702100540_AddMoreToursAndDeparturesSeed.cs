using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreToursAndDeparturesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Feature", "Form", "Highlight", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-333333333311"), "[]", null, "TOUR-VN1", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, "Explore rich heritage.", null, null, null, "Historic sites.", "All inclusive tour.", null, "Sample tour in Vietnam.", false, true, null, 4, null, "Vietnam", "vietnam-heritage-discovery-tour", "Vietnam Heritage Discovery Tour", "Tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("11111111-1111-1111-1111-333333333312"), "[]", null, "TOUR-VN2", new DateTime(2026, 1, 1, 1, 0, 0, 0, DateTimeKind.Utc), 6, "Explore natural highlights.", null, null, null, "Spectacular bays.", "All inclusive tour.", null, "Sample tour in northern Vietnam.", false, true, null, 5, null, "Vietnam", "vietnam-northern-highlights", "Vietnam Northern Highlights", "Tour", new DateTime(2026, 1, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("11111111-1111-1111-1111-333333333313"), "[]", null, "TOUR-TH1", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Explore Thai islands.", null, null, null, "Bangkok and Phuket.", "Flight not included.", null, "Sample tour in Thailand.", false, true, null, 3, null, "Thailand", "thailand-paradise-getaway", "Thailand Paradise Getaway", "Tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "DepartureSchedules",
                columns: new[] { "Id", "AccommodationStandards", "Code", "CreatedAt", "IsDeleted", "Price", "ServiceId", "StartTime", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-333333333311"), "3-star hotel", "DEP-VN1", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "4000000/customer", new Guid("11111111-1111-1111-1111-333333333311"), "Weekly", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("44444444-4444-4444-4444-333333333312"), "3-star hotel", "DEP-VN2", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "4500000/customer", new Guid("11111111-1111-1111-1111-333333333312"), "Weekly", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("44444444-4444-4444-4444-333333333313"), "3-star hotel", "DEP-TH1", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "3800000/customer", new Guid("11111111-1111-1111-1111-333333333313"), "Weekly", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-333333333311"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-333333333312"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-333333333313"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333311"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333312"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333313"));
        }
    }
}
