using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedFromLiveCatalog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888881"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888882"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888883"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-333333333311"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-333333333312"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-333333333313"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444441"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444442"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444443"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555551"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555552"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555553"));

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

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666662"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666663"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666671"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666672"));

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
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333331"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333332"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222221"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222223"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222224"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666661"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111112"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111113"));

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

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333311"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333312"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-333333333313"));

            migrationBuilder.AddColumn<string>(
                name: "PriceText",
                table: "Services",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Author", "CreatedAt", "Description", "IsDeleted", "ReadingTime", "SubTitile", "Tag", "Titile", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01b1cff1-b779-6962-501d-d1fad40823d1"), "Perlunas Team", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đà Lạt đẹp quanh năm, nhưng mỗi mùa lại có một sắc thái riêng. Cùng Perlunas chọn thời điểm hợp với chuyến đi của bạn.", false, "6 phút đọc", "Đà Lạt đẹp quanh năm, nhưng mỗi mùa lại có một sắc thái riêng. Cùng Perlunas chọn thời điểm hợp với chuyến đi của bạn.", "Cẩm nang điểm đến", "Kinh nghiệm du lịch Đà Lạt: đi mùa nào đẹp nhất?", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3ba1c9ca-b087-f6ad-53f7-6661263927dd"), "Perlunas Team", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đi cùng con không hề đáng sợ nếu bạn chuẩn bị đúng cách. Vài bí quyết để cả nhà cùng vui.", false, "6 phút đọc", "Đi cùng con không hề đáng sợ nếu bạn chuẩn bị đúng cách. Vài bí quyết để cả nhà cùng vui.", "Mẹo chuẩn bị", "Cẩm nang du lịch cùng trẻ nhỏ không căng thẳng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("41d9c601-dad8-03a5-ef3d-005d5d83212d"), "Perlunas Team", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Từ mì Quảng, bún bò Huế đến cao lầu Hội An — bản đồ vị giác miền Trung qua từng món ăn.", false, "5 phút đọc", "Từ mì Quảng, bún bò Huế đến cao lầu Hội An — bản đồ vị giác miền Trung qua từng món ăn.", "Ẩm thực", "Ẩm thực miền Trung nhất định phải thử một lần", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("75590804-8743-67aa-5ef8-0a59b7a1cdf3"), "Perlunas Team", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Những thói quen nhỏ giúp chuyến đi của bạn nhẹ nhàng hơn với thiên nhiên và cộng đồng địa phương.", false, "5 phút đọc", "Những thói quen nhỏ giúp chuyến đi của bạn nhẹ nhàng hơn với thiên nhiên và cộng đồng địa phương.", "Cảm hứng", "Du lịch bền vững: đi tử tế hơn với điểm đến", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8e471a7e-6ce1-0fca-3a68-c77dc221ff30"), "Perlunas Team", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đi biển không cần mang cả tủ đồ. Đây là danh sách tối giản giúp bạn nhẹ vali mà vẫn đủ đầy.", false, "4 phút đọc", "Đi biển không cần mang cả tủ đồ. Đây là danh sách tối giản giúp bạn nhẹ vali mà vẫn đủ đầy.", "Mẹo chuẩn bị", "Checklist hành lý gọn nhẹ cho chuyến biển đảo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("930bcada-e714-1e4e-a23f-9922481c6a46"), "Perlunas Team", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Tà Xùa, Y Tý, Fansipan — bản đồ săn mây cho người mê biển mây bồng bềnh mỗi sớm.", false, "7 phút đọc", "Tà Xùa, Y Tý, Fansipan — bản đồ săn mây cho người mê biển mây bồng bềnh mỗi sớm.", "Cẩm nang điểm đến", "Săn mây miền Bắc: những điểm đẹp nhất đầu đông", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("003b5c21-369d-5c7e-9e4d-82150133793c"), "Sứ mệnh", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.mission.eyebrow", "text", "Sứ mệnh · Nhãn", "Giới thiệu", null, "", 60, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("004891b9-5e27-7e02-3d8c-56718498a6b9"), "Một chuyến đi đoàn không bắt đầu từ số lượng người, mà từ cảm giác mọi người cùng thuộc về một hành trình. Điều khó nhất không phải là đưa nhiều người đi cùng nhau, mà là giữ cho ai cũng thấy mình được quan tâm.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.p1", "textarea", "Tour đoàn · Đoạn 1", "Trang chủ", null, "", 23, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("00c941fb-0469-baf8-0d0d-2f408515124a"), "Vận chuyển, lưu trú, ăn uống, hướng dẫn và các hoạt động gắn kết — tất cả được điều phối bởi một đội ngũ duy nhất.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block2.body", "textarea", "Khối 2 · Nội dung", "Tour đoàn", null, "", 100, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0418e9d6-1ef4-0722-fba5-c77ed788f4bc"), "Thứ 2 - Thứ 6", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.1.day", "text", "Giờ làm việc · Dòng 1 · Ngày", "Liên hệ", null, "", 84, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("049a80b8-4298-b3e2-8619-9ab9700aa750"), "Cảm nhận", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.eyebrow", "text", "Feedback · Nhãn", "Tour riêng tư", null, "", 125, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("05ee4325-808c-ec82-b641-922cef25b440"), "Perlunas đồng hành cùng doanh nghiệp", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.intro.title", "textarea", "Đoạn giới thiệu · Tiêu đề", "Tour đoàn", null, "", 102, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("06285583-2abb-07de-201f-1fb04bb374c2"), "Gói du lịch", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.combos.eyebrow", "text", "Combo · Nhãn", "Trang chủ", null, "", 17, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0677f038-e60d-dd37-49f9-bb7941c30a21"), "Những chỗ nghỉ được tuyển chọn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hotels.title", "textarea", "Khách sạn · Tiêu đề", "Trang chủ", null, "", 15, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("082d2f49-180b-d4bd-b50b-fe1761de61ec"), "Liên hệ tư vấn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.cta.button", "text", "Khối kêu gọi · Nút", "Giới thiệu", null, "", 76, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0cabe749-3c42-5ddc-36ee-d208f4ab7155"), "Chăm chút từng chi tiết, theo sát đến khi bạn trở về.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.2.desc", "textarea", "Giá trị 2 · Mô tả", "Giới thiệu", null, "", 70, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0f188bb1-c93f-6135-0d56-5b77bad21a16"), "Giá trị cốt lõi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.eyebrow", "text", "Giá trị cốt lõi · Nhãn", "Giới thiệu", null, "", 66, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0f596fe7-a517-d27d-b56c-e62aea7fc7b5"), "Mỗi hành trình là một viên ngọc dưới ánh trăng. Thiết kế những hành trình du lịch trong nước tinh tế và trọn vẹn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.tagline", "textarea", "Footer · Mô tả thương hiệu", "Chung", null, "", 155, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1273c77d-d451-aa12-d98f-b33da86818b3"), "Cảm ơn bạn đã ghé Perlunas. Chúng tôi tin rằng một hành trình đẹp không bắt đầu từ điểm đến, mà từ cảm giác bạn mang theo trên suốt chặng đường.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.p1", "textarea", "Về chúng tôi · Đoạn 1", "Trang chủ", null, "", 33, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("135e3ed1-aa61-30e8-7dbf-7e00a49451ba"), "Mỗi hành trình\nlà một viên ngọc.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hero.title", "textarea", "Hero · Tiêu đề", "Trang chủ", null, "", 1, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1383ed9a-23d1-6368-3bbe-9719adf0d334"), "Liên hệ tư vấn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hero.cta.secondary", "text", "Hero · Nút phụ", "Trang chủ", null, "", 4, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("16cdbc76-4f7e-dff3-754f-306145571a73"), "Gói du lịch khắp Việt Nam.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.hero.title", "textarea", "Hero · Tiêu đề", "Combo", null, "", 142, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1793d50d-5841-876e-cdb3-9e502116d530"), "Chọn gói phù hợp với nhu cầu của bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.choose.title", "textarea", "Cách chọn gói · Tiêu đề", "Phân loại Combo", null, "", 152, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("17b5469c-d517-301e-ccf6-af13244e4caa"), "Lịch khởi hành đều đặn, giá trọn gói rõ ràng, không phát sinh. Mỗi hành trình đều có thể may đo lại theo nhịp đi của bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourspage.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Tour trọn gói", null, "", 131, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("226b7aee-55ed-bc34-3026-3a652dd4e5db"), "Một số hành trình riêng đã thiết kế", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.title", "textarea", "Hành trình đã làm · Tiêu đề", "Tour riêng tư", null, "", 123, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("242cbc33-48cb-5c10-e968-7bd13316d3b8"), "https://images.unsplash.com/photo-1585970661791-9cec67470281?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.vision.image", "image", "Tầm nhìn · Ảnh", "Giới thiệu", null, "", 59, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("244486da-a6de-8c01-70c9-8fade9c759da"), "Lắng nghe, đề xuất, rồi tinh chỉnh.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.block.title", "text", "Khối · Tiêu đề", "Tour riêng tư", null, "", 116, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2469a941-9c71-c39e-f348-24f92eb5f79c"), "Nguyễn Văn A", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.philosophy.author", "text", "Triết lý · Tác giả", "Trang chủ", null, "", 8, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("27da4c8b-726e-9ee5-853e-63be273b3a57"), "Thứ 7", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.2.day", "text", "Giờ làm việc · Dòng 2 · Ngày", "Liên hệ", null, "", 86, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2d958ba6-4117-6267-662c-397de71b176f"), "Tại sao chọn Perlunas?", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.whyus.title", "text", "Tại sao chọn · Tiêu đề", "Trang chủ", null, "", 40, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2fafc1c9-349d-6120-a875-91ad637b551d"), "Một đầu mối lo trọn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block2.title", "text", "Khối 2 · Tiêu đề", "Tour đoàn", null, "", 99, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("300b774c-6d04-a446-ce43-3c1dc3d5b7ff"), "Feedback từ khách hàng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.feedback.title", "textarea", "Feedback · Tiêu đề", "Tour riêng tư", null, "", 126, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("30183877-e54a-42cb-1e2a-3828b8e3780a"), "Liên hệ tư vấn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.cta.button", "text", "Khối kêu gọi · Nút", "Tour đoàn", null, "", 110, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("32b9133d-222b-d05b-43d1-8ecf11f0c1ff"), "https://images.unsplash.com/photo-1521737604893-d14cc237f11d?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.philosophy.image", "image", "Triết lý kinh doanh · Ảnh", "Giới thiệu", null, "", 65, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3436c553-9587-fc3e-f6eb-1ec108a94b4c"), "Đề xuất chi tiết", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.cta", "text", "Tour riêng tư · Nút", "Trang chủ", null, "", 29, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("351ac8a9-10d5-0eda-e4df-2f334d4639d0"), "Để lại thông tin, Perlunas tư vấn gói phù hợp với bạn, miễn phí.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.cta.body", "textarea", "Khối kêu gọi · Nội dung", "Combo", null, "", 146, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("38ededb1-f8c8-69c7-9e6d-86d537cfd757"), "Khám phá Gói du lịch", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.upsell.button", "text", "Upsell · Nút", "Khách sạn", null, "", 140, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3a177178-c1ea-a6a1-a2a7-34f5bc6a9ced"), "Cách chọn gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.choose.eyebrow", "text", "Cách chọn gói · Nhãn", "Phân loại Combo", null, "", 151, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3b3d1240-11af-8e21-e70b-68dbac1d98b3"), "Tour riêng tư", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.eyebrow", "text", "Hero · Nhãn", "Tour riêng tư", null, "", 111, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3bc2c192-1ca6-6e15-a5ba-cd2d2677c0a3"), "Ba viên ngọc, ba chuẩn dịch vụ.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.hero.title", "textarea", "Hero · Tiêu đề", "Phân loại Combo", null, "", 149, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3d01f488-bad6-e812-2a54-f8fd5e2f766f"), "Perlunas thiết kế những chuyến đi trong nước đáng nhớ, tinh tế trong từng chi tiết và trọn vẹn từ đầu đến cuối.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hero.subtitle", "textarea", "Hero · Đoạn mô tả", "Trang chủ", null, "", 2, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4005b808-ab4d-4b53-fe0e-f6c4c0390379"), "Mặc định là những chỗ nghỉ Perlunas tuyển chọn. Chọn nơi đến và loại hình lưu trú để xem danh sách phù hợp với bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Khách sạn", null, "", 135, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("400e9a9c-ffc0-2f7d-b6f5-9ac7ca03c41a"), "https://images.unsplash.com/photo-1528127269322-539801943592?fm=jpg&q=60&w=2000&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.hero.image", "image", "Hero · Ảnh lớn", "Giới thiệu", null, "", 48, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4251a5e7-5d2f-6b8b-0e84-e5b0f10dbd60"), "Pearl", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.pearl.title", "text", "Pearl · Tiêu đề", "Giới thiệu", null, "", 50, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("46ad2fc8-9e76-a7ae-cc8b-7a3d0ef36f15"), "Gói du lịch kết hợp lưu trú, di chuyển và trải nghiệm theo ba mức: Akoya, Tahiti và South Sea, để chuyến đi của bạn liền mạch từ đầu đến cuối.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.upsell.body", "textarea", "Upsell · Nội dung", "Khách sạn", null, "", 139, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("46fa7f24-fa89-4265-bbae-57ee2c238efc"), "Không chỉ là đặt phòng, hãy đi cùng một gói trọn vẹn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.upsell.title", "textarea", "Upsell · Tiêu đề", "Khách sạn", null, "", 138, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("482b322d-aa3f-a63d-1c68-65a6f5934d5e"), "Đã thiết kế", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.work.eyebrow", "text", "Hành trình đã làm · Nhãn", "Tour riêng tư", null, "", 122, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4833c9bf-99f2-69ab-3817-65e89697a740"), "Nhận tư vấn chọn gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.choose.button", "text", "Cách chọn gói · Nút", "Phân loại Combo", null, "", 154, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4dab6cbf-c083-e211-93ac-78c862674366"), "Cảm nhận", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.eyebrow", "text", "Feedback · Nhãn", "Tour đoàn", null, "", 107, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4f1d25cc-eb03-773a-cd4d-435f00f01cf4"), "Xem chi tiết", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.packagetours.cta", "text", "Tour trọn gói · Nút thẻ", "Trang chủ", null, "", 13, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5054e184-2ccf-25bb-497f-179cf6a16af5"), "Những trải nghiệm chỉn chu, khơi gợi cảm hứng cho mỗi chuyến đi.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.packagetours.subtitle", "textarea", "Tour trọn gói · Mô tả", "Trang chủ", null, "", 12, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5543e00c-b994-c9b9-eee4-fb2a50f173e2"), "Những hành trình đã thiết kế sẵn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.packagetours.title", "textarea", "Tour trọn gói · Tiêu đề", "Trang chủ", null, "", 11, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("57fc6cc8-a6f9-854b-ee3b-59a3f4dadc70"), "Một số khách hàng đã hợp tác", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.clients.eyebrow", "text", "Khách hàng · Nhãn", "Tour riêng tư", null, "", 124, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("591484a3-a441-a52f-0ce9-5f5d5a765955"), "Yêu cầu tư vấn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.eyebrow", "text", "Hero · Nhãn", "Liên hệ", null, "", 77, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("59f02fdf-99ff-81dc-e7aa-9c34a28cf071"), "Về chúng tôi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.eyebrow", "text", "Hero · Nhãn", "Giới thiệu", null, "", 46, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5b7ed0bb-2bb6-7012-6367-48eb44ef5b69"), "Perlunas không bán những chuyến đi rập khuôn. Chúng tôi thiết kế những hành trình hợp với từng con người: tử tế, tinh tế và trọn vẹn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.hero.intro", "textarea", "Hero · Câu tuyên ngôn", "Giới thiệu", null, "", 47, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5cef9e35-18de-af99-324f-8e5afa14b6a2"), "Giá minh bạch", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.whyus.1.title", "text", "Tại sao chọn · Lý do 1 · Tiêu đề", "Trang chủ", null, "", 41, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5ebb5adc-dee0-8aa6-22ff-9a941cf8db73"), "https://images.unsplash.com/photo-1539635278303-d4002c07eae3?fm=jpg&q=60&w=1000&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block2.image", "image", "Khối 2 · Ảnh", "Tour đoàn", null, "", 101, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5f6f3bc0-b6d6-a3c8-f963-0c8564872403"), "Một số khách hàng đã hợp tác", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.clients.eyebrow", "text", "Khách hàng · Nhãn", "Tour đoàn", null, "", 106, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5f708f4b-6ee3-a579-f4b4-377a54e4a94d"), "Akoya, Tahiti và South Sea là ba chuẩn dịch vụ Perlunas đặt ra, gọi tên theo ba dòng ngọc trai quý nhất thế giới. Mỗi chuẩn áp dụng cho nhiều gói ở nhiều nơi và mức giá khác nhau — đây là ý nghĩa và những gì có trong từng gói.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Phân loại Combo", null, "", 150, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5f7e5641-8db3-b4c6-8d67-ebc98da5d8d1"), "Xem tất cả", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.combos.viewall", "text", "Combo · Ô xem tất cả", "Trang chủ", null, "", 21, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("60e2cc23-056f-a53c-6f47-e9151d575dcc"), "Chỗ nghỉ trên khắp Việt Nam.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.hero.title", "textarea", "Hero · Tiêu đề", "Khách sạn", null, "", 134, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("63838004-1afc-9534-fb90-1d66471eff84"), "Nhà sáng lập Perlunas", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.philosophy.role", "text", "Triết lý · Chức danh", "Trang chủ", null, "", 9, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("66f054c3-9033-e008-fab7-0b2ae2fd008a"), "Mang những hành trình tử tế, chỉn chu đến gần hơn với mỗi người, để ai cũng có thể đi và trở về trọn vẹn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.mission.body", "textarea", "Sứ mệnh · Nội dung", "Giới thiệu", null, "", 61, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("671d9441-9c76-e2fc-a613-deee8a143e48"), "Liên hệ tư vấn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.cta.button", "text", "Khối kêu gọi · Nút", "Combo", null, "", 147, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("693fbe8f-2ac2-7ed7-1931-ffd2fc6a355a"), "Bắt đầu thiết kế hành trình của riêng bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.cta.title", "textarea", "Khối kêu gọi · Tiêu đề", "Tour riêng tư", null, "", 127, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("698a1d81-444e-9197-e6fa-01b1a42d37da"), "Viên ngọc là bạn, vị khách của chúng tôi. Mỗi người một câu chuyện, nên chuyến đi cũng phải độc bản và của riêng bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.pearl.body", "textarea", "Pearl · Nội dung", "Giới thiệu", null, "", 51, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6c2a09a2-4ef6-6695-74b0-3cc4f390e77a"), "Phân loại Gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.eyebrow", "text", "Hero · Nhãn", "Phân loại Combo", null, "", 148, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6d6ac4ad-1e75-fb21-9e7b-836b3b0b461d"), "Mỗi điểm đến có ba gói theo mức độ trải nghiệm: Akoya, Tahiti và South Sea, đặt theo tên ba dòng ngọc trai quý.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.combos.text", "textarea", "Combo · Mô tả", "Trang chủ", null, "", 19, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6f589531-b724-1804-2d87-cf464e82b811"), "Cách chúng tôi làm việc", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.block.eyebrow", "text", "Khối · Nhãn", "Tour riêng tư", null, "", 115, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6fff5ba7-597d-1930-9d75-7c24e6a6cadb"), "Tận tâm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.2.title", "text", "Giá trị 2 · Tiêu đề", "Giới thiệu", null, "", 69, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("724f78b7-667d-8e60-e8be-803b987749c2"), "Xem thêm tất cả khách sạn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hotels.link", "text", "Khách sạn · Liên kết xem thêm", "Trang chủ", null, "", 16, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("72988e40-1ebc-a3d9-ec1a-33549ac92533"), "Hãy kể cho chúng tôi về đoàn của bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.p3", "textarea", "Tour đoàn · Đoạn 3", "Trang chủ", null, "", 25, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("72b12ce2-71b3-bcbe-7d71-365bb439d34b"), "Team building, gala dinner, hội nghị kết hợp tham quan — Perlunas lo trọn từ vận chuyển, lưu trú đến kịch bản gắn kết, với một đầu mối duy nhất xuyên suốt hành trình.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Tour đoàn", null, "", 92, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("733221dd-6b41-2b0a-ee06-3ca324046634"), "Chọn một vùng đất để bắt đầu.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.combos.title", "textarea", "Combo · Tiêu đề", "Trang chủ", null, "", 18, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("738b02de-722b-f905-3f0e-b1f672591abc"), "Bắt đầu thiết kế hành trình của riêng bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.cta.title", "textarea", "Khối kêu gọi · Tiêu đề", "Tour đoàn", null, "", 109, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("74fe23a2-d06a-a78f-7acb-4c4c596f8830"), "Hẹn gặp bạn trên những cung đường,", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.signoff", "text", "Về chúng tôi · Lời kết", "Trang chủ", null, "", 36, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("751a6dfd-32ee-cd9b-6339-f1fb1c24d88c"), "Mỗi đoàn là một câu chuyện riêng. Chúng tôi lắng nghe mục tiêu của bạn — từ gắn kết đội ngũ đến tri ân khách hàng — rồi thiết kế hành trình phù hợp nhất, chỉn chu trong từng khâu.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.intro.body", "textarea", "Đoạn giới thiệu · Nội dung (admin tự ghi)", "Tour đoàn", null, "", 103, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("75585640-7d76-015c-a148-7e037db0ee35"), "Feedback từ khách hàng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.feedback.title", "textarea", "Feedback · Tiêu đề", "Tour đoàn", null, "", 108, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("78a133eb-293d-d509-5d8e-d1b6acf3751c"), "Thiết kế hành trình du lịch trong nước", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hero.eyebrow", "text", "Hero · Nhãn", "Trang chủ", null, "", 0, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7a75458f-d907-c973-0daa-fc8949524e2f"), "Thân gửi bạn,", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.salutation", "text", "Về chúng tôi · Lời chào", "Trang chủ", null, "", 32, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7c2268fb-75f3-ac1e-b6ac-001b77f5e7c9"), "Triết lý kinh doanh", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.philosophy.eyebrow", "text", "Triết lý kinh doanh · Nhãn", "Giới thiệu", null, "", 63, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7e76414a-1b0e-c4ee-4e06-bd8cd659f1d0"), "Luna(s)", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.luna.title", "text", "Luna · Tiêu đề", "Giới thiệu", null, "", 54, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("801ba8c0-7c08-6334-c854-51ad0c7d155f"), "Khách sạn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.eyebrow", "text", "Hero · Nhãn", "Khách sạn", null, "", 133, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("80f15804-38e2-412a-9c41-58d46ce1e5b2"), "https://images.unsplash.com/photo-1774599661329-d9a2f999d1c4?fm=jpg&q=60&w=1000&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block1.image", "image", "Khối 1 · Ảnh", "Tour đoàn", null, "", 97, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8244270e-7b15-4f7b-0562-51acf56147c7"), "Khám phá hành trình", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hero.cta.primary", "text", "Hero · Nút chính", "Trang chủ", null, "", 3, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("82dde8a8-0e24-de9d-f952-351cc21a202d"), "Mỗi gói kết hợp lưu trú, di chuyển và trải nghiệm theo một trong ba chuẩn dịch vụ: Akoya, Tahiti, South Sea. Lọc theo nhu cầu của bạn, hoặc tìm hiểu ý nghĩa từng phân loại.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Combo", null, "", 143, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("835f961e-2f3b-5a7a-2d64-1e4924b49375"), "https://images.unsplash.com/photo-1528127269322-539801943592?fm=jpg&q=60&w=2000&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourspage.hero.image", "image", "Hero · Ảnh lớn", "Tour trọn gói", null, "", 132, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8622f81e-4d58-8f36-97d3-2f7213b7cd77"), "Minh bạch", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.3.title", "text", "Giá trị 3 · Tiêu đề", "Giới thiệu", null, "", 71, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8668febd-5072-6ce9-da99-ff5980f796cd"), "Tầm nhìn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.vision.eyebrow", "text", "Tầm nhìn · Nhãn", "Giới thiệu", null, "", 57, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8816a7d8-4243-1daa-fa36-57eaa21e8ff7"), "https://images.unsplash.com/photo-1539635278303-d4002c07eae3?fm=jpg&q=60&w=2000&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.hero.image", "image", "Hero · Ảnh lớn", "Combo", null, "", 144, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("899f8b33-d8c8-5727-1727-3659a85f4406"), "Sau khi bạn gửi yêu cầu, Perlunas sẽ liên hệ sớm để tư vấn và lên kế hoạch qua Zalo, điện thoại hoặc gặp trực tiếp. Mọi tư vấn và báo giá đều hoàn toàn miễn phí.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Liên hệ", null, "", 79, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8cb7c3f3-58c2-99e3-d248-41b63567e2ae"), "Tên thương hiệu", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.pearl.eyebrow", "text", "Pearl · Nhãn", "Giới thiệu", null, "", 49, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8d1566e4-1834-655a-191b-dc319a1d8359"), "Hỗ trợ tận nơi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.whyus.4.title", "text", "Tại sao chọn · Lý do 4 · Tiêu đề", "Trang chủ", null, "", 44, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8e976c12-5e1b-0b8c-5669-683c40adeb52"), "Một người đồng hành đi cùng bạn qua nhiều hành trình.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.4.desc", "textarea", "Giá trị 4 · Mô tả", "Giới thiệu", null, "", 74, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8edde97d-3d2a-e977-6e9a-aeb072d0b630"), "Trải nghiệm địa phương", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.whyus.5.title", "text", "Tại sao chọn · Lý do 5 · Tiêu đề", "Trang chủ", null, "", 45, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8f093ef2-98dc-5662-8984-8738e36ae76d"), "Tour trọn gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.packagetours.eyebrow", "text", "Tour trọn gói · Nhãn", "Trang chủ", null, "", 10, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9031b24b-c5b9-957b-5044-78e6b2b89dac"), "Trước chuyến đi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block1.eyebrow", "text", "Khối 1 · Nhãn", "Tour đoàn", null, "", 94, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("93050730-7d2c-b028-c37a-02ec1736ca08"), "Một số tour đoàn đã làm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.title", "textarea", "Tour đã làm · Tiêu đề", "Tour đoàn", null, "", 105, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("930919d0-0aad-b77c-858e-f25ff02b15e2"), "Nhắn tin", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.message.label", "text", "Nhắn tin · Nhãn", "Liên hệ", null, "", 82, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("935619cf-2d18-74fa-0f3c-3ab01442009c"), "Triết lý", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.philosophy.eyebrow", "text", "Triết lý · Nhãn", "Trang chủ", null, "", 6, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("93f88116-cc7c-94eb-0c48-aa5fb94bc905"), "Về chúng tôi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.eyebrow", "text", "Về chúng tôi · Nhãn", "Trang chủ", null, "", 30, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("95f3e091-9fc5-f359-b41d-27e6fb070e22"), "Liên hệ tư vấn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.cta.button", "text", "Khối kêu gọi · Nút", "Tour riêng tư", null, "", 128, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("97b49d74-2e68-6b1d-7446-69482bd63577"), "Đề xuất chi tiết", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.block.button", "text", "Khối · Nút", "Tour riêng tư", null, "", 118, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("991e2f42-0f0a-e069-f763-98bc3a1eca4b"), "Mỗi hành trình là một viên ngọc dưới ánh trăng.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.legal.tagline", "text", "Footer · Câu cuối", "Chung", null, "", 157, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9a456cc3-7974-7c70-e82a-123bf7b84c91"), "Nhận ưu đãi và thông tin mới nhất từ Perlunas", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.newsletter.eyebrow", "text", "Footer · Newsletter nhãn", "Chung", null, "", 156, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9ad20313-1717-ea1b-26aa-d1e64e9da201"), "Chân thành", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.1.title", "text", "Giá trị 1 · Tiêu đề", "Giới thiệu", null, "", 67, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9ae6ab6d-d737-7cf9-76e5-3941571d45e0"), "Nâng tầm trải nghiệm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.upsell.eyebrow", "text", "Upsell · Nhãn", "Khách sạn", null, "", 137, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9aeefac8-c403-ea50-2f4b-3b3124a1cf31"), "Bạn chia sẻ mong muốn, ngân sách và nhịp đi; Perlunas đề xuất một hành trình chi tiết rồi tinh chỉnh cùng bạn đến khi vừa ý — riêng tư, linh hoạt và trọn vẹn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.intro.body", "textarea", "Đoạn giới thiệu · Nội dung (admin tự ghi)", "Tour riêng tư", null, "", 121, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9f49e927-f3e0-5c22-a24d-67fc6f3d3a92"), "Hiểu đoàn trước khi lên lịch", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block1.title", "text", "Khối 1 · Tiêu đề", "Tour đoàn", null, "", 95, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a0fa752c-17f5-ef2f-657b-650d56fc8f81"), "Tư vấn miễn phí", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.whyus.2.title", "text", "Tại sao chọn · Lý do 2 · Tiêu đề", "Trang chủ", null, "", 42, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a32d80d8-59dc-3386-5852-4013f0c6b971"), "Lịch trình may đo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.whyus.3.title", "text", "Tại sao chọn · Lý do 3 · Tiêu đề", "Trang chủ", null, "", 43, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a7cca81f-3def-1c1d-c7c8-aef97e2f94fe"), "https://images.unsplash.com/photo-1566759996874-04d713cc224a?fm=jpg&q=60&w=2000&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.hero.image", "image", "Hero · Ảnh lớn", "Tour riêng tư", null, "", 114, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a8cc27dd-d7d8-7d37-47b8-12bcc260a771"), "Trở thành người đồng hành du lịch trong nước được tin yêu nhất tại Việt Nam.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.vision.body", "textarea", "Tầm nhìn · Nội dung", "Giới thiệu", null, "", 58, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ac060c01-719a-9fa9-177c-1379f89bd59f"), "Hành trình may đo cho riêng bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.hero.title", "textarea", "Hero · Tiêu đề", "Tour riêng tư", null, "", 112, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ae8e194a-f7e1-e990-7f6c-68d134dd1760"), "Giờ làm việc", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.label", "text", "Giờ làm việc · Nhãn", "Liên hệ", null, "", 83, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("af461a72-2506-8c7f-0737-f566e40d20e3"), "9:00 - 18:00", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.3.time", "text", "Giờ làm việc · Dòng 3 · Giờ", "Liên hệ", null, "", 89, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b29c4871-02cb-8ee1-a3d2-b79c42eda2a4"), "Tìm hiểu ba gói ngọc", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.combos.link", "text", "Combo · Liên kết", "Trang chủ", null, "", 20, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b36164ca-e708-5d34-d17a-0de2d3fa3d5f"), "Kể cho chúng tôi về chuyến đi của bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hero.title", "textarea", "Hero · Tiêu đề", "Liên hệ", null, "", 78, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b3c4d404-265e-e578-5c49-28427536cbbe"), "Trong chuyến đi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block2.eyebrow", "text", "Khối 2 · Nhãn", "Tour đoàn", null, "", 98, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b3c5e14e-fae8-896c-d55a-a9c9b790f1c0"), "Bạn chia sẻ mong muốn và ngân sách, chúng tôi đề xuất một hành trình chi tiết và điều chỉnh cùng bạn cho đến khi vừa ý.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.block.body", "textarea", "Khối · Nội dung", "Tour riêng tư", null, "", 117, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b6264cd6-0e10-73ac-bf85-64be24043b7e"), "https://images.unsplash.com/photo-1595345705177-ffe090eb0784?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.pearl.image", "image", "Pearl · Ảnh", "Giới thiệu", null, "", 52, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b6423768-c307-76b5-17af-9f5a021ea74c"), "https://images.unsplash.com/photo-1768881618157-2cc24f7493c6?fm=jpg&q=60&w=2000&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.hero.image", "image", "Hero · Ảnh lớn", "Tour đoàn", null, "", 93, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b6afb61b-c099-45b7-6da2-f1644e0a3353"), "Liên hệ tư vấn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.cta", "text", "Tour đoàn · Nút", "Trang chủ", null, "", 26, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b78062b1-d157-32fa-5698-b81b80a8b6ff"), "https://images.unsplash.com/photo-1566759996874-04d713cc224a?fm=jpg&q=60&w=1000&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.block.image", "image", "Khối · Ảnh", "Tour riêng tư", null, "", 119, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bcabd284-2e10-0be3-f66e-a3e2d959921c"), "8:00 - 21:00", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.1.time", "text", "Giờ làm việc · Dòng 1 · Giờ", "Liên hệ", null, "", 85, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("be0d1ed5-d717-07c3-8e92-6473071b6796"), "Tour riêng tư", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.eyebrow", "text", "Tour riêng tư · Nhãn", "Trang chủ", null, "", 27, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bf336563-7349-441c-a02b-6f311a85a575"), "Xách balo lên và đi, phần còn lại để Perlunas lo.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourspage.hero.title", "textarea", "Hero · Tiêu đề", "Tour trọn gói", null, "", 130, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c029fc13-55cc-7382-09c4-a46d322d7136"), "Chủ nhật", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.3.day", "text", "Giờ làm việc · Dòng 3 · Ngày", "Liên hệ", null, "", 88, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c3ddf3fc-1e35-c09d-e840-38f12ddaf18d"), "Gọi ngay hôm nay", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.call.label", "text", "Gọi · Nhãn", "Liên hệ", null, "", 80, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c9177084-d2b5-ffb3-fac7-07e063bdc956"), "Gói du lịch", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.eyebrow", "text", "Hero · Nhãn", "Combo", null, "", 141, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c939ff9d-4b08-d5ef-02ce-4bf13996da13"), "Vì thế, chúng tôi không tạo ra những chuyến đi rập khuôn. Chúng tôi lắng nghe câu chuyện của từng người, rồi thiết kế một lịch trình vừa vặn — chỉn chu trong từng chi tiết, tinh tế và trọn vẹn từ đầu đến cuối.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.p2", "textarea", "Về chúng tôi · Đoạn 2", "Trang chủ", null, "", 34, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbca273e-3b58-e679-39f5-e8afddcc96cb"), "Đoàn đông tới mấy, vẫn trọn vẹn từng người", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.title", "textarea", "Tour đoàn · Tiêu đề", "Trang chủ", null, "", 22, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cc1a2cb0-92ab-be0b-251c-9d08af75e307"), "Đoàn đông tới mấy, vẫn trọn vẹn từng người.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.hero.title", "textarea", "Hero · Tiêu đề", "Tour đoàn", null, "", 91, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cc4de10a-8dd6-65b2-50f9-6f923325f145"), "/about.png", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.image", "image", "Về chúng tôi · Ảnh", "Trang chủ", null, "", 31, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ccafaff8-20a4-2da6-ea22-9a6ecdfd94eb"), "Vietnam Airlines\nVietravel\nSaigontourist\nMường Thanh\nVinpearl\nBamboo Airways\nAccor Hotels\nSun World\nVietjet Air\nMarriott", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.partners.list", "textarea", "Đối tác · Danh sách (mỗi dòng một tên)", "Trang chủ", null, "", 39, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ce651df3-68a6-7d1e-8592-87bc09335a3e"), "https://cf.bstatic.com/xdata/images/hotel/max1024x768/482730525.jpg?k=4feae26c2ba7205e2fd33376a45a3db0798930244ec595cbc6a006400947a81a&o=", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.hero.image", "image", "Hero · Ảnh lớn", "Khách sạn", null, "", 136, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cec1e950-6ebe-c782-9b63-b1d68fe458e8"), "/hero-vid.mp4", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hero.video", "image", "Hero · Video nền (URL)", "Trang chủ", null, "", 5, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cf06c8e5-9cbf-b692-adf0-6c52da817325"), "Hành trình may đo cho riêng bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.title", "textarea", "Tour riêng tư · Tiêu đề", "Trang chủ", null, "", 28, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d1089649-ec2d-0a3e-2c3f-07430ef329be"), "Đã thực hiện", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.work.eyebrow", "text", "Tour đã làm · Nhãn", "Tour đoàn", null, "", 104, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d1f4fae1-465b-fb34-a74b-53af11b356cf"), "Perlunas", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.signature", "text", "Về chúng tôi · Chữ ký", "Trang chủ", null, "", 37, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d2f69603-3a54-bddb-3267-b0cc20db78ff"), "Báo giá trọn gói rõ ràng, nói được làm được.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.3.desc", "textarea", "Giá trị 3 · Mô tả", "Giới thiệu", null, "", 72, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d473a044-58ba-09d3-0231-0b3973de21e0"), "https://images.unsplash.com/photo-1581886573745-4487c55d95f8?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.luna.image", "image", "Luna · Ảnh", "Giới thiệu", null, "", 56, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d82175a4-f6e6-760c-8e1e-324bd03ad7ff"), "Chúng tôi tin một hành trình đẹp đến từ sự tử tế trong từng chi tiết, chứ không phải mức giá rẻ nhất. Perlunas chọn làm đúng và làm thật: minh bạch với khách, công bằng với đối tác, và đặt trải nghiệm lâu dài lên trước lợi nhuận trước mắt.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.philosophy.body", "textarea", "Triết lý kinh doanh · Nội dung", "Giới thiệu", null, "", 64, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d873c942-8bf3-439d-1367-ac18299cbf9f"), "https://images.unsplash.com/photo-1592903204858-e288251ad9cc?fm=jpg&q=60&w=1200&auto=format&fit=crop", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.mission.image", "image", "Sứ mệnh · Ảnh", "Giới thiệu", null, "", 62, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("da4b0cde-fc39-4562-c363-bd505291069b"), "Tên thương hiệu", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.luna.eyebrow", "text", "Luna · Nhãn", "Giới thiệu", null, "", 53, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("db6010ce-bbbe-7ee6-6bd7-26d4d05e2c5f"), "Khách sạn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.hotels.eyebrow", "text", "Khách sạn · Nhãn", "Trang chủ", null, "", 14, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("db67b3fb-553f-fdaf-9467-876c02c6d368"), "Mỗi gói phù hợp với một kiểu chuyến đi khác nhau — về ngân sách, mức độ riêng tư và những trải nghiệm bạn mong muốn. Phần hướng dẫn chọn gói chi tiết sẽ được Perlunas cập nhật. Trong lúc đó, cứ để lại thông tin, chúng tôi sẽ tư vấn gói hợp nhất cho bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.choose.body", "textarea", "Cách chọn gói · Nội dung", "Phân loại Combo", null, "", 153, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e09b5b38-f757-b493-f9bc-1f753c7e38e1"), "Đó là lý do Perlunas tìm hiểu từng đoàn trước khi lên lịch: mục tiêu, độ tuổi, ngân sách và nhịp đi riêng. Chúng tôi lo trọn từ vận chuyển, lưu trú, ăn uống đến kịch bản gắn kết, với một đầu mối duy nhất xuyên suốt.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.p2", "textarea", "Tour đoàn · Đoạn 2", "Trang chủ", null, "", 24, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e2c1f0fd-1964-fe4e-a4dc-7ecd36a7202b"), "Cùng Perlunas bắt đầu hành trình của bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.cta.title", "textarea", "Khối kêu gọi · Tiêu đề", "Giới thiệu", null, "", 75, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e31b31dd-0f5b-20cd-6e61-c34ba4938cb0"), "Hành trình thiết kế riêng cho bạn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.intro.title", "textarea", "Đoạn giới thiệu · Tiêu đề", "Tour riêng tư", null, "", 120, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e43dcb66-f565-0d54-b4a2-2e9e9ca51e2c"), "8:00 - 20:00", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.hours.2.time", "text", "Giờ làm việc · Dòng 2 · Giờ", "Liên hệ", null, "", 87, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e530af59-2adb-572c-01db-752a25650677"), "Mỗi nhóm khách có một nhịp đi riêng. Perlunas thiết kế lịch trình, lưu trú và trải nghiệm theo đúng mong muốn của bạn — linh hoạt từ ngày khởi hành đến từng điểm dừng.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Tour riêng tư", null, "", 113, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e6b4effe-b646-dd52-d78b-f9d85112ece5"), "Tư vấn thật lòng, đúng nhu cầu và ngân sách của bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.1.desc", "textarea", "Giá trị 1 · Mô tả", "Giới thiệu", null, "", 68, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e6c246d3-4184-1e97-29b4-e91e30169780"), "Bền lâu", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.values.4.title", "text", "Giá trị 4 · Tiêu đề", "Giới thiệu", null, "", 73, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ebb97473-7ee5-dc54-7b0f-679caa1226af"), "Chưa biết chọn gói nào?", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.cta.title", "text", "Khối kêu gọi · Tiêu đề", "Combo", null, "", 145, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f148932c-963a-f8c6-f567-d91d46ef4a54"), "Với chúng tôi, mỗi vị khách là một viên ngọc. Và Perlunas xin được là ánh trăng lặng lẽ dõi theo, đồng hành cùng bạn qua thật nhiều hành trình.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.about.p3", "textarea", "Về chúng tôi · Đoạn 3", "Trang chủ", null, "", 35, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f30aee07-fa47-4502-5b3f-cf61553bc32b"), "Tour trọn gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourspage.eyebrow", "text", "Hero · Nhãn", "Tour trọn gói", null, "", 129, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f8151390-4e14-01b5-f0b6-37efde694efd"), "Tour đoàn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.eyebrow", "text", "Hero · Nhãn", "Tour đoàn", null, "", 90, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f8b96b90-3715-7cbe-59f1-37b814736639"), "Ánh trăng là Perlunas, lặng lẽ dõi theo và chăm chút từng chi tiết. Chữ “s” nhỏ ở cuối là lời hứa đồng hành bền lâu.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.luna.body", "textarea", "Luna · Nội dung", "Giới thiệu", null, "", 55, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fb98b799-b08c-4c46-8ee2-09efc10ffef3"), "Một hành trình đẹp bắt đầu từ cảm giác bạn mang theo, không phải điểm đến. Vì thế Perlunas không tạo ra những chuyến đi rập khuôn. Chúng tôi lắng nghe từng người, rồi thiết kế một hành trình vừa vặn, chỉn chu trong từng chi tiết. Với chúng tôi, mỗi vị khách là một viên ngọc.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.philosophy.text", "textarea", "Triết lý · Nội dung", "Trang chủ", null, "", 7, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fc7d00bf-72ab-c14a-dcff-31682f48a56c"), "Chúng tôi tìm hiểu mục tiêu, độ tuổi, ngân sách và nhịp đi riêng của từng đoàn để thiết kế lịch trình phù hợp nhất.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.block1.body", "textarea", "Khối 1 · Nội dung", "Tour đoàn", null, "", 96, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fea672f8-0a88-3582-440e-31e6ee860c63"), "Tư vấn nhanh trong giờ làm việc.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.call.note", "text", "Gọi · Ghi chú", "Liên hệ", null, "", 81, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ffe0741a-f63a-5553-24d5-24a5ff24a874"), "Đối tác đồng hành", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.partners.eyebrow", "text", "Đối tác · Nhãn", "Trang chủ", null, "", 38, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, null, new List<string> { "da-nang" }, new List<string>(), null, null, new List<string> { "Cầu Vàng Bà Nà Hills", "Phố cổ Hội An về đêm", "Thả đèn hoa đăng sông Hoài", "Biển Mỹ Khê" }, null, null, null, "Cầu Vàng, phố Hội lồng đèn và bãi biển Mỹ Khê.", false, true, null, 2, "từ 3.190.000đ", null, "Miền Trung", "da-nang-hoi-an", "Đà Nẵng Hội An", "Tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"), "[]", "Akoya", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Đà Lạt", new List<string>(), new List<string>(), null, "Resort", new List<string>(), null, null, null, null, false, true, null, 2, "4.000.000đ", null, null, "akoya-terracotta-da-lat-2d", "Terracotta Đà Lạt", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"), "[]", "Akoya", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Hà Nội", new List<string>(), new List<string>(), null, "Hotel", new List<string>(), null, null, null, null, false, true, null, 2, "5.000.000đ", null, null, "akoya-sheraton-ha-noi-2d", "Sheraton Hà Nội", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"), "[]", "Tahiti", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Nha Trang", new List<string>(), new List<string>(), null, "Resort", new List<string>(), null, null, null, null, false, true, null, 3, "7.500.000đ", null, null, "tahiti-vinpearl-nha-trang-3d", "Vinpearl Nha Trang", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "BestSeller", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[] { new Guid("1c319bb9-c82d-5a4a-22b3-2f5d6625fbd2"), "[]", true, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Nhà gỗ trên sườn núi, ngắm ruộng bậc thang và biển mây mỗi sớm.", "Sa Pa", new List<string>(), new List<string>(), null, "Retreat", new List<string>(), null, null, null, null, false, true, null, null, "2.200.000đ", null, null, "sapa-cloud", "Sa Pa Cloud Retreat", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("22f4078a-1c46-d445-a3fb-c9ab91136022"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Spa thảo mộc, yoga buổi sớm và thực đơn chữa lành giữa cao nguyên.", "Đà Lạt", new List<string>(), new List<string>(), null, "Wellness", new List<string>(), null, null, null, null, false, true, null, null, "2.800.000đ", null, null, "pinewood-wellness", "Pinewood Wellness", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"), "[]", "Tahiti", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Hà Nội", new List<string>(), new List<string>(), null, "Hotel", new List<string>(), null, null, null, null, false, true, null, 4, "15.000.000đ", null, null, "tahiti-sheraton-ha-noi-4d", "Sheraton Hà Nội", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"), "[]", "South Sea", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Đà Nẵng", new List<string>(), new List<string>(), null, "Retreat", new List<string>(), null, null, null, null, false, true, null, 3, "13.000.000đ", null, null, "south-sea-naman-da-nang-3d", "Naman Retreat Đà Nẵng", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, null, new List<string> { "nha-trang" }, new List<string>(), null, null, new List<string> { "Khám phá đảo Hòn Mun", "Tắm bùn khoáng", "Vịnh Nha Trang", "Ẩm thực biển" }, null, null, null, "Vịnh biển trong xanh và những hòn đảo gần bờ.", false, true, null, 2, "từ 2.990.000đ", null, "Miền Trung", "nha-trang", "Nha Trang biển xanh", "Tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"), "[]", "Akoya", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Sa Pa", new List<string>(), new List<string>(), null, "Hotel", new List<string>(), null, null, null, null, false, true, null, 2, "5.500.000đ", null, null, "akoya-de-la-coupole-sa-pa-2d", "Hôtel de la Coupole Sa Pa", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "BestSeller", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("64b5eb41-96db-8d39-22e5-4a7f2e4e4129"), "[]", true, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Resort mặt biển, hồ bơi nhiều tầng và khu vui chơi cho gia đình.", "Nha Trang", new List<string>(), new List<string>(), null, "Resort", new List<string>(), null, null, null, null, false, true, null, null, "3.200.000đ", null, null, "azure-bay", "Azure Bay Resort", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6a695375-8160-a254-bce4-37be78bdbe63"), "[]", true, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Khu nghỉ dưỡng bên bãi biển riêng phía Nam đảo Ngọc, hồ bơi vô cực hướng hoàng hôn.", "Phú Quốc", new List<string>(), new List<string>(), null, "Resort", new List<string>(), null, null, null, null, false, true, null, null, "3.500.000đ", null, null, "lunar-bay", "Lunar Bay Resort", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, null, new List<string> { "phu-quoc" }, new List<string>(), null, null, new List<string> { "Cáp treo Hòn Thơm dài nhất thế giới", "Lặn ngắm san hô 3 đảo", "Hoàng hôn bãi Sao", "Chợ đêm hải sản" }, null, null, null, "Biển trong vắt, san hô và hoàng hôn rực rỡ phương Nam.", false, true, null, 2, "từ 3.690.000đ", null, "Miền Nam", "phu-quoc", "Phú Quốc đảo ngọc", "Tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6b3cd177-825d-b0a4-22df-db79721fa23e"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Khu nghỉ trị liệu yên tĩnh, tắm khoáng nóng nhìn ra vịnh di sản.", "Hạ Long", new List<string>(), new List<string>(), null, "Wellness", new List<string>(), null, null, null, null, false, true, null, null, "2.600.000đ", null, null, "bay-wellness", "Bay Wellness", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "BestSeller", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("6fc490b0-6501-7066-2716-f195529f23d3"), "[]", true, "Akoya", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Đà Nẵng", new List<string>(), new List<string>(), null, "Resort", new List<string>(), null, null, null, null, false, true, null, 2, "5.000.000đ", null, null, "akoya-intercontinental-da-nang-2d", "Intercontinental Đà Nẵng", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"), "[]", true, "Tahiti", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Hà Nội", new List<string>(), new List<string>(), null, "Hotel", new List<string>(), null, null, null, null, false, true, null, 3, "8.000.000đ", null, null, "tahiti-sheraton-ha-noi-3d", "Sheraton Hà Nội", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[] { new Guid("836e3fca-9da6-4631-f71f-ef0f27a681c1"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Khách sạn trung tâm, vài bước tới chợ đêm và hồ Xuân Hương.", "Đà Lạt", new List<string>(), new List<string>(), null, "Hotel", new List<string>(), null, null, null, null, false, true, null, null, "1.400.000đ", null, null, "stella-dalat", "Stella Hotel", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "BestSeller", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"), "[]", true, "Tahiti", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Phú Quốc", new List<string>(), new List<string>(), null, "Resort", new List<string>(), null, null, null, null, false, true, null, 3, "9.000.000đ", null, null, "tahiti-jw-marriott-phu-quoc-3d", "JW Marriott Phú Quốc", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8e401cad-0a9e-259e-9819-bf4842528f05"), "[]", true, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Phong cách cổ điển giữa phố Pháp, cách Hồ Gươm vài phút đi bộ.", "Hà Nội", new List<string>(), new List<string>(), null, "Hotel", new List<string>(), null, null, null, null, false, true, null, null, "2.400.000đ", null, null, "metropole-lune", "Metropole Lune", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"), "[]", true, "South Sea", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Đà Lạt", new List<string>(), new List<string>(), null, "Retreat", new List<string>(), null, null, null, null, false, true, null, 3, "11.000.000đ", null, null, "south-sea-ana-mandara-da-lat-3d", "Ana Mandara Đà Lạt", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[] { new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, null, null, new List<string> { "ha-noi", "sa-pa" }, new List<string>(), null, null, new List<string> { "Phố cổ Hà Nội và Hồ Gươm", "Ruộng bậc thang Mường Hoa", "Cáp treo Fansipan", "Bản làng người Mông, người Dao" }, null, null, null, "Từ phố cổ ngàn năm tới ruộng bậc thang và đỉnh Fansipan.", false, true, null, 3, "từ 4.290.000đ", null, "Miền Bắc", "ha-noi-sapa", "Hà Nội Sa Pa", "Tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "BestSeller", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a846c103-c841-b1a6-3479-a7299029ca67"), "[]", true, "South Sea", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Phú Quốc", new List<string>(), new List<string>(), null, "Resort", new List<string>(), null, null, null, null, false, true, null, 3, "12.000.000đ", null, null, "south-sea-intercontinental-phu-quoc-3d", "InterContinental Phú Quốc", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("abca9795-459e-619e-fac5-12763e8182cf"), "[]", true, "Akoya", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Nha Trang", new List<string>(), new List<string>(), null, "Resort", new List<string>(), null, null, null, null, false, true, null, 2, "4.500.000đ", null, null, "akoya-vinpearl-nha-trang-2d", "Vinpearl Nha Trang", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[] { new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, null, new List<string> { "da-lat" }, new List<string>(), null, null, new List<string> { "Săn mây Cầu Đất lúc bình minh", "Vườn hồng và đồi chè Cầu Đất", "Cà phê giữa rừng thông", "Chợ đêm và ẩm thực phố núi" }, null, null, null, "Ba ngày giữa rừng thông và sương sớm trên cao nguyên.", false, true, null, 2, "từ 2.890.000đ", null, "Tây Nguyên", "da-lat", "Đà Lạt mộng mơ", "Tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "BestSeller", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[] { new Guid("be9279af-57b7-1a64-3d9c-e69e8885cc0a"), "[]", true, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Ngay mặt vịnh, thuận tiện cho hành trình du thuyền khám phá đảo đá.", "Hạ Long", new List<string>(), new List<string>(), null, "Hotel", new List<string>(), null, null, null, null, false, true, null, null, "1.900.000đ", null, null, "halong-pearl", "Hạ Long Pearl Hotel", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[] { new Guid("c798db8d-3381-10a2-4623-3a599a44ad4a"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Bungalow ven biển, bến tàu riêng và nhà hàng hải sản trên mặt nước.", "Phú Quốc", new List<string>(), new List<string>(), null, "Resort", new List<string>(), null, null, null, null, false, true, null, null, "4.200.000đ", null, null, "pearl-cove", "Pearl Cove Resort", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "BestSeller", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"), "[]", true, "Tahiti", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Hạ Long", new List<string>(), new List<string>(), null, "Hotel", new List<string>(), null, null, null, null, false, true, null, 3, "8.500.000đ", null, null, "tahiti-sheraton-ha-long-3d", "Sheraton Hạ Long", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d07f4322-2edb-544f-7286-265c1c258ce0"), "[]", true, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Ẩn mình giữa rừng thông, mỗi sáng thức dậy trong sương và tiếng chim.", "Đà Lạt", new List<string>(), new List<string>(), null, "Retreat", new List<string>(), null, null, null, null, false, true, null, null, "2.500.000đ", null, null, "serenity-retreat", "Serenity Retreat", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d43e2322-4d95-0305-d0aa-1303db0dade7"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Không gian nhỏ xinh giữa vườn, xe đạp dạo phố và lớp nấu ăn địa phương.", "Hội An", new List<string>(), new List<string>(), null, "Boutique Hotel", new List<string>(), null, null, null, null, false, true, null, null, "1.600.000đ", null, null, "an-yen-boutique", "An Yên Boutique", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("de0528da-01be-297f-3d6f-59795657002f"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Khách sạn nhỏ trong phố cổ, ban công nhìn xuống nhịp sống ngàn năm.", "Hà Nội", new List<string>(), new List<string>(), null, "Boutique Hotel", new List<string>(), null, null, null, null, false, true, null, null, "1.700.000đ", null, null, "old-quarter-boutique", "Old Quarter Boutique", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e50a45c4-40d6-316f-0e40-2e58860b0f8e"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Sát biển Mỹ Khê, gần cầu Rồng và phố ẩm thực sôi động.", "Đà Nẵng", new List<string>(), new List<string>(), null, "Hotel", new List<string>(), null, null, null, null, false, true, null, null, "1.900.000đ", null, null, "danang-grand", "Đà Nẵng Grand Hotel", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f8598638-8a39-2092-c30f-1f4e69dc2511"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Phòng hướng vịnh, hồ bơi tầng thượng nhìn toàn cảnh thành phố biển.", "Nha Trang", new List<string>(), new List<string>(), null, "Hotel", new List<string>(), null, null, null, null, false, true, null, null, "1.800.000đ", null, null, "ocean-pearl", "Ocean Pearl Hotel", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "BestSeller", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[] { new Guid("fce66f24-a18b-3b62-8473-12df889d6e6f"), "[]", true, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Khách sạn boutique trong phố cổ, kiến trúc Đông Dương bên dòng Hoài giang.", "Hội An", new List<string>(), new List<string>(), null, "Boutique Hotel", new List<string>(), null, null, null, null, false, true, null, null, "2.000.000đ", null, null, "maison-de-lune", "Maison de Lune", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PriceText", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[] { new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"), "[]", "South Sea", null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Phú Quốc", new List<string>(), new List<string>(), null, "Resort", new List<string>(), null, null, null, null, false, true, null, 4, "16.000.000đ", null, null, "south-sea-jw-marriott-phu-quoc-4d", "JW Marriott Phú Quốc", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("01b1cff1-b779-6962-501d-d1fad40823d1"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("3ba1c9ca-b087-f6ad-53f7-6661263927dd"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("41d9c601-dad8-03a5-ef3d-005d5d83212d"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("75590804-8743-67aa-5ef8-0a59b7a1cdf3"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("8e471a7e-6ce1-0fca-3a68-c77dc221ff30"));

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: new Guid("930bcada-e714-1e4e-a23f-9922481c6a46"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("003b5c21-369d-5c7e-9e4d-82150133793c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("004891b9-5e27-7e02-3d8c-56718498a6b9"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00c941fb-0469-baf8-0d0d-2f408515124a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("0418e9d6-1ef4-0722-fba5-c77ed788f4bc"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("049a80b8-4298-b3e2-8619-9ab9700aa750"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("05ee4325-808c-ec82-b641-922cef25b440"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("06285583-2abb-07de-201f-1fb04bb374c2"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("0677f038-e60d-dd37-49f9-bb7941c30a21"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("082d2f49-180b-d4bd-b50b-fe1761de61ec"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("0cabe749-3c42-5ddc-36ee-d208f4ab7155"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("0f188bb1-c93f-6135-0d56-5b77bad21a16"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("0f596fe7-a517-d27d-b56c-e62aea7fc7b5"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("1273c77d-d451-aa12-d98f-b33da86818b3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("135e3ed1-aa61-30e8-7dbf-7e00a49451ba"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("1383ed9a-23d1-6368-3bbe-9719adf0d334"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("16cdbc76-4f7e-dff3-754f-306145571a73"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("1793d50d-5841-876e-cdb3-9e502116d530"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("17b5469c-d517-301e-ccf6-af13244e4caa"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("226b7aee-55ed-bc34-3026-3a652dd4e5db"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("242cbc33-48cb-5c10-e968-7bd13316d3b8"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("244486da-a6de-8c01-70c9-8fade9c759da"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("2469a941-9c71-c39e-f348-24f92eb5f79c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("27da4c8b-726e-9ee5-853e-63be273b3a57"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("2d958ba6-4117-6267-662c-397de71b176f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("2fafc1c9-349d-6120-a875-91ad637b551d"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("300b774c-6d04-a446-ce43-3c1dc3d5b7ff"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("30183877-e54a-42cb-1e2a-3828b8e3780a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("32b9133d-222b-d05b-43d1-8ecf11f0c1ff"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("3436c553-9587-fc3e-f6eb-1ec108a94b4c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("351ac8a9-10d5-0eda-e4df-2f334d4639d0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("38ededb1-f8c8-69c7-9e6d-86d537cfd757"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("3a177178-c1ea-a6a1-a2a7-34f5bc6a9ced"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("3b3d1240-11af-8e21-e70b-68dbac1d98b3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("3bc2c192-1ca6-6e15-a5ba-cd2d2677c0a3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("3d01f488-bad6-e812-2a54-f8fd5e2f766f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4005b808-ab4d-4b53-fe0e-f6c4c0390379"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("400e9a9c-ffc0-2f7d-b6f5-9ac7ca03c41a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4251a5e7-5d2f-6b8b-0e84-e5b0f10dbd60"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("46ad2fc8-9e76-a7ae-cc8b-7a3d0ef36f15"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("46fa7f24-fa89-4265-bbae-57ee2c238efc"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("482b322d-aa3f-a63d-1c68-65a6f5934d5e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4833c9bf-99f2-69ab-3817-65e89697a740"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4dab6cbf-c083-e211-93ac-78c862674366"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4f1d25cc-eb03-773a-cd4d-435f00f01cf4"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5054e184-2ccf-25bb-497f-179cf6a16af5"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5543e00c-b994-c9b9-eee4-fb2a50f173e2"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("57fc6cc8-a6f9-854b-ee3b-59a3f4dadc70"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("591484a3-a441-a52f-0ce9-5f5d5a765955"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("59f02fdf-99ff-81dc-e7aa-9c34a28cf071"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5b7ed0bb-2bb6-7012-6367-48eb44ef5b69"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5cef9e35-18de-af99-324f-8e5afa14b6a2"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5ebb5adc-dee0-8aa6-22ff-9a941cf8db73"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5f6f3bc0-b6d6-a3c8-f963-0c8564872403"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5f708f4b-6ee3-a579-f4b4-377a54e4a94d"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5f7e5641-8db3-b4c6-8d67-ebc98da5d8d1"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("60e2cc23-056f-a53c-6f47-e9151d575dcc"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("63838004-1afc-9534-fb90-1d66471eff84"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("66f054c3-9033-e008-fab7-0b2ae2fd008a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("671d9441-9c76-e2fc-a613-deee8a143e48"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("693fbe8f-2ac2-7ed7-1931-ffd2fc6a355a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("698a1d81-444e-9197-e6fa-01b1a42d37da"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6c2a09a2-4ef6-6695-74b0-3cc4f390e77a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6d6ac4ad-1e75-fb21-9e7b-836b3b0b461d"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6f589531-b724-1804-2d87-cf464e82b811"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6fff5ba7-597d-1930-9d75-7c24e6a6cadb"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("724f78b7-667d-8e60-e8be-803b987749c2"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("72988e40-1ebc-a3d9-ec1a-33549ac92533"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("72b12ce2-71b3-bcbe-7d71-365bb439d34b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("733221dd-6b41-2b0a-ee06-3ca324046634"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("738b02de-722b-f905-3f0e-b1f672591abc"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("74fe23a2-d06a-a78f-7acb-4c4c596f8830"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("751a6dfd-32ee-cd9b-6339-f1fb1c24d88c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("75585640-7d76-015c-a148-7e037db0ee35"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("78a133eb-293d-d509-5d8e-d1b6acf3751c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7a75458f-d907-c973-0daa-fc8949524e2f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7c2268fb-75f3-ac1e-b6ac-001b77f5e7c9"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7e76414a-1b0e-c4ee-4e06-bd8cd659f1d0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("801ba8c0-7c08-6334-c854-51ad0c7d155f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("80f15804-38e2-412a-9c41-58d46ce1e5b2"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8244270e-7b15-4f7b-0562-51acf56147c7"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("82dde8a8-0e24-de9d-f952-351cc21a202d"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("835f961e-2f3b-5a7a-2d64-1e4924b49375"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8622f81e-4d58-8f36-97d3-2f7213b7cd77"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8668febd-5072-6ce9-da99-ff5980f796cd"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8816a7d8-4243-1daa-fa36-57eaa21e8ff7"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("899f8b33-d8c8-5727-1727-3659a85f4406"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8cb7c3f3-58c2-99e3-d248-41b63567e2ae"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8d1566e4-1834-655a-191b-dc319a1d8359"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8e976c12-5e1b-0b8c-5669-683c40adeb52"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8edde97d-3d2a-e977-6e9a-aeb072d0b630"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8f093ef2-98dc-5662-8984-8738e36ae76d"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9031b24b-c5b9-957b-5044-78e6b2b89dac"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("93050730-7d2c-b028-c37a-02ec1736ca08"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("930919d0-0aad-b77c-858e-f25ff02b15e2"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("935619cf-2d18-74fa-0f3c-3ab01442009c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("93f88116-cc7c-94eb-0c48-aa5fb94bc905"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("95f3e091-9fc5-f359-b41d-27e6fb070e22"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("97b49d74-2e68-6b1d-7446-69482bd63577"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("991e2f42-0f0a-e069-f763-98bc3a1eca4b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9a456cc3-7974-7c70-e82a-123bf7b84c91"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9ad20313-1717-ea1b-26aa-d1e64e9da201"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9ae6ab6d-d737-7cf9-76e5-3941571d45e0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9aeefac8-c403-ea50-2f4b-3b3124a1cf31"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9f49e927-f3e0-5c22-a24d-67fc6f3d3a92"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a0fa752c-17f5-ef2f-657b-650d56fc8f81"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a32d80d8-59dc-3386-5852-4013f0c6b971"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a7cca81f-3def-1c1d-c7c8-aef97e2f94fe"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a8cc27dd-d7d8-7d37-47b8-12bcc260a771"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ac060c01-719a-9fa9-177c-1379f89bd59f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ae8e194a-f7e1-e990-7f6c-68d134dd1760"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("af461a72-2506-8c7f-0737-f566e40d20e3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b29c4871-02cb-8ee1-a3d2-b79c42eda2a4"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b36164ca-e708-5d34-d17a-0de2d3fa3d5f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b3c4d404-265e-e578-5c49-28427536cbbe"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b3c5e14e-fae8-896c-d55a-a9c9b790f1c0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b6264cd6-0e10-73ac-bf85-64be24043b7e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b6423768-c307-76b5-17af-9f5a021ea74c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b6afb61b-c099-45b7-6da2-f1644e0a3353"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b78062b1-d157-32fa-5698-b81b80a8b6ff"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("bcabd284-2e10-0be3-f66e-a3e2d959921c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("be0d1ed5-d717-07c3-8e92-6473071b6796"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("bf336563-7349-441c-a02b-6f311a85a575"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c029fc13-55cc-7382-09c4-a46d322d7136"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c3ddf3fc-1e35-c09d-e840-38f12ddaf18d"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c9177084-d2b5-ffb3-fac7-07e063bdc956"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c939ff9d-4b08-d5ef-02ce-4bf13996da13"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("cbca273e-3b58-e679-39f5-e8afddcc96cb"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("cc1a2cb0-92ab-be0b-251c-9d08af75e307"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("cc4de10a-8dd6-65b2-50f9-6f923325f145"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ccafaff8-20a4-2da6-ea22-9a6ecdfd94eb"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ce651df3-68a6-7d1e-8592-87bc09335a3e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("cec1e950-6ebe-c782-9b63-b1d68fe458e8"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("cf06c8e5-9cbf-b692-adf0-6c52da817325"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d1089649-ec2d-0a3e-2c3f-07430ef329be"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d1f4fae1-465b-fb34-a74b-53af11b356cf"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d2f69603-3a54-bddb-3267-b0cc20db78ff"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d473a044-58ba-09d3-0231-0b3973de21e0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d82175a4-f6e6-760c-8e1e-324bd03ad7ff"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d873c942-8bf3-439d-1367-ac18299cbf9f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("da4b0cde-fc39-4562-c363-bd505291069b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("db6010ce-bbbe-7ee6-6bd7-26d4d05e2c5f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("db67b3fb-553f-fdaf-9467-876c02c6d368"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e09b5b38-f757-b493-f9bc-1f753c7e38e1"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e2c1f0fd-1964-fe4e-a4dc-7ecd36a7202b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e31b31dd-0f5b-20cd-6e61-c34ba4938cb0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e43dcb66-f565-0d54-b4a2-2e9e9ca51e2c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e530af59-2adb-572c-01db-752a25650677"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e6b4effe-b646-dd52-d78b-f9d85112ece5"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e6c246d3-4184-1e97-29b4-e91e30169780"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ebb97473-7ee5-dc54-7b0f-679caa1226af"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("f148932c-963a-f8c6-f567-d91d46ef4a54"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("f30aee07-fa47-4502-5b3f-cf61553bc32b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("f8151390-4e14-01b5-f0b6-37efde694efd"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("f8b96b90-3715-7cbe-59f1-37b814736639"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("fb98b799-b08c-4c46-8ee2-09efc10ffef3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("fc7d00bf-72ab-c14a-dcff-31682f48a56c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("fea672f8-0a88-3582-440e-31e6ee860c63"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ffe0741a-f63a-5553-24d5-24a5ff24a874"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("1c319bb9-c82d-5a4a-22b3-2f5d6625fbd2"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("22f4078a-1c46-d445-a3fb-c9ab91136022"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("64b5eb41-96db-8d39-22e5-4a7f2e4e4129"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6a695375-8160-a254-bce4-37be78bdbe63"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6b3cd177-825d-b0a4-22df-db79721fa23e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6fc490b0-6501-7066-2716-f195529f23d3"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("836e3fca-9da6-4631-f71f-ef0f27a681c1"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8e401cad-0a9e-259e-9819-bf4842528f05"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a846c103-c841-b1a6-3479-a7299029ca67"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("abca9795-459e-619e-fac5-12763e8182cf"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("be9279af-57b7-1a64-3d9c-e69e8885cc0a"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c798db8d-3381-10a2-4623-3a599a44ad4a"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d07f4322-2edb-544f-7286-265c1c258ce0"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d43e2322-4d95-0305-d0aa-1303db0dade7"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("de0528da-01be-297f-3d6f-59795657002f"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e50a45c4-40d6-316f-0e40-2e58860b0f8e"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f8598638-8a39-2092-c30f-1f4e69dc2511"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("fce66f24-a18b-3b62-8473-12df889d6e6f"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"));

            migrationBuilder.DropColumn(
                name: "PriceText",
                table: "Services");

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
                columns: new[] { "Id", "Album", "BestSeller", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[] { new Guid("11111111-1111-1111-1111-111111111111"), "[]", true, null, "PLN-001", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, "Sample service description.", null, new List<string> { "Da Nang Beach" }, new List<string>(), "Sample features.", null, new List<string> { "Sample service highlights." }, "<h3>Điểm nhấn hành trình</h3><ul><li>Ngắm hoàng hôn trên biển Đà Nẵng</li><li>Dạo phố cổ Hội An lung linh đèn lồng</li><li>Thưởng thức tinh hoa ẩm thực miền Trung</li></ul><h3>Du lịch Bền vững (ESG)</h3><p>Tôn vinh cảnh quan thiên nhiên, kết nối cộng đồng địa phương qua các làng nghề và không gian bản địa.</p><h3>Trải nghiệm Bản địa (LEI)</h3><p>Khám phá văn hóa – lịch sử tiêu biểu và những trải nghiệm chỉ có tại điểm đến.</p>", "Sample service information.", "Sample instructions.", "Sample introduction for the main service.", false, true, "Featured", 2, null, "Vietnam", "perlunas-signature-tour", "Perlunas Signature Tour", "Tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111112"), "[]", null, "PLN-002", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Beachfront resort package.", "Da Nang Beach", new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, null, "Full-board", new List<string> { "Private beach", "spa", "local dining" }, null, "Includes room and breakfast.", null, null, false, true, null, 3, "Nghỉ dưỡng", "Da Nang", "beach-resort-package", "Beach Resort Package", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("11111111-1111-1111-1111-111111111113"), "[]", "Akoya", "PLN-003", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "Private travel experience.", "Hoi An Ancient Town", new List<string>(), new List<string>(), "Private guide, custom route", "Half-board", new List<string> { "Flexible route", "private guide" }, null, "Dedicated guide and vehicle.", "Confirm itinerary before departure.", "Custom private trip with flexible schedule.", false, true, "Private", 1, "Tham quan", "Hoi An", "private-custom-journey", "Private Custom Journey", "Combo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("11111111-1111-1111-1111-222222222211"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Sapa Valley", new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, "Mountain view, organic restaurant", "Bed and breakfast", new List<string>(), null, null, "Eco guidelines apply.", "Scenic lodge in the heart of nature.", false, true, null, null, "Nghỉ dưỡng", "Vietnam", "vietnam-eco-lodge", "Vietnam Eco Lodge", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "BestSeller", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[] { new Guid("11111111-1111-1111-1111-222222222212"), "[]", true, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Hanoi Old Quarter", new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, "City view, spa, fitness center", "Room only", new List<string>(), null, null, "Check-in after 14:00.", "Luxury hotel in the historical quarter.", false, true, null, null, "Tham quan", "Vietnam", "hanoi-royal-palace-hotel", "Hanoi Royal Palace Hotel", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Album", "Classify", "Code", "CreatedAt", "Day", "Description", "Destination", "Destinations", "Facilities", "Feature", "Form", "Highlight", "HighlightContent", "Infor", "Instruct", "Introducetion", "IsDeleted", "IsPublic", "Label", "Night", "PurposeOfTrip", "Region", "Slug", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-222222222213"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Ho Chi Minh City", new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, "Rooftop bar, pool", "Room only", new List<string>(), null, null, "Strictly non-smoking.", "Elegant boutique hotel reflecting local heritage.", false, true, null, null, "Tham quan", "Vietnam", "saigon-heritage-hotel", "Saigon Heritage Hotel", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("11111111-1111-1111-1111-222222222214"), "[]", null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, "Phu Quoc Island", new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, "Private beach, infinity pool", "Full-board", new List<string>(), null, null, "No pets allowed.", "Seaside resort with stunning sunset views.", false, true, null, null, "Nghỉ dưỡng", "Vietnam", "phu-quoc-sunset-resort", "Phu Quoc Sunset Resort", "Hotel", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("11111111-1111-1111-1111-333333333311"), "[]", null, "TOUR-VN1", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, "Explore rich heritage.", null, new List<string>(), new List<string>(), null, null, new List<string> { "Historic sites." }, null, "All inclusive tour.", null, "Sample tour in Vietnam.", false, true, null, 4, null, "Vietnam", "vietnam-heritage-discovery-tour", "Vietnam Heritage Discovery Tour", "Tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("11111111-1111-1111-1111-333333333312"), "[]", null, "TOUR-VN2", new DateTime(2026, 1, 1, 1, 0, 0, 0, DateTimeKind.Utc), 6, "Explore natural highlights.", null, new List<string>(), new List<string>(), null, null, new List<string> { "Spectacular bays." }, null, "All inclusive tour.", null, "Sample tour in northern Vietnam.", false, true, null, 5, null, "Vietnam", "vietnam-northern-highlights", "Vietnam Northern Highlights", "Tour", new DateTime(2026, 1, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("11111111-1111-1111-1111-333333333313"), "[]", null, "TOUR-TH1", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Explore Thai islands.", null, new List<string>(), new List<string>(), null, null, new List<string> { "Bangkok and Phuket." }, null, "Flight not included.", null, "Sample tour in Thailand.", false, true, null, 3, null, "Thailand", "thailand-paradise-getaway", "Thailand Paradise Getaway", "Tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "DepartureSchedules",
                columns: new[] { "Id", "AccommodationStandards", "Code", "CreatedAt", "IsDeleted", "Price", "ServiceId", "StartTime", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-333333333311"), "3-star hotel", "DEP-VN1", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "4000000/customer", new Guid("11111111-1111-1111-1111-333333333311"), "Weekly", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("44444444-4444-4444-4444-333333333312"), "3-star hotel", "DEP-VN2", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "4500000/customer", new Guid("11111111-1111-1111-1111-333333333312"), "Weekly", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("44444444-4444-4444-4444-333333333313"), "3-star hotel", "DEP-TH1", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "3800000/customer", new Guid("11111111-1111-1111-1111-333333333313"), "Weekly", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("44444444-4444-4444-4444-444444444441"), "3-star hotel", "DEP-001", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "3500000/customer", new Guid("11111111-1111-1111-1111-111111111111"), "2026-07-15", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("44444444-4444-4444-4444-444444444442"), "4-star resort", "DEP-002", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "5200000/customer", new Guid("11111111-1111-1111-1111-111111111111"), "2026-09-20", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("44444444-4444-4444-4444-444444444443"), "Boutique hotel", "DEP-003", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "Quote on request", new Guid("11111111-1111-1111-1111-111111111111"), "On request", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "ImportantInfors",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "ServiceId", "SubTitle", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("55555555-5555-5555-5555-555555555551"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Xe du lịch đời mới máy lạnh đưa đón theo chương trình.\nKhách sạn theo tiêu chuẩn, 2 - 3 khách/phòng.\nCác bữa ăn theo chương trình.\nVé tham quan các điểm có trong chương trình.\nHướng dẫn viên kinh nghiệm phục vụ suốt tuyến.\nBảo hiểm du lịch và nước suối trên xe.", false, new Guid("11111111-1111-1111-1111-111111111111"), "", "Giá tour bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55555555-5555-5555-5555-555555555552"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Quý khách xuất trình giấy tờ tuỳ thân hợp lệ khi nhận phòng.", false, new Guid("11111111-1111-1111-1111-111111111113"), "Giấy tờ cần thiết", "Nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55555555-5555-5555-5555-555555555553"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lịch trình cuối cùng được xác nhận trước ngày khởi hành 48 giờ.", false, new Guid("11111111-1111-1111-1111-111111111113"), "Thiết kế theo yêu cầu", "Lịch trình riêng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55555555-5555-5555-5555-5555555555a1"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Chi phí cá nhân, giặt ủi, điện thoại, đồ uống ngoài chương trình.\nTiền tip cho hướng dẫn viên và tài xế.\nPhụ thu phòng đơn.\nThuế VAT và hóa đơn đỏ (nếu khách yêu cầu).", false, new Guid("11111111-1111-1111-1111-111111111111"), "", "Giá tour chưa bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55555555-5555-5555-5555-5555555555a2"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, ngủ chung với bố mẹ; 2 người lớn kèm tối đa 1 trẻ.\nTrẻ 5 - dưới 10 tuổi: tính 50% giá tour.\nTrẻ từ 10 tuổi trở lên: tính như người lớn.", false, new Guid("11111111-1111-1111-1111-111111111111"), "", "Giá trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55555555-5555-5555-5555-5555555555a3"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá tour ngay khi đăng ký để giữ chỗ.\nThanh toán phần còn lại trước ngày khởi hành tối thiểu 7 ngày.\nCung cấp đầy đủ thông tin: họ tên, năm sinh, số CMND/CCCD/hộ chiếu.", false, new Guid("11111111-1111-1111-1111-111111111111"), "", "Điều kiện đăng ký và thanh toán", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55555555-5555-5555-5555-5555555555a4"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Huỷ trước khởi hành từ 15 ngày: phí 30% giá tour.\nHuỷ trước 7 - 14 ngày: phí 50% giá tour.\nHuỷ trong vòng 6 ngày hoặc không khởi hành (no-show): phí 100% giá tour.", false, new Guid("11111111-1111-1111-1111-111111111111"), "Ngày thường", "Điều kiện đổi và huỷ tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55555555-5555-5555-5555-5555555555a5"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Thiên tai, dịch bệnh, thời tiết xấu, chuyến bay delay/huỷ… hai bên cùng thương lượng giải quyết hợp lý, đảm bảo quyền lợi tối đa cho khách.\nPerlunas có quyền thay đổi lộ trình vì lý do an toàn nhưng vẫn đảm bảo tiêu chuẩn dịch vụ.", false, new Guid("11111111-1111-1111-1111-111111111111"), "", "Trường hợp bất khả kháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
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
                    { new Guid("33333333-3333-3333-3333-111111111120"), "120m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The ultimate luxury stay with top amenities.", "[\"Butler service\",\"Kitchen\"]", false, "2 King", 4, "6500000", "5000000", new Guid("11111111-1111-1111-1111-111111111111"), "Presidential Tour Suite", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-222222222211"), "30m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Eco-friendly wood cabin room.", "[\"Mountain view\",\"organic tea\"]", false, "1 Queen", 2, "1100000", "950000", new Guid("11111111-1111-1111-1111-222222222211"), "Eco Lodge Room", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-222222222212"), "45m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Luxurious royal room with classic decor.", "[\"City view\",\"jacuzzi\"]", false, "1 King", 2, "2600000", "2100000", new Guid("11111111-1111-1111-1111-222222222212"), "Royal Suite", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-222222222213"), "35m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Charming room with historical accents.", "[\"Garden view\",\"espresso machine\"]", false, "1 Double", 2, "1700000", "1400000", new Guid("11111111-1111-1111-1111-222222222213"), "Heritage Room", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-222222222214"), "40m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Direct beach view from your room balcony.", "[\"Beachfront\",\"Sunset view\"]", false, "1 King", 2, "3300000", "2800000", new Guid("11111111-1111-1111-1111-222222222214"), "Sunset Beach Room", "night", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-333333333331"), "35m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sample deluxe room.", "[\"Balcony\",\"breakfast\",\"sea view\"]", false, "1", 2, "1500000", "1200000", new Guid("11111111-1111-1111-1111-111111111112"), "Deluxe Room", "đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-333333333332"), "80m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Private family villa near the beach.", "[\"Private pool\",\"kitchen\",\"breakfast\"]", false, "2", 4, "4000000", "3500000", new Guid("11111111-1111-1111-1111-111111111112"), "Family Villa", "đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "45m2", "[]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Suite for private journey guests.", "[\"Old town view\",\"breakfast\"]", false, "1", 2, "2200000", null, new Guid("11111111-1111-1111-1111-111111111113"), "Heritage Suite", "đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "CreatedAt", "Day", "Description", "IsDeleted", "ServiceId", "Sumary", "Titile", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("22222222-2222-2222-2222-222222222221"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Day 1", "Airport pickup and welcome dinner.", false, new Guid("11111111-1111-1111-1111-111111111111"), "Arrive and settle in.", "Arrival", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Day 2", "Guided tour and local activities.", false, new Guid("11111111-1111-1111-1111-111111111111"), "Explore the destination.", "Experience", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("22222222-2222-2222-2222-222222222223"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Day 1", "Welcome drink, room check-in, free beach time.", false, new Guid("11111111-1111-1111-1111-111111111112"), "Check in and relax.", "Resort check-in", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("22222222-2222-2222-2222-222222222224"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Day 1", "Custom stops based on customer preference.", false, new Guid("11111111-1111-1111-1111-111111111113"), "Private tour with local guide.", "Private discovery", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }
    }
}
