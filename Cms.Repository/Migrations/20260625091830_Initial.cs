using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComboTiers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Tagline = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Pearl = table.Column<string>(type: "text", nullable: false),
                    Story = table.Column<string>(type: "text", nullable: false),
                    Includes = table.Column<List<string>>(type: "text[]", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboTiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Combos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Slug = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Tier = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    HotelName = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    City = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    StayType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Nights = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Featured = table.Column<bool>(type: "boolean", nullable: false),
                    Cover = table.Column<string>(type: "text", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Phone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Subject = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    Message = table.Column<string>(type: "text", nullable: false),
                    IsRead = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupTours",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupTours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Slug = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    City = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Price = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Desc = table.Column<string>(type: "text", nullable: false),
                    Featured = table.Column<bool>(type: "boolean", nullable: false),
                    Cover = table.Column<string>(type: "text", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageContents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Key = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    Page = table.Column<string>(type: "text", nullable: false),
                    Label = table.Column<string>(type: "text", nullable: false),
                    Kind = table.Column<string>(type: "text", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrivateTours",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateTours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    LegalName = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Tagline = table.Column<string>(type: "text", nullable: false),
                    Manifesto = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    TaxId = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    OfficesJson = table.Column<string>(type: "jsonb", nullable: false),
                    SocialJson = table.Column<string>(type: "jsonb", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taxonomies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Group = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Slug = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxonomies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Slug = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Region = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Nights = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Price = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Teaser = table.Column<string>(type: "text", nullable: false),
                    Highlights = table.Column<List<string>>(type: "text[]", nullable: false),
                    Stays = table.Column<List<string>>(type: "text[]", nullable: false),
                    Cover = table.Column<string>(type: "text", nullable: false),
                    Featured = table.Column<bool>(type: "boolean", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Role = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ComboTiers",
                columns: new[] { "Id", "CreatedAt", "Includes", "IsDeleted", "Name", "Pearl", "SortOrder", "Story", "Tagline", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("60000000-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new List<string> { "Khách sạn 3-4 sao trung tâm", "Xe đưa đón và di chuyển theo lịch trình", "Ăn sáng mỗi ngày", "Hướng dẫn viên ở các điểm chính", "Vé tham quan cơ bản" }, false, "Akoya", "Ngọc Akoya nhỏ nhắn, tròn đều và sáng trong, là dòng ngọc cổ điển làm nên vẻ đẹp thanh lịch quen thuộc.", 1, "Gói khởi đầu vừa vặn: gọn gàng, chỉn chu, đủ đầy những điều quan trọng nhất cho một chuyến đi nhẹ nhàng.", "Khởi đầu tinh tế", null },
                    { new Guid("60000000-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new List<string> { "Khách sạn 4-5 sao", "Xe riêng cho nhóm", "Ăn sáng và một số bữa đặc sản", "Hướng dẫn viên xuyên suốt", "Trải nghiệm địa phương riêng (lớp nấu ăn, làng nghề…)" }, false, "Tahiti", "Ngọc Tahiti mang sắc huyền bí của biển sâu, ánh lên những tầng màu khó quên, hiếm và cá tính.", 2, "Gói trải nghiệm đậm hơn: nhiều khoảnh khắc riêng tư, những trải nghiệm địa phương được chọn lọc kỹ.", "Trải nghiệm đậm sâu", null },
                    { new Guid("60000000-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new List<string> { "Resort/khách sạn 5 sao", "Xe riêng và tài xế suốt hành trình", "Trọn bữa, nhà hàng chọn lọc", "Trải nghiệm độc quyền, vé ưu tiên", "Hỗ trợ concierge 24/7" }, false, "South Sea", "Ngọc South Sea là dòng ngọc quý và lớn nhất, ánh vàng hoặc trắng sang trọng, biểu tượng của sự trọn vẹn.", 3, "Gói trọn vẹn nhất: chăm chút từng chi tiết, riêng tư và thượng hạng từ đầu đến cuối hành trình.", "Trọn vẹn thượng hạng", null }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "City", "Cover", "CreatedAt", "Featured", "HotelName", "IsDeleted", "Nights", "Price", "Slug", "SortOrder", "StayType", "Tier", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("50000000-0000-0000-0000-000000000001"), "Đà Nẵng", "https://picsum.photos/seed/akoya-intercontinental-da-nang-2d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Intercontinental Đà Nẵng", false, 2, "5.000.000đ/khách", "akoya-intercontinental-da-nang-2d", 1, "Resort", "Akoya", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50000000-0000-0000-0000-000000000002"), "Hà Nội", "https://picsum.photos/seed/tahiti-sheraton-ha-noi-3d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Sheraton Hà Nội", false, 3, "8.000.000đ/khách", "tahiti-sheraton-ha-noi-3d", 2, "Hotel", "Tahiti", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50000000-0000-0000-0000-000000000003"), "Hà Nội", "https://picsum.photos/seed/akoya-sheraton-ha-noi-2d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "Sheraton Hà Nội", false, 2, "5.000.000đ/khách", "akoya-sheraton-ha-noi-2d", 3, "Hotel", "Akoya", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50000000-0000-0000-0000-000000000004"), "Hà Nội", "https://picsum.photos/seed/tahiti-sheraton-ha-noi-4d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "Sheraton Hà Nội", false, 4, "15.000.000đ/khách", "tahiti-sheraton-ha-noi-4d", 4, "Hotel", "Tahiti", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50000000-0000-0000-0000-000000000005"), "Phú Quốc", "https://picsum.photos/seed/south-sea-intercontinental-phu-quoc-3d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "InterContinental Phú Quốc", false, 3, "12.000.000đ/khách", "south-sea-intercontinental-phu-quoc-3d", 5, "Resort", "South Sea", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50000000-0000-0000-0000-000000000006"), "Phú Quốc", "https://picsum.photos/seed/tahiti-jw-marriott-phu-quoc-3d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "JW Marriott Phú Quốc", false, 3, "9.000.000đ/khách", "tahiti-jw-marriott-phu-quoc-3d", 6, "Resort", "Tahiti", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50000000-0000-0000-0000-000000000007"), "Phú Quốc", "https://picsum.photos/seed/south-sea-jw-marriott-phu-quoc-4d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "JW Marriott Phú Quốc", false, 4, "16.000.000đ/khách", "south-sea-jw-marriott-phu-quoc-4d", 7, "Resort", "South Sea", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50000000-0000-0000-0000-000000000008"), "Nha Trang", "https://picsum.photos/seed/akoya-vinpearl-nha-trang-2d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Vinpearl Nha Trang", false, 2, "4.500.000đ/khách", "akoya-vinpearl-nha-trang-2d", 8, "Resort", "Akoya", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50000000-0000-0000-0000-000000000009"), "Nha Trang", "https://picsum.photos/seed/tahiti-vinpearl-nha-trang-3d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "Vinpearl Nha Trang", false, 3, "7.500.000đ/khách", "tahiti-vinpearl-nha-trang-3d", 9, "Resort", "Tahiti", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50000000-0000-0000-0000-00000000000a"), "Đà Lạt", "https://picsum.photos/seed/south-sea-ana-mandara-da-lat-3d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Ana Mandara Đà Lạt", false, 3, "11.000.000đ/khách", "south-sea-ana-mandara-da-lat-3d", 10, "Retreat", "South Sea", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50000000-0000-0000-0000-00000000000b"), "Đà Lạt", "https://picsum.photos/seed/akoya-terracotta-da-lat-2d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "Terracotta Đà Lạt", false, 2, "4.000.000đ/khách", "akoya-terracotta-da-lat-2d", 11, "Resort", "Akoya", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50000000-0000-0000-0000-00000000000c"), "Hạ Long", "https://picsum.photos/seed/tahiti-sheraton-ha-long-3d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Sheraton Hạ Long", false, 3, "8.500.000đ/khách", "tahiti-sheraton-ha-long-3d", 12, "Hotel", "Tahiti", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50000000-0000-0000-0000-00000000000d"), "Sa Pa", "https://picsum.photos/seed/akoya-de-la-coupole-sa-pa-2d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "Hôtel de la Coupole Sa Pa", false, 2, "5.500.000đ/khách", "akoya-de-la-coupole-sa-pa-2d", 13, "Hotel", "Akoya", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50000000-0000-0000-0000-00000000000e"), "Đà Nẵng", "https://picsum.photos/seed/south-sea-naman-da-nang-3d/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "Naman Retreat Đà Nẵng", false, 3, "13.000.000đ/khách", "south-sea-naman-da-nang-3d", 14, "Retreat", "South Sea", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "ContactMessages",
                columns: new[] { "Id", "CreatedAt", "Email", "IsDeleted", "IsRead", "Message", "Name", "Phone", "Subject", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a0000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), "an.nguyen@example.com", false, false, "Chào Perlunas, gia đình mình 4 người muốn đi Hà Giang mùa hoa tam giác mạch tháng 11.", "Nguyễn Văn An", "0901234567", "Tư vấn tour Hà Giang tháng 11", null },
                    { new Guid("a0000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Utc), "binh.tran@example.com", false, false, "Mình muốn đặt combo Phú Quốc 3 ngày 2 đêm cho 2 người vào cuối tháng này.", "Trần Thị Bình", "0938111222", "Đặt combo Phú Quốc cho 2 người", null },
                    { new Guid("a0000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Utc), "cuong.le@example.com", false, true, "Công ty mình cần tổ chức team building biển đảo cho khoảng 30 nhân viên.", "Lê Hoàng Cường", "0977333444", "Tour team building cho công ty 30 người", null }
                });

            migrationBuilder.InsertData(
                table: "GroupTours",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "SortOrder", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("80000000-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Chương trình team building biển đảo, gắn kết đội ngũ với các hoạt động vận động và gala dinner.", "https://picsum.photos/seed/group-teambuilding/1200/800", false, 1, "Tour đoàn doanh nghiệp (Team Building)", null },
                    { new Guid("80000000-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hành trình trải nghiệm giáo dục, về nguồn và khám phá di sản phù hợp cho các trường học.", "https://picsum.photos/seed/group-student/1200/800", false, 2, "Tour đoàn học sinh – sinh viên", null },
                    { new Guid("80000000-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lịch trình nghỉ dưỡng cao cấp dành cho các chương trình tri ân, hội nghị khách hàng quy mô lớn.", "https://picsum.photos/seed/group-vip/1200/800", false, 3, "Tour đoàn tri ân khách hàng", null }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Cover", "CreatedAt", "Desc", "Featured", "IsDeleted", "Name", "Price", "Slug", "SortOrder", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("40000000-0000-0000-0000-000000000001"), "Phú Quốc", "https://picsum.photos/seed/lunar-bay/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khu nghỉ dưỡng bên bãi biển riêng phía Nam đảo Ngọc, hồ bơi vô cực hướng hoàng hôn.", true, false, "Lunar Bay Resort", "3.500.000đ/đêm", "lunar-bay", 1, "Resort", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000002"), "Phú Quốc", "https://picsum.photos/seed/pearl-cove/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bungalow ven biển, bến tàu riêng và nhà hàng hải sản trên mặt nước.", false, false, "Pearl Cove Resort", "4.200.000đ/đêm", "pearl-cove", 2, "Resort", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000003"), "Hội An", "https://picsum.photos/seed/maison-de-lune/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khách sạn boutique trong phố cổ, kiến trúc Đông Dương bên dòng Hoài giang.", true, false, "Maison de Lune", "2.000.000đ/đêm", "maison-de-lune", 3, "Boutique Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000004"), "Hội An", "https://picsum.photos/seed/an-yen-boutique/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Không gian nhỏ xinh giữa vườn, xe đạp dạo phố và lớp nấu ăn địa phương.", false, false, "An Yên Boutique", "1.600.000đ/đêm", "an-yen-boutique", 4, "Boutique Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000005"), "Đà Lạt", "https://picsum.photos/seed/serenity-retreat/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ẩn mình giữa rừng thông, mỗi sáng thức dậy trong sương và tiếng chim.", true, false, "Serenity Retreat", "2.500.000đ/đêm", "serenity-retreat", 5, "Retreat", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000006"), "Đà Lạt", "https://picsum.photos/seed/pinewood-wellness/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Spa thảo mộc, yoga buổi sớm và thực đơn chữa lành giữa cao nguyên.", false, false, "Pinewood Wellness", "2.800.000đ/đêm", "pinewood-wellness", 6, "Wellness", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000007"), "Đà Lạt", "https://picsum.photos/seed/stella-dalat/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khách sạn trung tâm, vài bước tới chợ đêm và hồ Xuân Hương.", false, false, "Stella Hotel", "1.400.000đ/đêm", "stella-dalat", 7, "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000008"), "Nha Trang", "https://picsum.photos/seed/azure-bay/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Resort mặt biển, hồ bơi nhiều tầng và khu vui chơi cho gia đình.", true, false, "Azure Bay Resort", "3.200.000đ/đêm", "azure-bay", 8, "Resort", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000009"), "Nha Trang", "https://picsum.photos/seed/ocean-pearl/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng hướng vịnh, hồ bơi tầng thượng nhìn toàn cảnh thành phố biển.", false, false, "Ocean Pearl Hotel", "1.800.000đ/đêm", "ocean-pearl", 9, "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-00000000000a"), "Hạ Long", "https://picsum.photos/seed/halong-pearl/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngay mặt vịnh, thuận tiện cho hành trình du thuyền khám phá đảo đá.", true, false, "Hạ Long Pearl Hotel", "1.900.000đ/đêm", "halong-pearl", 10, "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-00000000000b"), "Hạ Long", "https://picsum.photos/seed/bay-wellness/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khu nghỉ trị liệu yên tĩnh, tắm khoáng nóng nhìn ra vịnh di sản.", false, false, "Bay Wellness", "2.600.000đ/đêm", "bay-wellness", 11, "Wellness", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-00000000000c"), "Hà Nội", "https://picsum.photos/seed/metropole-lune/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phong cách cổ điển giữa phố Pháp, cách Hồ Gươm vài phút đi bộ.", true, false, "Metropole Lune", "2.400.000đ/đêm", "metropole-lune", 12, "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-00000000000d"), "Hà Nội", "https://picsum.photos/seed/old-quarter-boutique/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khách sạn nhỏ trong phố cổ, ban công nhìn xuống nhịp sống ngàn năm.", false, false, "Old Quarter Boutique", "1.700.000đ/đêm", "old-quarter-boutique", 13, "Boutique Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-00000000000e"), "Sa Pa", "https://picsum.photos/seed/sapa-cloud/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Nhà gỗ trên sườn núi, ngắm ruộng bậc thang và biển mây mỗi sớm.", true, false, "Sa Pa Cloud Retreat", "2.200.000đ/đêm", "sapa-cloud", 14, "Retreat", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-00000000000f"), "Đà Nẵng", "https://picsum.photos/seed/danang-grand/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sát biển Mỹ Khê, gần cầu Rồng và phố ẩm thực sôi động.", false, false, "Đà Nẵng Grand Hotel", "1.900.000đ/đêm", "danang-grand", 15, "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "Page", "SortOrder", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hero.eyebrow", "text", "Hero · Nhãn", "Trang chủ", 1, null, "Thiết kế hành trình du lịch trong nước" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hero.title", "textarea", "Hero · Tiêu đề", "Trang chủ", 2, null, "Mỗi hành trình\nlà một viên ngọc." },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hero.subtitle", "textarea", "Hero · Đoạn mô tả", "Trang chủ", 3, null, "Perlunas thiết kế những chuyến đi trong nước đáng nhớ, tinh tế trong từng chi tiết và trọn vẹn từ đầu đến cuối." },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hero.cta.primary", "text", "Hero · Nút chính", "Trang chủ", 4, null, "Khám phá hành trình" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hero.cta.secondary", "text", "Hero · Nút phụ", "Trang chủ", 5, null, "Liên hệ tư vấn" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hero.video", "image", "Hero · Video nền (URL)", "Trang chủ", 6, null, "/hero-vid.mp4" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.philosophy.eyebrow", "text", "Triết lý · Nhãn", "Trang chủ", 7, null, "Triết lý" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.philosophy.text", "textarea", "Triết lý · Nội dung", "Trang chủ", 8, null, "Một hành trình đẹp bắt đầu từ cảm giác bạn mang theo, không phải điểm đến. Vì thế Perlunas không tạo ra những chuyến đi rập khuôn. Chúng tôi lắng nghe từng người, rồi thiết kế một hành trình vừa vặn, chỉn chu trong từng chi tiết. Với chúng tôi, mỗi vị khách là một viên ngọc." },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.packagetours.eyebrow", "text", "Tour trọn gói · Nhãn", "Trang chủ", 9, null, "Tour trọn gói" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.packagetours.title", "textarea", "Tour trọn gói · Tiêu đề", "Trang chủ", 10, null, "Những hành trình đã thiết kế sẵn." },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.packagetours.subtitle", "textarea", "Tour trọn gói · Mô tả", "Trang chủ", 11, null, "Những trải nghiệm chỉn chu, khơi gợi cảm hứng cho mỗi chuyến đi." },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.packagetours.cta", "text", "Tour trọn gói · Nút thẻ", "Trang chủ", 12, null, "Xem chi tiết" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hotels.eyebrow", "text", "Khách sạn · Nhãn", "Trang chủ", 13, null, "Khách sạn" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hotels.title", "textarea", "Khách sạn · Tiêu đề", "Trang chủ", 14, null, "Những chỗ nghỉ được tuyển chọn." },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hotels.link", "text", "Khách sạn · Liên kết xem thêm", "Trang chủ", 15, null, "Xem thêm tất cả khách sạn" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.combos.eyebrow", "text", "Combo · Nhãn", "Trang chủ", 16, null, "Combo du lịch" },
                    { new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.combos.title", "textarea", "Combo · Tiêu đề", "Trang chủ", 17, null, "Chọn một vùng đất để bắt đầu." },
                    { new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.combos.text", "textarea", "Combo · Mô tả", "Trang chủ", 18, null, "Mỗi điểm đến có ba gói combo theo mức độ trải nghiệm: Akoya, Tahiti và South Sea, đặt theo tên ba dòng ngọc trai quý." },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.combos.link", "text", "Combo · Liên kết", "Trang chủ", 19, null, "Tìm hiểu ba gói ngọc" },
                    { new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.combos.viewall", "text", "Combo · Ô xem tất cả", "Trang chủ", 20, null, "Xem tất cả" },
                    { new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.title", "textarea", "Tour đoàn · Tiêu đề", "Trang chủ", 21, null, "Đoàn đông tới mấy, vẫn trọn vẹn từng người" },
                    { new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.p1", "textarea", "Tour đoàn · Đoạn 1", "Trang chủ", 22, null, "Một chuyến đi đoàn không bắt đầu từ số lượng người, mà từ cảm giác mọi người cùng thuộc về một hành trình. Điều khó nhất không phải là đưa nhiều người đi cùng nhau, mà là giữ cho ai cũng thấy mình được quan tâm." },
                    { new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.p2", "textarea", "Tour đoàn · Đoạn 2", "Trang chủ", 23, null, "Đó là lý do Perlunas tìm hiểu từng đoàn trước khi lên lịch: mục tiêu, độ tuổi, ngân sách và nhịp đi riêng. Chúng tôi lo trọn từ vận chuyển, lưu trú, ăn uống đến kịch bản gắn kết, với một đầu mối duy nhất xuyên suốt." },
                    { new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.p3", "textarea", "Tour đoàn · Đoạn 3", "Trang chủ", 24, null, "Hãy kể cho chúng tôi về đoàn của bạn." },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.cta", "text", "Tour đoàn · Nút", "Trang chủ", 25, null, "Liên hệ tư vấn" },
                    { new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.eyebrow", "text", "Tour riêng tư · Nhãn", "Trang chủ", 26, null, "Tour riêng tư" },
                    { new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.title", "textarea", "Tour riêng tư · Tiêu đề", "Trang chủ", 27, null, "Hành trình may đo cho riêng bạn." },
                    { new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.cta", "text", "Tour riêng tư · Nút", "Trang chủ", 28, null, "Đề xuất chi tiết" },
                    { new Guid("00000000-0000-0000-0000-000000000029"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.eyebrow", "text", "Về chúng tôi · Nhãn", "Trang chủ", 29, null, "Về chúng tôi" },
                    { new Guid("00000000-0000-0000-0000-000000000030"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.image", "image", "Về chúng tôi · Ảnh", "Trang chủ", 30, null, "/about.png" },
                    { new Guid("00000000-0000-0000-0000-000000000031"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.salutation", "text", "Về chúng tôi · Lời chào", "Trang chủ", 31, null, "Thân gửi bạn," },
                    { new Guid("00000000-0000-0000-0000-000000000032"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.p1", "textarea", "Về chúng tôi · Đoạn 1", "Trang chủ", 32, null, "Cảm ơn bạn đã ghé Perlunas. Chúng tôi tin rằng một hành trình đẹp không bắt đầu từ điểm đến, mà từ cảm giác bạn mang theo trên suốt chặng đường." },
                    { new Guid("00000000-0000-0000-0000-000000000033"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.p2", "textarea", "Về chúng tôi · Đoạn 2", "Trang chủ", 33, null, "Vì thế, chúng tôi không tạo ra những chuyến đi rập khuôn. Chúng tôi lắng nghe câu chuyện của từng người, rồi thiết kế một lịch trình vừa vặn — chỉn chu trong từng chi tiết, tinh tế và trọn vẹn từ đầu đến cuối." },
                    { new Guid("00000000-0000-0000-0000-000000000034"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.p3", "textarea", "Về chúng tôi · Đoạn 3", "Trang chủ", 34, null, "Với chúng tôi, mỗi vị khách là một viên ngọc. Và Perlunas xin được là ánh trăng lặng lẽ dõi theo, đồng hành cùng bạn qua thật nhiều hành trình." },
                    { new Guid("00000000-0000-0000-0000-000000000035"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.signoff", "text", "Về chúng tôi · Lời kết", "Trang chủ", 35, null, "Hẹn gặp bạn trên những cung đường," },
                    { new Guid("00000000-0000-0000-0000-000000000036"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.signature", "text", "Về chúng tôi · Chữ ký", "Trang chủ", 36, null, "Perlunas" },
                    { new Guid("00000000-0000-0000-0000-000000000037"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.partners.eyebrow", "text", "Đối tác · Nhãn", "Trang chủ", 37, null, "Đối tác đồng hành" },
                    { new Guid("00000000-0000-0000-0000-000000000038"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.partners.list", "textarea", "Đối tác · Danh sách", "Trang chủ", 38, null, "Vietnam Airlines\nVietravel\nSaigontourist\nMường Thanh\nVinpearl\nBamboo Airways\nAccor Hotels\nSun World\nVietjet Air\nMarriott" },
                    { new Guid("00000000-0000-0000-0000-000000000039"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.whyus.title", "text", "Tại sao chọn · Tiêu đề", "Trang chủ", 39, null, "Tại sao chọn Perlunas?" },
                    { new Guid("00000000-0000-0000-0000-000000000040"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.whyus.1.title", "text", "Lý do 1 · Tiêu đề", "Trang chủ", 40, null, "Giá minh bạch" },
                    { new Guid("00000000-0000-0000-0000-000000000041"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.whyus.2.title", "text", "Lý do 2 · Tiêu đề", "Trang chủ", 41, null, "Tư vấn miễn phí" },
                    { new Guid("00000000-0000-0000-0000-000000000042"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.whyus.3.title", "text", "Lý do 3 · Tiêu đề", "Trang chủ", 42, null, "Lịch trình may đo" },
                    { new Guid("00000000-0000-0000-0000-000000000043"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.whyus.4.title", "text", "Lý do 4 · Tiêu đề", "Trang chủ", 43, null, "Hỗ trợ tận nơi" },
                    { new Guid("00000000-0000-0000-0000-000000000044"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.whyus.5.title", "text", "Lý do 5 · Tiêu đề", "Trang chủ", 44, null, "Trải nghiệm địa phương" },
                    { new Guid("00000000-0000-0000-0000-000000000045"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.eyebrow", "text", "Hero · Nhãn", "Giới thiệu", 45, null, "Về chúng tôi" },
                    { new Guid("00000000-0000-0000-0000-000000000046"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.hero.intro", "textarea", "Hero · Câu tuyên ngôn", "Giới thiệu", 46, null, "Perlunas không bán những chuyến đi rập khuôn. Chúng tôi thiết kế những hành trình hợp với từng con người: tử tế, tinh tế và trọn vẹn." },
                    { new Guid("00000000-0000-0000-0000-000000000047"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.hero.image", "image", "Hero · Ảnh lớn", "Giới thiệu", 47, null, "https://images.unsplash.com/photo-1528127269322-539801943592?fm=jpg&q=60&w=2000" },
                    { new Guid("00000000-0000-0000-0000-000000000048"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.pearl.eyebrow", "text", "Pearl · Nhãn", "Giới thiệu", 48, null, "Tên thương hiệu" },
                    { new Guid("00000000-0000-0000-0000-000000000049"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.pearl.title", "text", "Pearl · Tiêu đề", "Giới thiệu", 49, null, "Pearl" },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.pearl.body", "textarea", "Pearl · Nội dung", "Giới thiệu", 50, null, "Viên ngọc là bạn, vị khách của chúng tôi. Mỗi người một câu chuyện, nên chuyến đi cũng phải độc bản và của riêng bạn." },
                    { new Guid("00000000-0000-0000-0000-000000000051"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.pearl.image", "image", "Pearl · Ảnh", "Giới thiệu", 51, null, "https://images.unsplash.com/photo-1595345705177-ffe090eb0784?fm=jpg&q=60&w=1200" },
                    { new Guid("00000000-0000-0000-0000-000000000052"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.luna.eyebrow", "text", "Luna · Nhãn", "Giới thiệu", 52, null, "Tên thương hiệu" },
                    { new Guid("00000000-0000-0000-0000-000000000053"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.luna.title", "text", "Luna · Tiêu đề", "Giới thiệu", 53, null, "Luna(s)" },
                    { new Guid("00000000-0000-0000-0000-000000000054"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.luna.body", "textarea", "Luna · Nội dung", "Giới thiệu", 54, null, "Ánh trăng là Perlunas, lặng lẽ dõi theo và chăm chút từng chi tiết. Chữ “s” nhỏ ở cuối là lời hứa đồng hành bền lâu." },
                    { new Guid("00000000-0000-0000-0000-000000000055"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.luna.image", "image", "Luna · Ảnh", "Giới thiệu", 55, null, "https://images.unsplash.com/photo-1581886573745-4487c55d95f8?fm=jpg&q=60&w=1200" },
                    { new Guid("00000000-0000-0000-0000-000000000056"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.vision.eyebrow", "text", "Tầm nhìn · Nhãn", "Giới thiệu", 56, null, "Tầm nhìn" },
                    { new Guid("00000000-0000-0000-0000-000000000057"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.vision.body", "textarea", "Tầm nhìn · Nội dung", "Giới thiệu", 57, null, "Trở thành người đồng hành du lịch trong nước được tin yêu nhất tại Việt Nam." },
                    { new Guid("00000000-0000-0000-0000-000000000058"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.vision.image", "image", "Tầm nhìn · Ảnh", "Giới thiệu", 58, null, "https://images.unsplash.com/photo-1585970661791-9cec67470281?fm=jpg&q=60&w=1200" },
                    { new Guid("00000000-0000-0000-0000-000000000059"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.mission.eyebrow", "text", "Sứ mệnh · Nhãn", "Giới thiệu", 59, null, "Sứ mệnh" },
                    { new Guid("00000000-0000-0000-0000-000000000060"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.mission.body", "textarea", "Sứ mệnh · Nội dung", "Giới thiệu", 60, null, "Mang những hành trình tử tế, chỉn chu đến gần hơn với mỗi người, để ai cũng có thể đi và trở về trọn vẹn." },
                    { new Guid("00000000-0000-0000-0000-000000000061"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.mission.image", "image", "Sứ mệnh · Ảnh", "Giới thiệu", 61, null, "https://images.unsplash.com/photo-1592903204858-e288251ad9cc?fm=jpg&q=60&w=1200" },
                    { new Guid("00000000-0000-0000-0000-000000000062"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.eyebrow", "text", "Giá trị cốt lõi · Nhãn", "Giới thiệu", 62, null, "Giá trị cốt lõi" },
                    { new Guid("00000000-0000-0000-0000-000000000063"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.1.title", "text", "Giá trị 1 · Tiêu đề", "Giới thiệu", 63, null, "Chân thành" },
                    { new Guid("00000000-0000-0000-0000-000000000064"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.1.desc", "textarea", "Giá trị 1 · Mô tả", "Giới thiệu", 64, null, "Tư vấn thật lòng, đúng nhu cầu và ngân sách của bạn." },
                    { new Guid("00000000-0000-0000-0000-000000000065"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.2.title", "text", "Giá trị 2 · Tiêu đề", "Giới thiệu", 65, null, "Tận tâm" },
                    { new Guid("00000000-0000-0000-0000-000000000066"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.2.desc", "textarea", "Giá trị 2 · Mô tả", "Giới thiệu", 66, null, "Chăm chút từng chi tiết, theo sát đến khi bạn trở về." },
                    { new Guid("00000000-0000-0000-0000-000000000067"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.3.title", "text", "Giá trị 3 · Tiêu đề", "Giới thiệu", 67, null, "Minh bạch" },
                    { new Guid("00000000-0000-0000-0000-000000000068"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.3.desc", "textarea", "Giá trị 3 · Mô tả", "Giới thiệu", 68, null, "Báo giá trọn gói rõ ràng, nói được làm được." },
                    { new Guid("00000000-0000-0000-0000-000000000069"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.4.title", "text", "Giá trị 4 · Tiêu đề", "Giới thiệu", 69, null, "Bền lâu" },
                    { new Guid("00000000-0000-0000-0000-000000000070"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.4.desc", "textarea", "Giá trị 4 · Mô tả", "Giới thiệu", 70, null, "Một người đồng hành đi cùng bạn qua nhiều hành trình." },
                    { new Guid("00000000-0000-0000-0000-000000000071"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.cta.title", "textarea", "Khối kêu gọi · Tiêu đề", "Giới thiệu", 71, null, "Cùng Perlunas bắt đầu hành trình của bạn." },
                    { new Guid("00000000-0000-0000-0000-000000000072"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.cta.button", "text", "Khối kêu gọi · Nút", "Giới thiệu", 72, null, "Liên hệ tư vấn" },
                    { new Guid("00000000-0000-0000-0000-000000000073"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.eyebrow", "text", "Hero · Nhãn", "Liên hệ", 73, null, "Yêu cầu tư vấn" },
                    { new Guid("00000000-0000-0000-0000-000000000074"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hero.title", "textarea", "Hero · Tiêu đề", "Liên hệ", 74, null, "Kể cho chúng tôi về chuyến đi của bạn." },
                    { new Guid("00000000-0000-0000-0000-000000000075"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Liên hệ", 75, null, "Sau khi bạn gửi yêu cầu, Perlunas sẽ liên hệ sớm để tư vấn và lên kế hoạch qua Zalo, điện thoại hoặc gặp trực tiếp. Mọi tư vấn và báo giá đều hoàn toàn miễn phí." },
                    { new Guid("00000000-0000-0000-0000-000000000076"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.call.label", "text", "Gọi · Nhãn", "Liên hệ", 76, null, "Gọi ngay hôm nay" },
                    { new Guid("00000000-0000-0000-0000-000000000077"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.call.note", "text", "Gọi · Ghi chú", "Liên hệ", 77, null, "Tư vấn nhanh trong giờ làm việc." },
                    { new Guid("00000000-0000-0000-0000-000000000078"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.message.label", "text", "Nhắn tin · Nhãn", "Liên hệ", 78, null, "Nhắn tin" },
                    { new Guid("00000000-0000-0000-0000-000000000079"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.label", "text", "Giờ làm việc · Nhãn", "Liên hệ", 79, null, "Giờ làm việc" },
                    { new Guid("00000000-0000-0000-0000-000000000080"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.1.day", "text", "Giờ làm việc · Dòng 1 Ngày", "Liên hệ", 80, null, "Thứ 2 - Thứ 6" },
                    { new Guid("00000000-0000-0000-0000-000000000081"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.1.time", "text", "Giờ làm việc · Dòng 1 Giờ", "Liên hệ", 81, null, "8:00 - 21:00" },
                    { new Guid("00000000-0000-0000-0000-000000000082"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.2.day", "text", "Giờ làm việc · Dòng 2 Ngày", "Liên hệ", 82, null, "Thứ 7" },
                    { new Guid("00000000-0000-0000-0000-000000000083"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.2.time", "text", "Giờ làm việc · Dòng 2 Giờ", "Liên hệ", 83, null, "8:00 - 20:00" },
                    { new Guid("00000000-0000-0000-0000-000000000084"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.3.day", "text", "Giờ làm việc · Dòng 3 Ngày", "Liên hệ", 84, null, "Chủ nhật" },
                    { new Guid("00000000-0000-0000-0000-000000000085"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.3.time", "text", "Giờ làm việc · Dòng 3 Giờ", "Liên hệ", 85, null, "9:00 - 18:00" },
                    { new Guid("00000000-0000-0000-0000-000000000086"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.eyebrow", "text", "Hero · Nhãn", "Tour đoàn", 86, null, "Tour đoàn" },
                    { new Guid("00000000-0000-0000-0000-000000000087"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.hero.title", "textarea", "Hero · Tiêu đề", "Tour đoàn", 87, null, "Đoàn đông tới mấy, vẫn trọn vẹn từng người." },
                    { new Guid("00000000-0000-0000-0000-000000000088"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Tour đoàn", 88, null, "Team building, gala dinner, hội nghị kết hợp tham quan — Perlunas lo trọn từ vận chuyển, lưu trú đến kịch bản gắn kết, với một đầu mối duy nhất xuyên suốt hành trình." },
                    { new Guid("00000000-0000-0000-0000-000000000089"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.hero.image", "image", "Hero · Ảnh lớn", "Tour đoàn", 89, null, "https://images.unsplash.com/photo-1768881618157-2cc24f7493c6?fm=jpg&q=60&w=2000" },
                    { new Guid("00000000-0000-0000-0000-000000000090"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block1.eyebrow", "text", "Khối 1 · Nhãn", "Tour đoàn", 90, null, "Trước chuyến đi" },
                    { new Guid("00000000-0000-0000-0000-000000000091"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block1.title", "text", "Khối 1 · Tiêu đề", "Tour đoàn", 91, null, "Hiểu đoàn trước khi lên lịch" },
                    { new Guid("00000000-0000-0000-0000-000000000092"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block1.body", "textarea", "Khối 1 · Nội dung", "Tour đoàn", 92, null, "Chúng tôi tìm hiểu mục tiêu, độ tuổi, ngân sách và nhịp đi riêng của từng đoàn để thiết kế lịch trình phù hợp nhất." },
                    { new Guid("00000000-0000-0000-0000-000000000093"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block1.image", "image", "Khối 1 · Ảnh", "Tour đoàn", 93, null, "https://images.unsplash.com/photo-1774599661329-d9a2f999d1c4?fm=jpg&q=60&w=1000" },
                    { new Guid("00000000-0000-0000-0000-000000000094"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block2.eyebrow", "text", "Khối 2 · Nhãn", "Tour đoàn", 94, null, "Trong chuyến đi" },
                    { new Guid("00000000-0000-0000-0000-000000000095"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block2.title", "text", "Khối 2 · Tiêu đề", "Tour đoàn", 95, null, "Một đầu mối lo trọn" },
                    { new Guid("00000000-0000-0000-0000-000000000096"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block2.body", "textarea", "Khối 2 · Nội dung", "Tour đoàn", 96, null, "Vận chuyển, lưu trú, ăn uống, hướng dẫn và các hoạt động gắn kết — tất cả được điều phối bởi một đội ngũ duy nhất." },
                    { new Guid("00000000-0000-0000-0000-000000000097"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block2.image", "image", "Khối 2 · Ảnh", "Tour đoàn", 97, null, "https://images.unsplash.com/photo-1539635278303-d4002c07eae3?fm=jpg&q=60&w=1000" },
                    { new Guid("00000000-0000-0000-0000-000000000098"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.cta.title", "textarea", "Khối kêu gọi · Tiêu đề", "Tour đoàn", 98, null, "Hãy kể cho chúng tôi về đoàn của bạn." },
                    { new Guid("00000000-0000-0000-0000-000000000099"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.cta.button", "text", "Khối kêu gọi · Nút", "Tour đoàn", 99, null, "Liên hệ tư vấn" },
                    { new Guid("00000000-0000-0000-0000-000000000100"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.eyebrow", "text", "Hero · Nhãn", "Tour riêng tư", 100, null, "Tour riêng tư" },
                    { new Guid("00000000-0000-0000-0000-000000000101"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.hero.title", "textarea", "Hero · Tiêu đề", "Tour riêng tư", 101, null, "Hành trình may đo cho riêng bạn." },
                    { new Guid("00000000-0000-0000-0000-000000000102"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Tour riêng tư", 102, null, "Mỗi nhóm khách có một nhịp đi riêng. Perlunas thiết kế lịch trình, lưu trú và trải nghiệm theo đúng mong muốn của bạn — linh hoạt từ ngày khởi hành đến từng điểm dừng." },
                    { new Guid("00000000-0000-0000-0000-000000000103"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.block.eyebrow", "text", "Khối · Nhãn", "Tour riêng tư", 103, null, "Cách chúng tôi làm việc" },
                    { new Guid("00000000-0000-0000-0000-000000000104"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.block.title", "text", "Khối · Tiêu đề", "Tour riêng tư", 104, null, "Lắng nghe, đề xuất, rồi tinh chỉnh." },
                    { new Guid("00000000-0000-0000-0000-000000000105"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.block.body", "textarea", "Khối · Nội dung", "Tour riêng tư", 105, null, "Bạn chia sẻ mong muốn và ngân sách, chúng tôi đề xuất một hành trình chi tiết và điều chỉnh cùng bạn cho đến khi vừa ý." },
                    { new Guid("00000000-0000-0000-0000-000000000106"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.block.button", "text", "Khối · Nút", "Tour riêng tư", 106, null, "Đề xuất chi tiết" },
                    { new Guid("00000000-0000-0000-0000-000000000107"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.block.image", "image", "Khối · Ảnh", "Tour riêng tư", 107, null, "https://images.unsplash.com/photo-1566759996874-04d713cc224a?fm=jpg&q=60&w=1000" },
                    { new Guid("00000000-0000-0000-0000-000000000108"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.cta.title", "textarea", "Khối kêu gọi · Tiêu đề", "Tour riêng tư", 108, null, "Bắt đầu thiết kế hành trình của riêng bạn." },
                    { new Guid("00000000-0000-0000-0000-000000000109"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.cta.button", "text", "Khối kêu gọi · Nút", "Tour riêng tư", 109, null, "Liên hệ tư vấn" },
                    { new Guid("00000000-0000-0000-0000-000000000110"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourspage.eyebrow", "text", "Hero · Nhãn", "Tour trọn gói", 110, null, "Tour trọn gói" },
                    { new Guid("00000000-0000-0000-0000-000000000111"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourspage.hero.title", "textarea", "Hero · Tiêu đề", "Tour trọn gói", 111, null, "Xách balo lên và đi, phần còn lại để Perlunas lo." },
                    { new Guid("00000000-0000-0000-0000-000000000112"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourspage.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Tour trọn gói", 112, null, "Lịch khởi hành đều đặn, giá trọn gói rõ ràng, không phát sinh." },
                    { new Guid("00000000-0000-0000-0000-000000000113"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.eyebrow", "text", "Hero · Nhãn", "Khách sạn", 113, null, "Khách sạn" },
                    { new Guid("00000000-0000-0000-0000-000000000114"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.hero.title", "textarea", "Hero · Tiêu đề", "Khách sạn", 114, null, "Chỗ nghỉ trên khắp Việt Nam." },
                    { new Guid("00000000-0000-0000-0000-000000000115"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Khách sạn", 115, null, "Mặc định là những chỗ nghỉ Perlunas tuyển chọn." },
                    { new Guid("00000000-0000-0000-0000-000000000116"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.upsell.eyebrow", "text", "Upsell · Nhãn", "Khách sạn", 116, null, "Nâng tầm trải nghiệm" },
                    { new Guid("00000000-0000-0000-0000-000000000117"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.upsell.title", "textarea", "Upsell · Tiêu đề", "Khách sạn", 117, null, "Không chỉ là đặt phòng, hãy đi cùng một combo trọn vẹn." },
                    { new Guid("00000000-0000-0000-0000-000000000118"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.upsell.body", "textarea", "Upsell · Nội dung", "Khách sạn", 118, null, "Combo du lịch kết hợp lưu trú, di chuyển và trải nghiệm theo ba mức: Akoya, Tahiti và South Sea." },
                    { new Guid("00000000-0000-0000-0000-000000000119"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.upsell.button", "text", "Upsell · Nút", "Khách sạn", 119, null, "Khám phá Combo du lịch" },
                    { new Guid("00000000-0000-0000-0000-000000000120"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.eyebrow", "text", "Hero · Nhãn", "Combo", 120, null, "Combo du lịch" },
                    { new Guid("00000000-0000-0000-0000-000000000121"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.hero.title", "textarea", "Hero · Tiêu đề", "Combo", 121, null, "Combo trọn gói khắp Việt Nam." },
                    { new Guid("00000000-0000-0000-0000-000000000122"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Combo", 122, null, "Mỗi combo kết hợp lưu trú, di chuyển và trải nghiệm theo một trong ba chuẩn dịch vụ." },
                    { new Guid("00000000-0000-0000-0000-000000000123"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.cta.title", "text", "Khối kêu gọi · Tiêu đề", "Combo", 123, null, "Chưa biết chọn combo nào?" },
                    { new Guid("00000000-0000-0000-0000-000000000124"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.cta.body", "textarea", "Khối kêu gọi · Nội dung", "Combo", 124, null, "Để lại thông tin, Perlunas tư vấn gói phù hợp với bạn, miễn phí." },
                    { new Guid("00000000-0000-0000-0000-000000000125"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.cta.button", "text", "Khối kêu gọi · Nút", "Combo", 125, null, "Nhận tư vấn" },
                    { new Guid("00000000-0000-0000-0000-000000000126"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.eyebrow", "text", "Hero · Nhãn", "Phân loại Combo", 126, null, "Phân loại Combo" },
                    { new Guid("00000000-0000-0000-0000-000000000127"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.hero.title", "textarea", "Hero · Tiêu đề", "Phân loại Combo", 127, null, "Ba viên ngọc, ba chuẩn dịch vụ." },
                    { new Guid("00000000-0000-0000-0000-000000000128"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Phân loại Combo", 128, null, "Akoya, Tahiti và South Sea là ba chuẩn dịch vụ Perlunas đặt ra." },
                    { new Guid("00000000-0000-0000-0000-000000000129"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.choose.eyebrow", "text", "Cách chọn gói · Nhãn", "Phân loại Combo", 129, null, "Cách chọn gói" },
                    { new Guid("00000000-0000-0000-0000-000000000130"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.choose.title", "textarea", "Cách chọn gói · Tiêu đề", "Phân loại Combo", 130, null, "Chọn gói phù hợp với nhu cầu của bạn." },
                    { new Guid("00000000-0000-0000-0000-000000000131"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.choose.body", "textarea", "Cách chọn gói · Nội dung", "Phân loại Combo", 131, null, "Mỗi gói phù hợp với một kiểu chuyến đi khác nhau." },
                    { new Guid("00000000-0000-0000-0000-000000000132"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.choose.button", "text", "Cách chọn gói · Nút", "Phân loại Combo", 132, null, "Nhận tư vấn chọn gói" },
                    { new Guid("00000000-0000-0000-0000-000000000133"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.tagline", "textarea", "Footer · Mô tả thương hiệu", "Chung", 133, null, "Mỗi hành trình là một viên ngọc dưới ánh trăng. Thiết kế những hành trình du lịch trong nước tinh tế và trọn vẹn." },
                    { new Guid("00000000-0000-0000-0000-000000000134"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.newsletter.eyebrow", "text", "Footer · Newsletter nhãn", "Chung", 134, null, "Nhận tư vấn từ Perlunas" },
                    { new Guid("00000000-0000-0000-0000-000000000135"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.newsletter.note", "text", "Footer · Newsletter ghi chú", "Chung", 135, null, "Để lại email, Perlunas sẽ liên hệ tư vấn miễn phí." },
                    { new Guid("00000000-0000-0000-0000-000000000136"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.legal.tagline", "text", "Footer · Câu cuối", "Chung", 136, null, "Mỗi hành trình là một viên ngọc dưới ánh trăng." }
                });

            migrationBuilder.InsertData(
                table: "PrivateTours",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "SortOrder", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("90000000-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hành trình lãng mạn được thiết kế riêng cho các cặp đôi với dịch vụ trọn gói và không gian riêng tư.", "https://picsum.photos/seed/private-honeymoon/1200/800", false, 1, "Tour riêng tư cặp đôi (Honeymoon)", null },
                    { new Guid("90000000-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lịch trình linh hoạt phù hợp mọi lứa tuổi, có hướng dẫn viên và xe riêng cho cả gia đình.", "https://picsum.photos/seed/private-family/1200/800", false, 2, "Tour riêng tư gia đình", null },
                    { new Guid("90000000-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trải nghiệm thượng lưu với khách sạn 5 sao, chuyên cơ và quản gia riêng cho hành trình đẳng cấp.", "https://picsum.photos/seed/private-luxury/1200/800", false, 3, "Tour riêng tư cao cấp (Luxury)", null },
                    { new Guid("90000000-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Dành cho người ưa mạo hiểm: trekking, chèo kayak và cắm trại tại những điểm đến hoang sơ.", "https://picsum.photos/seed/private-adventure/1200/800", false, 4, "Tour riêng tư khám phá (Adventure)", null }
                });

            migrationBuilder.InsertData(
                table: "SiteSettings",
                columns: new[] { "Id", "CreatedAt", "Description", "Email", "IsDeleted", "LegalName", "Manifesto", "Name", "OfficesJson", "Phone", "SocialJson", "Tagline", "TaxId", "UpdatedAt" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Perlunas là công ty du lịch Việt Nam chuyên thiết kế tour trọn gói, combo nghỉ dưỡng và đặt phòng khách sạn cao cấp.", "xinchao@perlunas.vn", false, "CÔNG TY DU LỊCH PERLUNAS", "Chúng tôi không chỉ bán tour — chúng tôi tạo nên những kỷ niệm lấp lánh.", "Perlunas", "[{\"label\":\"Văn phòng TP.HCM\",\"address\":\"123 Nguyễn Huệ, Phường Bến Nghé, Quận 1, TP.HCM\"}]", "0900 000 000", "[{\"label\":\"Facebook\",\"href\":\"https://facebook.com\"},{\"label\":\"Zalo\",\"href\":\"https://zalo.me/0900000000\"}]", "Mỗi hành trình là một viên ngọc dưới ánh trăng", "", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Taxonomies",
                columns: new[] { "Id", "CreatedAt", "Group", "IsDeleted", "Name", "Slug", "SortOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("70000000-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "city", false, "Hà Nội", "ha-noi", 1, null },
                    { new Guid("70000000-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "city", false, "TP. Hồ Chí Minh", "tp-ho-chi-minh", 2, null },
                    { new Guid("70000000-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "city", false, "Hạ Long", "ha-long", 3, null },
                    { new Guid("70000000-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "city", false, "Sa Pa", "sa-pa", 4, null },
                    { new Guid("70000000-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "city", false, "Đà Nẵng", "da-nang", 5, null },
                    { new Guid("70000000-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "city", false, "Hội An", "hoi-an", 6, null },
                    { new Guid("70000000-0000-0000-0000-000000000007"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "city", false, "Huế", "hue", 7, null },
                    { new Guid("70000000-0000-0000-0000-000000000008"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "city", false, "Đà Lạt", "da-lat", 8, null },
                    { new Guid("70000000-0000-0000-0000-000000000009"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "city", false, "Nha Trang", "nha-trang", 9, null },
                    { new Guid("70000000-0000-0000-0000-00000000000a"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "city", false, "Phú Quốc", "phu-quoc", 10, null },
                    { new Guid("70000000-0000-0000-0000-00000000000b"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "stay-type", false, "Hotel", "hotel", 1, null },
                    { new Guid("70000000-0000-0000-0000-00000000000c"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "stay-type", false, "Resort", "resort", 2, null },
                    { new Guid("70000000-0000-0000-0000-00000000000d"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "stay-type", false, "Retreat", "retreat", 3, null },
                    { new Guid("70000000-0000-0000-0000-00000000000e"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "stay-type", false, "Wellness", "wellness", 4, null },
                    { new Guid("70000000-0000-0000-0000-00000000000f"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "stay-type", false, "Boutique Hotel", "boutique-hotel", 5, null },
                    { new Guid("70000000-0000-0000-0000-000000000010"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "region", false, "Miền Bắc", "mien-bac", 1, null },
                    { new Guid("70000000-0000-0000-0000-000000000011"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "region", false, "Miền Trung", "mien-trung", 2, null },
                    { new Guid("70000000-0000-0000-0000-000000000012"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "region", false, "Miền Nam", "mien-nam", 3, null },
                    { new Guid("70000000-0000-0000-0000-000000000013"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "region", false, "Tây Nguyên", "tay-nguyen", 4, null },
                    { new Guid("70000000-0000-0000-0000-000000000014"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "region", false, "Quốc tế", "quoc-te", 5, null }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "Cover", "CreatedAt", "Featured", "Highlights", "IsDeleted", "Name", "Nights", "Price", "Region", "Slug", "SortOrder", "Stays", "Teaser", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("30000000-0000-0000-0000-000000000001"), "https://picsum.photos/seed/da-lat/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new List<string> { "Săn mây Cầu Đất lúc bình minh", "Vườn hồng và đồi chè Cầu Đất", "Cà phê giữa rừng thông", "Chợ đêm và ẩm thực phố núi" }, false, "Đà Lạt mộng mơ", "3 ngày 2 đêm", "từ 2.890.000đ", "Tây Nguyên", "da-lat", 1, new List<string> { "da-lat" }, "Ba ngày giữa rừng thông và sương sớm trên cao nguyên.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("30000000-0000-0000-0000-000000000002"), "https://picsum.photos/seed/phu-quoc/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new List<string> { "Cáp treo Hòn Thơm dài nhất thế giới", "Lặn ngắm san hô 3 đảo", "Hoàng hôn bãi Sao", "Chợ đêm hải sản" }, false, "Phú Quốc đảo ngọc", "3 ngày 2 đêm", "từ 3.690.000đ", "Miền Nam", "phu-quoc", 2, new List<string> { "phu-quoc" }, "Biển trong vắt, san hô và hoàng hôn rực rỡ phương Nam.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("30000000-0000-0000-0000-000000000003"), "https://picsum.photos/seed/ha-noi-sapa/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new List<string> { "Phố cổ Hà Nội và Hồ Gươm", "Ruộng bậc thang Mường Hoa", "Cáp treo Fansipan", "Bản làng người Mông, người Dao" }, false, "Hà Nội Sa Pa", "4 ngày 3 đêm", "từ 4.290.000đ", "Miền Bắc", "ha-noi-sapa", 3, new List<string> { "ha-noi", "sa-pa" }, "Từ phố cổ ngàn năm tới ruộng bậc thang và đỉnh Fansipan.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("30000000-0000-0000-0000-000000000004"), "https://picsum.photos/seed/da-nang-hoi-an/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new List<string> { "Cầu Vàng Bà Nà Hills", "Phố cổ Hội An về đêm", "Thả đèn hoa đăng sông Hoài", "Biển Mỹ Khê" }, false, "Đà Nẵng Hội An", "3 ngày 2 đêm", "từ 3.190.000đ", "Miền Trung", "da-nang-hoi-an", 4, new List<string> { "da-nang" }, "Cầu Vàng, phố Hội lồng đèn và bãi biển Mỹ Khê.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("30000000-0000-0000-0000-000000000005"), "https://picsum.photos/seed/nha-trang/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new List<string> { "Khám phá đảo Hòn Mun", "Tắm bùn khoáng", "Vịnh Nha Trang", "Ẩm thực biển" }, false, "Nha Trang biển xanh", "3 ngày 2 đêm", "từ 2.990.000đ", "Miền Trung", "nha-trang", 5, new List<string> { "nha-trang" }, "Vịnh biển trong xanh và những hòn đảo gần bờ.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Combos_Slug",
                table: "Combos",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_Slug",
                table: "Hotels",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PageContents_Key",
                table: "PageContents",
                column: "Key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Taxonomies_Group_Name",
                table: "Taxonomies",
                columns: new[] { "Group", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tours_Slug",
                table: "Tours",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComboTiers");

            migrationBuilder.DropTable(
                name: "Combos");

            migrationBuilder.DropTable(
                name: "ContactMessages");

            migrationBuilder.DropTable(
                name: "GroupTours");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "PageContents");

            migrationBuilder.DropTable(
                name: "PrivateTours");

            migrationBuilder.DropTable(
                name: "SiteSettings");

            migrationBuilder.DropTable(
                name: "Taxonomies");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
