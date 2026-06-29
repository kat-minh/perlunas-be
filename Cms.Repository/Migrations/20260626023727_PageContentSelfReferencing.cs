using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class PageContentSelfReferencing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PageContents_Key",
                table: "PageContents");

            migrationBuilder.DropColumn(
                name: "Page",
                table: "PageContents");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "PageContents",
                type: "character varying(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(120)",
                oldMaxLength: 120);

            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "PageContents",
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
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home", "page", "Trang chủ", null, "" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about", "page", "Giới thiệu", null, "" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "contact", "page", "Liên hệ", null, "" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "grouppage", "page", "Tour đoàn", null, "" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "privatepage", "page", "Tour riêng tư", null, "" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "tourspage", "page", "Tour trọn gói", null, "" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "hotelspage", "page", "Khách sạn", null, "" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "combopage", "page", "Combo", null, "" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "combotiers", "page", "Phân loại Combo", null, "" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "footer", "page", "Chung", null, "" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.hero.eyebrow", "text", "Hero · Nhãn", new Guid("00000000-0000-0000-0000-000000000001"), "Thiết kế hành trình du lịch trong nước" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.hero.title", "textarea", "Hero · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000001"), "Mỗi hành trình\nlà một viên ngọc." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.hero.subtitle", "textarea", "Hero · Đoạn mô tả", new Guid("00000000-0000-0000-0000-000000000001"), "Perlunas thiết kế những chuyến đi trong nước đáng nhớ, tinh tế trong từng chi tiết và trọn vẹn từ đầu đến cuối." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.hero.cta.primary", "text", "Hero · Nút chính", new Guid("00000000-0000-0000-0000-000000000001"), "Khám phá hành trình" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.hero.cta.secondary", "Hero · Nút phụ", new Guid("00000000-0000-0000-0000-000000000001"), "Liên hệ tư vấn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.hero.video", "image", "Hero · Video nền (URL)", new Guid("00000000-0000-0000-0000-000000000001"), "/hero-vid.mp4" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.philosophy.eyebrow", "text", "Triết lý · Nhãn", new Guid("00000000-0000-0000-0000-000000000001"), "Triết lý" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.philosophy.text", "Triết lý · Nội dung", new Guid("00000000-0000-0000-0000-000000000001"), "Một hành trình đẹp bắt đầu từ cảm giác bạn mang theo, không phải điểm đến. Vì thế Perlunas không tạo ra những chuyến đi rập khuôn. Chúng tôi lắng nghe từng người, rồi thiết kế một hành trình vừa vặn, chỉn chu trong từng chi tiết. Với chúng tôi, mỗi vị khách là một viên ngọc." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.packagetours.eyebrow", "Tour trọn gói · Nhãn", new Guid("00000000-0000-0000-0000-000000000001"), "Tour trọn gói" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.packagetours.title", "textarea", "Tour trọn gói · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000001"), "Những hành trình đã thiết kế sẵn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.packagetours.subtitle", "Tour trọn gói · Mô tả", new Guid("00000000-0000-0000-0000-000000000001"), "Những trải nghiệm chỉn chu, khơi gợi cảm hứng cho mỗi chuyến đi." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.packagetours.cta", "text", "Tour trọn gói · Nút thẻ", new Guid("00000000-0000-0000-0000-000000000001"), "Xem chi tiết" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.hotels.eyebrow", "text", "Khách sạn · Nhãn", new Guid("00000000-0000-0000-0000-000000000001"), "Khách sạn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.hotels.title", "Khách sạn · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000001"), "Những chỗ nghỉ được tuyển chọn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.hotels.link", "Khách sạn · Liên kết xem thêm", new Guid("00000000-0000-0000-0000-000000000001"), "Xem thêm tất cả khách sạn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.combos.eyebrow", "Combo · Nhãn", new Guid("00000000-0000-0000-0000-000000000001"), "Combo du lịch" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.combos.title", "Combo · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000001"), "Chọn một vùng đất để bắt đầu." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.combos.text", "textarea", "Combo · Mô tả", new Guid("00000000-0000-0000-0000-000000000001"), "Mỗi điểm đến có ba gói combo theo mức độ trải nghiệm: Akoya, Tahiti và South Sea, đặt theo tên ba dòng ngọc trai quý." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.combos.link", "Combo · Liên kết", new Guid("00000000-0000-0000-0000-000000000001"), "Tìm hiểu ba gói ngọc" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.combos.viewall", "text", "Combo · Ô xem tất cả", new Guid("00000000-0000-0000-0000-000000000001"), "Xem tất cả" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.grouptours.title", "textarea", "Tour đoàn · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000001"), "Đoàn đông tới mấy, vẫn trọn vẹn từng người" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.grouptours.p1", "Tour đoàn · Đoạn 1", new Guid("00000000-0000-0000-0000-000000000001"), "Một chuyến đi đoàn không bắt đầu từ số lượng người, mà từ cảm giác mọi người cùng thuộc về một hành trình. Điều khó nhất không phải là đưa nhiều người đi cùng nhau, mà là giữ cho ai cũng thấy mình được quan tâm." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.grouptours.p2", "Tour đoàn · Đoạn 2", new Guid("00000000-0000-0000-0000-000000000001"), "Đó là lý do Perlunas tìm hiểu từng đoàn trước khi lên lịch: mục tiêu, độ tuổi, ngân sách và nhịp đi riêng. Chúng tôi lo trọn từ vận chuyển, lưu trú, ăn uống đến kịch bản gắn kết, với một đầu mối duy nhất xuyên suốt." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.grouptours.p3", "Tour đoàn · Đoạn 3", new Guid("00000000-0000-0000-0000-000000000001"), "Hãy kể cho chúng tôi về đoàn của bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.grouptours.cta", "Tour đoàn · Nút", new Guid("00000000-0000-0000-0000-000000000001"), "Liên hệ tư vấn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.privatetour.eyebrow", "Tour riêng tư · Nhãn", new Guid("00000000-0000-0000-0000-000000000001"), "Tour riêng tư" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.privatetour.title", "textarea", "Tour riêng tư · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000001"), "Hành trình may đo cho riêng bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.privatetour.cta", "text", "Tour riêng tư · Nút", new Guid("00000000-0000-0000-0000-000000000001"), "Đề xuất chi tiết" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.about.eyebrow", "Về chúng tôi · Nhãn", new Guid("00000000-0000-0000-0000-000000000001"), "Về chúng tôi" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.about.image", "image", "Về chúng tôi · Ảnh", new Guid("00000000-0000-0000-0000-000000000001"), "/about.png" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.about.salutation", "Về chúng tôi · Lời chào", new Guid("00000000-0000-0000-0000-000000000001"), "Thân gửi bạn," });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.about.p1", "textarea", "Về chúng tôi · Đoạn 1", new Guid("00000000-0000-0000-0000-000000000001"), "Cảm ơn bạn đã ghé Perlunas. Chúng tôi tin rằng một hành trình đẹp không bắt đầu từ điểm đến, mà từ cảm giác bạn mang theo trên suốt chặng đường." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.about.p2", "textarea", "Về chúng tôi · Đoạn 2", new Guid("00000000-0000-0000-0000-000000000001"), "Vì thế, chúng tôi không tạo ra những chuyến đi rập khuôn. Chúng tôi lắng nghe câu chuyện của từng người, rồi thiết kế một lịch trình vừa vặn — chỉn chu trong từng chi tiết, tinh tế và trọn vẹn từ đầu đến cuối." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.about.p3", "textarea", "Về chúng tôi · Đoạn 3", new Guid("00000000-0000-0000-0000-000000000001"), "Với chúng tôi, mỗi vị khách là một viên ngọc. Và Perlunas xin được là ánh trăng lặng lẽ dõi theo, đồng hành cùng bạn qua thật nhiều hành trình." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.about.signoff", "Về chúng tôi · Lời kết", new Guid("00000000-0000-0000-0000-000000000001"), "Hẹn gặp bạn trên những cung đường," });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.about.signature", "text", "Về chúng tôi · Chữ ký", new Guid("00000000-0000-0000-0000-000000000001"), "Perlunas" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.partners.eyebrow", "text", "Đối tác · Nhãn", new Guid("00000000-0000-0000-0000-000000000001"), "Đối tác đồng hành" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.partners.list", "textarea", "Đối tác · Danh sách", new Guid("00000000-0000-0000-0000-000000000001"), "Vietnam Airlines\nVietravel\nSaigontourist\nMường Thanh\nVinpearl\nBamboo Airways\nAccor Hotels\nSun World\nVietjet Air\nMarriott" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.whyus.title", "Tại sao chọn · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000001"), "Tại sao chọn Perlunas?" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.whyus.1.title", "text", "Lý do 1 · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000001"), "Giá minh bạch" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.whyus.2.title", "text", "Lý do 2 · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000001"), "Tư vấn miễn phí" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.whyus.3.title", "Lý do 3 · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000001"), "Lịch trình may đo" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "home.whyus.4.title", "Lý do 4 · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000001"), "Hỗ trợ tận nơi" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "home.whyus.5.title", "text", "Lý do 5 · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000001"), "Trải nghiệm địa phương" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.eyebrow", "text", "Hero · Nhãn", new Guid("00000000-0000-0000-0000-000000000002"), "Về chúng tôi" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.hero.intro", "textarea", "Hero · Câu tuyên ngôn", new Guid("00000000-0000-0000-0000-000000000002"), "Perlunas không bán những chuyến đi rập khuôn. Chúng tôi thiết kế những hành trình hợp với từng con người: tử tế, tinh tế và trọn vẹn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.hero.image", "image", "Hero · Ảnh lớn", new Guid("00000000-0000-0000-0000-000000000002"), "https://images.unsplash.com/photo-1528127269322-539801943592?fm=jpg&q=60&w=2000" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.pearl.eyebrow", "text", "Pearl · Nhãn", new Guid("00000000-0000-0000-0000-000000000002"), "Tên thương hiệu" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.pearl.title", "Pearl · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000002"), "Pearl" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.pearl.body", "Pearl · Nội dung", new Guid("00000000-0000-0000-0000-000000000002"), "Viên ngọc là bạn, vị khách của chúng tôi. Mỗi người một câu chuyện, nên chuyến đi cũng phải độc bản và của riêng bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.pearl.image", "Pearl · Ảnh", new Guid("00000000-0000-0000-0000-000000000002"), "https://images.unsplash.com/photo-1595345705177-ffe090eb0784?fm=jpg&q=60&w=1200" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.luna.eyebrow", "Luna · Nhãn", new Guid("00000000-0000-0000-0000-000000000002"), "Tên thương hiệu" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.luna.title", "Luna · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000002"), "Luna(s)" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.luna.body", "Luna · Nội dung", new Guid("00000000-0000-0000-0000-000000000002"), "Ánh trăng là Perlunas, lặng lẽ dõi theo và chăm chút từng chi tiết. Chữ “s” nhỏ ở cuối là lời hứa đồng hành bền lâu." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.luna.image", "image", "Luna · Ảnh", new Guid("00000000-0000-0000-0000-000000000002"), "https://images.unsplash.com/photo-1581886573745-4487c55d95f8?fm=jpg&q=60&w=1200" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.vision.eyebrow", "text", "Tầm nhìn · Nhãn", new Guid("00000000-0000-0000-0000-000000000002"), "Tầm nhìn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.vision.body", "textarea", "Tầm nhìn · Nội dung", new Guid("00000000-0000-0000-0000-000000000002"), "Trở thành người đồng hành du lịch trong nước được tin yêu nhất tại Việt Nam." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.vision.image", "image", "Tầm nhìn · Ảnh", new Guid("00000000-0000-0000-0000-000000000002"), "https://images.unsplash.com/photo-1585970661791-9cec67470281?fm=jpg&q=60&w=1200" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.mission.eyebrow", "Sứ mệnh · Nhãn", new Guid("00000000-0000-0000-0000-000000000002"), "Sứ mệnh" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.mission.body", "Sứ mệnh · Nội dung", new Guid("00000000-0000-0000-0000-000000000002"), "Mang những hành trình tử tế, chỉn chu đến gần hơn với mỗi người, để ai cũng có thể đi và trở về trọn vẹn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.mission.image", "image", "Sứ mệnh · Ảnh", new Guid("00000000-0000-0000-0000-000000000002"), "https://images.unsplash.com/photo-1592903204858-e288251ad9cc?fm=jpg&q=60&w=1200" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.values.eyebrow", "Giá trị cốt lõi · Nhãn", new Guid("00000000-0000-0000-0000-000000000002"), "Giá trị cốt lõi" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.values.1.title", "Giá trị 1 · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000002"), "Chân thành" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.values.1.desc", "Giá trị 1 · Mô tả", new Guid("00000000-0000-0000-0000-000000000002"), "Tư vấn thật lòng, đúng nhu cầu và ngân sách của bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.values.2.title", "text", "Giá trị 2 · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000002"), "Tận tâm" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.values.2.desc", "textarea", "Giá trị 2 · Mô tả", new Guid("00000000-0000-0000-0000-000000000002"), "Chăm chút từng chi tiết, theo sát đến khi bạn trở về." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.values.3.title", "Giá trị 3 · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000002"), "Minh bạch" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.values.3.desc", "textarea", "Giá trị 3 · Mô tả", new Guid("00000000-0000-0000-0000-000000000002"), "Báo giá trọn gói rõ ràng, nói được làm được." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.values.4.title", "Giá trị 4 · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000002"), "Bền lâu" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.values.4.desc", "textarea", "Giá trị 4 · Mô tả", new Guid("00000000-0000-0000-0000-000000000002"), "Một người đồng hành đi cùng bạn qua nhiều hành trình." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "about.cta.title", "textarea", "Khối kêu gọi · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000002"), "Cùng Perlunas bắt đầu hành trình của bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "about.cta.button", "Khối kêu gọi · Nút", new Guid("00000000-0000-0000-0000-000000000002"), "Liên hệ tư vấn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "contact.eyebrow", "Hero · Nhãn", new Guid("00000000-0000-0000-0000-000000000003"), "Yêu cầu tư vấn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "contact.hero.title", "textarea", "Hero · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000003"), "Kể cho chúng tôi về chuyến đi của bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "contact.hero.intro", "textarea", "Hero · Đoạn mở đầu", new Guid("00000000-0000-0000-0000-000000000003"), "Sau khi bạn gửi yêu cầu, Perlunas sẽ liên hệ sớm để tư vấn và lên kế hoạch qua Zalo, điện thoại hoặc gặp trực tiếp. Mọi tư vấn và báo giá đều hoàn toàn miễn phí." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "contact.call.label", "Gọi · Nhãn", new Guid("00000000-0000-0000-0000-000000000003"), "Gọi ngay hôm nay" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "contact.call.note", "text", "Gọi · Ghi chú", new Guid("00000000-0000-0000-0000-000000000003"), "Tư vấn nhanh trong giờ làm việc." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "contact.message.label", "text", "Nhắn tin · Nhãn", new Guid("00000000-0000-0000-0000-000000000003"), "Nhắn tin" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "contact.hours.label", "text", "Giờ làm việc · Nhãn", new Guid("00000000-0000-0000-0000-000000000003"), "Giờ làm việc" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "contact.hours.1.day", "Giờ làm việc · Dòng 1 Ngày", new Guid("00000000-0000-0000-0000-000000000003"), "Thứ 2 - Thứ 6" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "contact.hours.1.time", "Giờ làm việc · Dòng 1 Giờ", new Guid("00000000-0000-0000-0000-000000000003"), "8:00 - 21:00" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "contact.hours.2.day", "text", "Giờ làm việc · Dòng 2 Ngày", new Guid("00000000-0000-0000-0000-000000000003"), "Thứ 7" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "contact.hours.2.time", "text", "Giờ làm việc · Dòng 2 Giờ", new Guid("00000000-0000-0000-0000-000000000003"), "8:00 - 20:00" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "contact.hours.3.day", "Giờ làm việc · Dòng 3 Ngày", new Guid("00000000-0000-0000-0000-000000000003"), "Chủ nhật" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "contact.hours.3.time", "Giờ làm việc · Dòng 3 Giờ", new Guid("00000000-0000-0000-0000-000000000003"), "9:00 - 18:00" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "grouppage.eyebrow", "text", "Hero · Nhãn", new Guid("00000000-0000-0000-0000-000000000004"), "Tour đoàn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "grouppage.hero.title", "textarea", "Hero · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000004"), "Đoàn đông tới mấy, vẫn trọn vẹn từng người." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "grouppage.hero.intro", "Hero · Đoạn mở đầu", new Guid("00000000-0000-0000-0000-000000000004"), "Team building, gala dinner, hội nghị kết hợp tham quan — Perlunas lo trọn từ vận chuyển, lưu trú đến kịch bản gắn kết, với một đầu mối duy nhất xuyên suốt hành trình." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "grouppage.hero.image", "image", "Hero · Ảnh lớn", new Guid("00000000-0000-0000-0000-000000000004"), "https://images.unsplash.com/photo-1768881618157-2cc24f7493c6?fm=jpg&q=60&w=2000" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "grouppage.block1.eyebrow", "Khối 1 · Nhãn", new Guid("00000000-0000-0000-0000-000000000004"), "Trước chuyến đi" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "grouppage.block1.title", "text", "Khối 1 · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000004"), "Hiểu đoàn trước khi lên lịch" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "grouppage.block1.body", "Khối 1 · Nội dung", new Guid("00000000-0000-0000-0000-000000000004"), "Chúng tôi tìm hiểu mục tiêu, độ tuổi, ngân sách và nhịp đi riêng của từng đoàn để thiết kế lịch trình phù hợp nhất." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "grouppage.block1.image", "image", "Khối 1 · Ảnh", new Guid("00000000-0000-0000-0000-000000000004"), "https://images.unsplash.com/photo-1774599661329-d9a2f999d1c4?fm=jpg&q=60&w=1000" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "grouppage.block2.eyebrow", "Khối 2 · Nhãn", new Guid("00000000-0000-0000-0000-000000000004"), "Trong chuyến đi" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "grouppage.block2.title", "text", "Khối 2 · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000004"), "Một đầu mối lo trọn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "grouppage.block2.body", "textarea", "Khối 2 · Nội dung", new Guid("00000000-0000-0000-0000-000000000004"), "Vận chuyển, lưu trú, ăn uống, hướng dẫn và các hoạt động gắn kết — tất cả được điều phối bởi một đội ngũ duy nhất." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "grouppage.block2.image", "Khối 2 · Ảnh", new Guid("00000000-0000-0000-0000-000000000004"), "https://images.unsplash.com/photo-1539635278303-d4002c07eae3?fm=jpg&q=60&w=1000" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "Key", "ParentId", "Value" },
                values: new object[] { "grouppage.cta.title", new Guid("00000000-0000-0000-0000-000000000004"), "Hãy kể cho chúng tôi về đoàn của bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "Key", "ParentId" },
                values: new object[] { "grouppage.cta.button", new Guid("00000000-0000-0000-0000-000000000004") });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "Key", "ParentId", "Value" },
                values: new object[] { "privatepage.eyebrow", new Guid("00000000-0000-0000-0000-000000000005"), "Tour riêng tư" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "Key", "ParentId", "Value" },
                values: new object[] { "privatepage.hero.title", new Guid("00000000-0000-0000-0000-000000000005"), "Hành trình may đo cho riêng bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "Key", "ParentId", "Value" },
                values: new object[] { "privatepage.hero.intro", new Guid("00000000-0000-0000-0000-000000000005"), "Mỗi nhóm khách có một nhịp đi riêng. Perlunas thiết kế lịch trình, lưu trú và trải nghiệm theo đúng mong muốn của bạn — linh hoạt từ ngày khởi hành đến từng điểm dừng." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "privatepage.block.eyebrow", "Khối · Nhãn", new Guid("00000000-0000-0000-0000-000000000005"), "Cách chúng tôi làm việc" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "privatepage.block.title", "text", "Khối · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000005"), "Lắng nghe, đề xuất, rồi tinh chỉnh." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "privatepage.block.body", "Khối · Nội dung", new Guid("00000000-0000-0000-0000-000000000005"), "Bạn chia sẻ mong muốn và ngân sách, chúng tôi đề xuất một hành trình chi tiết và điều chỉnh cùng bạn cho đến khi vừa ý." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "privatepage.block.button", "Khối · Nút", new Guid("00000000-0000-0000-0000-000000000005"), "Đề xuất chi tiết" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "privatepage.block.image", "image", "Khối · Ảnh", new Guid("00000000-0000-0000-0000-000000000005"), "https://images.unsplash.com/photo-1566759996874-04d713cc224a?fm=jpg&q=60&w=1000" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "privatepage.cta.title", "Khối kêu gọi · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000005"), "Bắt đầu thiết kế hành trình của riêng bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "privatepage.cta.button", "Khối kêu gọi · Nút", new Guid("00000000-0000-0000-0000-000000000005"), "Liên hệ tư vấn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "Key", "ParentId", "Value" },
                values: new object[] { "tourspage.eyebrow", new Guid("00000000-0000-0000-0000-000000000006"), "Tour trọn gói" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "Key", "ParentId", "Value" },
                values: new object[] { "tourspage.hero.title", new Guid("00000000-0000-0000-0000-000000000006"), "Xách balo lên và đi, phần còn lại để Perlunas lo." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "Key", "ParentId", "Value" },
                values: new object[] { "tourspage.hero.intro", new Guid("00000000-0000-0000-0000-000000000006"), "Lịch khởi hành đều đặn, giá trọn gói rõ ràng, không phát sinh." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "hotelspage.eyebrow", "Hero · Nhãn", new Guid("00000000-0000-0000-0000-000000000007"), "Khách sạn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "hotelspage.hero.title", "Hero · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000007"), "Chỗ nghỉ trên khắp Việt Nam." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "hotelspage.hero.intro", "textarea", "Hero · Đoạn mở đầu", new Guid("00000000-0000-0000-0000-000000000007"), "Mặc định là những chỗ nghỉ Perlunas tuyển chọn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "hotelspage.upsell.eyebrow", "Upsell · Nhãn", new Guid("00000000-0000-0000-0000-000000000007"), "Nâng tầm trải nghiệm" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "hotelspage.upsell.title", "Upsell · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000007"), "Không chỉ là đặt phòng, hãy đi cùng một combo trọn vẹn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "hotelspage.upsell.body", "Upsell · Nội dung", new Guid("00000000-0000-0000-0000-000000000007"), "Combo du lịch kết hợp lưu trú, di chuyển và trải nghiệm theo ba mức: Akoya, Tahiti và South Sea." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "hotelspage.upsell.button", "Upsell · Nút", new Guid("00000000-0000-0000-0000-000000000007"), "Khám phá Combo du lịch" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "combopage.eyebrow", "text", "Hero · Nhãn", new Guid("00000000-0000-0000-0000-000000000008"), "Combo du lịch" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "combopage.hero.title", "Hero · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000008"), "Combo trọn gói khắp Việt Nam." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "combopage.hero.intro", "textarea", "Hero · Đoạn mở đầu", new Guid("00000000-0000-0000-0000-000000000008"), "Mỗi combo kết hợp lưu trú, di chuyển và trải nghiệm theo một trong ba chuẩn dịch vụ." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "combopage.cta.title", "text", "Khối kêu gọi · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000008"), "Chưa biết chọn combo nào?" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "Key", "Kind", "Label", "ParentId", "Value" },
                values: new object[] { "combopage.cta.body", "textarea", "Khối kêu gọi · Nội dung", new Guid("00000000-0000-0000-0000-000000000008"), "Để lại thông tin, Perlunas tư vấn gói phù hợp với bạn, miễn phí." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "combopage.cta.button", "Khối kêu gọi · Nút", new Guid("00000000-0000-0000-0000-000000000008"), "Nhận tư vấn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "Key", "Label", "ParentId", "Value" },
                values: new object[] { "combotiers.eyebrow", "Hero · Nhãn", new Guid("00000000-0000-0000-0000-000000000009"), "Phân loại Combo" });

            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "ParentId", "SortOrder", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000137"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.hero.title", "textarea", "Hero · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000009"), 137, null, "Ba viên ngọc, ba chuẩn dịch vụ." },
                    { new Guid("00000000-0000-0000-0000-000000000138"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.hero.intro", "textarea", "Hero · Đoạn mở đầu", new Guid("00000000-0000-0000-0000-000000000009"), 138, null, "Akoya, Tahiti và South Sea là ba chuẩn dịch vụ Perlunas đặt ra." },
                    { new Guid("00000000-0000-0000-0000-000000000139"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.choose.eyebrow", "text", "Cách chọn gói · Nhãn", new Guid("00000000-0000-0000-0000-000000000009"), 139, null, "Cách chọn gói" },
                    { new Guid("00000000-0000-0000-0000-000000000140"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.choose.title", "textarea", "Cách chọn gói · Tiêu đề", new Guid("00000000-0000-0000-0000-000000000009"), 140, null, "Chọn gói phù hợp với nhu cầu của bạn." },
                    { new Guid("00000000-0000-0000-0000-000000000141"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.choose.body", "textarea", "Cách chọn gói · Nội dung", new Guid("00000000-0000-0000-0000-000000000009"), 141, null, "Mỗi gói phù hợp với một kiểu chuyến đi khác nhau." },
                    { new Guid("00000000-0000-0000-0000-000000000142"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.choose.button", "text", "Cách chọn gói · Nút", new Guid("00000000-0000-0000-0000-000000000009"), 142, null, "Nhận tư vấn chọn gói" },
                    { new Guid("00000000-0000-0000-0000-000000000143"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.tagline", "textarea", "Footer · Mô tả thương hiệu", new Guid("00000000-0000-0000-0000-000000000010"), 143, null, "Mỗi hành trình là một viên ngọc dưới ánh trăng. Thiết kế những hành trình du lịch trong nước tinh tế và trọn vẹn." },
                    { new Guid("00000000-0000-0000-0000-000000000144"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.newsletter.eyebrow", "text", "Footer · Newsletter nhãn", new Guid("00000000-0000-0000-0000-000000000010"), 144, null, "Nhận tư vấn từ Perlunas" },
                    { new Guid("00000000-0000-0000-0000-000000000145"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.newsletter.note", "text", "Footer · Newsletter ghi chú", new Guid("00000000-0000-0000-0000-000000000010"), 145, null, "Để lại email, Perlunas sẽ liên hệ tư vấn miễn phí." },
                    { new Guid("00000000-0000-0000-0000-000000000146"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "footer.legal.tagline", "text", "Footer · Câu cuối", new Guid("00000000-0000-0000-0000-000000000010"), 146, null, "Mỗi hành trình là một viên ngọc dưới ánh trăng." }
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
                name: "IX_PageContents_ParentId",
                table: "PageContents",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_PageContents_PageContents_ParentId",
                table: "PageContents",
                column: "ParentId",
                principalTable: "PageContents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageContents_PageContents_ParentId",
                table: "PageContents");

            migrationBuilder.DropIndex(
                name: "IX_PageContents_ParentId",
                table: "PageContents");

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"));

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "PageContents");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "PageContents",
                type: "character varying(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Page",
                table: "PageContents",
                type: "text",
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
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.hero.eyebrow", "text", "Hero · Nhãn", "Trang chủ", "Thiết kế hành trình du lịch trong nước" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.hero.title", "textarea", "Hero · Tiêu đề", "Trang chủ", "Mỗi hành trình\nlà một viên ngọc." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.hero.subtitle", "textarea", "Hero · Đoạn mô tả", "Trang chủ", "Perlunas thiết kế những chuyến đi trong nước đáng nhớ, tinh tế trong từng chi tiết và trọn vẹn từ đầu đến cuối." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.hero.cta.primary", "text", "Hero · Nút chính", "Trang chủ", "Khám phá hành trình" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.hero.cta.secondary", "text", "Hero · Nút phụ", "Trang chủ", "Liên hệ tư vấn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.hero.video", "image", "Hero · Video nền (URL)", "Trang chủ", "/hero-vid.mp4" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.philosophy.eyebrow", "text", "Triết lý · Nhãn", "Trang chủ", "Triết lý" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.philosophy.text", "textarea", "Triết lý · Nội dung", "Trang chủ", "Một hành trình đẹp bắt đầu từ cảm giác bạn mang theo, không phải điểm đến. Vì thế Perlunas không tạo ra những chuyến đi rập khuôn. Chúng tôi lắng nghe từng người, rồi thiết kế một hành trình vừa vặn, chỉn chu trong từng chi tiết. Với chúng tôi, mỗi vị khách là một viên ngọc." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.packagetours.eyebrow", "text", "Tour trọn gói · Nhãn", "Trang chủ", "Tour trọn gói" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.packagetours.title", "textarea", "Tour trọn gói · Tiêu đề", "Trang chủ", "Những hành trình đã thiết kế sẵn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.packagetours.subtitle", "textarea", "Tour trọn gói · Mô tả", "Trang chủ", "Những trải nghiệm chỉn chu, khơi gợi cảm hứng cho mỗi chuyến đi." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.packagetours.cta", "text", "Tour trọn gói · Nút thẻ", "Trang chủ", "Xem chi tiết" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.hotels.eyebrow", "text", "Khách sạn · Nhãn", "Trang chủ", "Khách sạn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.hotels.title", "textarea", "Khách sạn · Tiêu đề", "Trang chủ", "Những chỗ nghỉ được tuyển chọn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.hotels.link", "Khách sạn · Liên kết xem thêm", "Trang chủ", "Xem thêm tất cả khách sạn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.combos.eyebrow", "text", "Combo · Nhãn", "Trang chủ", "Combo du lịch" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.combos.title", "textarea", "Combo · Tiêu đề", "Trang chủ", "Chọn một vùng đất để bắt đầu." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.combos.text", "Combo · Mô tả", "Trang chủ", "Mỗi điểm đến có ba gói combo theo mức độ trải nghiệm: Akoya, Tahiti và South Sea, đặt theo tên ba dòng ngọc trai quý." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.combos.link", "Combo · Liên kết", "Trang chủ", "Tìm hiểu ba gói ngọc" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.combos.viewall", "text", "Combo · Ô xem tất cả", "Trang chủ", "Xem tất cả" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.grouptours.title", "Tour đoàn · Tiêu đề", "Trang chủ", "Đoàn đông tới mấy, vẫn trọn vẹn từng người" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.grouptours.p1", "textarea", "Tour đoàn · Đoạn 1", "Trang chủ", "Một chuyến đi đoàn không bắt đầu từ số lượng người, mà từ cảm giác mọi người cùng thuộc về một hành trình. Điều khó nhất không phải là đưa nhiều người đi cùng nhau, mà là giữ cho ai cũng thấy mình được quan tâm." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.grouptours.p2", "textarea", "Tour đoàn · Đoạn 2", "Trang chủ", "Đó là lý do Perlunas tìm hiểu từng đoàn trước khi lên lịch: mục tiêu, độ tuổi, ngân sách và nhịp đi riêng. Chúng tôi lo trọn từ vận chuyển, lưu trú, ăn uống đến kịch bản gắn kết, với một đầu mối duy nhất xuyên suốt." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.grouptours.p3", "Tour đoàn · Đoạn 3", "Trang chủ", "Hãy kể cho chúng tôi về đoàn của bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.grouptours.cta", "Tour đoàn · Nút", "Trang chủ", "Liên hệ tư vấn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.privatetour.eyebrow", "Tour riêng tư · Nhãn", "Trang chủ", "Tour riêng tư" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.privatetour.title", "Tour riêng tư · Tiêu đề", "Trang chủ", "Hành trình may đo cho riêng bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.privatetour.cta", "text", "Tour riêng tư · Nút", "Trang chủ", "Đề xuất chi tiết" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.about.eyebrow", "Về chúng tôi · Nhãn", "Trang chủ", "Về chúng tôi" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.about.image", "image", "Về chúng tôi · Ảnh", "Trang chủ", "/about.png" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.about.salutation", "text", "Về chúng tôi · Lời chào", "Trang chủ", "Thân gửi bạn," });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.about.p1", "Về chúng tôi · Đoạn 1", "Trang chủ", "Cảm ơn bạn đã ghé Perlunas. Chúng tôi tin rằng một hành trình đẹp không bắt đầu từ điểm đến, mà từ cảm giác bạn mang theo trên suốt chặng đường." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.about.p2", "Về chúng tôi · Đoạn 2", "Trang chủ", "Vì thế, chúng tôi không tạo ra những chuyến đi rập khuôn. Chúng tôi lắng nghe câu chuyện của từng người, rồi thiết kế một lịch trình vừa vặn — chỉn chu trong từng chi tiết, tinh tế và trọn vẹn từ đầu đến cuối." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.about.p3", "Về chúng tôi · Đoạn 3", "Trang chủ", "Với chúng tôi, mỗi vị khách là một viên ngọc. Và Perlunas xin được là ánh trăng lặng lẽ dõi theo, đồng hành cùng bạn qua thật nhiều hành trình." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.about.signoff", "Về chúng tôi · Lời kết", "Trang chủ", "Hẹn gặp bạn trên những cung đường," });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.about.signature", "Về chúng tôi · Chữ ký", "Trang chủ", "Perlunas" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.partners.eyebrow", "text", "Đối tác · Nhãn", "Trang chủ", "Đối tác đồng hành" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.partners.list", "textarea", "Đối tác · Danh sách", "Trang chủ", "Vietnam Airlines\nVietravel\nSaigontourist\nMường Thanh\nVinpearl\nBamboo Airways\nAccor Hotels\nSun World\nVietjet Air\nMarriott" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.whyus.title", "Tại sao chọn · Tiêu đề", "Trang chủ", "Tại sao chọn Perlunas?" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.whyus.1.title", "text", "Lý do 1 · Tiêu đề", "Trang chủ", "Giá minh bạch" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "home.whyus.2.title", "Lý do 2 · Tiêu đề", "Trang chủ", "Tư vấn miễn phí" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.whyus.3.title", "text", "Lý do 3 · Tiêu đề", "Trang chủ", "Lịch trình may đo" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.whyus.4.title", "text", "Lý do 4 · Tiêu đề", "Trang chủ", "Hỗ trợ tận nơi" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "home.whyus.5.title", "text", "Lý do 5 · Tiêu đề", "Trang chủ", "Trải nghiệm địa phương" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "about.eyebrow", "Hero · Nhãn", "Giới thiệu", "Về chúng tôi" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.hero.intro", "textarea", "Hero · Câu tuyên ngôn", "Giới thiệu", "Perlunas không bán những chuyến đi rập khuôn. Chúng tôi thiết kế những hành trình hợp với từng con người: tử tế, tinh tế và trọn vẹn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.hero.image", "image", "Hero · Ảnh lớn", "Giới thiệu", "https://images.unsplash.com/photo-1528127269322-539801943592?fm=jpg&q=60&w=2000" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.pearl.eyebrow", "text", "Pearl · Nhãn", "Giới thiệu", "Tên thương hiệu" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "about.pearl.title", "Pearl · Tiêu đề", "Giới thiệu", "Pearl" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.pearl.body", "textarea", "Pearl · Nội dung", "Giới thiệu", "Viên ngọc là bạn, vị khách của chúng tôi. Mỗi người một câu chuyện, nên chuyến đi cũng phải độc bản và của riêng bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.pearl.image", "image", "Pearl · Ảnh", "Giới thiệu", "https://images.unsplash.com/photo-1595345705177-ffe090eb0784?fm=jpg&q=60&w=1200" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "about.luna.eyebrow", "Luna · Nhãn", "Giới thiệu", "Tên thương hiệu" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "about.luna.title", "Luna · Tiêu đề", "Giới thiệu", "Luna(s)" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.luna.body", "textarea", "Luna · Nội dung", "Giới thiệu", "Ánh trăng là Perlunas, lặng lẽ dõi theo và chăm chút từng chi tiết. Chữ “s” nhỏ ở cuối là lời hứa đồng hành bền lâu." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.luna.image", "image", "Luna · Ảnh", "Giới thiệu", "https://images.unsplash.com/photo-1581886573745-4487c55d95f8?fm=jpg&q=60&w=1200" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.vision.eyebrow", "text", "Tầm nhìn · Nhãn", "Giới thiệu", "Tầm nhìn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.vision.body", "textarea", "Tầm nhìn · Nội dung", "Giới thiệu", "Trở thành người đồng hành du lịch trong nước được tin yêu nhất tại Việt Nam." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.vision.image", "image", "Tầm nhìn · Ảnh", "Giới thiệu", "https://images.unsplash.com/photo-1585970661791-9cec67470281?fm=jpg&q=60&w=1200" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "about.mission.eyebrow", "Sứ mệnh · Nhãn", "Giới thiệu", "Sứ mệnh" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "about.mission.body", "Sứ mệnh · Nội dung", "Giới thiệu", "Mang những hành trình tử tế, chỉn chu đến gần hơn với mỗi người, để ai cũng có thể đi và trở về trọn vẹn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "about.mission.image", "Sứ mệnh · Ảnh", "Giới thiệu", "https://images.unsplash.com/photo-1592903204858-e288251ad9cc?fm=jpg&q=60&w=1200" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "about.values.eyebrow", "Giá trị cốt lõi · Nhãn", "Giới thiệu", "Giá trị cốt lõi" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "about.values.1.title", "Giá trị 1 · Tiêu đề", "Giới thiệu", "Chân thành" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "about.values.1.desc", "Giá trị 1 · Mô tả", "Giới thiệu", "Tư vấn thật lòng, đúng nhu cầu và ngân sách của bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.values.2.title", "text", "Giá trị 2 · Tiêu đề", "Giới thiệu", "Tận tâm" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.values.2.desc", "textarea", "Giá trị 2 · Mô tả", "Giới thiệu", "Chăm chút từng chi tiết, theo sát đến khi bạn trở về." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.values.3.title", "text", "Giá trị 3 · Tiêu đề", "Giới thiệu", "Minh bạch" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.values.3.desc", "textarea", "Giá trị 3 · Mô tả", "Giới thiệu", "Báo giá trọn gói rõ ràng, nói được làm được." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "about.values.4.title", "Giá trị 4 · Tiêu đề", "Giới thiệu", "Bền lâu" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "about.values.4.desc", "Giá trị 4 · Mô tả", "Giới thiệu", "Một người đồng hành đi cùng bạn qua nhiều hành trình." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "about.cta.title", "textarea", "Khối kêu gọi · Tiêu đề", "Giới thiệu", "Cùng Perlunas bắt đầu hành trình của bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "about.cta.button", "Khối kêu gọi · Nút", "Giới thiệu", "Liên hệ tư vấn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "contact.eyebrow", "Hero · Nhãn", "Liên hệ", "Yêu cầu tư vấn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "contact.hero.title", "Hero · Tiêu đề", "Liên hệ", "Kể cho chúng tôi về chuyến đi của bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "contact.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Liên hệ", "Sau khi bạn gửi yêu cầu, Perlunas sẽ liên hệ sớm để tư vấn và lên kế hoạch qua Zalo, điện thoại hoặc gặp trực tiếp. Mọi tư vấn và báo giá đều hoàn toàn miễn phí." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "contact.call.label", "text", "Gọi · Nhãn", "Liên hệ", "Gọi ngay hôm nay" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "contact.call.note", "Gọi · Ghi chú", "Liên hệ", "Tư vấn nhanh trong giờ làm việc." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "contact.message.label", "text", "Nhắn tin · Nhãn", "Liên hệ", "Nhắn tin" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "contact.hours.label", "Giờ làm việc · Nhãn", "Liên hệ", "Giờ làm việc" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "contact.hours.1.day", "text", "Giờ làm việc · Dòng 1 Ngày", "Liên hệ", "Thứ 2 - Thứ 6" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "contact.hours.1.time", "text", "Giờ làm việc · Dòng 1 Giờ", "Liên hệ", "8:00 - 21:00" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "contact.hours.2.day", "Giờ làm việc · Dòng 2 Ngày", "Liên hệ", "Thứ 7" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "contact.hours.2.time", "Giờ làm việc · Dòng 2 Giờ", "Liên hệ", "8:00 - 20:00" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "contact.hours.3.day", "text", "Giờ làm việc · Dòng 3 Ngày", "Liên hệ", "Chủ nhật" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "contact.hours.3.time", "text", "Giờ làm việc · Dòng 3 Giờ", "Liên hệ", "9:00 - 18:00" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "grouppage.eyebrow", "Hero · Nhãn", "Tour đoàn", "Tour đoàn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "grouppage.hero.title", "textarea", "Hero · Tiêu đề", "Tour đoàn", "Đoàn đông tới mấy, vẫn trọn vẹn từng người." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "grouppage.hero.intro", "textarea", "Hero · Đoạn mở đầu", "Tour đoàn", "Team building, gala dinner, hội nghị kết hợp tham quan — Perlunas lo trọn từ vận chuyển, lưu trú đến kịch bản gắn kết, với một đầu mối duy nhất xuyên suốt hành trình." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "grouppage.hero.image", "image", "Hero · Ảnh lớn", "Tour đoàn", "https://images.unsplash.com/photo-1768881618157-2cc24f7493c6?fm=jpg&q=60&w=2000" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "grouppage.block1.eyebrow", "Khối 1 · Nhãn", "Tour đoàn", "Trước chuyến đi" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "grouppage.block1.title", "Khối 1 · Tiêu đề", "Tour đoàn", "Hiểu đoàn trước khi lên lịch" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "grouppage.block1.body", "textarea", "Khối 1 · Nội dung", "Tour đoàn", "Chúng tôi tìm hiểu mục tiêu, độ tuổi, ngân sách và nhịp đi riêng của từng đoàn để thiết kế lịch trình phù hợp nhất." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "grouppage.block1.image", "image", "Khối 1 · Ảnh", "Tour đoàn", "https://images.unsplash.com/photo-1774599661329-d9a2f999d1c4?fm=jpg&q=60&w=1000" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "grouppage.block2.eyebrow", "Khối 2 · Nhãn", "Tour đoàn", "Trong chuyến đi" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "grouppage.block2.title", "Khối 2 · Tiêu đề", "Tour đoàn", "Một đầu mối lo trọn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "grouppage.block2.body", "textarea", "Khối 2 · Nội dung", "Tour đoàn", "Vận chuyển, lưu trú, ăn uống, hướng dẫn và các hoạt động gắn kết — tất cả được điều phối bởi một đội ngũ duy nhất." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "grouppage.block2.image", "image", "Khối 2 · Ảnh", "Tour đoàn", "https://images.unsplash.com/photo-1539635278303-d4002c07eae3?fm=jpg&q=60&w=1000" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "grouppage.cta.title", "Khối kêu gọi · Tiêu đề", "Tour đoàn", "Hãy kể cho chúng tôi về đoàn của bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "grouppage.cta.button", "text", "Khối kêu gọi · Nút", "Tour đoàn", "Liên hệ tư vấn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "privatepage.eyebrow", "Hero · Nhãn", "Tour riêng tư", "Tour riêng tư" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "privatepage.hero.title", "textarea", "Hero · Tiêu đề", "Tour riêng tư", "Hành trình may đo cho riêng bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "privatepage.hero.intro", "Hero · Đoạn mở đầu", "Tour riêng tư", "Mỗi nhóm khách có một nhịp đi riêng. Perlunas thiết kế lịch trình, lưu trú và trải nghiệm theo đúng mong muốn của bạn — linh hoạt từ ngày khởi hành đến từng điểm dừng." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "privatepage.block.eyebrow", "text", "Khối · Nhãn", "Tour riêng tư", "Cách chúng tôi làm việc" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "privatepage.block.title", "Khối · Tiêu đề", "Tour riêng tư", "Lắng nghe, đề xuất, rồi tinh chỉnh." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "privatepage.block.body", "textarea", "Khối · Nội dung", "Tour riêng tư", "Bạn chia sẻ mong muốn và ngân sách, chúng tôi đề xuất một hành trình chi tiết và điều chỉnh cùng bạn cho đến khi vừa ý." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "privatepage.block.button", "text", "Khối · Nút", "Tour riêng tư", "Đề xuất chi tiết" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "privatepage.block.image", "Khối · Ảnh", "Tour riêng tư", "https://images.unsplash.com/photo-1566759996874-04d713cc224a?fm=jpg&q=60&w=1000" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "Key", "Page", "Value" },
                values: new object[] { "privatepage.cta.title", "Tour riêng tư", "Bắt đầu thiết kế hành trình của riêng bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "Key", "Page" },
                values: new object[] { "privatepage.cta.button", "Tour riêng tư" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "Key", "Page", "Value" },
                values: new object[] { "tourspage.eyebrow", "Tour trọn gói", "Tour trọn gói" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "Key", "Page", "Value" },
                values: new object[] { "tourspage.hero.title", "Tour trọn gói", "Xách balo lên và đi, phần còn lại để Perlunas lo." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "Key", "Page", "Value" },
                values: new object[] { "tourspage.hero.intro", "Tour trọn gói", "Lịch khởi hành đều đặn, giá trọn gói rõ ràng, không phát sinh." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "hotelspage.eyebrow", "Hero · Nhãn", "Khách sạn", "Khách sạn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "hotelspage.hero.title", "textarea", "Hero · Tiêu đề", "Khách sạn", "Chỗ nghỉ trên khắp Việt Nam." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "hotelspage.hero.intro", "Hero · Đoạn mở đầu", "Khách sạn", "Mặc định là những chỗ nghỉ Perlunas tuyển chọn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "hotelspage.upsell.eyebrow", "Upsell · Nhãn", "Khách sạn", "Nâng tầm trải nghiệm" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "hotelspage.upsell.title", "textarea", "Upsell · Tiêu đề", "Khách sạn", "Không chỉ là đặt phòng, hãy đi cùng một combo trọn vẹn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "hotelspage.upsell.body", "Upsell · Nội dung", "Khách sạn", "Combo du lịch kết hợp lưu trú, di chuyển và trải nghiệm theo ba mức: Akoya, Tahiti và South Sea." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "hotelspage.upsell.button", "Upsell · Nút", "Khách sạn", "Khám phá Combo du lịch" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "Key", "Page", "Value" },
                values: new object[] { "combopage.eyebrow", "Combo", "Combo du lịch" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "Key", "Page", "Value" },
                values: new object[] { "combopage.hero.title", "Combo", "Combo trọn gói khắp Việt Nam." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "Key", "Page", "Value" },
                values: new object[] { "combopage.hero.intro", "Combo", "Mỗi combo kết hợp lưu trú, di chuyển và trải nghiệm theo một trong ba chuẩn dịch vụ." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "combopage.cta.title", "Khối kêu gọi · Tiêu đề", "Combo", "Chưa biết chọn combo nào?" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "combopage.cta.body", "Khối kêu gọi · Nội dung", "Combo", "Để lại thông tin, Perlunas tư vấn gói phù hợp với bạn, miễn phí." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "combopage.cta.button", "text", "Khối kêu gọi · Nút", "Combo", "Nhận tư vấn" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "combotiers.eyebrow", "Hero · Nhãn", "Phân loại Combo", "Phân loại Combo" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "combotiers.hero.title", "Hero · Tiêu đề", "Phân loại Combo", "Ba viên ngọc, ba chuẩn dịch vụ." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "combotiers.hero.intro", "Hero · Đoạn mở đầu", "Phân loại Combo", "Akoya, Tahiti và South Sea là ba chuẩn dịch vụ Perlunas đặt ra." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "combotiers.choose.eyebrow", "Cách chọn gói · Nhãn", "Phân loại Combo", "Cách chọn gói" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "combotiers.choose.title", "textarea", "Cách chọn gói · Tiêu đề", "Phân loại Combo", "Chọn gói phù hợp với nhu cầu của bạn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "combotiers.choose.body", "Cách chọn gói · Nội dung", "Phân loại Combo", "Mỗi gói phù hợp với một kiểu chuyến đi khác nhau." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "combotiers.choose.button", "text", "Cách chọn gói · Nút", "Phân loại Combo", "Nhận tư vấn chọn gói" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "footer.tagline", "textarea", "Footer · Mô tả thương hiệu", "Chung", "Mỗi hành trình là một viên ngọc dưới ánh trăng. Thiết kế những hành trình du lịch trong nước tinh tế và trọn vẹn." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "Key", "Kind", "Label", "Page", "Value" },
                values: new object[] { "footer.newsletter.eyebrow", "text", "Footer · Newsletter nhãn", "Chung", "Nhận tư vấn từ Perlunas" });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "footer.newsletter.note", "Footer · Newsletter ghi chú", "Chung", "Để lại email, Perlunas sẽ liên hệ tư vấn miễn phí." });

            migrationBuilder.UpdateData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "Key", "Label", "Page", "Value" },
                values: new object[] { "footer.legal.tagline", "Footer · Câu cuối", "Chung", "Mỗi hành trình là một viên ngọc dưới ánh trăng." });

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
                name: "IX_PageContents_Key",
                table: "PageContents",
                column: "Key",
                unique: true);
        }
    }
}
