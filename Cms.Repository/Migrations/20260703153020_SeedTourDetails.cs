using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedTourDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DepartureSchedules",
                columns: new[] { "Id", "AccommodationStandards", "Code", "CreatedAt", "IsDeleted", "OriginalPrice", "Price", "ServiceId", "StartTime", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("dddd0001-0000-0000-0000-000000000001"), "Khách sạn 3 sao", "PL-DL-0712", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, null, "2890000", new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), "2026-07-12", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0001-0000-0000-0000-000000000002"), "Khách sạn 4 sao", "PL-DL-0809", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "3290000", "2990000", new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), "2026-08-09", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0001-0000-0000-0000-000000000003"), "Resort 4 sao", "PL-DL-0913", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "3490000", "3190000", new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), "2026-09-13", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0001-0000-0000-0000-000000000004"), "Resort 4 sao", "PL-DL-1011", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, null, "3390000", new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), "2026-10-11", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0001-0000-0000-0000-000000000005"), "Khách sạn 4 sao", "PL-DL-1108", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "3190000", "2890000", new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), "2026-11-08", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0002-0000-0000-0000-000000000001"), "Khách sạn 4 sao", "PL-PQ-0719", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, null, "3690000", new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), "2026-07-19", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0002-0000-0000-0000-000000000002"), "Resort 4 sao", "PL-PQ-0816", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "4290000", "3890000", new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), "2026-08-16", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0002-0000-0000-0000-000000000003"), "Resort 4 sao", "PL-PQ-0920", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "4090000", "3690000", new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), "2026-09-20", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0002-0000-0000-0000-000000000004"), "Resort 5 sao", "PL-PQ-1018", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, null, "4190000", new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), "2026-10-18", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0002-0000-0000-0000-000000000005"), "Resort 5 sao", "PL-PQ-1115", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "4490000", "3990000", new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), "2026-11-15", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0003-0000-0000-0000-000000000001"), "Khách sạn 3 sao", "PL-HS-0724", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, null, "4290000", new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), "2026-07-24", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0003-0000-0000-0000-000000000002"), "Khách sạn 4 sao", "PL-HS-0821", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "4890000", "4490000", new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), "2026-08-21", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0003-0000-0000-0000-000000000003"), "Khách sạn 4 sao", "PL-HS-0918", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "5090000", "4690000", new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), "2026-09-18", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0003-0000-0000-0000-000000000004"), "Resort 4 sao", "PL-HS-1016", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, null, "4990000", new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), "2026-10-16", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0003-0000-0000-0000-000000000005"), "Khách sạn 4 sao", "PL-HS-1113", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "4790000", "4290000", new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), "2026-11-13", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0004-0000-0000-0000-000000000001"), "Khách sạn 4 sao", "PL-DN-0717", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, null, "3190000", new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), "2026-07-17", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0004-0000-0000-0000-000000000002"), "Resort 4 sao", "PL-DN-0814", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "3790000", "3390000", new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), "2026-08-14", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0004-0000-0000-0000-000000000003"), "Resort 4 sao", "PL-DN-0911", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "3590000", "3190000", new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), "2026-09-11", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0004-0000-0000-0000-000000000004"), "Resort 5 sao", "PL-DN-1009", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, null, "3690000", new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), "2026-10-09", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0004-0000-0000-0000-000000000005"), "Resort 4 sao", "PL-DN-1106", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "3690000", "3290000", new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), "2026-11-06", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0005-0000-0000-0000-000000000001"), "Khách sạn 4 sao", "PL-NT-0711", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, null, "2990000", new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), "2026-07-11", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0005-0000-0000-0000-000000000002"), "Resort 4 sao", "PL-NT-0808", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "3590000", "3190000", new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), "2026-08-08", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0005-0000-0000-0000-000000000003"), "Resort 4 sao", "PL-NT-0912", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "3390000", "2990000", new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), "2026-09-12", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0005-0000-0000-0000-000000000004"), "Resort 5 sao", "PL-NT-1010", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, null, "3490000", new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), "2026-10-10", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dddd0005-0000-0000-0000-000000000005"), "Resort 4 sao", "PL-NT-1107", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "3490000", "3090000", new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), "2026-11-07", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "ImportantInfors",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "ServiceId", "SubTitle", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("eeee0001-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Xe du lịch đời mới đưa đón theo chương trình\nKhách sạn/resort theo tiêu chuẩn đã chọn (2 khách/phòng)\nCác bữa ăn theo chương trình\nVé tham quan các điểm ghi trong lịch trình\nHướng dẫn viên nhiệt tình, kinh nghiệm\nBảo hiểm du lịch theo quy định", false, new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), null, "Giá bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0001-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay khứ hồi (nếu có)\nChi phí cá nhân, đồ uống ngoài chương trình\nPhụ thu phòng đơn\nTiền tip cho hướng dẫn viên và tài xế\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), null, "Giá không bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0001-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, gia đình tự lo chi phí (ngủ ghép cùng bố mẹ)\nTrẻ 5–10 tuổi: tính 50% giá tour, ngủ ghép cùng bố mẹ\nTrẻ từ 11 tuổi: tính như người lớn, tiêu chuẩn đầy đủ\nHai người lớn chỉ kèm 1 trẻ dưới 10 tuổi; trẻ thứ hai tính thêm", false, new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0001-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mang theo CCCD/hộ chiếu bản gốc còn hạn khi khởi hành\nCó mặt tại điểm đón trước giờ khởi hành 15 phút\nChương trình có thể thay đổi thứ tự điểm đến tuỳ thời tiết, đảm bảo đủ điểm tham quan\nPerlunas không chịu trách nhiệm với sự cố bất khả kháng (thiên tai, dịch bệnh…)", false, new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), null, "Lưu ý & điều kiện", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0001-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá tour khi đăng ký, thanh toán đủ trước khởi hành 7 ngày\nHuỷ trước 15 ngày: hoàn 90% tiền cọc\nHuỷ trước 7–14 ngày: phí huỷ 50% giá tour\nHuỷ trong vòng 7 ngày: phí huỷ 100% giá tour", false, new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), null, "Thanh toán & huỷ tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0002-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Xe du lịch đời mới đưa đón theo chương trình\nKhách sạn/resort theo tiêu chuẩn đã chọn (2 khách/phòng)\nCác bữa ăn theo chương trình\nVé tham quan các điểm ghi trong lịch trình\nHướng dẫn viên nhiệt tình, kinh nghiệm\nBảo hiểm du lịch theo quy định", false, new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), null, "Giá bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0002-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay khứ hồi (nếu có)\nChi phí cá nhân, đồ uống ngoài chương trình\nPhụ thu phòng đơn\nTiền tip cho hướng dẫn viên và tài xế\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), null, "Giá không bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0002-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, gia đình tự lo chi phí (ngủ ghép cùng bố mẹ)\nTrẻ 5–10 tuổi: tính 50% giá tour, ngủ ghép cùng bố mẹ\nTrẻ từ 11 tuổi: tính như người lớn, tiêu chuẩn đầy đủ\nHai người lớn chỉ kèm 1 trẻ dưới 10 tuổi; trẻ thứ hai tính thêm", false, new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0002-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mang theo CCCD/hộ chiếu bản gốc còn hạn khi khởi hành\nCó mặt tại điểm đón trước giờ khởi hành 15 phút\nChương trình có thể thay đổi thứ tự điểm đến tuỳ thời tiết, đảm bảo đủ điểm tham quan\nPerlunas không chịu trách nhiệm với sự cố bất khả kháng (thiên tai, dịch bệnh…)", false, new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), null, "Lưu ý & điều kiện", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0002-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá tour khi đăng ký, thanh toán đủ trước khởi hành 7 ngày\nHuỷ trước 15 ngày: hoàn 90% tiền cọc\nHuỷ trước 7–14 ngày: phí huỷ 50% giá tour\nHuỷ trong vòng 7 ngày: phí huỷ 100% giá tour", false, new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), null, "Thanh toán & huỷ tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0003-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Xe du lịch đời mới đưa đón theo chương trình\nKhách sạn/resort theo tiêu chuẩn đã chọn (2 khách/phòng)\nCác bữa ăn theo chương trình\nVé tham quan các điểm ghi trong lịch trình\nHướng dẫn viên nhiệt tình, kinh nghiệm\nBảo hiểm du lịch theo quy định", false, new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), null, "Giá bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0003-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay khứ hồi (nếu có)\nChi phí cá nhân, đồ uống ngoài chương trình\nPhụ thu phòng đơn\nTiền tip cho hướng dẫn viên và tài xế\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), null, "Giá không bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0003-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, gia đình tự lo chi phí (ngủ ghép cùng bố mẹ)\nTrẻ 5–10 tuổi: tính 50% giá tour, ngủ ghép cùng bố mẹ\nTrẻ từ 11 tuổi: tính như người lớn, tiêu chuẩn đầy đủ\nHai người lớn chỉ kèm 1 trẻ dưới 10 tuổi; trẻ thứ hai tính thêm", false, new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0003-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mang theo CCCD/hộ chiếu bản gốc còn hạn khi khởi hành\nCó mặt tại điểm đón trước giờ khởi hành 15 phút\nChương trình có thể thay đổi thứ tự điểm đến tuỳ thời tiết, đảm bảo đủ điểm tham quan\nPerlunas không chịu trách nhiệm với sự cố bất khả kháng (thiên tai, dịch bệnh…)", false, new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), null, "Lưu ý & điều kiện", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0003-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá tour khi đăng ký, thanh toán đủ trước khởi hành 7 ngày\nHuỷ trước 15 ngày: hoàn 90% tiền cọc\nHuỷ trước 7–14 ngày: phí huỷ 50% giá tour\nHuỷ trong vòng 7 ngày: phí huỷ 100% giá tour", false, new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), null, "Thanh toán & huỷ tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0004-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Xe du lịch đời mới đưa đón theo chương trình\nKhách sạn/resort theo tiêu chuẩn đã chọn (2 khách/phòng)\nCác bữa ăn theo chương trình\nVé tham quan các điểm ghi trong lịch trình\nHướng dẫn viên nhiệt tình, kinh nghiệm\nBảo hiểm du lịch theo quy định", false, new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), null, "Giá bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0004-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay khứ hồi (nếu có)\nChi phí cá nhân, đồ uống ngoài chương trình\nPhụ thu phòng đơn\nTiền tip cho hướng dẫn viên và tài xế\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), null, "Giá không bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0004-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, gia đình tự lo chi phí (ngủ ghép cùng bố mẹ)\nTrẻ 5–10 tuổi: tính 50% giá tour, ngủ ghép cùng bố mẹ\nTrẻ từ 11 tuổi: tính như người lớn, tiêu chuẩn đầy đủ\nHai người lớn chỉ kèm 1 trẻ dưới 10 tuổi; trẻ thứ hai tính thêm", false, new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0004-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mang theo CCCD/hộ chiếu bản gốc còn hạn khi khởi hành\nCó mặt tại điểm đón trước giờ khởi hành 15 phút\nChương trình có thể thay đổi thứ tự điểm đến tuỳ thời tiết, đảm bảo đủ điểm tham quan\nPerlunas không chịu trách nhiệm với sự cố bất khả kháng (thiên tai, dịch bệnh…)", false, new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), null, "Lưu ý & điều kiện", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0004-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá tour khi đăng ký, thanh toán đủ trước khởi hành 7 ngày\nHuỷ trước 15 ngày: hoàn 90% tiền cọc\nHuỷ trước 7–14 ngày: phí huỷ 50% giá tour\nHuỷ trong vòng 7 ngày: phí huỷ 100% giá tour", false, new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), null, "Thanh toán & huỷ tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0005-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Xe du lịch đời mới đưa đón theo chương trình\nKhách sạn/resort theo tiêu chuẩn đã chọn (2 khách/phòng)\nCác bữa ăn theo chương trình\nVé tham quan các điểm ghi trong lịch trình\nHướng dẫn viên nhiệt tình, kinh nghiệm\nBảo hiểm du lịch theo quy định", false, new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), null, "Giá bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0005-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vé máy bay khứ hồi (nếu có)\nChi phí cá nhân, đồ uống ngoài chương trình\nPhụ thu phòng đơn\nTiền tip cho hướng dẫn viên và tài xế\nThuế VAT xuất hoá đơn (nếu khách yêu cầu)", false, new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), null, "Giá không bao gồm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0005-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trẻ dưới 5 tuổi: miễn phí, gia đình tự lo chi phí (ngủ ghép cùng bố mẹ)\nTrẻ 5–10 tuổi: tính 50% giá tour, ngủ ghép cùng bố mẹ\nTrẻ từ 11 tuổi: tính như người lớn, tiêu chuẩn đầy đủ\nHai người lớn chỉ kèm 1 trẻ dưới 10 tuổi; trẻ thứ hai tính thêm", false, new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), null, "Chính sách trẻ em", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0005-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mang theo CCCD/hộ chiếu bản gốc còn hạn khi khởi hành\nCó mặt tại điểm đón trước giờ khởi hành 15 phút\nChương trình có thể thay đổi thứ tự điểm đến tuỳ thời tiết, đảm bảo đủ điểm tham quan\nPerlunas không chịu trách nhiệm với sự cố bất khả kháng (thiên tai, dịch bệnh…)", false, new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), null, "Lưu ý & điều kiện", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eeee0005-0000-0000-0000-000000000005"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đặt cọc 50% giá tour khi đăng ký, thanh toán đủ trước khởi hành 7 ngày\nHuỷ trước 15 ngày: hoàn 90% tiền cọc\nHuỷ trước 7–14 ngày: phí huỷ 50% giá tour\nHuỷ trong vòng 7 ngày: phí huỷ 100% giá tour", false, new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), null, "Thanh toán & huỷ tour", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "CreatedAt", "Day", "Description", "IsDeleted", "ServiceId", "Sumary", "Titile", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("cccc0001-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Khởi hành sáng sớm đi Đà Lạt. Nhận phòng, dùng bữa trưa, chiều dạo Quảng trường Lâm Viên và hồ Xuân Hương. Tối tự do khám phá chợ đêm phố núi.", false, new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), "Ăn trưa, tối", "TP.HCM – Đà Lạt", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0001-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Dậy sớm săn mây tại Cầu Đất, tham quan đồi chè và vườn hồng. Chiều ghé làng Cù Lần, thưởng thức cà phê giữa rừng thông.", false, new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), "Ăn sáng, trưa, tối", "Săn mây Cầu Đất – đồi chè", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0001-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Tham quan vườn hoa thành phố, mua đặc sản làm quà. Trả phòng, dùng bữa trưa và khởi hành về TP.HCM, kết thúc hành trình.", false, new Guid("af94c02c-15b7-9e87-ba8e-9f5266c55668"), "Ăn sáng, trưa", "Đà Lạt – TP.HCM", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0002-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Đón tại sân bay, nhận phòng. Chiều tham quan Nam đảo: nhà thùng nước mắm, cơ sở ngọc trai. Tối dạo chợ đêm hải sản Dương Đông.", false, new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), "Ăn trưa, tối", "Đến Phú Quốc – Nam đảo", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0002-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Trải nghiệm cáp treo Hòn Thơm dài nhất thế giới, tắm biển và lặn ngắm san hô 3 đảo. Chiều ngắm hoàng hôn tại bãi Sao.", false, new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), "Ăn sáng, trưa, tối", "Cáp treo Hòn Thơm – lặn san hô", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0002-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Buổi sáng tự do nghỉ dưỡng, tắm biển. Trả phòng, mua đặc sản và ra sân bay, kết thúc chuyến đi.", false, new Guid("6b16f002-c173-9ada-ef84-72abcdda571b"), "Ăn sáng", "Tự do – Tiễn sân bay", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0003-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Đón tại sân bay Nội Bài, nhận phòng. Dạo phố cổ Hà Nội, hồ Hoàn Kiếm, thưởng thức ẩm thực 36 phố phường.", false, new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), "Ăn tối", "Đến Hà Nội – phố cổ", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0003-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Khởi hành đi Sa Pa theo cao tốc. Nhận phòng, chiều tham quan bản Cát Cát, tìm hiểu văn hoá người Mông.", false, new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), "Ăn sáng, trưa, tối", "Hà Nội – Sa Pa", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0003-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Đi cáp treo chinh phục đỉnh Fansipan 3.143m. Chiều ngắm ruộng bậc thang Mường Hoa, dạo thị trấn trong sương.", false, new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), "Ăn sáng, trưa, tối", "Chinh phục Fansipan", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0003-0000-0000-0000-000000000004"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 4", "Trả phòng, về Hà Nội. Mua quà đặc sản và ra sân bay, kết thúc hành trình Tây Bắc.", false, new Guid("a3f73676-e4fd-a5e7-f98c-1b46064d1f56"), "Ăn sáng, trưa", "Sa Pa – Hà Nội – tiễn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0004-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Đón sân bay, nhận phòng. Chiều tham quan bán đảo Sơn Trà, chùa Linh Ứng. Tối dạo cầu Rồng và sông Hàn.", false, new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), "Ăn tối", "Đến Đà Nẵng – Sơn Trà", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0004-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Cả ngày khám phá Bà Nà Hills: Cầu Vàng, Làng Pháp, hầm rượu. Chiều về tắm biển Mỹ Khê.", false, new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), "Ăn sáng, trưa, tối", "Bà Nà – Cầu Vàng", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0004-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Sáng tham quan phố cổ Hội An, chùa Cầu, thả đèn hoa đăng. Trả phòng, mua đặc sản và ra sân bay.", false, new Guid("04d243a2-c184-4e32-6ebd-bf055b3d82f3"), "Ăn sáng, trưa", "Phố cổ Hội An – tiễn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0005-0000-0000-0000-000000000001"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 1", "Đón sân bay Cam Ranh, nhận phòng. Chiều trải nghiệm tắm bùn khoáng nóng, thư giãn. Tối dạo phố biển.", false, new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), "Ăn tối", "Đến Nha Trang – tắm bùn", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0005-0000-0000-0000-000000000002"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 2", "Du thuyền tham quan vịnh Nha Trang, tắm biển và lặn ngắm san hô. Chiều vui chơi tại khu giải trí trên đảo.", false, new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), "Ăn sáng, trưa, tối", "Tour 4 đảo – vịnh Nha Trang", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cccc0005-0000-0000-0000-000000000003"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ngày 3", "Tham quan Tháp Bà Ponagar, nhà thờ Núi. Trả phòng, mua đặc sản biển và ra sân bay, kết thúc chuyến đi.", false, new Guid("509ea0b0-c67f-5e1f-cdcb-52dd26a40771"), "Ăn sáng", "Tháp Bà – tiễn sân bay", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
                    }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0001-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0001-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0001-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0001-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0001-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0002-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0002-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0002-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0002-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0002-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0003-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0003-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0003-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0003-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0003-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0004-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0004-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0004-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0004-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0004-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0005-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0005-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0005-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0005-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "DepartureSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dddd0005-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0001-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0001-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0001-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0001-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0001-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0002-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0002-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0002-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0002-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0002-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0003-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0003-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0003-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0003-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0003-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0004-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0004-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0004-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0004-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0004-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0005-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0005-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0005-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0005-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0005-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0001-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0001-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0001-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0002-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0002-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0002-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0003-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0003-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0003-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0003-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0004-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0004-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0004-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0005-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0005-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0005-0000-0000-0000-000000000003"));

            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
                    }
    }
}
