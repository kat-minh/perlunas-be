using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddTourHighlightContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HighlightContent",
                table: "Services",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555551"),
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Xe du lịch đời mới máy lạnh đưa đón theo chương trình.\nKhách sạn theo tiêu chuẩn, 2 - 3 khách/phòng.\nCác bữa ăn theo chương trình.\nVé tham quan các điểm có trong chương trình.\nHướng dẫn viên kinh nghiệm phục vụ suốt tuyến.\nBảo hiểm du lịch và nước suối trên xe.", "", "Giá tour bao gồm" });

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555552"),
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Quý khách xuất trình giấy tờ tuỳ thân hợp lệ khi nhận phòng.", "Giấy tờ cần thiết", "Nhận phòng" });

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555553"),
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Lịch trình cuối cùng được xác nhận trước ngày khởi hành 48 giờ.", "Thiết kế theo yêu cầu", "Lịch trình riêng" });

            migrationBuilder.InsertData(
                table: "ImportantInfors",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "ServiceId", "SubTitle", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("55555555-5555-5555-5555-5555555555a1"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Chi phí cá nhân, giặt ủi, điện thoại, đồ uống ngoài chương trình.\nTiền tip cho hướng dẫn viên và tài xế.\nPhụ thu phòng đơn.\nThuế VAT và hóa đơn đỏ (nếu khách yêu cầu).", false, new Guid("11111111-1111-1111-1111-111111111111"), "", "Giá tour chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55555555-5555-5555-5555-5555555555a2"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung với bố mẹ; 2 người lớn kèm tối đa 1 trẻ.\nTrẻ 5 - dưới 10 tuổi: tính 50% giá tour.\nTrẻ từ 10 tuổi trở lên: tính như người lớn.", false, new Guid("11111111-1111-1111-1111-111111111111"), "", "Giá trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55555555-5555-5555-5555-5555555555a3"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá tour ngay khi đăng ký để giữ chỗ.\nThanh toán phần còn lại trước ngày khởi hành tối thiểu 7 ngày.\nCung cấp đầy đủ thông tin: họ tên, năm sinh, số CMND/CCCD/hộ chiếu.", false, new Guid("11111111-1111-1111-1111-111111111111"), "", "Điều kiện đăng ký và thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55555555-5555-5555-5555-5555555555a4"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước khởi hành từ 15 ngày: phí 30% giá tour.\nHuỷ trước 7 - 14 ngày: phí 50% giá tour.\nHuỷ trong vòng 6 ngày hoặc không khởi hành (no-show): phí 100% giá tour.", false, new Guid("11111111-1111-1111-1111-111111111111"), "Ngày thường", "Điều kiện đổi và huỷ tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55555555-5555-5555-5555-5555555555a5"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ… hai bên cùng thương lượng giải quyết hợp lý, đảm bảo quyền lợi tối đa cho khách.\nPerlunas có quyền thay đổi lộ trình vì lý do an toàn nhưng vẫn đảm bảo tiêu chuẩn dịch vụ.", false, new Guid("11111111-1111-1111-1111-111111111111"), "", "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "Destinations", "Facilities", "Highlight", "HighlightContent" },
                values: new object[] { new List<string> { "Da Nang Beach" }, new List<string>(), new List<string> { "Sample service highlights." }, "<h3>Điểm nhấn hành trình</h3><ul><li>Ngắm hoàng hôn trên biển Đà Nẵng</li><li>Dạo phố cổ Hội An lung linh đèn lồng</li><li>Thưởng thức tinh hoa ẩm thực miền Trung</li></ul><h3>Du lịch Bền vững (ESG)</h3><p>Tôn vinh cảnh quan thiên nhiên, kết nối cộng đồng địa phương qua các làng nghề và không gian bản địa.</p><h3>Trải nghiệm Bản địa (LEI)</h3><p>Khám phá văn hóa – lịch sử tiêu biểu và những trải nghiệm chỉ có tại điểm đến.</p>" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111112"),
                columns: new[] { "Destinations", "Facilities", "Highlight", "HighlightContent" },
                values: new object[] { new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string> { "Private beach", "spa", "local dining" }, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111113"),
                columns: new[] { "Destinations", "Facilities", "Highlight", "HighlightContent" },
                values: new object[] { new List<string>(), new List<string>(), new List<string> { "Flexible route", "private guide" }, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222211"),
                columns: new[] { "Destinations", "Facilities", "Highlight", "HighlightContent" },
                values: new object[] { new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>(), null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222212"),
                columns: new[] { "Destinations", "Facilities", "Highlight", "HighlightContent" },
                values: new object[] { new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>(), null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222213"),
                columns: new[] { "Destinations", "Facilities", "Highlight", "HighlightContent" },
                values: new object[] { new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>(), null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-222222222214"),
                columns: new[] { "Destinations", "Facilities", "Highlight", "HighlightContent" },
                values: new object[] { new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>(), null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333311"),
                columns: new[] { "Destinations", "Facilities", "Highlight", "HighlightContent" },
                values: new object[] { new List<string>(), new List<string>(), new List<string> { "Historic sites." }, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333312"),
                columns: new[] { "Destinations", "Facilities", "Highlight", "HighlightContent" },
                values: new object[] { new List<string>(), new List<string>(), new List<string> { "Spectacular bays." }, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333313"),
                columns: new[] { "Destinations", "Facilities", "Highlight", "HighlightContent" },
                values: new object[] { new List<string>(), new List<string>(), new List<string> { "Bangkok and Phuket." }, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-5555555555a1"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-5555555555a2"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-5555555555a3"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-5555555555a4"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-5555555555a5"));

            migrationBuilder.DropColumn(
                name: "HighlightContent",
                table: "Services");

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555551"),
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Cancellation terms depend on departure date.", "Important before booking", "Cancellation policy" });

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555552"),
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Guests must present valid identification at check-in.", "Required documents", "Resort check-in" });

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555553"),
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Final itinerary must be confirmed 48 hours before departure.", "Custom planning", "Private itinerary" });

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
    }
}
