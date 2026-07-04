using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedComboDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ImportantInfors",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "ServiceId", "SubTitle", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("cccf0001-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("6fc490b0-6501-7066-2716-f195529f23d3"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0001-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("6fc490b0-6501-7066-2716-f195529f23d3"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0001-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("6fc490b0-6501-7066-2716-f195529f23d3"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0001-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("6fc490b0-6501-7066-2716-f195529f23d3"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0001-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("6fc490b0-6501-7066-2716-f195529f23d3"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0001-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("6fc490b0-6501-7066-2716-f195529f23d3"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0002-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0002-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0002-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0002-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0002-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0002-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0003-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0003-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0003-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0003-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0003-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0003-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0004-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0004-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0004-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0004-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0004-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0004-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0005-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("a846c103-c841-b1a6-3479-a7299029ca67"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0005-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("a846c103-c841-b1a6-3479-a7299029ca67"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0005-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("a846c103-c841-b1a6-3479-a7299029ca67"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0005-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("a846c103-c841-b1a6-3479-a7299029ca67"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0005-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("a846c103-c841-b1a6-3479-a7299029ca67"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0005-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("a846c103-c841-b1a6-3479-a7299029ca67"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0006-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0006-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0006-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0006-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0006-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0006-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0007-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0007-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0007-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0007-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0007-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0007-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0008-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("abca9795-459e-619e-fac5-12763e8182cf"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0008-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("abca9795-459e-619e-fac5-12763e8182cf"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0008-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("abca9795-459e-619e-fac5-12763e8182cf"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0008-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("abca9795-459e-619e-fac5-12763e8182cf"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0008-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("abca9795-459e-619e-fac5-12763e8182cf"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0008-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("abca9795-459e-619e-fac5-12763e8182cf"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0009-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0009-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0009-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0009-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0009-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0009-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0010-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0010-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0010-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0010-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0010-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0010-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0011-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0011-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0011-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0011-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0011-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0011-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0012-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0012-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0012-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0012-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0012-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0012-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0013-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0013-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0013-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0013-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0013-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0013-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0014-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng nghỉ tại khách sạn/resort theo tiêu chuẩn gói\nĂn sáng mỗi ngày tại khách sạn\nCác dịch vụ và tiện ích theo chương trình gói\nƯu đãi/quà tặng đi kèm gói (nếu có)", false, new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"), null, "Giá gói bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0014-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay/di chuyển đến điểm đến (nếu không nêu trong gói)\nChi phí cá nhân, giặt ủi, đồ uống ngoài chương trình\nCác bữa ăn và dịch vụ không liệt kê trong gói\nPhụ thu nâng hạng phòng, ngày lễ, Tết và cao điểm\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"), null, "Giá gói chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0014-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung giường với bố mẹ; 2 người lớn kèm tối đa 1 trẻ\nTrẻ 5 – dưới 12 tuổi: phụ thu suất ăn/giường phụ theo quy định khách sạn\nTrẻ từ 12 tuổi: tính tiêu chuẩn như người lớn", false, new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0014-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá gói khi đăng ký để giữ chỗ\nThanh toán phần còn lại trước ngày nhận phòng tối thiểu 7 ngày\nCung cấp đầy đủ họ tên, số điện thoại, email khi đăng ký", false, new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"), null, "Điều kiện đăng ký & thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0014-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước ngày nhận phòng từ 15 ngày: phí 30% giá gói\nHuỷ trước 7 – 14 ngày: phí 50% giá gói\nHuỷ trong vòng 6 ngày hoặc không nhận phòng (no-show): phí 100% giá gói\nNgày lễ, Tết áp dụng chính sách riêng, phí huỷ cao hơn", false, new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"), null, "Điều kiện đổi & huỷ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccf0014-0000-0000-0000-000000000006"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bất khả kháng (thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ…): hai bên không bồi thường mà cùng thương lượng hợp lý, đảm bảo quyền lợi tối đa cho khách\nPerlunas có quyền điều chỉnh dịch vụ tương đương vì lý do khách quan nhưng vẫn đảm bảo tiêu chuẩn của gói", false, new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"), null, "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "RoomCategories",
                columns: new[] { "Id", "Acreage", "Album", "CreatedAt", "Description", "Feature", "IsDeleted", "NumberOfBed", "NumberOfCustomer", "OriginalPrice", "Price", "ServiceId", "Titile", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("caaa0001-0000-0000-0000-000000000001"), "32 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng Deluxe ấm cúng với ban công riêng, đầy đủ tiện nghi cho một kỳ nghỉ đôi thoải mái.", "[\"Wifi miễn phí\",\"Điều hòa\",\"Ban công\",\"Minibar\"]", false, "1 giường đôi lớn", 2, "3000000", "2500000", new Guid("6fc490b0-6501-7066-2716-f195529f23d3"), "Phòng Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caaa0002-0000-0000-0000-000000000001"), "42 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng Premier rộng rãi với ban công hướng cảnh và tiện nghi cao cấp, lý tưởng cho cặp đôi tận hưởng kỳ nghỉ.", "[\"Ban công view\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\",\"Minibar\"]", false, "1 giường King", 2, "5000000", "4000000", new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"), "Phòng Premier", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caaa0003-0000-0000-0000-000000000001"), "32 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng Deluxe ấm cúng với ban công riêng, đầy đủ tiện nghi cho một kỳ nghỉ đôi thoải mái.", "[\"Wifi miễn phí\",\"Điều hòa\",\"Ban công\",\"Minibar\"]", false, "1 giường đôi lớn", 2, "3000000", "2500000", new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"), "Phòng Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caaa0004-0000-0000-0000-000000000001"), "42 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng Premier rộng rãi với ban công hướng cảnh và tiện nghi cao cấp, lý tưởng cho cặp đôi tận hưởng kỳ nghỉ.", "[\"Ban công view\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\",\"Minibar\"]", false, "1 giường King", 2, "5000000", "4000000", new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"), "Phòng Premier", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caaa0005-0000-0000-0000-000000000001"), "58 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Suite cao cấp nhất với phòng khách riêng và tầm nhìn đẹp, dành cho gia đình hoặc kỳ nghỉ thật đặc biệt.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\",\"Minibar\"]", false, "1 giường King + sofa", 3, "7500000", "6000000", new Guid("a846c103-c841-b1a6-3479-a7299029ca67"), "Suite hướng biển", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caaa0006-0000-0000-0000-000000000001"), "42 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng Premier rộng rãi với ban công hướng cảnh và tiện nghi cao cấp, lý tưởng cho cặp đôi tận hưởng kỳ nghỉ.", "[\"Ban công view\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\",\"Minibar\"]", false, "1 giường King", 2, "5000000", "4000000", new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"), "Phòng Premier", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caaa0007-0000-0000-0000-000000000001"), "58 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Suite cao cấp nhất với phòng khách riêng và tầm nhìn đẹp, dành cho gia đình hoặc kỳ nghỉ thật đặc biệt.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\",\"Minibar\"]", false, "1 giường King + sofa", 3, "7500000", "6000000", new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"), "Suite hướng biển", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caaa0008-0000-0000-0000-000000000001"), "32 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng Deluxe ấm cúng với ban công riêng, đầy đủ tiện nghi cho một kỳ nghỉ đôi thoải mái.", "[\"Wifi miễn phí\",\"Điều hòa\",\"Ban công\",\"Minibar\"]", false, "1 giường đôi lớn", 2, "3000000", "2500000", new Guid("abca9795-459e-619e-fac5-12763e8182cf"), "Phòng Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caaa0009-0000-0000-0000-000000000001"), "42 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng Premier rộng rãi với ban công hướng cảnh và tiện nghi cao cấp, lý tưởng cho cặp đôi tận hưởng kỳ nghỉ.", "[\"Ban công view\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\",\"Minibar\"]", false, "1 giường King", 2, "5000000", "4000000", new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"), "Phòng Premier", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caaa0010-0000-0000-0000-000000000001"), "58 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Suite cao cấp nhất với phòng khách riêng và tầm nhìn đẹp, dành cho gia đình hoặc kỳ nghỉ thật đặc biệt.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\",\"Minibar\"]", false, "1 giường King + sofa", 3, "7500000", "6000000", new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"), "Suite hướng biển", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caaa0011-0000-0000-0000-000000000001"), "32 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng Deluxe ấm cúng với ban công riêng, đầy đủ tiện nghi cho một kỳ nghỉ đôi thoải mái.", "[\"Wifi miễn phí\",\"Điều hòa\",\"Ban công\",\"Minibar\"]", false, "1 giường đôi lớn", 2, "3000000", "2500000", new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"), "Phòng Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caaa0012-0000-0000-0000-000000000001"), "42 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng Premier rộng rãi với ban công hướng cảnh và tiện nghi cao cấp, lý tưởng cho cặp đôi tận hưởng kỳ nghỉ.", "[\"Ban công view\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\",\"Minibar\"]", false, "1 giường King", 2, "5000000", "4000000", new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"), "Phòng Premier", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caaa0013-0000-0000-0000-000000000001"), "32 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng Deluxe ấm cúng với ban công riêng, đầy đủ tiện nghi cho một kỳ nghỉ đôi thoải mái.", "[\"Wifi miễn phí\",\"Điều hòa\",\"Ban công\",\"Minibar\"]", false, "1 giường đôi lớn", 2, "3000000", "2500000", new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"), "Phòng Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caaa0014-0000-0000-0000-000000000001"), "58 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Suite cao cấp nhất với phòng khách riêng và tầm nhìn đẹp, dành cho gia đình hoặc kỳ nghỉ thật đặc biệt.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\",\"Minibar\"]", false, "1 giường King + sofa", 3, "7500000", "6000000", new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"), "Suite hướng biển", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "CreatedAt", "Day", "Description", "IsDeleted", "ServiceId", "Sumary", "Titile", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("cbbb0001-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Đà Nẵng, làm thủ tục nhận phòng tại Intercontinental Đà Nẵng. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("6fc490b0-6501-7066-2716-f195529f23d3"), "Ăn theo tiêu chuẩn gói", "Đến Đà Nẵng – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0001-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("6fc490b0-6501-7066-2716-f195529f23d3"), "Ăn sáng tại khách sạn", "Đà Nẵng – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0002-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Hà Nội, làm thủ tục nhận phòng tại Sheraton Hà Nội. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"), "Ăn theo tiêu chuẩn gói", "Đến Hà Nội – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0002-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do tận hưởng Sheraton Hà Nội hoặc khám phá Hà Nội theo sở thích. Perlunas sẵn sàng gợi ý điểm tham quan, ẩm thực và trải nghiệm địa phương.", false, new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"), "Ăn sáng tại khách sạn", "Tự do tại Hà Nội", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0002-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"), "Ăn sáng tại khách sạn", "Hà Nội – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0003-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Hà Nội, làm thủ tục nhận phòng tại Sheraton Hà Nội. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"), "Ăn theo tiêu chuẩn gói", "Đến Hà Nội – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0003-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"), "Ăn sáng tại khách sạn", "Hà Nội – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0004-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Hà Nội, làm thủ tục nhận phòng tại Sheraton Hà Nội. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"), "Ăn theo tiêu chuẩn gói", "Đến Hà Nội – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0004-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do tận hưởng Sheraton Hà Nội hoặc khám phá Hà Nội theo sở thích. Perlunas sẵn sàng gợi ý điểm tham quan, ẩm thực và trải nghiệm địa phương.", false, new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"), "Ăn sáng tại khách sạn", "Tự do tại Hà Nội", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0004-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Tự do tận hưởng Sheraton Hà Nội hoặc khám phá Hà Nội theo sở thích. Perlunas sẵn sàng gợi ý điểm tham quan, ẩm thực và trải nghiệm địa phương.", false, new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"), "Ăn sáng tại khách sạn", "Tự do tại Hà Nội", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0004-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 4", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"), "Ăn sáng tại khách sạn", "Hà Nội – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0005-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Phú Quốc, làm thủ tục nhận phòng tại InterContinental Phú Quốc. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("a846c103-c841-b1a6-3479-a7299029ca67"), "Ăn theo tiêu chuẩn gói", "Đến Phú Quốc – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0005-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do tận hưởng InterContinental Phú Quốc hoặc khám phá Phú Quốc theo sở thích. Perlunas sẵn sàng gợi ý điểm tham quan, ẩm thực và trải nghiệm địa phương.", false, new Guid("a846c103-c841-b1a6-3479-a7299029ca67"), "Ăn sáng tại khách sạn", "Tự do tại Phú Quốc", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0005-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("a846c103-c841-b1a6-3479-a7299029ca67"), "Ăn sáng tại khách sạn", "Phú Quốc – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0006-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Phú Quốc, làm thủ tục nhận phòng tại JW Marriott Phú Quốc. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"), "Ăn theo tiêu chuẩn gói", "Đến Phú Quốc – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0006-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do tận hưởng JW Marriott Phú Quốc hoặc khám phá Phú Quốc theo sở thích. Perlunas sẵn sàng gợi ý điểm tham quan, ẩm thực và trải nghiệm địa phương.", false, new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"), "Ăn sáng tại khách sạn", "Tự do tại Phú Quốc", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0006-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"), "Ăn sáng tại khách sạn", "Phú Quốc – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0007-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Phú Quốc, làm thủ tục nhận phòng tại JW Marriott Phú Quốc. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"), "Ăn theo tiêu chuẩn gói", "Đến Phú Quốc – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0007-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do tận hưởng JW Marriott Phú Quốc hoặc khám phá Phú Quốc theo sở thích. Perlunas sẵn sàng gợi ý điểm tham quan, ẩm thực và trải nghiệm địa phương.", false, new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"), "Ăn sáng tại khách sạn", "Tự do tại Phú Quốc", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0007-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Tự do tận hưởng JW Marriott Phú Quốc hoặc khám phá Phú Quốc theo sở thích. Perlunas sẵn sàng gợi ý điểm tham quan, ẩm thực và trải nghiệm địa phương.", false, new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"), "Ăn sáng tại khách sạn", "Tự do tại Phú Quốc", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0007-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 4", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"), "Ăn sáng tại khách sạn", "Phú Quốc – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0008-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Nha Trang, làm thủ tục nhận phòng tại Vinpearl Nha Trang. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("abca9795-459e-619e-fac5-12763e8182cf"), "Ăn theo tiêu chuẩn gói", "Đến Nha Trang – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0008-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("abca9795-459e-619e-fac5-12763e8182cf"), "Ăn sáng tại khách sạn", "Nha Trang – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0009-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Nha Trang, làm thủ tục nhận phòng tại Vinpearl Nha Trang. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"), "Ăn theo tiêu chuẩn gói", "Đến Nha Trang – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0009-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do tận hưởng Vinpearl Nha Trang hoặc khám phá Nha Trang theo sở thích. Perlunas sẵn sàng gợi ý điểm tham quan, ẩm thực và trải nghiệm địa phương.", false, new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"), "Ăn sáng tại khách sạn", "Tự do tại Nha Trang", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0009-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"), "Ăn sáng tại khách sạn", "Nha Trang – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0010-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Đà Lạt, làm thủ tục nhận phòng tại Ana Mandara Đà Lạt. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"), "Ăn theo tiêu chuẩn gói", "Đến Đà Lạt – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0010-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do tận hưởng Ana Mandara Đà Lạt hoặc khám phá Đà Lạt theo sở thích. Perlunas sẵn sàng gợi ý điểm tham quan, ẩm thực và trải nghiệm địa phương.", false, new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"), "Ăn sáng tại khách sạn", "Tự do tại Đà Lạt", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0010-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"), "Ăn sáng tại khách sạn", "Đà Lạt – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0011-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Đà Lạt, làm thủ tục nhận phòng tại Terracotta Đà Lạt. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"), "Ăn theo tiêu chuẩn gói", "Đến Đà Lạt – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0011-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"), "Ăn sáng tại khách sạn", "Đà Lạt – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0012-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Hạ Long, làm thủ tục nhận phòng tại Sheraton Hạ Long. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"), "Ăn theo tiêu chuẩn gói", "Đến Hạ Long – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0012-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do tận hưởng Sheraton Hạ Long hoặc khám phá Hạ Long theo sở thích. Perlunas sẵn sàng gợi ý điểm tham quan, ẩm thực và trải nghiệm địa phương.", false, new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"), "Ăn sáng tại khách sạn", "Tự do tại Hạ Long", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0012-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"), "Ăn sáng tại khách sạn", "Hạ Long – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0013-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Sa Pa, làm thủ tục nhận phòng tại Hôtel de la Coupole Sa Pa. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"), "Ăn theo tiêu chuẩn gói", "Đến Sa Pa – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0013-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"), "Ăn sáng tại khách sạn", "Sa Pa – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0014-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Quý khách đến Đà Nẵng, làm thủ tục nhận phòng tại Naman Retreat Đà Nẵng. Tự do nghỉ ngơi, tận hưởng tiện ích và dùng bữa theo tiêu chuẩn gói.", false, new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"), "Ăn theo tiêu chuẩn gói", "Đến Đà Nẵng – nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0014-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Tự do tận hưởng Naman Retreat Đà Nẵng hoặc khám phá Đà Nẵng theo sở thích. Perlunas sẵn sàng gợi ý điểm tham quan, ẩm thực và trải nghiệm địa phương.", false, new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"), "Ăn sáng tại khách sạn", "Tự do tại Đà Nẵng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbbb0014-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Tự do ăn sáng, thư giãn và mua sắm đặc sản làm quà. Quý khách làm thủ tục trả phòng, kết thúc kỳ nghỉ. Hẹn gặp lại quý khách.", false, new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"), "Ăn sáng tại khách sạn", "Đà Nẵng – trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
                    }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0001-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0001-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0001-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0001-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0001-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0001-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0002-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0002-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0002-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0002-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0002-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0002-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0003-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0003-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0003-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0003-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0003-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0003-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0004-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0004-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0004-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0004-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0004-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0004-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0005-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0005-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0005-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0005-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0005-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0005-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0006-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0006-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0006-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0006-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0006-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0006-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0007-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0007-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0007-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0007-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0007-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0007-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0008-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0008-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0008-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0008-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0008-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0008-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0009-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0009-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0009-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0009-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0009-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0009-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0010-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0010-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0010-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0010-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0010-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0010-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0011-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0011-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0011-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0011-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0011-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0011-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0012-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0012-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0012-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0012-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0012-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0012-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0013-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0013-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0013-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0013-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0013-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0013-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0014-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0014-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0014-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0014-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0014-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0014-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0001-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0002-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0003-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0004-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0005-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0006-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0007-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0008-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0009-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0010-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0011-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0012-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0013-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0014-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0001-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0001-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0002-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0002-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0002-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0003-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0003-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0004-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0004-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0004-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0004-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0005-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0005-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0005-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0006-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0006-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0006-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0007-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0007-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0007-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0007-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0008-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0008-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0009-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0009-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0009-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0010-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0010-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0010-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0011-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0011-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0012-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0012-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0012-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0013-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0013-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0014-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0014-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0014-0000-0000-0000-000000000003"));

            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
                    }
    }
}
