using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class HotelComboTaxonomyFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "StayType",
                table: "Combos");

            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                table: "Hotels",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StayTypeId",
                table: "Hotels",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StayTypeId",
                table: "Combos",
                type: "uuid",
                nullable: true);

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
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000c"));

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000002"),
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000b"));

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000003"),
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000b"));

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000004"),
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000b"));

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000005"),
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000c"));

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000006"),
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000c"));

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000007"),
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000c"));

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000008"),
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000c"));

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000009"),
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000c"));

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000a"),
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000d"));

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000b"),
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000c"));

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000c"),
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000b"));

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000d"),
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000b"));

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000e"),
                column: "StayTypeId",
                value: new Guid("70000000-0000-0000-0000-00000000000d"));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-00000000000a"), new Guid("70000000-0000-0000-0000-00000000000c") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-00000000000a"), new Guid("70000000-0000-0000-0000-00000000000c") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000006"), new Guid("70000000-0000-0000-0000-00000000000f") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000006"), new Guid("70000000-0000-0000-0000-00000000000f") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000008"), new Guid("70000000-0000-0000-0000-00000000000d") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000006"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000008"), new Guid("70000000-0000-0000-0000-00000000000e") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000007"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000008"), new Guid("70000000-0000-0000-0000-00000000000b") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000008"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000009"), new Guid("70000000-0000-0000-0000-00000000000c") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000009"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000009"), new Guid("70000000-0000-0000-0000-00000000000b") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-00000000000a"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000003"), new Guid("70000000-0000-0000-0000-00000000000b") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-00000000000b"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000003"), new Guid("70000000-0000-0000-0000-00000000000e") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-00000000000c"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000001"), new Guid("70000000-0000-0000-0000-00000000000b") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-00000000000d"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000001"), new Guid("70000000-0000-0000-0000-00000000000f") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-00000000000e"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000004"), new Guid("70000000-0000-0000-0000-00000000000d") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-00000000000f"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000005"), new Guid("70000000-0000-0000-0000-00000000000b") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000010"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000005"), new Guid("70000000-0000-0000-0000-00000000000c") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000011"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000001"), new Guid("70000000-0000-0000-0000-00000000000b") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000012"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-00000000000a"), new Guid("70000000-0000-0000-0000-00000000000c") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000013"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-00000000000a"), new Guid("70000000-0000-0000-0000-00000000000c") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000014"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000009"), new Guid("70000000-0000-0000-0000-00000000000c") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000015"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000008"), new Guid("70000000-0000-0000-0000-00000000000d") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000016"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000008"), new Guid("70000000-0000-0000-0000-00000000000c") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000017"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000003"), new Guid("70000000-0000-0000-0000-00000000000b") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000018"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000004"), new Guid("70000000-0000-0000-0000-00000000000b") });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000019"),
                columns: new[] { "CityId", "StayTypeId" },
                values: new object[] { new Guid("70000000-0000-0000-0000-000000000005"), new Guid("70000000-0000-0000-0000-00000000000d") });

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
                name: "IX_Hotels_CityId",
                table: "Hotels",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_StayTypeId",
                table: "Hotels",
                column: "StayTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_StayTypeId",
                table: "Combos",
                column: "StayTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Taxonomies_StayTypeId",
                table: "Combos",
                column: "StayTypeId",
                principalTable: "Taxonomies",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Taxonomies_CityId",
                table: "Hotels",
                column: "CityId",
                principalTable: "Taxonomies",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Taxonomies_StayTypeId",
                table: "Hotels",
                column: "StayTypeId",
                principalTable: "Taxonomies",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Taxonomies_StayTypeId",
                table: "Combos");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Taxonomies_CityId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Taxonomies_StayTypeId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_CityId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_StayTypeId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Combos_StayTypeId",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "StayTypeId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "StayTypeId",
                table: "Combos");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Hotels",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Hotels",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StayType",
                table: "Combos",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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
                column: "StayType",
                value: "Resort");

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000002"),
                column: "StayType",
                value: "Hotel");

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000003"),
                column: "StayType",
                value: "Hotel");

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000004"),
                column: "StayType",
                value: "Hotel");

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000005"),
                column: "StayType",
                value: "Resort");

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000006"),
                column: "StayType",
                value: "Resort");

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000007"),
                column: "StayType",
                value: "Resort");

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000008"),
                column: "StayType",
                value: "Resort");

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000009"),
                column: "StayType",
                value: "Resort");

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000a"),
                column: "StayType",
                value: "Retreat");

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000b"),
                column: "StayType",
                value: "Resort");

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000c"),
                column: "StayType",
                value: "Hotel");

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000d"),
                column: "StayType",
                value: "Hotel");

            migrationBuilder.UpdateData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-00000000000e"),
                column: "StayType",
                value: "Retreat");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Phú Quốc", "Resort" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Phú Quốc", "Resort" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Hội An", "Boutique Hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Hội An", "Boutique Hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Đà Lạt", "Retreat" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000006"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Đà Lạt", "Wellness" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000007"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Đà Lạt", "Hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000008"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Nha Trang", "Resort" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000009"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Nha Trang", "Hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-00000000000a"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Hạ Long", "Hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-00000000000b"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Hạ Long", "Wellness" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-00000000000c"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Hà Nội", "Hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-00000000000d"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Hà Nội", "Boutique Hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-00000000000e"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Sa Pa", "Retreat" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-00000000000f"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Đà Nẵng", "Hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000010"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Đà Nẵng", "Resort" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000011"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Hà Nội", "Hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000012"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Phú Quốc", "Resort" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000013"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Phú Quốc", "Resort" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000014"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Nha Trang", "Resort" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000015"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Đà Lạt", "Retreat" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000016"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Đà Lạt", "Resort" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000017"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Hạ Long", "Hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000018"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Sa Pa", "Hotel" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000019"),
                columns: new[] { "City", "Type" },
                values: new object[] { "Đà Nẵng", "Retreat" });

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
