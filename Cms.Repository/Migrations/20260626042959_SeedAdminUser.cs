using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsDeleted", "PasswordHash", "Role", "UpdatedAt", "Username" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "admin@perlunas.com", false, "$2a$11$a2sSMwXgDlROTQLW1yAsIOrUC3b4TTNXFzr4JzFRVxNLEJARwH4/i", "Admin", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

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
