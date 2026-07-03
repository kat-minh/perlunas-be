using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedContentBatch3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SiteSettings",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777772"));

            migrationBuilder.DeleteData(
                table: "SiteSettings",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777773"));

            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("031f6ca2-0dec-b058-8c10-f429565f9bcc"), "Đóng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.close", "text", "QuickEnquiry: nút đóng", "Form liên hệ / đặt", null, "", 280, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("06648fd2-193d-6a89-1fd5-53fcaba69c99"), "Tìm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.search.aria", "text", "Nút tìm (aria)", "Thành phần dùng chung", null, "", 271, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("080c7770-b43c-971f-0845-82562ab2f91f"), "Khách sạn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.meta.title", "text", "hotelspage.meta.title", "Trang Khách sạn", null, "", 381, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0861bf41-2e70-b91b-c16a-fa26f2c86f00"), "Email", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.email", "text", "QuickEnquiry: nhãn email", "Form liên hệ / đặt", null, "", 285, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("09035125-2307-3222-9a88-cc0988ebe411"), "Đã nhận thông tin", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.ok.title", "text", "QuickEnquiry: tiêu đề thành công", "Form liên hệ / đặt", null, "", 278, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("09922c7b-aee9-bfac-ebf4-03a10f6d9f6a"), "Blog", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "nav.blog", "text", "Nav: Blog", "Điều hướng (nav)", null, "", 325, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("09a11736-5ce7-2b61-4a03-9cd38e88f19c"), "Nơi đến", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.filter.city", "text", "catalog.filter.city", "Danh mục & bộ lọc (catalog)", null, "", 366, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0a599923-2f20-8b43-0913-bba38b6455c5"), "Chúng tôi cam kết bảo mật thông tin của khách hàng.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.privacy", "textarea", "QuickEnquiry: cam kết", "Form liên hệ / đặt", null, "", 291, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0ebe4174-dd24-9f4d-2929-96acbb5f0047"), "Số người", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.group", "text", "LeadForm: Số người", "Form liên hệ / đặt", null, "", 345, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("130d9cda-2815-253f-725f-aeb1c9587527"), "Chưa có chỗ nghỉ phù hợp với bộ lọc này. Bạn thử bỏ bớt một tiêu chí nhé.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.empty", "textarea", "hotelspage.empty", "Trang Khách sạn", null, "", 387, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1327f29a-0ade-ccf0-0cd7-ed1487c0cf0a"), "Tour riêng tư may đo theo yêu cầu: gia đình, cặp đôi, nhóm bạn, trăng mật — lịch trình thiết kế riêng cho mỗi hành trình.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.meta.desc", "textarea", "privatepage.meta.desc", "Trang Tour riêng tư", null, "", 401, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("13499153-0f00-5dca-613e-ea13fd5bb2f8"), "Nhận thông tin ưu đãi và cảm hứng du lịch từ Perlunas.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.consent", "textarea", "LeadForm: Nhận thông tin ưu đãi và cảm hứng du lịch từ Perlunas.", "Form liên hệ / đặt", null, "", 353, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("13966d77-4e8d-6fd3-349d-dec0e2a2baba"), "Vùng miền", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.filter.region", "text", "catalog.filter.region", "Danh mục & bộ lọc (catalog)", null, "", 374, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1737ae4b-9724-d468-063d-feca0859a7c3"), "Gửi thông tin", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.submit", "text", "QuickEnquiry: nút gửi", "Form liên hệ / đặt", null, "", 290, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1a6dba4f-e6f8-e0f4-def9-682da2bccdce"), "Chú thích", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.legend", "text", "catalog.legend", "Danh mục & bộ lọc (catalog)", null, "", 376, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1ac0bd90-1e33-20c4-6b33-c08b88d600b3"), "Gửi thông tin", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.submit", "text", "LeadForm: Gửi thông tin", "Form liên hệ / đặt", null, "", 354, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1d11386a-e28d-9bbf-7b89-0211acde9705"), "Tên khách sạn hoặc nơi đến…", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.search.combo", "text", "catalog.search.combo", "Danh mục & bộ lọc (catalog)", null, "", 364, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("210b1cfb-1fb9-b078-ecaa-4229f10791db"), "Công ty", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.col.company", "text", "Footer: Công ty", "Footer", null, "", 335, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("237b2d95-85a7-857e-1c40-491601b8758f"), "Thông tin liên hệ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.contact", "text", "HotelBooking: tiêu đề mục liên hệ", "Form liên hệ / đặt", null, "", 297, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("27d12543-3cce-076a-6ec1-57ab39412e83"), "Người lớn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.adults", "text", "HotelBooking: nhãn người lớn", "Form liên hệ / đặt", null, "", 308, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2890e329-26af-5728-ca20-94048b82766e"), "Cảm ơn bạn. Perlunas sẽ liên hệ qua Zalo hoặc điện thoại trong thời gian sớm nhất.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.ok.body", "textarea", "QuickEnquiry: nội dung thành công", "Form liên hệ / đặt", null, "", 279, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("28c2783d-3920-bcc5-c536-82f349eedbd0"), "Số phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.roomqty", "text", "HotelBooking: nhãn số phòng", "Form liên hệ / đặt", null, "", 304, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("29d1adf4-e569-cb43-e011-751dfc5c1faa"), "Gửi yêu cầu tư vấn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.newsletter.submit", "text", "Footer: Gửi yêu cầu tư vấn", "Footer", null, "", 336, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2dcd6885-59b0-d666-b78b-72f90e033b90"), "Trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.children", "text", "HotelBooking: nhãn trẻ em", "Form liên hệ / đặt", null, "", 310, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("30506410-f0be-c425-cdca-25c8bdada7c0"), "Sắp ra mắt", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.comingsoon", "text", "catalog.comingsoon", "Danh mục & bộ lọc (catalog)", null, "", 379, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("30b1dfb4-7d60-28ab-2948-c595ce4cf85c"), "Bạn quan tâm dịch vụ nào?", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.service", "text", "LeadForm: Bạn quan tâm dịch vụ nào?", "Form liên hệ / đặt", null, "", 347, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("30ba0b40-3eb0-1b4f-b6b7-1a7de637e8e3"), "Thông tin đang quan tâm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.interest", "text", "QuickEnquiry: nhãn quan tâm", "Form liên hệ / đặt", null, "", 287, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("312cd0d5-1bff-8a4c-fe78-8cb0dea14c96"), "Hotline:", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.label.hotline", "text", "Footer: Hotline:", "Footer", null, "", 333, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("35e4fb8b-ed15-9a4b-8268-71f557cbf3bf"), "Tìm kiếm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.searchlabel", "text", "Nhãn ô tìm kiếm", "Thành phần dùng chung", null, "", 270, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3a8a82b0-151b-99b1-50ac-ae58e935d7e6"), "Tất cả loại hình", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.filter.type.all", "text", "catalog.filter.type.all", "Danh mục & bộ lọc (catalog)", null, "", 369, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3e5e1a1b-93e0-4432-51cd-2233243a7470"), "Đặt phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.openbtn", "text", "HotelBooking: nút mở", "Form liên hệ / đặt", null, "", 292, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3f1115fa-342f-076b-fe76-a2344117eeb0"), "0901 234 567", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.phone.ph", "text", "QuickEnquiry: placeholder SĐT", "Form liên hệ / đặt", null, "", 284, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4115f5b2-efea-fd5e-7f8c-ed828416bd50"), "Đi trong bao lâu?", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.duration", "text", "LeadForm: Đi trong bao lâu?", "Form liên hệ / đặt", null, "", 344, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("418c30e7-f848-e596-b6f0-1a38604f4bc3"), "có thể thêm nhiều hạng phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.sec2.room.hint", "text", "HotelBooking: gợi ý mục 2 (phòng)", "Form liên hệ / đặt", null, "", 301, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4329528b-f18d-4d00-0994-c01e0cd2b0f5"), "Sau", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.next", "text", "Nút trang sau", "Thành phần dùng chung", null, "", 275, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4618648c-a56f-bba5-e3ae-f746450e56e3"), "Hạng phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.roomtype", "text", "HotelBooking: nhãn hạng phòng", "Form liên hệ / đặt", null, "", 302, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("464bc2fd-0ec7-24e8-513d-7cd020383e72"), "MST:", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.label.taxid", "text", "Footer: MST:", "Footer", null, "", 331, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("47ad2151-f78b-de22-128c-2a485756f172"), "Số điện thoại / Zalo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.phone", "text", "LeadForm: Số điện thoại / Zalo", "Form liên hệ / đặt", null, "", 350, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4a8b82f4-19ec-9564-7b17-d85ee6ed510b"), "Chính sách & Điều khoản", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "policy.meta.title", "text", "Policy: title", "Chính sách & Điều khoản", null, "", 355, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4cfbefa7-ac42-719a-a7a6-b304a8e593f6"), "Tất cả vùng miền", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.filter.region.all", "text", "catalog.filter.region.all", "Danh mục & bộ lọc (catalog)", null, "", 375, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4d62717b-423a-357a-2420-74c24785fdb9"), "Tour riêng tư", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "privatepage.meta.title", "text", "privatepage.meta.title", "Trang Tour riêng tư", null, "", 400, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4d8508b1-b100-bbda-8583-5f27a8678dfe"), "chỗ nghỉ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.unit", "text", "hotelspage.unit", "Trang Khách sạn", null, "", 386, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("51ef92b1-68cc-0e68-b31d-7489a74c7702"), "Họ tên", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.name", "text", "QuickEnquiry: nhãn họ tên", "Form liên hệ / đặt", null, "", 281, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("51fc0e17-1cb8-2095-3e97-bd26cdf0eed8"), "Đang gửi…", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.submitting", "text", "QuickEnquiry: đang gửi", "Form liên hệ / đặt", null, "", 289, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("53d75004-09ea-c91f-9c92-c0161608a706"), "Vị trí thuận tiện, an toàn.\nChất lượng và tiện nghi đạt chuẩn 4 - 5 sao.\nDịch vụ tận tâm, không gian tinh tế.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.criteria.items", "list", "hotelspage.criteria.items", "Trang Khách sạn", null, "", 388, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("56811717-edda-3202-0269-aff0bcd08df2"), "Thông tin của bạn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.you.title", "text", "LeadForm: Thông tin của bạn", "Form liên hệ / đặt", null, "", 341, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("56cdda4b-a9ec-a635-0347-91a38070f4e6"), "Tất cả mục đích", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.filter.purpose.all", "text", "catalog.filter.purpose.all", "Danh mục & bộ lọc (catalog)", null, "", 373, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("58722cb0-d2d1-de6a-ac26-0453e99edc3a"), "Chưa có gói phù hợp với bộ lọc này. Bạn thử bỏ bớt một tiêu chí nhé.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.empty", "textarea", "combopage.empty", "Trang Gói du lịch", null, "", 393, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("58ba2355-4954-44ae-f307-b6b92ac15fce"), "Chưa có tour phù hợp. Bạn thử từ khóa khác nhé.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourspage.empty", "textarea", "tourspage.empty", "Trang Tour trọn gói", null, "", 397, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("58ec486f-7bc1-7cc7-732c-f8e9a61ec3f0"), "Tour trọn gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourspage.meta.title", "text", "tourspage.meta.title", "Trang Tour trọn gói", null, "", 394, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5bf3638b-7da2-fd28-f2c4-f3391d3ce68b"), "ảnh", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "common.photos", "text", "Đơn vị ảnh", "Thành phần dùng chung", null, "", 269, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5c950fa8-d6e4-09cb-7721-0b59eae183b6"), "Mọi thắc mắc về chính sách, vui lòng liên hệ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "policy.contact.pre", "text", "Policy: pre", "Chính sách & Điều khoản", null, "", 361, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5cb56590-7cd8-f681-d243-71544f775cf7"), "Một chỗ nghỉ đúng giúp bạn nạp lại năng lượng và cảm nhận trọn vẹn không khí của điểm đến — Perlunas xem đây là một phần quan trọng của trải nghiệm.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.why.body", "textarea", "hotelspage.why.body", "Trang Khách sạn", null, "", 384, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5e5e5fb3-e666-ff25-e9e0-cc4ddc57b78a"), "Gửi chưa thành công, bạn thử lại hoặc nhắn Zalo trực tiếp giúp chúng tôi nhé.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.error", "textarea", "QuickEnquiry: lỗi", "Form liên hệ / đặt", null, "", 288, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5f3f626e-c326-3d27-194a-c31b27d1725e"), "Xóa bộ lọc", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.clearfilter", "text", "Nút xóa bộ lọc", "Thành phần dùng chung", null, "", 272, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("62c6fa2b-f905-2c76-28ac-fcb25cb53f9b"), "Phòng, ngày & số khách", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.sec2.room", "text", "HotelBooking: mục 2 (phòng)", "Form liên hệ / đặt", null, "", 299, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("63c23771-88a8-54a5-6d09-256f130b496b"), "Tổ chức tour đoàn trọn gói: team building, gala dinner, hội nghị kết hợp tham quan — một đầu mối lo trọn cho cả đoàn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.meta.desc", "textarea", "grouppage.meta.desc", "Trang Tour đoàn", null, "", 399, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("67739a3e-9141-94bf-09c8-a42a6053e590"), "Gói & số khách", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.sec2.combo", "text", "HotelBooking: mục 2 (combo)", "Form liên hệ / đặt", null, "", 298, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("69e7f6a7-c70b-608c-5136-7aaa1535266f"), "Từ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.pricefrom", "text", "catalog.pricefrom", "Danh mục & bộ lọc (catalog)", null, "", 377, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6d24f408-6bb8-a5b3-71a7-22feca9be42a"), "Loại hình", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.filter.type", "text", "catalog.filter.type", "Danh mục & bộ lọc (catalog)", null, "", 368, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6ded1a4d-9c47-7d26-f416-34f601d0cb18"), "Dự kiến khi nào?", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.when", "text", "LeadForm: Dự kiến khi nào?", "Form liên hệ / đặt", null, "", 343, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6ed1ce37-9039-c1ca-5793-2a3d4c15e23a"), "Đặt phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.eyebrow", "text", "HotelBooking: nhãn form", "Form liên hệ / đặt", null, "", 296, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6edda4ca-3136-10a3-c0ee-95584a9aa1ba"), "Chính sách & Điều khoản", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.link.policy", "text", "Footer: Chính sách & Điều khoản", "Footer", null, "", 329, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("74356c43-138a-2523-faf5-7b1b53ac40aa"), "Số khách", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.guests", "text", "HotelBooking: nhãn số khách", "Form liên hệ / đặt", null, "", 307, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("745067d0-f249-771c-42ec-31f4503b2999"), "Perlunas sẽ liên hệ xác nhận, check rate với đối tác và phản hồi sớm nhất.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.note", "textarea", "HotelBooking: ghi chú", "Form liên hệ / đặt", null, "", 317, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("787f72c2-0887-60e1-2c0e-3024aca5cff4"), "Phân trang", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.pagination.aria", "text", "Phân trang (aria)", "Thành phần dùng chung", null, "", 273, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("78ec2203-6c0f-9945-c3f5-9a9ebec155cb"), "đúng theo giấy tờ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.name.hint", "text", "QuickEnquiry: gợi ý họ tên", "Form liên hệ / đặt", null, "", 282, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7a2adfc1-dbfc-00d6-85bf-7b1a2e54c446"), "Xem chi tiết", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "roomdetail.viewbtn", "text", "RoomDetail: nút xem", "Thành phần dùng chung", null, "", 262, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7bc6ee92-a057-08c0-c559-e358a49995c5"), "gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.unit", "text", "combopage.unit", "Trang Gói du lịch", null, "", 392, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("80fb7df5-789e-68c8-f7b7-92a656aa89d7"), "Thêm gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.addcombo", "text", "HotelBooking: nút thêm gói", "Form liên hệ / đặt", null, "", 314, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("818c9dcf-2045-396e-d1b2-19a01bcb2e7a"), "Tiện nghi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "roomdetail.amenities", "text", "RoomDetail: nhãn tiện nghi", "Thành phần dùng chung", null, "", 264, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("81ba0573-b2bc-208b-b1de-49aa6fcfc16b"), "Gửi chưa thành công, bạn thử lại hoặc nhắn Zalo trực tiếp giúp chúng tôi nhé.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.error", "textarea", "LeadForm: Gửi chưa thành công, bạn thử lại hoặc nhắn Zalo trực tiếp giúp chúng tôi nhé.", "Form liên hệ / đặt", null, "", 339, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("840c0403-c659-219b-5b27-64e5f6256a62"), "Tất cả phân loại", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.filter.tier.all", "text", "catalog.filter.tier.all", "Danh mục & bộ lọc (catalog)", null, "", 371, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("84a2e008-a71a-cbfb-3706-ff9f5d522b11"), "Gói trong tháng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.comboinmonth", "text", "HotelBooking: aria gói trong tháng", "Form liên hệ / đặt", null, "", 319, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("87066e5a-a74c-cb13-7059-917280ac52fa"), "Em bé", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.infants", "text", "HotelBooking: nhãn em bé", "Form liên hệ / đặt", null, "", 312, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("873fdab9-f87a-d372-b6fd-3fef9456a63b"), "Đã nhận yêu cầu đặt phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.ok.title", "text", "HotelBooking: tiêu đề thành công", "Form liên hệ / đặt", null, "", 293, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8a163f46-b6df-96b9-6649-d9d6206ac24c"), "Tour riêng tư", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "nav.private", "text", "Nav: Tour riêng tư", "Điều hướng (nav)", null, "", 324, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8b8b7f55-6f69-821c-2f0e-a94fc654df42"), "Chính sách đặt dịch vụ, thanh toán, hoàn hủy, bảo mật thông tin và điều khoản sử dụng dịch vụ của Perlunas.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "policy.meta.desc", "textarea", "Policy: desc", "Chính sách & Điều khoản", null, "", 356, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8d18b1ed-b7a5-b610-9055-cab0a0f35a96"), "Pháp lý", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "policy.eyebrow", "text", "Policy: eyebrow", "Chính sách & Điều khoản", null, "", 357, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8fe4e540-24d6-8215-62e4-03fb163c6aa3"), "Gửi yêu cầu tư vấn cho Perlunas. Để lại thông tin chuyến đi, đội ngũ sẽ liên hệ sớm để lên kế hoạch và báo giá miễn phí.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contactpage.meta.desc", "textarea", "contactpage.meta.desc", "Trang Liên hệ", null, "", 405, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("90c5ab5d-af83-39a6-f872-e770e23bb48c"), "Chỗ nghỉ tuyển chọn trên khắp Việt Nam — resort, boutique, retreat và wellness.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.meta.desc", "textarea", "hotelspage.meta.desc", "Trang Khách sạn", null, "", 382, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("956e08bd-c5aa-e8d0-13fb-7a6bf28d0d8a"), "Thêm hạng phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.addroom", "text", "HotelBooking: nút thêm phòng", "Form liên hệ / đặt", null, "", 315, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("956fa0ae-ee44-321b-eecb-56a1649011d0"), "Gói du lịch", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.meta.title", "text", "combopage.meta.title", "Trang Gói du lịch", null, "", 389, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("97ea6459-9f5e-a089-83e0-b3fead86bb9a"), "Liên hệ tư vấn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.aria", "text", "QuickEnquiry: aria", "Form liên hệ / đặt", null, "", 277, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9ad2ae33-5f15-c587-34d3-0d521a7bb93e"), "Tour đoàn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "nav.group", "text", "Nav: Tour đoàn", "Điều hướng (nav)", null, "", 323, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9c1d191e-a68d-a485-a83f-ca2ddff7afd3"), "email@cuaban.com", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.newsletter.placeholder", "text", "Footer: email@cuaban.com", "Footer", null, "", 337, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9cedd680-2058-e153-88ec-28ce78cf6469"), "Liên hệ tư vấn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "nav.cta", "text", "Nav: Liên hệ tư vấn", "Điều hướng (nav)", null, "", 327, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a11ee3a1-2a1d-434d-1df8-1cc9ab3efcf3"), "Về chúng tôi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "nav.about", "text", "Nav: Về chúng tôi", "Điều hướng (nav)", null, "", 326, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a324c786-36d1-5e93-d34c-0677ab69733e"), "ban@email.com", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.email.ph", "text", "QuickEnquiry: placeholder email", "Form liên hệ / đặt", null, "", 286, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a37d6e01-2ad7-48bd-8ce6-dff6a463e0ee"), "Số điện thoại (có Zalo)", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.phone", "text", "QuickEnquiry: nhãn SĐT", "Form liên hệ / đặt", null, "", 283, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a59641ed-8664-b566-b2ab-af379af1ba04"), "Xem thêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "common.expand", "text", "Nút xem thêm", "Thành phần dùng chung", null, "", 267, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a5a588b5-b48f-24ea-e947-fa7d6e16cefa"), "Liên hệ ngay", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "qe.openbtn", "text", "QuickEnquiry: nút mở", "Form liên hệ / đặt", null, "", 276, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a5ad59da-aef9-9654-ec23-980cc59a58ee"), "hoặc hotline", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "policy.contact.mid", "text", "Policy: mid", "Chính sách & Điều khoản", null, "", 362, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a9eada18-69c2-75b1-f563-7eff38b7da7e"), "Mục đích chuyến đi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.filter.purpose", "text", "catalog.filter.purpose", "Danh mục & bộ lọc (catalog)", null, "", 372, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ab5fd958-9850-1580-6483-6ee69cf1ea5d"), "Tất cả nơi đến", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.filter.city.all", "text", "catalog.filter.city.all", "Danh mục & bộ lọc (catalog)", null, "", 367, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b1f1e98c-202c-7699-1a43-66b32826f14f"), "có thể thêm nhiều gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.sec2.combo.hint", "text", "HotelBooking: gợi ý mục 2 (combo)", "Form liên hệ / đặt", null, "", 300, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b43cd03e-6e0e-61a5-1db5-73415c7b3bd2"), "Chính sách & Điều khoản", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "policy.title", "text", "Policy: title", "Chính sách & Điều khoản", null, "", 358, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b51fac01-6dbc-1d83-2e43-ac6464e35c27"), "Đóng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.close", "text", "HotelBooking: nút đóng", "Form liên hệ / đặt", null, "", 295, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b5db6dd7-6903-41f8-ec85-4a326aa2b644"), "Mở menu", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "nav.menu", "text", "Nav: Mở menu", "Điều hướng (nav)", null, "", 328, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bad1043b-b33f-ec3a-e05b-a05e5c2eeb7b"), "Gửi yêu cầu đặt phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.submit", "text", "HotelBooking: nút gửi", "Form liên hệ / đặt", null, "", 316, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bbe8386a-07bd-2236-e0f1-d2dc46f148b8"), "Về chúng tôi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.meta.title", "text", "about.meta.title", "Trang Về chúng tôi", null, "", 402, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bc40c4e2-c547-bc2a-65cf-119ebb9187a3"), "Ghi chú thêm (không bắt buộc)", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.note", "text", "LeadForm: Ghi chú thêm (không bắt buộc)", "Form liên hệ / đặt", null, "", 348, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("be4383e5-5905-bd8c-1758-a90d5e0fd9ee"), "Tên khách sạn hoặc nơi đến…", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.search.hotel", "text", "catalog.search.hotel", "Danh mục & bộ lọc (catalog)", null, "", 363, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("befdda8f-12b0-1a40-4d8f-24ffc914b3ac"), "khách", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "roomdetail.guests", "text", "RoomDetail: đơn vị khách", "Thành phần dùng chung", null, "", 263, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bf6a951d-80ad-79d2-1e3d-39083977cf46"), "từ 12 tuổi trở lên", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.adults.hint", "text", "HotelBooking: gợi ý người lớn", "Form liên hệ / đặt", null, "", 309, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c195cce6-dc62-cd51-408e-c150f90d106b"), "Tầm quan trọng của nơi lưu trú cho một chuyến đi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.why.title", "textarea", "hotelspage.why.title", "Trang Khách sạn", null, "", 383, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c1ef6b7f-b9eb-0bdc-90a6-0c4cfc6ccabf"), "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "roomdetail.priceunit", "text", "RoomDetail: đơn vị giá", "Thành phần dùng chung", null, "", 265, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c283f696-6a13-204a-d6d3-5575855279a5"), "Trả phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.checkout", "text", "HotelBooking: nhãn trả phòng", "Form liên hệ / đặt", null, "", 306, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c2a9c70a-40cc-3f07-7c61-e3e47af071ff"), "Các chính sách dưới đây áp dụng cho dịch vụ Perlunas cung cấp. Vui lòng đọc kỹ trước khi sử dụng dịch vụ.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "policy.intro", "textarea", "Policy: intro", "Chính sách & Điều khoản", null, "", 359, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c45e933b-646f-7bca-ce0c-d84b0c98da36"), "tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourspage.unit", "text", "tourspage.unit", "Trang Tour trọn gói", null, "", 396, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c6795554-4628-9e2a-2929-2d0446e6a3be"), "Gói du lịch", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "nav.combo", "text", "Nav: Gói du lịch", "Điều hướng (nav)", null, "", 322, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c949f2ee-be19-d21a-3532-d22256c73891"), "Bạn muốn đi đâu?", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.where", "text", "LeadForm: Bạn muốn đi đâu?", "Form liên hệ / đặt", null, "", 342, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cac8e966-16ed-31b5-6d2a-28bee0507596"), "Mọi quyền được bảo lưu.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.copyright", "text", "Footer: Mọi quyền được bảo lưu.", "Footer", null, "", 338, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbaf6804-39fc-6479-23fe-fddf278e2388"), "Tiêu chuẩn chọn đối tác lưu trú cao cấp", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hotelspage.criteria.title", "text", "hotelspage.criteria.title", "Trang Khách sạn", null, "", 385, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cefe5643-2e23-40f2-5e5e-e23a39d703c4"), "Lưu trú cao cấp", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "nav.hotel", "text", "Nav: Lưu trú cao cấp", "Điều hướng (nav)", null, "", 321, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d2e5787c-95cd-040a-1317-96ecd1788491"), "Giá từ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.pricefrom2", "text", "catalog.pricefrom2", "Danh mục & bộ lọc (catalog)", null, "", 378, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d4b07472-252c-95ea-c774-78cc08cf1c6f"), "Tên tour hoặc vùng miền…", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.search.tour", "text", "catalog.search.tour", "Danh mục & bộ lọc (catalog)", null, "", 365, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d59a96ca-1c97-bfde-5b8c-847b1b6fcb63"), "Thu gọn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "common.collapse", "text", "Nút thu gọn", "Thành phần dùng chung", null, "", 266, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d9ab4f74-00da-9e01-fe3e-1e10dd43c9e3"), "Những hành trình du lịch trong nước được thiết kế sẵn, chỉ việc khởi hành.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tourspage.meta.desc", "textarea", "tourspage.meta.desc", "Trang Tour trọn gói", null, "", 395, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("da536faf-d17e-b5f6-9fb4-5d18e44fd4d6"), "Họ và tên", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.name", "text", "LeadForm: Họ và tên", "Form liên hệ / đặt", null, "", 349, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dca4b6c2-0f9b-2f92-40cc-98e78144c3a3"), "Phân loại", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.filter.tier", "text", "catalog.filter.tier", "Danh mục & bộ lọc (catalog)", null, "", 370, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("de5fc51d-4121-cee7-fe84-9ef7f56f2b9a"), "Ngân sách mỗi người", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.budget", "text", "LeadForm: Ngân sách mỗi người", "Form liên hệ / đặt", null, "", 346, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("df046072-d6e5-b7c3-bc1d-4a979f762ac1"), "Công ty:", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.label.company", "text", "Footer: Công ty:", "Footer", null, "", 330, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("df763d97-0f0d-35a0-2c41-673493c852be"), "Phân loại Gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.classifybtn", "text", "combopage.classifybtn", "Trang Gói du lịch", null, "", 391, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("df961b1d-ac42-ec80-0851-4a7c4930acf3"), "Perlunas thiết kế những hành trình du lịch trong nước tinh tế và trọn vẹn. Tên thương hiệu, triết lý, giá trị cốt lõi, tầm nhìn và sứ mệnh.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "about.meta.desc", "textarea", "about.meta.desc", "Trang Về chúng tôi", null, "", 403, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dfddf7db-e349-53d6-b334-be1bc4c912a0"), "Bạn biết Perlunas qua đâu?", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.source", "text", "LeadForm: Bạn biết Perlunas qua đâu?", "Form liên hệ / đặt", null, "", 352, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e082f0d9-04dc-e7fa-c101-638abcb6223a"), "Perlunas sẽ liên hệ để xác nhận thông tin, kiểm tra phòng với đối tác và phản hồi sớm nhất.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.ok.body", "textarea", "HotelBooking: nội dung thành công", "Form liên hệ / đặt", null, "", 294, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e1089a80-8b44-41b7-394c-d2b45fcfbd78"), "Xoá hạng phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.removeroom", "text", "HotelBooking: nút xoá", "Form liên hệ / đặt", null, "", 303, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e3635807-8b5e-e0ae-e277-82f251c76e72"), "Tour đoàn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "grouppage.meta.title", "text", "grouppage.meta.title", "Trang Tour đoàn", null, "", 398, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e5147b78-f854-62e9-1af1-b2f1cb80d88f"), "Gói du lịch khắp Việt Nam theo ba chuẩn dịch vụ Akoya, Tahiti và South Sea.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combopage.meta.desc", "textarea", "combopage.meta.desc", "Trang Gói du lịch", null, "", 390, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e5acd269-6c06-e802-de64-ece20e74373c"), "Email (không bắt buộc)", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.email", "text", "LeadForm: Email (không bắt buộc)", "Form liên hệ / đặt", null, "", 351, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e736cbad-c232-3a9f-ce71-80853f8832f5"), "Yêu cầu tư vấn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contactpage.meta.title", "text", "contactpage.meta.title", "Trang Liên hệ", null, "", 404, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e8a489f9-58d8-3c94-f75b-cb53274e9259"), "Xem tất cả", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "common.viewall", "text", "Nút xem tất cả", "Thành phần dùng chung", null, "", 268, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ea2d70c7-e4ae-9039-899d-eb66f19c1e7f"), "dưới 5 tuổi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.infants.hint", "text", "HotelBooking: gợi ý em bé", "Form liên hệ / đặt", null, "", 313, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eb9bf8dd-6f46-c738-178c-1e516f37d741"), "Tour ghép lẻ trọn gói", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "nav.tour", "text", "Nav: Tour ghép lẻ trọn gói", "Điều hướng (nav)", null, "", 320, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("edb022d6-5fc2-5b58-dc7a-c719b25603d2"), "Email:", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.label.email", "text", "Footer: Email:", "Footer", null, "", 332, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f8b46b58-55f2-2db5-2538-779df6bd05e3"), "5 đến dưới 12 tuổi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.children.hint", "text", "HotelBooking: gợi ý trẻ em", "Form liên hệ / đặt", null, "", 311, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f97f161c-c324-2a23-72bb-7298e0eba203"), "Chuyến đi của bạn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "lf.trip.title", "text", "LeadForm: Chuyến đi của bạn", "Form liên hệ / đặt", null, "", 340, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("faefac9e-cb3f-0a3f-b78d-be0a8ea400c0"), "Nhận phòng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.checkin", "text", "HotelBooking: nhãn nhận phòng", "Form liên hệ / đặt", null, "", 305, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fb2b67f4-ebbd-aba1-6d2b-660b4a3aaf3c"), "Dịch vụ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.col.services", "text", "Footer: Dịch vụ", "Footer", null, "", 334, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fb329912-be60-f621-4431-e1ba345af112"), "Xem chi tiết", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.viewdetail", "text", "catalog.viewdetail", "Danh mục & bộ lọc (catalog)", null, "", 380, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fd45dbcc-e42b-4595-b7f1-051ca42535c7"), "<section><h2>1. Chính sách đặt dịch vụ &amp; thanh toán</h2><ul><li>Khách hàng đặt cọc trước để giữ chỗ; phần còn lại thanh toán trước ngày khởi hành theo thỏa thuận trong hợp đồng/xác nhận dịch vụ.</li><li>Các hình thức thanh toán: chuyển khoản ngân hàng, tiền mặt tại văn phòng hoặc các kênh thanh toán được Perlunas hỗ trợ.</li><li>Mọi khoản phí, thuế và dịch vụ kèm theo sẽ được thông báo rõ ràng trước khi xác nhận đặt chỗ.</li></ul></section><section><h2>2. Chính sách hoàn &amp; hủy</h2><ul><li>Yêu cầu hủy/đổi lịch cần được gửi bằng văn bản (email/Zalo) tới Perlunas.</li><li>Mức phí hoàn/hủy phụ thuộc vào thời điểm thông báo và quy định của nhà cung cấp dịch vụ (hãng bay, khách sạn, đối tác tour).</li><li>Trường hợp bất khả kháng (thiên tai, dịch bệnh…) sẽ được xử lý theo thỏa thuận và quy định của các bên liên quan.</li></ul></section><section><h2>3. Chính sách bảo mật thông tin</h2><ul><li>Perlunas thu thập thông tin khách hàng chỉ nhằm phục vụ việc tư vấn, đặt và cung cấp dịch vụ.</li><li>Thông tin cá nhân được bảo mật, không chia sẻ cho bên thứ ba ngoài mục đích thực hiện dịch vụ hoặc theo yêu cầu của pháp luật.</li></ul></section><section><h2>4. Trách nhiệm &amp; điều khoản chung</h2><ul><li>Perlunas cam kết cung cấp dịch vụ đúng như mô tả đã xác nhận với khách hàng.</li><li>Khách hàng có trách nhiệm cung cấp thông tin chính xác và tuân thủ các quy định của điểm đến, nhà cung cấp dịch vụ.</li><li>Mọi khiếu nại được tiếp nhận và xử lý qua hotline hoặc email chính thức của công ty.</li></ul></section>", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "policy.body", "richtext", "Policy: body", "Chính sách & Điều khoản", null, "", 360, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fd53c55a-800f-cc45-6983-1c90d88baa81"), "Tháng đi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "hb.month", "text", "HotelBooking: aria tháng", "Form liên hệ / đặt", null, "", 318, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ff21de61-0f82-f412-8ccd-be0da3fb5a82"), "Trước", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "catalog.prev", "text", "Nút trang trước", "Thành phần dùng chung", null, "", 274, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
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
                keyValue: new Guid("031f6ca2-0dec-b058-8c10-f429565f9bcc"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("06648fd2-193d-6a89-1fd5-53fcaba69c99"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("080c7770-b43c-971f-0845-82562ab2f91f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("0861bf41-2e70-b91b-c16a-fa26f2c86f00"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("09035125-2307-3222-9a88-cc0988ebe411"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("09922c7b-aee9-bfac-ebf4-03a10f6d9f6a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("09a11736-5ce7-2b61-4a03-9cd38e88f19c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("0a599923-2f20-8b43-0913-bba38b6455c5"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("0ebe4174-dd24-9f4d-2929-96acbb5f0047"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("130d9cda-2815-253f-725f-aeb1c9587527"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("1327f29a-0ade-ccf0-0cd7-ed1487c0cf0a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("13499153-0f00-5dca-613e-ea13fd5bb2f8"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("13966d77-4e8d-6fd3-349d-dec0e2a2baba"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("1737ae4b-9724-d468-063d-feca0859a7c3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("1a6dba4f-e6f8-e0f4-def9-682da2bccdce"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("1ac0bd90-1e33-20c4-6b33-c08b88d600b3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("1d11386a-e28d-9bbf-7b89-0211acde9705"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("210b1cfb-1fb9-b078-ecaa-4229f10791db"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("237b2d95-85a7-857e-1c40-491601b8758f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("27d12543-3cce-076a-6ec1-57ab39412e83"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("2890e329-26af-5728-ca20-94048b82766e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("28c2783d-3920-bcc5-c536-82f349eedbd0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("29d1adf4-e569-cb43-e011-751dfc5c1faa"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("2dcd6885-59b0-d666-b78b-72f90e033b90"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("30506410-f0be-c425-cdca-25c8bdada7c0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("30b1dfb4-7d60-28ab-2948-c595ce4cf85c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("30ba0b40-3eb0-1b4f-b6b7-1a7de637e8e3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("312cd0d5-1bff-8a4c-fe78-8cb0dea14c96"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("35e4fb8b-ed15-9a4b-8268-71f557cbf3bf"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("3a8a82b0-151b-99b1-50ac-ae58e935d7e6"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("3e5e1a1b-93e0-4432-51cd-2233243a7470"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("3f1115fa-342f-076b-fe76-a2344117eeb0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4115f5b2-efea-fd5e-7f8c-ed828416bd50"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("418c30e7-f848-e596-b6f0-1a38604f4bc3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4329528b-f18d-4d00-0994-c01e0cd2b0f5"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4618648c-a56f-bba5-e3ae-f746450e56e3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("464bc2fd-0ec7-24e8-513d-7cd020383e72"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("47ad2151-f78b-de22-128c-2a485756f172"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4a8b82f4-19ec-9564-7b17-d85ee6ed510b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4cfbefa7-ac42-719a-a7a6-b304a8e593f6"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4d62717b-423a-357a-2420-74c24785fdb9"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4d8508b1-b100-bbda-8583-5f27a8678dfe"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("51ef92b1-68cc-0e68-b31d-7489a74c7702"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("51fc0e17-1cb8-2095-3e97-bd26cdf0eed8"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("53d75004-09ea-c91f-9c92-c0161608a706"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("56811717-edda-3202-0269-aff0bcd08df2"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("56cdda4b-a9ec-a635-0347-91a38070f4e6"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("58722cb0-d2d1-de6a-ac26-0453e99edc3a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("58ba2355-4954-44ae-f307-b6b92ac15fce"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("58ec486f-7bc1-7cc7-732c-f8e9a61ec3f0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5bf3638b-7da2-fd28-f2c4-f3391d3ce68b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5c950fa8-d6e4-09cb-7721-0b59eae183b6"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5cb56590-7cd8-f681-d243-71544f775cf7"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5e5e5fb3-e666-ff25-e9e0-cc4ddc57b78a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5f3f626e-c326-3d27-194a-c31b27d1725e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("62c6fa2b-f905-2c76-28ac-fcb25cb53f9b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("63c23771-88a8-54a5-6d09-256f130b496b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("67739a3e-9141-94bf-09c8-a42a6053e590"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("69e7f6a7-c70b-608c-5136-7aaa1535266f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6d24f408-6bb8-a5b3-71a7-22feca9be42a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6ded1a4d-9c47-7d26-f416-34f601d0cb18"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6ed1ce37-9039-c1ca-5793-2a3d4c15e23a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6edda4ca-3136-10a3-c0ee-95584a9aa1ba"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("74356c43-138a-2523-faf5-7b1b53ac40aa"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("745067d0-f249-771c-42ec-31f4503b2999"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("787f72c2-0887-60e1-2c0e-3024aca5cff4"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("78ec2203-6c0f-9945-c3f5-9a9ebec155cb"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7a2adfc1-dbfc-00d6-85bf-7b1a2e54c446"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7bc6ee92-a057-08c0-c559-e358a49995c5"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("80fb7df5-789e-68c8-f7b7-92a656aa89d7"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("818c9dcf-2045-396e-d1b2-19a01bcb2e7a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("81ba0573-b2bc-208b-b1de-49aa6fcfc16b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("840c0403-c659-219b-5b27-64e5f6256a62"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("84a2e008-a71a-cbfb-3706-ff9f5d522b11"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("87066e5a-a74c-cb13-7059-917280ac52fa"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("873fdab9-f87a-d372-b6fd-3fef9456a63b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8a163f46-b6df-96b9-6649-d9d6206ac24c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8b8b7f55-6f69-821c-2f0e-a94fc654df42"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8d18b1ed-b7a5-b610-9055-cab0a0f35a96"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8fe4e540-24d6-8215-62e4-03fb163c6aa3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("90c5ab5d-af83-39a6-f872-e770e23bb48c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("956e08bd-c5aa-e8d0-13fb-7a6bf28d0d8a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("956fa0ae-ee44-321b-eecb-56a1649011d0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("97ea6459-9f5e-a089-83e0-b3fead86bb9a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9ad2ae33-5f15-c587-34d3-0d521a7bb93e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9c1d191e-a68d-a485-a83f-ca2ddff7afd3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9cedd680-2058-e153-88ec-28ce78cf6469"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a11ee3a1-2a1d-434d-1df8-1cc9ab3efcf3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a324c786-36d1-5e93-d34c-0677ab69733e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a37d6e01-2ad7-48bd-8ce6-dff6a463e0ee"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a59641ed-8664-b566-b2ab-af379af1ba04"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a5a588b5-b48f-24ea-e947-fa7d6e16cefa"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a5ad59da-aef9-9654-ec23-980cc59a58ee"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("a9eada18-69c2-75b1-f563-7eff38b7da7e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ab5fd958-9850-1580-6483-6ee69cf1ea5d"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b1f1e98c-202c-7699-1a43-66b32826f14f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b43cd03e-6e0e-61a5-1db5-73415c7b3bd2"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b51fac01-6dbc-1d83-2e43-ac6464e35c27"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b5db6dd7-6903-41f8-ec85-4a326aa2b644"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("bad1043b-b33f-ec3a-e05b-a05e5c2eeb7b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("bbe8386a-07bd-2236-e0f1-d2dc46f148b8"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("bc40c4e2-c547-bc2a-65cf-119ebb9187a3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("be4383e5-5905-bd8c-1758-a90d5e0fd9ee"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("befdda8f-12b0-1a40-4d8f-24ffc914b3ac"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("bf6a951d-80ad-79d2-1e3d-39083977cf46"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c195cce6-dc62-cd51-408e-c150f90d106b"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c1ef6b7f-b9eb-0bdc-90a6-0c4cfc6ccabf"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c283f696-6a13-204a-d6d3-5575855279a5"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c2a9c70a-40cc-3f07-7c61-e3e47af071ff"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c45e933b-646f-7bca-ce0c-d84b0c98da36"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c6795554-4628-9e2a-2929-2d0446e6a3be"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c949f2ee-be19-d21a-3532-d22256c73891"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("cac8e966-16ed-31b5-6d2a-28bee0507596"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("cbaf6804-39fc-6479-23fe-fddf278e2388"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("cefe5643-2e23-40f2-5e5e-e23a39d703c4"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d2e5787c-95cd-040a-1317-96ecd1788491"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d4b07472-252c-95ea-c774-78cc08cf1c6f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d59a96ca-1c97-bfde-5b8c-847b1b6fcb63"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("d9ab4f74-00da-9e01-fe3e-1e10dd43c9e3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("da536faf-d17e-b5f6-9fb4-5d18e44fd4d6"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("dca4b6c2-0f9b-2f92-40cc-98e78144c3a3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("de5fc51d-4121-cee7-fe84-9ef7f56f2b9a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("df046072-d6e5-b7c3-bc1d-4a979f762ac1"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("df763d97-0f0d-35a0-2c41-673493c852be"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("df961b1d-ac42-ec80-0851-4a7c4930acf3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("dfddf7db-e349-53d6-b334-be1bc4c912a0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e082f0d9-04dc-e7fa-c101-638abcb6223a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e1089a80-8b44-41b7-394c-d2b45fcfbd78"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e3635807-8b5e-e0ae-e277-82f251c76e72"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e5147b78-f854-62e9-1af1-b2f1cb80d88f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e5acd269-6c06-e802-de64-ece20e74373c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e736cbad-c232-3a9f-ce71-80853f8832f5"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("e8a489f9-58d8-3c94-f75b-cb53274e9259"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ea2d70c7-e4ae-9039-899d-eb66f19c1e7f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("eb9bf8dd-6f46-c738-178c-1e516f37d741"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("edb022d6-5fc2-5b58-dc7a-c719b25603d2"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("f8b46b58-55f2-2db5-2538-779df6bd05e3"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("f97f161c-c324-2a23-72bb-7298e0eba203"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("faefac9e-cb3f-0a3f-b78d-be0a8ea400c0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("fb2b67f4-ebbd-aba1-6d2b-660b4a3aaf3c"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("fb329912-be60-f621-4431-e1ba345af112"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("fd45dbcc-e42b-4595-b7f1-051ca42535c7"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("fd53c55a-800f-cc45-6983-1c90d88baa81"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ff21de61-0f82-f412-8ccd-be0da3fb5a82"));

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

            migrationBuilder.InsertData(
                table: "SiteSettings",
                columns: new[] { "Id", "CreatedAt", "Description", "Email", "IsDeleted", "LegalName", "Manifesto", "Name", "OfficesJson", "Phone", "SocialJson", "Tagline", "TaxId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("77777777-7777-7777-7777-777777777772"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Support channel information.", "support@perlunas.local", false, "Perlunas Travel Co., Ltd.", "Support-focused contact settings.", "Perlunas Support", "[]", "+84111111111", "{}", "Always here to help", "0000000000", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("77777777-7777-7777-7777-777777777773"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Branch contact information.", "danang@perlunas.local", false, "Perlunas Da Nang Branch", "Local branch settings.", "Perlunas Da Nang", "[]", "+84222222222", "{}", "Central Vietnam office", "0000000001", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }
    }
}
