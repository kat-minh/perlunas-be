using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedContentBatch2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0d9abcf6-a079-6034-804d-a816c7412e6a"), "Trải nghiệm đậm sâu", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tier.tahiti.tagline", "text", "Tahiti: tagline", "Phân loại Combo", null, "", 234, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("129e7532-e258-e0b8-5c65-d25a2cd7a35d"), "Khởi đầu tinh tế", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tier.akoya.tagline", "text", "Akoya: tagline", "Phân loại Combo", null, "", 230, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("14bfef19-0f2e-c0ab-6ea2-d10846aa6165"), "Team building của đoàn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.img2.alt", "text", "Ảnh tour đoàn 2: chú thích", "Trang chủ", null, "", 247, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("21674a05-cd12-274c-5231-3623b3c52e23"), "Cặp đôi", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.img2.alt", "text", "Ảnh tour riêng 2: chú thích", "Trang chủ", null, "", 255, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3795d469-f979-ab1d-3982-048f7ab06fad"), "perlunas-private-honeymoon", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.img4", "image", "Ảnh tour riêng 4", "Trang chủ", null, "", 258, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("434d8bd7-d7ee-4dcc-a91f-fe51fc0da12e"), "perlunas-private-solo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.img5", "image", "Ảnh tour riêng 5", "Trang chủ", null, "", 260, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4a28d15d-0695-f7cf-2aeb-a310a2e88b58"), "Ngọc Tahiti mang sắc huyền bí của biển sâu, ánh lên những tầng màu khó quên, hiếm và cá tính.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tier.tahiti.pearl", "textarea", "Tahiti: mô tả ngọc", "Phân loại Combo", null, "", 235, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5d13f0a8-05fb-f0a2-9d45-0f502026eeda"), "Ngọc Akoya nhỏ nhắn, tròn đều và sáng trong, là dòng ngọc cổ điển làm nên vẻ đẹp thanh lịch quen thuộc.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tier.akoya.pearl", "textarea", "Akoya: mô tả ngọc", "Phân loại Combo", null, "", 231, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("615df596-1989-81db-f04b-3d44e858cc32"), "Trọn vẹn thượng hạng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tier.south-sea.tagline", "text", "South Sea: tagline", "Phân loại Combo", null, "", 238, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("61d98f5d-dc3c-fe11-a09c-833983fb40ba"), "Khách sạn 4-5 sao\nXe riêng cho nhóm\nĂn sáng và một số bữa đặc sản\nHướng dẫn viên xuyên suốt\nTrải nghiệm địa phương riêng (lớp nấu ăn, làng nghề…)", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tier.tahiti.includes", "textarea", "Tahiti: gồm có (mỗi dòng 1 mục)", "Phân loại Combo", null, "", 237, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("623d9413-c1ef-fe43-fd8c-bb8d9ae2dc25"), "perlunas-private-family", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.img1", "image", "Ảnh tour riêng 1", "Trang chủ", null, "", 252, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("663741eb-947c-e7c8-d395-c33f255b8fca"), "Gói khởi đầu vừa vặn: gọn gàng, chỉn chu, đủ đầy những điều quan trọng nhất cho một chuyến đi nhẹ nhàng.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tier.akoya.story", "textarea", "Akoya: story", "Phân loại Combo", null, "", 232, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6cb5cb99-ca03-8462-0dc3-2868083e33a5"), "Resort/khách sạn 5 sao\nXe riêng và tài xế suốt hành trình\nTrọn bữa, nhà hàng chọn lọc\nTrải nghiệm độc quyền, vé ưu tiên\nHỗ trợ concierge 24/7", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tier.south-sea.includes", "textarea", "South Sea: gồm có (mỗi dòng 1 mục)", "Phân loại Combo", null, "", 241, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6d3dc16e-2dd0-38be-de3a-b19ba3a4bb5f"), "perlunas-private-friends", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.img3", "image", "Ảnh tour riêng 3", "Trang chủ", null, "", 256, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6e775a52-97af-2c49-8b8c-e8a76eebe2e0"), "Khoảnh khắc cùng đoàn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.img4.alt", "text", "Ảnh tour đoàn 4: chú thích", "Trang chủ", null, "", 251, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7d5902e2-6c3c-f360-b407-c07834e32080"), "perlunas-private-couples", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.img2", "image", "Ảnh tour riêng 2", "Trang chủ", null, "", 254, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("80f6cd83-e9da-4c4f-02f5-2150fcdc6ff4"), "Gói trọn vẹn nhất: chăm chút từng chi tiết, riêng tư và thượng hạng từ đầu đến cuối hành trình.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tier.south-sea.story", "textarea", "South Sea: story", "Phân loại Combo", null, "", 240, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("862a5926-b13d-712b-730a-153a313a5ff0"), "perlunas-group-celebrate", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.img4", "image", "Ảnh tour đoàn 4", "Trang chủ", null, "", 250, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("86e9f9bf-b734-7fea-437a-fc2954de2221"), "Đoàn đang tham quan", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.img3.alt", "text", "Ảnh tour đoàn 3: chú thích", "Trang chủ", null, "", 249, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8a344a1e-7236-0731-1c05-59c4fb26dfb6"), "Trăng mật", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.img4.alt", "text", "Ảnh tour riêng 4: chú thích", "Trang chủ", null, "", 259, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8ccd59d1-4c6c-3ef5-9cc8-04b931f8510f"), "Gala Dinner của đoàn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.img1.alt", "text", "Ảnh tour đoàn 1: chú thích", "Trang chủ", null, "", 245, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8d9347cf-87bc-1ed9-2a58-f6b776877373"), "Ngọc South Sea là dòng ngọc quý và lớn nhất, ánh vàng hoặc trắng sang trọng, biểu tượng của sự trọn vẹn.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tier.south-sea.pearl", "textarea", "South Sea: mô tả ngọc", "Phân loại Combo", null, "", 239, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("94412266-a2a5-77fa-1997-9b6d6e2eb180"), "Gói gồm có", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.includes.label", "text", "Nhãn 'Gói gồm có'", "Phân loại Combo", null, "", 243, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9e7cecff-03e9-8e11-9a26-b3e0afd50204"), "perlunas-group-gala", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.img1", "image", "Ảnh tour đoàn 1", "Trang chủ", null, "", 244, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("abac0d0d-9b8a-3419-5709-865507bd6bab"), "Gói du lịch", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "combotiers.back", "text", "Link quay lại", "Phân loại Combo", null, "", 242, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b9515d2a-7580-4cf8-d898-2ad6a00b3916"), "perlunas-group-team", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.img2", "image", "Ảnh tour đoàn 2", "Trang chủ", null, "", 246, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c80e6f59-cb58-b936-179d-56c18263ad33"), "Nhóm bạn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.img3.alt", "text", "Ảnh tour riêng 3: chú thích", "Trang chủ", null, "", 257, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cd48b396-8abb-ba8b-01b1-3eeafd2b4960"), "Một mình", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.img5.alt", "text", "Ảnh tour riêng 5: chú thích", "Trang chủ", null, "", 261, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dd94173c-d963-3be5-fe7d-04bf8d607e7f"), "Khách sạn 3-4 sao trung tâm\nXe đưa đón và di chuyển theo lịch trình\nĂn sáng mỗi ngày\nHướng dẫn viên ở các điểm chính\nVé tham quan cơ bản", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tier.akoya.includes", "textarea", "Akoya: gồm có (mỗi dòng 1 mục)", "Phân loại Combo", null, "", 233, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ec999627-bc6c-cb51-6e9d-e0cde7deab9f"), "Gói trải nghiệm đậm hơn: nhiều khoảnh khắc riêng tư, những trải nghiệm địa phương được chọn lọc kỹ.", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "tier.tahiti.story", "textarea", "Tahiti: story", "Phân loại Combo", null, "", 236, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f02a8ee9-edff-0e31-73a0-a5ec44e3c8c0"), "perlunas-group-tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.grouptours.img3", "image", "Ảnh tour đoàn 3", "Trang chủ", null, "", 248, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fa1a1ad9-9b2e-4aa0-ee61-c93a54effc31"), "Gia đình", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "home.privatetour.img1.alt", "text", "Ảnh tour riêng 1: chú thích", "Trang chủ", null, "", 253, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
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

            migrationBuilder.UpdateData(
                table: "SiteSettings",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777771"),
                columns: new[] { "Description", "Email", "LegalName", "Phone", "Tagline", "TaxId" },
                values: new object[] { "Perlunas thiết kế những hành trình du lịch trong nước tinh tế và trọn vẹn: tour trọn gói, đặt phòng khách sạn, gói du lịch, tour đoàn và tour riêng theo yêu cầu.", "xinchao@perlunas.vn", "Công ty TNHH Du lịch Perlunas", "0900 000 000", "Mỗi hành trình là một viên ngọc dưới ánh trăng", "0123456789" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("0d9abcf6-a079-6034-804d-a816c7412e6a"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("129e7532-e258-e0b8-5c65-d25a2cd7a35d"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("14bfef19-0f2e-c0ab-6ea2-d10846aa6165"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("21674a05-cd12-274c-5231-3623b3c52e23"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("3795d469-f979-ab1d-3982-048f7ab06fad"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("434d8bd7-d7ee-4dcc-a91f-fe51fc0da12e"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("4a28d15d-0695-f7cf-2aeb-a310a2e88b58"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("5d13f0a8-05fb-f0a2-9d45-0f502026eeda"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("615df596-1989-81db-f04b-3d44e858cc32"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("61d98f5d-dc3c-fe11-a09c-833983fb40ba"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("623d9413-c1ef-fe43-fd8c-bb8d9ae2dc25"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("663741eb-947c-e7c8-d395-c33f255b8fca"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6cb5cb99-ca03-8462-0dc3-2868083e33a5"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6d3dc16e-2dd0-38be-de3a-b19ba3a4bb5f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("6e775a52-97af-2c49-8b8c-e8a76eebe2e0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("7d5902e2-6c3c-f360-b407-c07834e32080"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("80f6cd83-e9da-4c4f-02f5-2150fcdc6ff4"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("862a5926-b13d-712b-730a-153a313a5ff0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("86e9f9bf-b734-7fea-437a-fc2954de2221"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8a344a1e-7236-0731-1c05-59c4fb26dfb6"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8ccd59d1-4c6c-3ef5-9cc8-04b931f8510f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("8d9347cf-87bc-1ed9-2a58-f6b776877373"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("94412266-a2a5-77fa-1997-9b6d6e2eb180"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("9e7cecff-03e9-8e11-9a26-b3e0afd50204"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("abac0d0d-9b8a-3419-5709-865507bd6bab"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("b9515d2a-7580-4cf8-d898-2ad6a00b3916"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("c80e6f59-cb58-b936-179d-56c18263ad33"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("cd48b396-8abb-ba8b-01b1-3eeafd2b4960"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("dd94173c-d963-3be5-fe7d-04bf8d607e7f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("ec999627-bc6c-cb51-6e9d-e0cde7deab9f"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("f02a8ee9-edff-0e31-73a0-a5ec44e3c8c0"));

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: new Guid("fa1a1ad9-9b2e-4aa0-ee61-c93a54effc31"));

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

            migrationBuilder.UpdateData(
                table: "SiteSettings",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777771"),
                columns: new[] { "Description", "Email", "LegalName", "Phone", "Tagline", "TaxId" },
                values: new object[] { "Sample site description.", "hello@perlunas.local", "Perlunas Travel Co., Ltd.", "+84000000000", "Travel with care", "0000000000" });
        }
    }
}
