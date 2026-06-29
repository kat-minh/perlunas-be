using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ComboRelations_TourCardMerge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupTours");

            migrationBuilder.DropTable(
                name: "PrivateTours");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "HotelName",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "Tier",
                table: "Combos");

            migrationBuilder.AddColumn<Guid>(
                name: "ComboTierId",
                table: "Combos",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "HotelId",
                table: "Combos",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "TourCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_TourCards", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ComboTiers",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000001"),
                column: "Includes",
                value: new List<string> { "Khách sạn 3-4 sao trung tâm", "Xe đưa đón và di chuyển theo lịch trình", "Ăn sáng mỗi ngày", "Hướng dẫn viên ở các điểm chính", "Vé tham quan cơ bản" });

            migrationBuilder.UpdateData(
                table: "ComboTiers",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000002"),
                column: "Includes",
                value: new List<string> { "Khách sạn 4-5 sao", "Xe riêng cho nhóm", "Ăn sáng và một số bữa đặc sản", "Hướng dẫn viên xuyên suốt", "Trải nghiệm địa phương riêng (lớp nấu ăn, làng nghề…)" });

            migrationBuilder.UpdateData(
                table: "ComboTiers",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000003"),
                column: "Includes",
                value: new List<string> { "Resort/khách sạn 5 sao", "Xe riêng và tài xế suốt hành trình", "Trọn bữa, nhà hàng chọn lọc", "Trải nghiệm độc quyền, vé ưu tiên", "Hỗ trợ concierge 24/7" });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000001"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000001"), new Guid("40000000-0000-0000-0000-000000000010"), null });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000002"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000002"), new Guid("40000000-0000-0000-0000-000000000011"), null });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000003"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000001"), new Guid("40000000-0000-0000-0000-000000000011"), null });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000004"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000002"), new Guid("40000000-0000-0000-0000-000000000011"), null });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000005"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000003"), new Guid("40000000-0000-0000-0000-000000000012"), null });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000006"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000002"), new Guid("40000000-0000-0000-0000-000000000013"), null });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000007"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000003"), new Guid("40000000-0000-0000-0000-000000000013"), null });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000008"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000001"), new Guid("40000000-0000-0000-0000-000000000014"), null });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000009"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000002"), new Guid("40000000-0000-0000-0000-000000000014"), null });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000a"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000003"), new Guid("40000000-0000-0000-0000-000000000015"), null });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000b"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000001"), new Guid("40000000-0000-0000-0000-000000000016"), null });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000c"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000002"), new Guid("40000000-0000-0000-0000-000000000017"), null });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000d"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000001"), new Guid("40000000-0000-0000-0000-000000000018"), null });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000e"),
                columns: new[] { "ComboTierId", "HotelId", "UpdatedAt" },
                values: new object[] { new Guid("60000000-0000-0000-0000-000000000003"), new Guid("40000000-0000-0000-0000-000000000019"), null });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Cover", "CreatedAt", "Desc", "Featured", "IsDeleted", "Name", "Price", "Slug", "SortOrder", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("40000000-0000-0000-0000-000000000010"), "Đà Nẵng", "https://picsum.photos/seed/intercontinental-da-nang/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khu nghỉ dưỡng sang trọng bên bờ biển Sơn Trà.", true, false, "Intercontinental Đà Nẵng", "5.500.000đ/đêm", "intercontinental-da-nang", 16, "Resort", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000011"), "Hà Nội", "https://picsum.photos/seed/sheraton-ha-noi/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khách sạn 5 sao tại khu ngoại giao đoàn, hồ bơi ngoài trời.", true, false, "Sheraton Hà Nội", "3.200.000đ/đêm", "sheraton-ha-noi", 17, "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000012"), "Phú Quốc", "https://picsum.photos/seed/intercontinental-phu-quoc/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Resort cao cấp trên bãi biển Kem, kiến trúc La Mã độc đáo.", true, false, "InterContinental Phú Quốc", "6.000.000đ/đêm", "intercontinental-phu-quoc", 18, "Resort", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000013"), "Phú Quốc", "https://picsum.photos/seed/jw-marriott-phu-quoc/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khu nghỉ dưỡng ven biển phía Nam đảo Ngọc.", true, false, "JW Marriott Phú Quốc", "5.800.000đ/đêm", "jw-marriott-phu-quoc", 19, "Resort", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000014"), "Nha Trang", "https://picsum.photos/seed/vinpearl-nha-trang/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khu nghỉ dưỡng trên đảo Hòn Tre, công viên nước và spa.", true, false, "Vinpearl Nha Trang", "3.500.000đ/đêm", "vinpearl-nha-trang", 20, "Resort", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000015"), "Đà Lạt", "https://picsum.photos/seed/ana-mandara-da-lat/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khu nghỉ dưỡng kiểu Pháp giữa rừng thông Đà Lạt.", true, false, "Ana Mandara Đà Lạt", "3.000.000đ/đêm", "ana-mandara-da-lat", 21, "Retreat", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000016"), "Đà Lạt", "https://picsum.photos/seed/terracotta-da-lat/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khu resort ấm cúng với kiến trúc gạch đỏ đặc trưng.", false, false, "Terracotta Đà Lạt", "2.200.000đ/đêm", "terracotta-da-lat", 22, "Resort", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000017"), "Hạ Long", "https://picsum.photos/seed/sheraton-ha-long/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khách sạn sang trọng nhìn ra vịnh di sản.", true, false, "Sheraton Hạ Long", "3.000.000đ/đêm", "sheraton-ha-long", 23, "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000018"), "Sa Pa", "https://picsum.photos/seed/hotel-coupole-sapa/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kiến trúc Pháp thời thuộc địa giữa trời mây Tây Bắc.", true, false, "Hôtel de la Coupole Sa Pa", "4.000.000đ/đêm", "hotel-de-la-coupole-sa-pa", 24, "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40000000-0000-0000-0000-000000000019"), "Đà Nẵng", "https://picsum.photos/seed/naman-retreat-da-nang/1200/800", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khu nghỉ dưỡng ven biển với spa và bãi biển riêng.", false, false, "Naman Retreat Đà Nẵng", "4.500.000đ/đêm", "naman-retreat-da-nang", 25, "Retreat", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "TourCards",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "SortOrder", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("80000000-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Chương trình team building biển đảo, gắn kết đội ngũ với các hoạt động vận động và gala dinner.", "https://picsum.photos/seed/group-teambuilding/1200/800", false, 1, "Tour đoàn doanh nghiệp (Team Building)", "Group", null },
                    { new Guid("80000000-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hành trình trải nghiệm giáo dục, về nguồn và khám phá di sản phù hợp cho các trường học.", "https://picsum.photos/seed/group-student/1200/800", false, 2, "Tour đoàn học sinh – sinh viên", "Group", null },
                    { new Guid("80000000-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lịch trình nghỉ dưỡng cao cấp dành cho các chương trình tri ân, hội nghị khách hàng quy mô lớn.", "https://picsum.photos/seed/group-vip/1200/800", false, 3, "Tour đoàn tri ân khách hàng", "Group", null },
                    { new Guid("90000000-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hành trình lãng mạn được thiết kế riêng cho các cặp đôi với dịch vụ trọn gói và không gian riêng tư.", "https://picsum.photos/seed/private-honeymoon/1200/800", false, 1, "Tour riêng tư cặp đôi (Honeymoon)", "Private", null },
                    { new Guid("90000000-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lịch trình linh hoạt phù hợp mọi lứa tuổi, có hướng dẫn viên và xe riêng cho cả gia đình.", "https://picsum.photos/seed/private-family/1200/800", false, 2, "Tour riêng tư gia đình", "Private", null },
                    { new Guid("90000000-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trải nghiệm thượng lưu với khách sạn 5 sao, chuyên cơ và quản gia riêng cho hành trình đẳng cấp.", "https://picsum.photos/seed/private-luxury/1200/800", false, 3, "Tour riêng tư cao cấp (Luxury)", "Private", null },
                    { new Guid("90000000-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Dành cho người ưa mạo hiểm: trekking, chèo kayak và cắm trại tại những điểm đến hoang sơ.", "https://picsum.photos/seed/private-adventure/1200/800", false, 4, "Tour riêng tư khám phá (Adventure)", "Private", null }
                });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                columns: new[] { "Highlights", "Stays" },
                values: new object[] { new List<string> { "Săn mây Cầu Đất lúc bình minh", "Vườn hồng và đồi chè Cầu Đất", "Cà phê giữa rừng thông", "Chợ đêm và ẩm thực phố núi" }, new List<string> { "da-lat" } });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                columns: new[] { "Highlights", "Stays" },
                values: new object[] { new List<string> { "Cáp treo Hòn Thơm dài nhất thế giới", "Lặn ngắm san hô 3 đảo", "Hoàng hôn bãi Sao", "Chợ đêm hải sản" }, new List<string> { "phu-quoc" } });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                columns: new[] { "Highlights", "Stays" },
                values: new object[] { new List<string> { "Phố cổ Hà Nội và Hồ Gươm", "Ruộng bậc thang Mường Hoa", "Cáp treo Fansipan", "Bản làng người Mông, người Dao" }, new List<string> { "ha-noi", "sa-pa" } });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                columns: new[] { "Highlights", "Stays" },
                values: new object[] { new List<string> { "Cầu Vàng Bà Nà Hills", "Phố cổ Hội An về đêm", "Thả đèn hoa đăng sông Hoài", "Biển Mỹ Khê" }, new List<string> { "da-nang" } });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000005"),
                columns: new[] { "Highlights", "Stays" },
                values: new object[] { new List<string> { "Khám phá đảo Hòn Mun", "Tắm bùn khoáng", "Vịnh Nha Trang", "Ẩm thực biển" }, new List<string> { "nha-trang" } });

            migrationBuilder.CreateIndex(
                name: "IX_Combos_ComboTierId",
                table: "Combos",
                column: "ComboTierId");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_HotelId",
                table: "Combos",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_TourCards_Type",
                table: "TourCards",
                column: "Type");

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_ComboTiers_ComboTierId",
                table: "Combos",
                column: "ComboTierId",
                principalTable: "ComboTiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Hotels_HotelId",
                table: "Combos",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Combos_ComboTiers_ComboTierId",
                table: "Combos");

            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Hotels_HotelId",
                table: "Combos");

            migrationBuilder.DropTable(
                name: "TourCards");

            migrationBuilder.DropIndex(
                name: "IX_Combos_ComboTierId",
                table: "Combos");

            migrationBuilder.DropIndex(
                name: "IX_Combos_HotelId",
                table: "Combos");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000019"));

            migrationBuilder.DropColumn(
                name: "ComboTierId",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Combos");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Combos",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HotelName",
                table: "Combos",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tier",
                table: "Combos",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "GroupTours",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupTours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrivateTours",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateTours", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ComboTiers",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000001"),
                column: "Includes",
                value: new List<string> { "Khách sạn 3-4 sao trung tâm", "Xe đưa đón và di chuyển theo lịch trình", "Ăn sáng mỗi ngày", "Hướng dẫn viên ở các điểm chính", "Vé tham quan cơ bản" });

            migrationBuilder.UpdateData(
                table: "ComboTiers",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000002"),
                column: "Includes",
                value: new List<string> { "Khách sạn 4-5 sao", "Xe riêng cho nhóm", "Ăn sáng và một số bữa đặc sản", "Hướng dẫn viên xuyên suốt", "Trải nghiệm địa phương riêng (lớp nấu ăn, làng nghề…)" });

            migrationBuilder.UpdateData(
                table: "ComboTiers",
                keyColumn: "Id",
                keyValue: new Guid("60000000-0000-0000-0000-000000000003"),
                column: "Includes",
                value: new List<string> { "Resort/khách sạn 5 sao", "Xe riêng và tài xế suốt hành trình", "Trọn bữa, nhà hàng chọn lọc", "Trải nghiệm độc quyền, vé ưu tiên", "Hỗ trợ concierge 24/7" });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000001"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Đà Nẵng", "Intercontinental Đà Nẵng", "Akoya", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000002"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Hà Nội", "Sheraton Hà Nội", "Tahiti", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000003"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Hà Nội", "Sheraton Hà Nội", "Akoya", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000004"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Hà Nội", "Sheraton Hà Nội", "Tahiti", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000005"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Phú Quốc", "InterContinental Phú Quốc", "South Sea", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000006"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Phú Quốc", "JW Marriott Phú Quốc", "Tahiti", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000007"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Phú Quốc", "JW Marriott Phú Quốc", "South Sea", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000008"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Nha Trang", "Vinpearl Nha Trang", "Akoya", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000009"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Nha Trang", "Vinpearl Nha Trang", "Tahiti", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000a"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Đà Lạt", "Ana Mandara Đà Lạt", "South Sea", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000b"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Đà Lạt", "Terracotta Đà Lạt", "Akoya", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000c"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Hạ Long", "Sheraton Hạ Long", "Tahiti", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000d"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Sa Pa", "Hôtel de la Coupole Sa Pa", "Akoya", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000e"),
                columns: new[] { "City", "HotelName", "Tier", "UpdatedAt" },
                values: new object[] { "Đà Nẵng", "Naman Retreat Đà Nẵng", "South Sea", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

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
                table: "PrivateTours",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "SortOrder", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("90000000-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hành trình lãng mạn được thiết kế riêng cho các cặp đôi với dịch vụ trọn gói và không gian riêng tư.", "https://picsum.photos/seed/private-honeymoon/1200/800", false, 1, "Tour riêng tư cặp đôi (Honeymoon)", null },
                    { new Guid("90000000-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lịch trình linh hoạt phù hợp mọi lứa tuổi, có hướng dẫn viên và xe riêng cho cả gia đình.", "https://picsum.photos/seed/private-family/1200/800", false, 2, "Tour riêng tư gia đình", null },
                    { new Guid("90000000-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trải nghiệm thượng lưu với khách sạn 5 sao, chuyên cơ và quản gia riêng cho hành trình đẳng cấp.", "https://picsum.photos/seed/private-luxury/1200/800", false, 3, "Tour riêng tư cao cấp (Luxury)", null },
                    { new Guid("90000000-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Dành cho người ưa mạo hiểm: trekking, chèo kayak và cắm trại tại những điểm đến hoang sơ.", "https://picsum.photos/seed/private-adventure/1200/800", false, 4, "Tour riêng tư khám phá (Adventure)", null }
                });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                columns: new[] { "Highlights", "Stays" },
                values: new object[] { new List<string> { "Săn mây Cầu Đất lúc bình minh", "Vườn hồng và đồi chè Cầu Đất", "Cà phê giữa rừng thông", "Chợ đêm và ẩm thực phố núi" }, new List<string> { "da-lat" } });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                columns: new[] { "Highlights", "Stays" },
                values: new object[] { new List<string> { "Cáp treo Hòn Thơm dài nhất thế giới", "Lặn ngắm san hô 3 đảo", "Hoàng hôn bãi Sao", "Chợ đêm hải sản" }, new List<string> { "phu-quoc" } });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                columns: new[] { "Highlights", "Stays" },
                values: new object[] { new List<string> { "Phố cổ Hà Nội và Hồ Gươm", "Ruộng bậc thang Mường Hoa", "Cáp treo Fansipan", "Bản làng người Mông, người Dao" }, new List<string> { "ha-noi", "sa-pa" } });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                columns: new[] { "Highlights", "Stays" },
                values: new object[] { new List<string> { "Cầu Vàng Bà Nà Hills", "Phố cổ Hội An về đêm", "Thả đèn hoa đăng sông Hoài", "Biển Mỹ Khê" }, new List<string> { "da-nang" } });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000005"),
                columns: new[] { "Highlights", "Stays" },
                values: new object[] { new List<string> { "Khám phá đảo Hòn Mun", "Tắm bùn khoáng", "Vịnh Nha Trang", "Ẩm thực biển" }, new List<string> { "nha-trang" } });
        }
    }
}
