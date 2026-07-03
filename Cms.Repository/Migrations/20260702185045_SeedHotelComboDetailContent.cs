using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedHotelComboDetailContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("121e8cf8-eaf3-ce42-e692-1a1391bbb31f"), "Nơi đến", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.ticket.dest", "text", "Vé: nhãn nơi đến", "Chi tiết khách sạn", null, "", 199, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("122c6749-8809-3ea6-c072-a2b4d2fc2694"), "Gói khác", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.related.eyebrow", "text", "Gói khác: nhãn", "Chi tiết combo", null, "", 227, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1c96a7e8-6c33-0310-e8a0-951546c09764"), "Tất cả gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.back", "text", "Link quay lại", "Chi tiết combo", null, "", 206, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("205e1200-00f9-d8d0-a097-f3484afcfaca"), "Điểm nổi bật", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.highlights.title", "text", "Tiêu đề điểm nổi bật", "Chi tiết combo", null, "", 218, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3450e472-94e0-7f5c-e866-29883813a013"), "Không gian nghỉ dưỡng hài hoà giữa tiện nghi hiện đại và dịch vụ tận tâm: phòng nghỉ thoáng đãng, khu vực chung được thiết kế tinh tế, cùng đội ngũ luôn sẵn sàng hỗ trợ trong suốt thời gian lưu trú.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.intro.p2", "textarea", "Giới thiệu: đoạn 2", "Chi tiết khách sạn", null, "", 186, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4213b66c-ad34-b368-bd63-d8d97ef891ce"), "Ưu đãi gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.tripinfo.deal.title", "text", "Thẻ Ưu đãi: tiêu đề", "Chi tiết combo", null, "", 210, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4ec6d686-c3f7-08da-9dcf-a882feb0b211"), "Lịch trình gợi ý", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.itinerary.title", "text", "Tiêu đề lịch trình", "Chi tiết combo", null, "", 219, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("56d826f7-10f5-6ccc-7cb0-08f5a66851f9"), "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.ticket.priceunit", "text", "Vé: đơn vị giá", "Chi tiết khách sạn", null, "", 200, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("57148b9e-a109-f066-9f73-a8fbb0a1d623"), "Phòng nghỉ trong gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.room.title", "text", "Tiêu đề phòng nghỉ", "Chi tiết combo", null, "", 222, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5e276887-1ab9-f236-2730-e9211a916ab4"), "Ăn uống", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.tripinfo.food.title", "text", "Thẻ Ăn uống: tiêu đề", "Chi tiết combo", null, "", 212, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("65eaba8d-6e98-84f6-cafe-08871746e462"), "Tìm hiểu ba dòng ngọc trai", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.includes.morelink", "text", "Link tìm hiểu dòng ngọc", "Chi tiết combo", null, "", 217, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("66a946dc-e4c1-e2e6-17bb-a8ea0ba0e68e"), "Thông tin chính về gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.tripinfo.title", "text", "Tiêu đề thông tin chính", "Chi tiết combo", null, "", 207, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7193d275-e499-4f68-056c-7290ba701cd8"), "Gói đã gồm những dịch vụ quan trọng nhất — xem chi tiết ở mục “Gói gồm có”.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.tripinfo.deal.body", "textarea", "Thẻ Ưu đãi: nội dung", "Chi tiết combo", null, "", 211, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("76c11c42-2a53-06d7-3e7f-611a0f2e49fc"), "Lưu trú tại khách sạn theo chuẩn của gói, nghỉ dưỡng trọn vẹn suốt kỳ nghỉ.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.tripinfo.stay.body", "textarea", "Thẻ Lưu trú: nội dung", "Chi tiết combo", null, "", 209, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7962d148-34b6-d71d-42ca-e8678d372127"), "Toạ lạc tại vị trí đắc địa, khách sạn là điểm dừng chân lý tưởng cho hành trình của bạn — nơi từng chi tiết được chăm chút để kỳ nghỉ trở nên trọn vẹn và đáng nhớ.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.intro.p1", "textarea", "Giới thiệu: đoạn 1", "Chi tiết khách sạn", null, "", 185, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7a01a281-6e2f-a271-0dbc-63a216e1e140"), "Xem loại phòng & tiện nghi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.guide.s1.title", "text", "Bước 1: tiêu đề", "Chi tiết khách sạn", null, "", 192, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7a60330f-c314-eb00-f1fa-2b0e7666849f"), "Gói khác tại", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.related.title", "text", "Gói khác: tiêu đề (tiền tố)", "Chi tiết combo", null, "", 228, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7bccc5a6-5606-949b-cfc6-dcff376fad92"), "Liên hệ hoặc điền form", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.guide.s3.title", "text", "Bước 3: tiêu đề", "Chi tiết khách sạn", null, "", 196, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7c57a17f-f7b4-1da1-9104-190e65eff62a"), "Giới thiệu", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.intro.title", "text", "Tiêu đề giới thiệu", "Chi tiết khách sạn", null, "", 184, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7d838bcd-7666-729e-d0ed-9aba9e48ca0a"), "Xem quy định độ tuổi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.guide.s2.title", "text", "Bước 2: tiêu đề", "Chi tiết khách sạn", null, "", 194, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("849199d5-9ccc-0d45-8b31-7cece2e3891a"), "Xem các gói khác", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.otherlink", "text", "Vé: link gói khác", "Chi tiết combo", null, "", 226, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8bfeec00-a7d6-c0be-9316-d0f0f22332bf"), "Di chuyển", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.tripinfo.transport.title", "text", "Thẻ Di chuyển: tiêu đề", "Chi tiết combo", null, "", 214, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("91dc5f3e-7664-d0dc-112d-d102436f6834"), "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.rooms.priceunit", "text", "Hạng phòng: đơn vị giá", "Chi tiết khách sạn", null, "", 190, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("937cd244-22b6-fcc8-aca9-9ca4b0b88644"), "Ăn sáng mỗi ngày và các bữa theo tiêu chuẩn gói, thực đơn đa dạng cùng đặc sản địa phương.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.tripinfo.food.body", "textarea", "Thẻ Ăn uống: nội dung", "Chi tiết combo", null, "", 213, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("96351521-239b-ed1f-a545-eda99dfe6d6c"), "Thông tin quan trọng về gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.info.title", "text", "Tiêu đề thông tin quan trọng", "Chi tiết combo", null, "", 221, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9bfc9705-3194-d970-e989-8e896460a93e"), "Phân loại", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.ticket.tier", "text", "Vé: nhãn phân loại", "Chi tiết combo", null, "", 224, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9f2202ce-1ab5-0e19-8410-7e0a9a7d15c3"), "Lưu trú", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.tripinfo.stay.title", "text", "Thẻ Lưu trú: tiêu đề", "Chi tiết combo", null, "", 208, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a13325c8-ad7a-b04a-542b-5ae68fdf9084"), "Gói gồm có", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.includes.title", "text", "Tiêu đề gói gồm có", "Chi tiết combo", null, "", 216, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a2736d17-066c-c13e-e287-516d311f2bd7"), "Bấm vào ảnh để xem thêm hình của từng hạng phòng. Có thể đặt nhiều hạng trong cùng một yêu cầu ở nút “Đặt phòng”.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.rooms.note", "textarea", "Hạng phòng: ghi chú", "Chi tiết khách sạn", null, "", 189, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a3b3d2bd-4024-b579-75eb-5c7225ed4cf3"), "Thời lượng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.ticket.duration", "text", "Vé: nhãn thời lượng", "Chi tiết combo", null, "", 225, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a5022235-8826-5dbf-99d9-531a0546a49f"), "Các hạng phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.rooms.title", "text", "Tiêu đề hạng phòng", "Chi tiết khách sạn", null, "", 188, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a5a7b1b0-e109-4fae-b4df-9d624725f98c"), "Đưa đón và di chuyển theo chương trình của gói, thuận tiện trong suốt kỳ nghỉ.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.tripinfo.transport.body", "textarea", "Thẻ Di chuyển: nội dung", "Chi tiết combo", null, "", 215, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ac02943a-2703-489a-fcb1-4ef83dae0c04"), "Xem thông tin các hạng phòng và tiện nghi để chọn hạng phù hợp.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.guide.s1.body", "textarea", "Bước 1: nội dung", "Chi tiết khách sạn", null, "", 193, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b71cdaab-d639-cc1a-fd5f-09589d37e5e2"), "Liên hệ Hotline/Zalo/Messenger để kiểm tra phòng và đặt, hoặc điền bảng thông tin — Perlunas sẽ chủ động liên hệ xác nhận, check rate với đối tác và phản hồi.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.guide.s3.body", "textarea", "Bước 3: nội dung", "Chi tiết khách sạn", null, "", 197, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ba4e5fe7-457b-9391-c775-c2e87ff01af9"), "Phản hồi nhanh qua Zalo / Hotline", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.perk3", "text", "Cam kết 3", "Chi tiết khách sạn", null, "", 203, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c45023a0-b291-c0cd-e645-ee75eb47a94b"), "Xem gói ở", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.combolink", "text", "Link xem gói (tiền tố)", "Chi tiết khách sạn", null, "", 205, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c6278a8c-4a8b-5462-4094-bfdb852d9475"), "Loại hình", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.ticket.type", "text", "Vé: nhãn loại hình", "Chi tiết khách sạn", null, "", 198, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cd742486-c2eb-885a-d57e-017c45488320"), "Lịch trình chi tiết theo ngày sẽ được Perlunas gửi và điều chỉnh theo số khách, ngày đi và sở thích của bạn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.itinerary.note", "textarea", "Lịch trình: ghi chú", "Chi tiết combo", null, "", 220, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d305941f-b145-3529-b711-2924a8b3fe5b"), "Giữ phòng đúng ngày bạn cần", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.perk2", "text", "Cam kết 2", "Chi tiết khách sạn", null, "", 202, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d31432e9-1e05-e2ed-52aa-85f33620f8ac"), "Tiện nghi nổi bật", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.facilities.title", "text", "Tiêu đề tiện nghi", "Chi tiết khách sạn", null, "", 183, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d3750332-5bc0-61d3-ec6e-ed6245fb167a"), "Hướng dẫn cách đặt phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.guide.title", "text", "Tiêu đề hướng dẫn đặt", "Chi tiết khách sạn", null, "", 191, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dca816e4-bda5-849e-aeb7-ce1664998b66"), "Perlunas đồng hành cùng bạn từ khâu chọn hạng phòng, xác nhận mức giá tốt với đối tác cho đến lúc nhận phòng — để bạn chỉ việc tận hưởng kỳ nghỉ của mình.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.intro.p3", "textarea", "Giới thiệu: đoạn 3", "Chi tiết khách sạn", null, "", 187, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e2dd22da-6b4d-5cbd-7776-c850013315e9"), "Gói đi kèm hạng phòng dưới đây. Bấm vào ảnh hoặc “Xem chi tiết” để xem thêm hình và tiện nghi.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.room.note", "textarea", "Phòng nghỉ: ghi chú", "Chi tiết combo", null, "", 223, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e8208bee-466c-00c7-157f-66769a3c2a2f"), "Giá tham khảo. Perlunas xác nhận mức giá chính xác theo hạng phòng và ngày ở.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.sidenote", "textarea", "Vé: ghi chú giá", "Chi tiết khách sạn", null, "", 204, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eb3824f5-8dc8-05b2-0297-8b01bb26a182"), "Tư vấn & báo giá miễn phí", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.perk1", "text", "Cam kết 1", "Chi tiết khách sạn", null, "", 201, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ee41b28d-0017-e8a3-092b-22beac81ceac"), "Tất cả khách sạn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.back", "text", "Link quay lại", "Chi tiết khách sạn", null, "", 182, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f00fbae7-22ee-8b99-765a-eb58c12480bc"), "Xem tất cả gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combodetail.related.viewall", "text", "Gói khác: xem tất cả", "Chi tiết combo", null, "", 229, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fdf0580d-e82d-06bf-0559-bea117e2e14f"), "Đọc kỹ quy định độ tuổi trẻ em, em bé để có giá phòng chính xác.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hoteldetail.guide.s2.body", "textarea", "Bước 2: nội dung", "Chi tiết khách sạn", null, "", 195, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string> { "da-nang" }, new List<string>(), new List<string> { "Cầu Vàng Bà Nà Hills", "Phố cổ Hội An về đêm", "Thả đèn hoa đăng sông Hoài", "Biển Mỹ Khê" } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("1c319bb9-c82d-5a4a-22b3-2f5d6625fbd2"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("22f4078a-1c46-d445-a3fb-c9ab91136022"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string> { "nha-trang" }, new List<string>(), new List<string> { "Khám phá đảo Hòn Mun", "Tắm bùn khoáng", "Vịnh Nha Trang", "Ẩm thực biển" } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("64b5eb41-96db-8d39-22e5-4a7f2e4e4129"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6a695375-8160-a254-bce4-37be78bdbe63"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string> { "phu-quoc" }, new List<string>(), new List<string> { "Cáp treo Hòn Thơm dài nhất thế giới", "Lặn ngắm san hô 3 đảo", "Hoàng hôn bãi Sao", "Chợ đêm hải sản" } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6b3cd177-825d-b0a4-22df-db79721fa23e"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6fc490b0-6501-7066-2716-f195529f23d3"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("836e3fca-9da6-4631-f71f-ef0f27a681c1"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8e401cad-0a9e-259e-9819-bf4842528f05"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string> { "ha-noi", "sa-pa" }, new List<string>(), new List<string> { "Phố cổ Hà Nội và Hồ Gươm", "Ruộng bậc thang Mường Hoa", "Cáp treo Fansipan", "Bản làng người Mông, người Dao" } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a846c103-c841-b1a6-3479-a7299029ca67"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("abca9795-459e-619e-fac5-12763e8182cf"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string> { "da-lat" }, new List<string>(), new List<string> { "Săn mây Cầu Đất lúc bình minh", "Vườn hồng và đồi chè Cầu Đất", "Cà phê giữa rừng thông", "Chợ đêm và ẩm thực phố núi" } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("be9279af-57b7-1a64-3d9c-e69e8885cc0a"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c798db8d-3381-10a2-4623-3a599a44ad4a"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d07f4322-2edb-544f-7286-265c1c258ce0"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d43e2322-4d95-0305-d0aa-1303db0dade7"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("de0528da-01be-297f-3d6f-59795657002f"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e50a45c4-40d6-316f-0e40-2e58860b0f8e"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f8598638-8a39-2092-c30f-1f4e69dc2511"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("fce66f24-a18b-3b62-8473-12df889d6e6f"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("121e8cf8-eaf3-ce42-e692-1a1391bbb31f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("122c6749-8809-3ea6-c072-a2b4d2fc2694"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("1c96a7e8-6c33-0310-e8a0-951546c09764"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("205e1200-00f9-d8d0-a097-f3484afcfaca"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("3450e472-94e0-7f5c-e866-29883813a013"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4213b66c-ad34-b368-bd63-d8d97ef891ce"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4ec6d686-c3f7-08da-9dcf-a882feb0b211"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("56d826f7-10f5-6ccc-7cb0-08f5a66851f9"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("57148b9e-a109-f066-9f73-a8fbb0a1d623"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5e276887-1ab9-f236-2730-e9211a916ab4"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("65eaba8d-6e98-84f6-cafe-08871746e462"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("66a946dc-e4c1-e2e6-17bb-a8ea0ba0e68e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7193d275-e499-4f68-056c-7290ba701cd8"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("76c11c42-2a53-06d7-3e7f-611a0f2e49fc"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7962d148-34b6-d71d-42ca-e8678d372127"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7a01a281-6e2f-a271-0dbc-63a216e1e140"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7a60330f-c314-eb00-f1fa-2b0e7666849f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7bccc5a6-5606-949b-cfc6-dcff376fad92"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7c57a17f-f7b4-1da1-9104-190e65eff62a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7d838bcd-7666-729e-d0ed-9aba9e48ca0a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("849199d5-9ccc-0d45-8b31-7cece2e3891a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8bfeec00-a7d6-c0be-9316-d0f0f22332bf"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("91dc5f3e-7664-d0dc-112d-d102436f6834"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("937cd244-22b6-fcc8-aca9-9ca4b0b88644"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("96351521-239b-ed1f-a545-eda99dfe6d6c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9bfc9705-3194-d970-e989-8e896460a93e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9f2202ce-1ab5-0e19-8410-7e0a9a7d15c3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a13325c8-ad7a-b04a-542b-5ae68fdf9084"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a2736d17-066c-c13e-e287-516d311f2bd7"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a3b3d2bd-4024-b579-75eb-5c7225ed4cf3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a5022235-8826-5dbf-99d9-531a0546a49f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a5a7b1b0-e109-4fae-b4df-9d624725f98c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ac02943a-2703-489a-fcb1-4ef83dae0c04"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b71cdaab-d639-cc1a-fd5f-09589d37e5e2"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ba4e5fe7-457b-9391-c775-c2e87ff01af9"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c45023a0-b291-c0cd-e645-ee75eb47a94b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c6278a8c-4a8b-5462-4094-bfdb852d9475"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("cd742486-c2eb-885a-d57e-017c45488320"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d305941f-b145-3529-b711-2924a8b3fe5b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d31432e9-1e05-e2ed-52aa-85f33620f8ac"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d3750332-5bc0-61d3-ec6e-ed6245fb167a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("dca816e4-bda5-849e-aeb7-ce1664998b66"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e2dd22da-6b4d-5cbd-7776-c850013315e9"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e8208bee-466c-00c7-157f-66769a3c2a2f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("eb3824f5-8dc8-05b2-0297-8b01bb26a182"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ee41b28d-0017-e8a3-092b-22beac81ceac"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("f00fbae7-22ee-8b99-765a-eb58c12480bc"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("fdf0580d-e82d-06bf-0559-bea117e2e14f"));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string> { "da-nang" }, new List<string>(), new List<string> { "Cầu Vàng Bà Nà Hills", "Phố cổ Hội An về đêm", "Thả đèn hoa đăng sông Hoài", "Biển Mỹ Khê" } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("083e6b00-8171-b03d-acd6-bcb2698ba71a"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("14ed53c2-55ae-229f-7de2-15307bd0766a"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("16d5bd3e-f290-82fa-601c-1866e2698c4b"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("1c319bb9-c82d-5a4a-22b3-2f5d6625fbd2"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("22f4078a-1c46-d445-a3fb-c9ab91136022"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string> { "nha-trang" }, new List<string>(), new List<string> { "Khám phá đảo Hòn Mun", "Tắm bùn khoáng", "Vịnh Nha Trang", "Ẩm thực biển" } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("64b5eb41-96db-8d39-22e5-4a7f2e4e4129"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6a695375-8160-a254-bce4-37be78bdbe63"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string> { "phu-quoc" }, new List<string>(), new List<string> { "Cáp treo Hòn Thơm dài nhất thế giới", "Lặn ngắm san hô 3 đảo", "Hoàng hôn bãi Sao", "Chợ đêm hải sản" } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6b3cd177-825d-b0a4-22df-db79721fa23e"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6fc490b0-6501-7066-2716-f195529f23d3"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("7cd58789-1ecc-9fb2-3546-a5e509fad35d"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("836e3fca-9da6-4631-f71f-ef0f27a681c1"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("84aeb32e-aa27-580d-57e9-3c60dd150c81"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("8e401cad-0a9e-259e-9819-bf4842528f05"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string> { "ha-noi", "sa-pa" }, new List<string>(), new List<string> { "Phố cổ Hà Nội và Hồ Gươm", "Ruộng bậc thang Mường Hoa", "Cáp treo Fansipan", "Bản làng người Mông, người Dao" } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("a846c103-c841-b1a6-3479-a7299029ca67"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("abca9795-459e-619e-fac5-12763e8182cf"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string> { "da-lat" }, new List<string>(), new List<string> { "Săn mây Cầu Đất lúc bình minh", "Vườn hồng và đồi chè Cầu Đất", "Cà phê giữa rừng thông", "Chợ đêm và ẩm thực phố núi" } });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("be9279af-57b7-1a64-3d9c-e69e8885cc0a"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c798db8d-3381-10a2-4623-3a599a44ad4a"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("cdb4217d-cea0-1eb8-d64b-f9137e42e049"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d07f4322-2edb-544f-7286-265c1c258ce0"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d43e2322-4d95-0305-d0aa-1303db0dade7"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("de0528da-01be-297f-3d6f-59795657002f"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e50a45c4-40d6-316f-0e40-2e58860b0f8e"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f8598638-8a39-2092-c30f-1f4e69dc2511"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("fce66f24-a18b-3b62-8473-12df889d6e6f"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });
        }
    }
}
