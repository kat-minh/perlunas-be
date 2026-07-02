using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedsForTourAndHotels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RoomCategories",
                columns: new[] { "Id", "Acreage", "Album", "CreatedAt", "Description", "Feature", "IsDeleted", "NumberOfBed", "NumberOfCustomer", "OriginalPrice", "Price", "ServiceId", "Titile", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("33333333-3333-3333-3333-111111111111"), "25m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Comfortable standard room for tour guests.", "[\"Wifi\",\"TV\"]", false, "2", 2, "1000000", "800000", new Guid("11111111-1111-1111-1111-111111111111"), "Standard Tour Room", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-111111111112"), "28m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Cozy superior room with city views.", "[\"Wifi\",\"Mini-bar\"]", false, "1", 2, "1200000", "1000000", new Guid("11111111-1111-1111-1111-111111111111"), "Superior Tour Room", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-111111111113"), "32m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Deluxe room offering premium comfort.", "[\"Wifi\",\"Balcony\",\"AC\"]", false, "1 Large", 2, "1600000", "1300000", new Guid("11111111-1111-1111-1111-111111111111"), "Deluxe Tour Room", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-111111111114"), "45m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Executive suite with a separate lounge area.", "[\"Lounge access\",\"Bathtub\"]", false, "1 King + 1 Single", 3, "2500000", "2000000", new Guid("11111111-1111-1111-1111-111111111111"), "Executive Tour Suite", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-111111111115"), "50m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Perfect suite designed for family travelers.", "[\"Kid friendly\",\"Kitchenette\"]", false, "2 Large", 4, "3000000", "2500000", new Guid("11111111-1111-1111-1111-111111111111"), "Family Tour Suite", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-111111111116"), "40m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Indulge in our premium tour suite experience.", "[\"Jacuzzi\",\"Welcome drink\"]", false, "1 King", 2, "2800000", "2200000", new Guid("11111111-1111-1111-1111-111111111111"), "Premium Tour Suite", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-111111111117"), "38m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Direct pool access from your patio.", "[\"Pool access\",\"Patio\"]", false, "1 King", 2, "2200000", "1800000", new Guid("11111111-1111-1111-1111-111111111111"), "Tour Cabana Room", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-111111111118"), "30m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Room featuring panoramic floor-to-ceiling windows.", "[\"View\",\"Coffee maker\"]", false, "1 Queen", 2, "1800000", "1500000", new Guid("11111111-1111-1111-1111-111111111111"), "Panoramic View Room", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-111111111119"), "42m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Romantic suite styled for honeymooners.", "[\"Flowers\",\"Champagne\"]", false, "1 King", 2, "3000000", "2400000", new Guid("11111111-1111-1111-1111-111111111111"), "Honeymoon Tour Suite", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-111111111120"), "120m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The ultimate luxury stay with top amenities.", "[\"Butler service\",\"Kitchen\"]", false, "2 King", 4, "6500000", "5000000", new Guid("11111111-1111-1111-1111-111111111111"), "Presidential Tour Suite", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Feature", "Form", "Highlight", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[] { new Guid("11111111-1111-1111-1111-222222222211"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Sapa Valley", "Mountain view, organic restaurant", "Bed and breakfast", null, null, "Eco guidelines apply.", "Scenic lodge in the heart of nature.", false, true, null, null, "ResortVacation", "Vietnam", "vietnam-eco-lodge", "Vietnam Eco Lodge", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "BestSeller", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Feature", "Form", "Highlight", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[] { new Guid("11111111-1111-1111-1111-222222222212"), "[]", true, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Hanoi Old Quarter", "City view, spa, fitness center", "Room only", null, null, "Check-in after 14:00.", "Luxury hotel in the historical quarter.", false, true, null, null, "Sightseeing", "Vietnam", "hanoi-royal-palace-hotel", "Hanoi Royal Palace Hotel", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Feature", "Form", "Highlight", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-222222222213"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Ho Chi Minh City", "Rooftop bar, pool", "Room only", null, null, "Strictly non-smoking.", "Elegant boutique hotel reflecting local heritage.", false, true, null, null, "Sightseeing", "Vietnam", "saigon-heritage-hotel", "Saigon Heritage Hotel", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("11111111-1111-1111-1111-222222222214"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Phu Quoc Island", "Private beach, infinity pool", "Full-board", null, null, "No pets allowed.", "Seaside resort with stunning sunset views.", false, true, null, null, "ResortVacation", "Vietnam", "phu-quoc-sunset-resort", "Phu Quoc Sunset Resort", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "RoomCategories",
                columns: new[] { "Id", "Acreage", "Album", "CreatedAt", "Description", "Feature", "IsDeleted", "NumberOfBed", "NumberOfCustomer", "OriginalPrice", "Price", "ServiceId", "Titile", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("33333333-3333-3333-3333-222222222211"), "30m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Eco-friendly wood cabin room.", "[\"Mountain view\",\"organic tea\"]", false, "1 Queen", 2, "1100000", "950000", new Guid("11111111-1111-1111-1111-222222222211"), "Eco Lodge Room", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-222222222212"), "45m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Luxurious royal room with classic decor.", "[\"City view\",\"jacuzzi\"]", false, "1 King", 2, "2600000", "2100000", new Guid("11111111-1111-1111-1111-222222222212"), "Royal Suite", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-222222222213"), "35m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Charming room with historical accents.", "[\"Garden view\",\"espresso machine\"]", false, "1 Double", 2, "1700000", "1400000", new Guid("11111111-1111-1111-1111-222222222213"), "Heritage Room", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-222222222214"), "40m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Direct beach view from your room balcony.", "[\"Beachfront\",\"Sunset view\"]", false, "1 King", 2, "3300000", "2800000", new Guid("11111111-1111-1111-1111-222222222214"), "Sunset Beach Room", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-111111111111"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-111111111112"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-111111111113"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-111111111114"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-111111111115"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-111111111116"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-111111111117"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-111111111118"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-111111111119"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-111111111120"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-222222222211"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-222222222212"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-222222222213"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-222222222214"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222211"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222212"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222213"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222214"));
        }
    }
}
