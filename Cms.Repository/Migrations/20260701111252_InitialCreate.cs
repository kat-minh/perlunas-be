using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Titile = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    SubTitile = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Author = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ReadingTime = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Tag = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageContents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: true),
                    PageKey = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    SectionKey = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Key = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ContentValue = table.Column<string>(type: "text", nullable: true),
                    Label = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Kind = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    SoftOrder = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PageContents_PageContents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "PageContents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Introducetion = table.Column<string>(type: "text", nullable: true),
                    Day = table.Column<int>(type: "integer", nullable: true),
                    Night = table.Column<int>(type: "integer", nullable: true),
                    Label = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Album = table.Column<string>(type: "text", nullable: true),
                    Region = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Infor = table.Column<string>(type: "text", nullable: true),
                    Highlight = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Instruct = table.Column<string>(type: "text", nullable: true),
                    Feature = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    LegalName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Tagline = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Manifesto = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    TaxId = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    OfficesJson = table.Column<string>(type: "text", nullable: true),
                    SocialJson = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartureSchedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uuid", nullable: false),
                    StartTime = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Price = table.Column<string>(type: "text", nullable: true),
                    AccommodationStandards = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartureSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartureSchedules_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImportantInfors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    SubTitle = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportantInfors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImportantInfors_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Album = table.Column<string>(type: "text", nullable: true),
                    Titile = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    NumberOfCustomer = table.Column<int>(type: "integer", nullable: true),
                    Acreage = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    NumberOfBed = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Feature = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomCategories_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Day = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Titile = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    SubTitile = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Sumary = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Author", "CreatedAt", "Description", "IsDeleted", "ReadingTime", "SubTitile", "Tag", "Titile", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("88888888-8888-8888-8888-888888888881"), "Perlunas Admin", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample blog content.", false, "5 min", "Start here", "guide", "Sample travel guide", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("88888888-8888-8888-8888-888888888882"), "Perlunas Admin", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Tips for selecting a resort package.", false, "7 min", "Family travel tips", "resort", "How to choose a resort", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("88888888-8888-8888-8888-888888888883"), "Perlunas Admin", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "How to prepare for a private custom trip.", false, "6 min", "Flexible journeys", "private-tour", "Private tour planning", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("66666666-6666-6666-6666-666666666661"), "Discover Perlunas", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "title", "text", "Hero title", "home", null, "hero", 1, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("66666666-6666-6666-6666-666666666662"), "We craft thoughtful travel experiences.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "description", "textarea", "About intro", "about", null, "intro", 1, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("66666666-6666-6666-6666-666666666663"), "Choose a journey that fits your style.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "subtitle", "text", "Service banner subtitle", "services", null, "banner", 2, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Code", "CreatedAt", "Day", "Description", "Feature", "Highlight", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "Region", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "[]", "PLN-001", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Sample service description.", "Sample features.", "Sample service highlights.", "Sample service information.", "Sample instructions.", "Sample introduction for the main service.", false, true, "Featured", 2, "Vietnam", "Perlunas Signature Tour", "Tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("11111111-1111-1111-1111-111111111112"), "[]", "PLN-002", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Beachfront resort package.", "Resort, breakfast, pool", "Private beach, spa, local dining", "Includes room and breakfast.", "Bring identification for check-in.", "Relaxing resort stay for families.", false, true, "Family", 3, "Da Nang", "Beach Resort Package", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("11111111-1111-1111-1111-111111111113"), "[]", "PLN-003", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Private travel experience.", "Private guide, custom route", "Flexible route, private guide", "Dedicated guide and vehicle.", "Confirm itinerary before departure.", "Custom private trip with flexible schedule.", false, true, "Private", 1, "Hoi An", "Private Custom Journey", "PrivateTour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "SiteSettings",
                columns: new[] { "Id", "CreatedAt", "Description", "Email", "IsDeleted", "LegalName", "Manifesto", "Name", "OfficesJson", "Phone", "SocialJson", "Tagline", "TaxId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("77777777-7777-7777-7777-777777777771"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample site description.", "hello@perlunas.local", false, "Perlunas Travel Co., Ltd.", "Sample manifesto.", "Perlunas", "[]", "+84000000000", "{}", "Travel with care", "0000000000", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("77777777-7777-7777-7777-777777777772"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Support channel information.", "support@perlunas.local", false, "Perlunas Travel Co., Ltd.", "Support-focused contact settings.", "Perlunas Support", "[]", "+84111111111", "{}", "Always here to help", "0000000000", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("77777777-7777-7777-7777-777777777773"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Branch contact information.", "danang@perlunas.local", false, "Perlunas Da Nang Branch", "Local branch settings.", "Perlunas Da Nang", "[]", "+84222222222", "{}", "Central Vietnam office", "0000000001", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "DepartureSchedules",
                columns: new[] { "Id", "AccommodationStandards", "Code", "CreatedAt", "IsDeleted", "Price", "ServiceId", "StartTime", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444441"), "3-star hotel", "DEP-001", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "3500000/customer", new Guid("11111111-1111-1111-1111-111111111111"), "2026-07-15", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("44444444-4444-4444-4444-444444444442"), "4-star resort", "DEP-002", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "5200000/customer", new Guid("11111111-1111-1111-1111-111111111112"), "2026-09-20", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("44444444-4444-4444-4444-444444444443"), "Boutique hotel", "DEP-003", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "Quote on request", new Guid("11111111-1111-1111-1111-111111111113"), "On request", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "ImportantInfors",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "ServiceId", "SubTitle", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("55555555-5555-5555-5555-555555555551"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Cancellation terms depend on departure date.", false, new Guid("11111111-1111-1111-1111-111111111111"), "Important before booking", "Cancellation policy", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55555555-5555-5555-5555-555555555552"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Guests must present valid identification at check-in.", false, new Guid("11111111-1111-1111-1111-111111111112"), "Required documents", "Resort check-in", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55555555-5555-5555-5555-555555555553"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Final itinerary must be confirmed 48 hours before departure.", false, new Guid("11111111-1111-1111-1111-111111111113"), "Custom planning", "Private itinerary", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("66666666-6666-6666-6666-666666666671"), "Explore breathtaking destinations with us", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "subtitle", "text", "Hero subtitle", "home", new Guid("66666666-6666-6666-6666-666666666661"), "hero", 2, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("66666666-6666-6666-6666-666666666672"), "Book Now", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "cta", "text", "Hero CTA button", "home", new Guid("66666666-6666-6666-6666-666666666661"), "hero", 3, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "RoomCategories",
                columns: new[] { "Id", "Acreage", "Album", "CreatedAt", "Description", "Feature", "IsDeleted", "NumberOfBed", "NumberOfCustomer", "Price", "ServiceId", "Titile", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("33333333-3333-3333-3333-333333333331"), "35m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample deluxe room.", "Balcony, breakfast, sea view", false, 1, 2, "1200000/night", new Guid("11111111-1111-1111-1111-111111111111"), "Deluxe Room", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-333333333332"), "80m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Private family villa near the beach.", "Private pool, kitchen, breakfast", false, 2, 4, "3500000/night", new Guid("11111111-1111-1111-1111-111111111112"), "Family Villa", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "45m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Suite for private journey guests.", "Old town view, breakfast", false, 1, 2, "1800000/night", new Guid("11111111-1111-1111-1111-111111111113"), "Heritage Suite", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "CreatedAt", "Day", "Description", "IsDeleted", "ServiceId", "SubTitile", "Sumary", "Titile", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("22222222-2222-2222-2222-222222222221"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Day 1", "Airport pickup and welcome dinner.", false, new Guid("11111111-1111-1111-1111-111111111111"), "Welcome and check-in", "Arrive and settle in.", "Arrival", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Day 2", "Guided tour and local activities.", false, new Guid("11111111-1111-1111-1111-111111111111"), "Main activities", "Explore the destination.", "Experience", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("22222222-2222-2222-2222-222222222223"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Day 1", "Welcome drink, room check-in, free beach time.", false, new Guid("11111111-1111-1111-1111-111111111112"), "Beach welcome", "Check in and relax.", "Resort check-in", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("22222222-2222-2222-2222-222222222224"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Day 1", "Custom stops based on customer preference.", false, new Guid("11111111-1111-1111-1111-111111111113"), "Flexible city tour", "Private tour with local guide.", "Private discovery", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartureSchedules_ServiceId",
                table: "DepartureSchedules",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportantInfors_ServiceId",
                table: "ImportantInfors",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_PageContents_PageKey_SectionKey",
                table: "PageContents",
                columns: new[] { "PageKey", "SectionKey" });

            migrationBuilder.CreateIndex(
                name: "IX_PageContents_ParentId",
                table: "PageContents",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCategories_ServiceId",
                table: "RoomCategories",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ServiceId",
                table: "Schedules",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_Code",
                table: "Services",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Services_Type",
                table: "Services",
                column: "Type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "DepartureSchedules");

            migrationBuilder.DropTable(
                name: "ImportantInfors");

            migrationBuilder.DropTable(
                name: "PageContents");

            migrationBuilder.DropTable(
                name: "RoomCategories");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "SiteSettings");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
