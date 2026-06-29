using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddTourTaxonomyFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TourTaxonomyDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "TaxonomyId",
                table: "Tours",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                columns: new[] { "Highlights", "Stays", "TaxonomyId" },
                values: new object[] { new List<string> { "Săn mây Cầu Đất lúc bình minh", "Vườn hồng và đồi chè Cầu Đất", "Cà phê giữa rừng thông", "Chợ đêm và ẩm thực phố núi" }, new List<string> { "da-lat" }, new Guid("70000000-0000-0000-0000-000000000008") });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                columns: new[] { "Highlights", "Stays", "TaxonomyId" },
                values: new object[] { new List<string> { "Cáp treo Hòn Thơm dài nhất thế giới", "Lặn ngắm san hô 3 đảo", "Hoàng hôn bãi Sao", "Chợ đêm hải sản" }, new List<string> { "phu-quoc" }, new Guid("70000000-0000-0000-0000-00000000000a") });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                columns: new[] { "Highlights", "Stays", "TaxonomyId" },
                values: new object[] { new List<string> { "Phố cổ Hà Nội và Hồ Gươm", "Ruộng bậc thang Mường Hoa", "Cáp treo Fansipan", "Bản làng người Mông, người Dao" }, new List<string> { "ha-noi", "sa-pa" }, new Guid("70000000-0000-0000-0000-000000000001") });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                columns: new[] { "Highlights", "Stays", "TaxonomyId" },
                values: new object[] { new List<string> { "Cầu Vàng Bà Nà Hills", "Phố cổ Hội An về đêm", "Thả đèn hoa đăng sông Hoài", "Biển Mỹ Khê" }, new List<string> { "da-nang" }, new Guid("70000000-0000-0000-0000-000000000005") });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000005"),
                columns: new[] { "Highlights", "Stays", "TaxonomyId" },
                values: new object[] { new List<string> { "Khám phá đảo Hòn Mun", "Tắm bùn khoáng", "Vịnh Nha Trang", "Ẩm thực biển" }, new List<string> { "nha-trang" }, new Guid("70000000-0000-0000-0000-000000000009") });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TaxonomyId",
                table: "Tours",
                column: "TaxonomyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Taxonomies_TaxonomyId",
                table: "Tours",
                column: "TaxonomyId",
                principalTable: "Taxonomies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Taxonomies_TaxonomyId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_TaxonomyId",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "TaxonomyId",
                table: "Tours");

            migrationBuilder.CreateTable(
                name: "TourTaxonomyDetails",
                columns: table => new
                {
                    TourId = table.Column<Guid>(type: "uuid", nullable: false),
                    TaxonomyId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourTaxonomyDetails", x => new { x.TourId, x.TaxonomyId });
                    table.ForeignKey(
                        name: "FK_TourTaxonomyDetails_Taxonomies_TaxonomyId",
                        column: x => x.TaxonomyId,
                        principalTable: "Taxonomies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourTaxonomyDetails_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "TourTaxonomyDetails",
                columns: new[] { "TaxonomyId", "TourId" },
                values: new object[,]
                {
                    { new Guid("70000000-0000-0000-0000-000000000008"), new Guid("30000000-0000-0000-0000-000000000001") },
                    { new Guid("70000000-0000-0000-0000-000000000013"), new Guid("30000000-0000-0000-0000-000000000001") },
                    { new Guid("70000000-0000-0000-0000-00000000000a"), new Guid("30000000-0000-0000-0000-000000000002") },
                    { new Guid("70000000-0000-0000-0000-000000000012"), new Guid("30000000-0000-0000-0000-000000000002") },
                    { new Guid("70000000-0000-0000-0000-000000000001"), new Guid("30000000-0000-0000-0000-000000000003") },
                    { new Guid("70000000-0000-0000-0000-000000000004"), new Guid("30000000-0000-0000-0000-000000000003") },
                    { new Guid("70000000-0000-0000-0000-000000000010"), new Guid("30000000-0000-0000-0000-000000000003") },
                    { new Guid("70000000-0000-0000-0000-000000000005"), new Guid("30000000-0000-0000-0000-000000000004") },
                    { new Guid("70000000-0000-0000-0000-000000000006"), new Guid("30000000-0000-0000-0000-000000000004") },
                    { new Guid("70000000-0000-0000-0000-000000000011"), new Guid("30000000-0000-0000-0000-000000000004") },
                    { new Guid("70000000-0000-0000-0000-000000000009"), new Guid("30000000-0000-0000-0000-000000000005") },
                    { new Guid("70000000-0000-0000-0000-000000000011"), new Guid("30000000-0000-0000-0000-000000000005") }
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
                name: "IX_TourTaxonomyDetails_TaxonomyId",
                table: "TourTaxonomyDetails",
                column: "TaxonomyId");
        }
    }
}
