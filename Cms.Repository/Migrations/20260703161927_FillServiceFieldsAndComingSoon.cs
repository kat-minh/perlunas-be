using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class FillServiceFieldsAndComingSoon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ComingSoon",
                table: "Services",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "PriceUnit", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Đà Nẵng Hội An là hành trình 3 ngày 2 đêm do Perlunas thiết kế để bạn cảm nhận trọn vẹn Miền Trung.</p><p>Lịch trình cân bằng giữa khám phá và nghỉ ngơi, dịch vụ chọn lọc và đồng hành tận tâm suốt chuyến đi.</p>", new List<string> { "da-nang" }, "3 ngày 2 đêm", new List<string>(), new List<string> { "Cầu Vàng Bà Nà Hills", "Phố cổ Hội An về đêm", "Thả đèn hoa đăng sông Hoài", "Biển Mỹ Khê" }, "<h3>Điểm nhấn hành trình</h3><ul><li>Cầu Vàng Bà Nà Hills</li><li>Phố cổ Hội An về đêm</li><li>Thả đèn hoa đăng sông Hoài</li><li>Biển Mỹ Khê</li></ul><p>Perlunas cam kết dịch vụ minh bạch, đối tác lưu trú chọn lọc và hỗ trợ 24/7.</p>", "/ khách", "{\"stay\":\"Khách sạn/resort tiêu chuẩn theo lịch khởi hành\",\"sightsee\":\"Tham quan điểm nổi bật của Miền Trung\",\"food\":\"Ẩm thực đặc trưng địa phương\",\"transport\":\"Xe du lịch đời mới + HDV suốt tuyến\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói Akoya tại Terracotta Đà Lạt (Đà Lạt) — 2 ngày 1 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "2 ngày 1 đêm", new List<string>(), new List<string> { "1 đêm nghỉ tại Terracotta Đà Lạt", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại Terracotta Đà Lạt — chuẩn Akoya</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Khởi đầu tinh tế", "4800000", "4000000", "/ khách", "Nghỉ dưỡng", "Tây Nguyên", "{\"stay\":\"Terracotta Đà Lạt (Đà Lạt)\",\"sightsee\":\"Tự do khám phá Đà Lạt\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói Akoya tại Sheraton Hà Nội (Hà Nội) — 2 ngày 1 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "2 ngày 1 đêm", new List<string>(), new List<string> { "1 đêm nghỉ tại Sheraton Hà Nội", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại Sheraton Hà Nội — chuẩn Akoya</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Khởi đầu tinh tế", "6000000", "5000000", "/ khách", "Nghỉ dưỡng", "Miền Bắc", "{\"stay\":\"Sheraton Hà Nội (Hà Nội)\",\"sightsee\":\"Tự do khám phá Hà Nội\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói Tahiti tại Vinpearl Nha Trang (Nha Trang) — 3 ngày 2 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "3 ngày 2 đêm", new List<string>(), new List<string> { "2 đêm nghỉ tại Vinpearl Nha Trang", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại Vinpearl Nha Trang — chuẩn Tahiti</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Nâng tầm trải nghiệm", "9000000", "7500000", "/ khách", "Nghỉ dưỡng", "Miền Trung", "{\"stay\":\"Vinpearl Nha Trang (Nha Trang)\",\"sightsee\":\"Tự do khám phá Nha Trang\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("1c319bb9-c82d-5a4a-22b3-2f5d6625fbd2"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("22f4078a-1c46-d445-a3fb-c9ab91136022"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Điều hòa", "Phòng gym", "Spa", "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói Tahiti tại Sheraton Hà Nội (Hà Nội) — 4 ngày 3 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "4 ngày 3 đêm", new List<string>(), new List<string> { "3 đêm nghỉ tại Sheraton Hà Nội", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại Sheraton Hà Nội — chuẩn Tahiti</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Nâng tầm trải nghiệm", "18000000", "15000000", "/ khách", "Nghỉ dưỡng", "Miền Bắc", "{\"stay\":\"Sheraton Hà Nội (Hà Nội)\",\"sightsee\":\"Tự do khám phá Hà Nội\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói South Sea tại Naman Retreat Đà Nẵng (Đà Nẵng) — 3 ngày 2 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "3 ngày 2 đêm", new List<string>(), new List<string> { "2 đêm nghỉ tại Naman Retreat Đà Nẵng", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại Naman Retreat Đà Nẵng — chuẩn South Sea</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Đỉnh cao nghỉ dưỡng", "15600000", "13000000", "/ khách", "Nghỉ dưỡng", "Miền Trung", "{\"stay\":\"Naman Retreat Đà Nẵng (Đà Nẵng)\",\"sightsee\":\"Tự do khám phá Đà Nẵng\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "PriceUnit", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Nha Trang biển xanh là hành trình 3 ngày 2 đêm do Perlunas thiết kế để bạn cảm nhận trọn vẹn Miền Trung.</p><p>Lịch trình cân bằng giữa khám phá và nghỉ ngơi, dịch vụ chọn lọc và đồng hành tận tâm suốt chuyến đi.</p>", new List<string> { "nha-trang" }, "3 ngày 2 đêm", new List<string>(), new List<string> { "Khám phá đảo Hòn Mun", "Tắm bùn khoáng", "Vịnh Nha Trang", "Ẩm thực biển" }, "<h3>Điểm nhấn hành trình</h3><ul><li>Khám phá đảo Hòn Mun</li><li>Tắm bùn khoáng</li><li>Vịnh Nha Trang</li><li>Ẩm thực biển</li></ul><p>Perlunas cam kết dịch vụ minh bạch, đối tác lưu trú chọn lọc và hỗ trợ 24/7.</p>", "/ khách", "{\"stay\":\"Khách sạn/resort tiêu chuẩn theo lịch khởi hành\",\"sightsee\":\"Tham quan điểm nổi bật của Miền Trung\",\"food\":\"Ẩm thực đặc trưng địa phương\",\"transport\":\"Xe du lịch đời mới + HDV suốt tuyến\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói Akoya tại Hôtel de la Coupole Sa Pa (Sa Pa) — 2 ngày 1 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "2 ngày 1 đêm", new List<string>(), new List<string> { "1 đêm nghỉ tại Hôtel de la Coupole Sa Pa", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại Hôtel de la Coupole Sa Pa — chuẩn Akoya</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Khởi đầu tinh tế", "6600000", "5500000", "/ khách", "Nghỉ dưỡng", "Miền Bắc", "{\"stay\":\"Hôtel de la Coupole Sa Pa (Sa Pa)\",\"sightsee\":\"Tự do khám phá Sa Pa\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("64b5eb41-96db-8d39-22e5-4a7f2e4e4129"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6a695375-8160-a254-bce4-37be78bdbe63"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym", "Spa", "Đưa đón sân bay" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "PriceUnit", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Phú Quốc đảo ngọc là hành trình 3 ngày 2 đêm do Perlunas thiết kế để bạn cảm nhận trọn vẹn Miền Nam.</p><p>Lịch trình cân bằng giữa khám phá và nghỉ ngơi, dịch vụ chọn lọc và đồng hành tận tâm suốt chuyến đi.</p>", new List<string> { "phu-quoc" }, "3 ngày 2 đêm", new List<string>(), new List<string> { "Cáp treo Hòn Thơm dài nhất thế giới", "Lặn ngắm san hô 3 đảo", "Hoàng hôn bãi Sao", "Chợ đêm hải sản" }, "<h3>Điểm nhấn hành trình</h3><ul><li>Cáp treo Hòn Thơm dài nhất thế giới</li><li>Lặn ngắm san hô 3 đảo</li><li>Hoàng hôn bãi Sao</li><li>Chợ đêm hải sản</li></ul><p>Perlunas cam kết dịch vụ minh bạch, đối tác lưu trú chọn lọc và hỗ trợ 24/7.</p>", "/ khách", "{\"stay\":\"Khách sạn/resort tiêu chuẩn theo lịch khởi hành\",\"sightsee\":\"Tham quan điểm nổi bật của Miền Nam\",\"food\":\"Ẩm thực đặc trưng địa phương\",\"transport\":\"Xe du lịch đời mới + HDV suốt tuyến\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6b3cd177-825d-b0a4-22df-db79721fa23e"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6fc490b0-6501-7066-2716-f195529f23d3"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói Akoya tại Intercontinental Đà Nẵng (Đà Nẵng) — 2 ngày 1 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "2 ngày 1 đêm", new List<string>(), new List<string> { "1 đêm nghỉ tại Intercontinental Đà Nẵng", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại Intercontinental Đà Nẵng — chuẩn Akoya</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Khởi đầu tinh tế", "6000000", "5000000", "/ khách", "Nghỉ dưỡng", "Miền Trung", "{\"stay\":\"Intercontinental Đà Nẵng (Đà Nẵng)\",\"sightsee\":\"Tự do khám phá Đà Nẵng\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói Tahiti tại Sheraton Hà Nội (Hà Nội) — 3 ngày 2 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "3 ngày 2 đêm", new List<string>(), new List<string> { "2 đêm nghỉ tại Sheraton Hà Nội", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại Sheraton Hà Nội — chuẩn Tahiti</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Nâng tầm trải nghiệm", "9600000", "8000000", "/ khách", "Nghỉ dưỡng", "Miền Bắc", "{\"stay\":\"Sheraton Hà Nội (Hà Nội)\",\"sightsee\":\"Tự do khám phá Hà Nội\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("836e3fca-9da6-4631-f71f-ef0f27a681c1"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói Tahiti tại JW Marriott Phú Quốc (Phú Quốc) — 3 ngày 2 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "3 ngày 2 đêm", new List<string>(), new List<string> { "2 đêm nghỉ tại JW Marriott Phú Quốc", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại JW Marriott Phú Quốc — chuẩn Tahiti</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Nâng tầm trải nghiệm", "10800000", "9000000", "/ khách", "Nghỉ dưỡng", "Miền Nam", "{\"stay\":\"JW Marriott Phú Quốc (Phú Quốc)\",\"sightsee\":\"Tự do khám phá Phú Quốc\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8e401cad-0a9e-259e-9819-bf4842528f05"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói South Sea tại Ana Mandara Đà Lạt (Đà Lạt) — 3 ngày 2 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "3 ngày 2 đêm", new List<string>(), new List<string> { "2 đêm nghỉ tại Ana Mandara Đà Lạt", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại Ana Mandara Đà Lạt — chuẩn South Sea</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Đỉnh cao nghỉ dưỡng", "13200000", "11000000", "/ khách", "Nghỉ dưỡng", "Tây Nguyên", "{\"stay\":\"Ana Mandara Đà Lạt (Đà Lạt)\",\"sightsee\":\"Tự do khám phá Đà Lạt\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "PriceUnit", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Hà Nội Sa Pa là hành trình 4 ngày 3 đêm do Perlunas thiết kế để bạn cảm nhận trọn vẹn Miền Bắc.</p><p>Lịch trình cân bằng giữa khám phá và nghỉ ngơi, dịch vụ chọn lọc và đồng hành tận tâm suốt chuyến đi.</p>", new List<string> { "ha-noi", "sa-pa" }, "4 ngày 3 đêm", new List<string>(), new List<string> { "Phố cổ Hà Nội và Hồ Gươm", "Ruộng bậc thang Mường Hoa", "Cáp treo Fansipan", "Bản làng người Mông, người Dao" }, "<h3>Điểm nhấn hành trình</h3><ul><li>Phố cổ Hà Nội và Hồ Gươm</li><li>Ruộng bậc thang Mường Hoa</li><li>Cáp treo Fansipan</li><li>Bản làng người Mông, người Dao</li></ul><p>Perlunas cam kết dịch vụ minh bạch, đối tác lưu trú chọn lọc và hỗ trợ 24/7.</p>", "/ khách", "{\"stay\":\"Khách sạn/resort tiêu chuẩn theo lịch khởi hành\",\"sightsee\":\"Tham quan điểm nổi bật của Miền Bắc\",\"food\":\"Ẩm thực đặc trưng địa phương\",\"transport\":\"Xe du lịch đời mới + HDV suốt tuyến\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a846c103-c841-b1a6-3479-a7299029ca67"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói South Sea tại InterContinental Phú Quốc (Phú Quốc) — 3 ngày 2 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "3 ngày 2 đêm", new List<string>(), new List<string> { "2 đêm nghỉ tại InterContinental Phú Quốc", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại InterContinental Phú Quốc — chuẩn South Sea</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Đỉnh cao nghỉ dưỡng", "14400000", "12000000", "/ khách", "Nghỉ dưỡng", "Miền Nam", "{\"stay\":\"InterContinental Phú Quốc (Phú Quốc)\",\"sightsee\":\"Tự do khám phá Phú Quốc\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("abca9795-459e-619e-fac5-12763e8182cf"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói Akoya tại Vinpearl Nha Trang (Nha Trang) — 2 ngày 1 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "2 ngày 1 đêm", new List<string>(), new List<string> { "1 đêm nghỉ tại Vinpearl Nha Trang", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại Vinpearl Nha Trang — chuẩn Akoya</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Khởi đầu tinh tế", "5400000", "4500000", "/ khách", "Nghỉ dưỡng", "Miền Trung", "{\"stay\":\"Vinpearl Nha Trang (Nha Trang)\",\"sightsee\":\"Tự do khám phá Nha Trang\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "PriceUnit", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Đà Lạt mộng mơ là hành trình 3 ngày 2 đêm do Perlunas thiết kế để bạn cảm nhận trọn vẹn Tây Nguyên.</p><p>Lịch trình cân bằng giữa khám phá và nghỉ ngơi, dịch vụ chọn lọc và đồng hành tận tâm suốt chuyến đi.</p>", new List<string> { "da-lat" }, "3 ngày 2 đêm", new List<string>(), new List<string> { "Săn mây Cầu Đất lúc bình minh", "Vườn hồng và đồi chè Cầu Đất", "Cà phê giữa rừng thông", "Chợ đêm và ẩm thực phố núi" }, "<h3>Điểm nhấn hành trình</h3><ul><li>Săn mây Cầu Đất lúc bình minh</li><li>Vườn hồng và đồi chè Cầu Đất</li><li>Cà phê giữa rừng thông</li><li>Chợ đêm và ẩm thực phố núi</li></ul><p>Perlunas cam kết dịch vụ minh bạch, đối tác lưu trú chọn lọc và hỗ trợ 24/7.</p>", "/ khách", "{\"stay\":\"Khách sạn/resort tiêu chuẩn theo lịch khởi hành\",\"sightsee\":\"Tham quan điểm nổi bật của Tây Nguyên\",\"food\":\"Ẩm thực đặc trưng địa phương\",\"transport\":\"Xe du lịch đời mới + HDV suốt tuyến\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("be9279af-57b7-1a64-3d9c-e69e8885cc0a"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Lễ tân 24h", "Điều hòa", "Phòng gym", "Spa", "Đưa đón sân bay", "Quầy bar" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c798db8d-3381-10a2-4623-3a599a44ad4a"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói Tahiti tại Sheraton Hạ Long (Hạ Long) — 3 ngày 2 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "3 ngày 2 đêm", new List<string>(), new List<string> { "2 đêm nghỉ tại Sheraton Hạ Long", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại Sheraton Hạ Long — chuẩn Tahiti</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Nâng tầm trải nghiệm", "10200000", "8500000", "/ khách", "Nghỉ dưỡng", "Miền Bắc", "{\"stay\":\"Sheraton Hạ Long (Hạ Long)\",\"sightsee\":\"Tự do khám phá Hạ Long\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d07f4322-2edb-544f-7286-265c1c258ce0"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d43e2322-4d95-0305-d0aa-1303db0dade7"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("de0528da-01be-297f-3d6f-59795657002f"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e50a45c4-40d6-316f-0e40-2e58860b0f8e"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f8598638-8a39-2092-c30f-1f4e69dc2511"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Spa", "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("fce66f24-a18b-3b62-8473-12df889d6e6f"),
                columns: new[] { "ComingSoon", "Destinations", "Facilities", "Highlight" },
                values: new object[] { false, new List<string>(), new List<string> { "Phòng gym", "Spa", "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"),
                columns: new[] { "Album", "ComingSoon", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1528127269322-539801943592?w=1600&q=70\",\"https://images.unsplash.com/photo-1540541338287-41700207dee6?w=1600&q=70\",\"https://images.unsplash.com/photo-1476514525535-07fb3b4ae5f1?w=1600&q=70\"]", false, "<p>Gói South Sea tại JW Marriott Phú Quốc (Phú Quốc) — 4 ngày 3 đêm nghỉ dưỡng trọn gói với phòng nghỉ chọn lọc và ưu đãi đi kèm.</p>", new List<string>(), "4 ngày 3 đêm", new List<string>(), new List<string> { "3 đêm nghỉ tại JW Marriott Phú Quốc", "Ăn sáng buffet mỗi ngày", "Ưu đãi ẩm thực & tiện ích tại resort", "Hỗ trợ đặt dịch vụ & đưa đón" }, "<h3>Vì sao chọn gói này</h3><ul><li>Lưu trú tại JW Marriott Phú Quốc — chuẩn South Sea</li><li>Ưu đãi ẩm thực & tiện ích resort</li><li>Linh hoạt ngày nhận/trả phòng</li></ul>", "Đỉnh cao nghỉ dưỡng", "19200000", "16000000", "/ khách", "Nghỉ dưỡng", "Miền Nam", "{\"stay\":\"JW Marriott Phú Quốc (Phú Quốc)\",\"sightsee\":\"Tự do khám phá Phú Quốc\",\"food\":\"Ăn sáng tại khách sạn\",\"transport\":\"Chủ động; Perlunas hỗ trợ đưa đón tuỳ gói\"}" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComingSoon",
                table: "Services");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "PriceUnit", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string> { "da-nang" }, null, new List<string>(), new List<string> { "Cầu Vàng Bà Nà Hills", "Phố cổ Hội An về đêm", "Thả đèn hoa đăng sông Hoài", "Biển Mỹ Khê" }, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("1c319bb9-c82d-5a4a-22b3-2f5d6625fbd2"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("22f4078a-1c46-d445-a3fb-c9ab91136022"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Điều hòa", "Phòng gym", "Spa", "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "PriceUnit", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string> { "nha-trang" }, null, new List<string>(), new List<string> { "Khám phá đảo Hòn Mun", "Tắm bùn khoáng", "Vịnh Nha Trang", "Ẩm thực biển" }, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("64b5eb41-96db-8d39-22e5-4a7f2e4e4129"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6a695375-8160-a254-bce4-37be78bdbe63"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym", "Spa", "Đưa đón sân bay" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "PriceUnit", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string> { "phu-quoc" }, null, new List<string>(), new List<string> { "Cáp treo Hòn Thơm dài nhất thế giới", "Lặn ngắm san hô 3 đảo", "Hoàng hôn bãi Sao", "Chợ đêm hải sản" }, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6b3cd177-825d-b0a4-22df-db79721fa23e"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6fc490b0-6501-7066-2716-f195529f23d3"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("836e3fca-9da6-4631-f71f-ef0f27a681c1"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8e401cad-0a9e-259e-9819-bf4842528f05"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "PriceUnit", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string> { "ha-noi", "sa-pa" }, null, new List<string>(), new List<string> { "Phố cổ Hà Nội và Hồ Gươm", "Ruộng bậc thang Mường Hoa", "Cáp treo Fansipan", "Bản làng người Mông, người Dao" }, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a846c103-c841-b1a6-3479-a7299029ca67"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("abca9795-459e-619e-fac5-12763e8182cf"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "PriceUnit", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string> { "da-lat" }, null, new List<string>(), new List<string> { "Săn mây Cầu Đất lúc bình minh", "Vườn hồng và đồi chè Cầu Đất", "Cà phê giữa rừng thông", "Chợ đêm và ẩm thực phố núi" }, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("be9279af-57b7-1a64-3d9c-e69e8885cc0a"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Lễ tân 24h", "Điều hòa", "Phòng gym", "Spa", "Đưa đón sân bay", "Quầy bar" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c798db8d-3381-10a2-4623-3a599a44ad4a"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d07f4322-2edb-544f-7286-265c1c258ce0"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d43e2322-4d95-0305-d0aa-1303db0dade7"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("de0528da-01be-297f-3d6f-59795657002f"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e50a45c4-40d6-316f-0e40-2e58860b0f8e"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f8598638-8a39-2092-c30f-1f4e69dc2511"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Spa", "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("fce66f24-a18b-3b62-8473-12df889d6e6f"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string> { "Phòng gym", "Spa", "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí" }, new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"),
                columns: new[] { "Album", "Description", "Destinations", "DurationText", "Facilities", "Highlight", "HighlightContent", "Label", "OriginalPrice", "Price", "PriceUnit", "PurposeOfTrip", "Region", "TripInfoJson" },
                values: new object[] { "[]", null, new List<string>(), null, new List<string>(), new List<string>(), null, null, null, null, null, null, null, null });
        }
    }
}
