using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedHotelRoomsAndDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RoomCategories",
                columns: new[] { "Id", "Acreage", "Album", "CreatedAt", "Description", "Feature", "IsDeleted", "NumberOfBed", "NumberOfCustomer", "OriginalPrice", "Price", "ServiceId", "Titile", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0559c6c1-868c-0017-a07e-25c63e52bf9f"), "24 m²", "[\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "3100000", "2600000", new Guid("6b3cd177-825d-b0a4-22df-db79721fa23e"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("091cbcd6-efb3-c02a-b8e0-5ffd1cca30ee"), "48 m²", "[\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "6000000", "4000000", new Guid("d07f4322-2edb-544f-7286-265c1c258ce0"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0cf635ce-d52b-b513-ba6a-74ee39f25a6d"), "32 m²", "[\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "4100000", "3000000", new Guid("8e401cad-0a9e-259e-9819-bf4842528f05"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1a1268da-0ede-1f56-1c68-b666bcb31268"), "48 m²", "[\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "4900000", "2900000", new Guid("836e3fca-9da6-4631-f71f-ef0f27a681c1"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1d42b704-76bf-5fbc-86c0-9c4660cdd82d"), "24 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "4000000", "3500000", new Guid("6a695375-8160-a254-bce4-37be78bdbe63"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("29feb817-52b4-4987-43fd-93c40e1b9e64"), "24 m²", "[\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "2100000", "1600000", new Guid("d43e2322-4d95-0305-d0aa-1303db0dade7"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("31083de2-b476-7eb0-3500-22f86573d6ec"), "48 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "5300000", "3300000", new Guid("f8598638-8a39-2092-c30f-1f4e69dc2511"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("35b9f593-0042-95cb-1d01-7fc1d1944bf9"), "32 m²", "[\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "3900000", "2800000", new Guid("1c319bb9-c82d-5a4a-22b3-2f5d6625fbd2"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3e07e0f0-7c49-f8ee-4a1f-2a9bbc9989c4"), "24 m²", "[\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "2500000", "2000000", new Guid("fce66f24-a18b-3b62-8473-12df889d6e6f"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4cede885-a106-edd7-0f33-00ea24d04576"), "48 m²", "[\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "5900000", "3900000", new Guid("8e401cad-0a9e-259e-9819-bf4842528f05"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5056c7b1-ef94-e9fa-de2c-3b80a7732955"), "24 m²", "[\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "3700000", "3200000", new Guid("64b5eb41-96db-8d39-22e5-4a7f2e4e4129"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("51bc31fa-442f-4571-669c-523e6e01856d"), "32 m²", "[\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "3100000", "2000000", new Guid("836e3fca-9da6-4631-f71f-ef0f27a681c1"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("672dc816-8bf9-25cd-b92a-c60449deb7f5"), "48 m²", "[\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "6100000", "4100000", new Guid("6b3cd177-825d-b0a4-22df-db79721fa23e"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6938b7b7-9e45-d7b3-679d-b82907a5c369"), "32 m²", "[\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "3300000", "2200000", new Guid("d43e2322-4d95-0305-d0aa-1303db0dade7"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("69c064c0-4ab2-a8e3-58b2-31b21188a087"), "24 m²", "[\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "2900000", "2400000", new Guid("8e401cad-0a9e-259e-9819-bf4842528f05"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6a4f7b2f-5a2c-87a5-620f-a7551777ca7d"), "24 m²", "[\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "2400000", "1900000", new Guid("e50a45c4-40d6-316f-0e40-2e58860b0f8e"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("708f3f2b-a8c0-ad23-60c2-699655278658"), "24 m²", "[\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "2200000", "1700000", new Guid("de0528da-01be-297f-3d6f-59795657002f"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("761c3b3a-b4da-bfad-19cf-e1a8fec0dc0a"), "48 m²", "[\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "6700000", "4700000", new Guid("64b5eb41-96db-8d39-22e5-4a7f2e4e4129"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7742168d-1099-c9e8-56ea-52ec97cf5cfe"), "32 m²", "[\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "4200000", "3100000", new Guid("d07f4322-2edb-544f-7286-265c1c258ce0"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7830e8b6-acd3-aa5b-6a0b-1264c0470c08"), "32 m²", "[\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "4900000", "3800000", new Guid("64b5eb41-96db-8d39-22e5-4a7f2e4e4129"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("78d4ee4f-9912-a914-689c-8384da89b713"), "32 m²", "[\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "3500000", "2400000", new Guid("f8598638-8a39-2092-c30f-1f4e69dc2511"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("93ecb381-650f-88a2-79a8-6cf950467964"), "32 m²", "[\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "3700000", "2600000", new Guid("fce66f24-a18b-3b62-8473-12df889d6e6f"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9754a920-301e-09e5-17c0-b73889efa55b"), "24 m²", "[\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "2700000", "2200000", new Guid("1c319bb9-c82d-5a4a-22b3-2f5d6625fbd2"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9bdb6ad7-5f65-28e8-4b75-b0f64606ff52"), "32 m²", "[\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "3600000", "2500000", new Guid("be9279af-57b7-1a64-3d9c-e69e8885cc0a"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9efcdd28-bbf2-e1bf-f0fc-79f323b19fac"), "24 m²", "[\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "1900000", "1400000", new Guid("836e3fca-9da6-4631-f71f-ef0f27a681c1"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a07c5c26-1d67-1785-77db-b74d17a7fa41"), "32 m²", "[\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "4500000", "3400000", new Guid("22f4078a-1c46-d445-a3fb-c9ab91136022"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a3c67ce7-0778-c46c-7bd3-57522ab5c1af"), "48 m²", "[\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "5200000", "3200000", new Guid("de0528da-01be-297f-3d6f-59795657002f"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a7ee2e0b-e247-98e1-6d62-2a427d0351fb"), "48 m²", "[\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "5400000", "3400000", new Guid("be9279af-57b7-1a64-3d9c-e69e8885cc0a"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ac7b0224-7f7e-fee8-5d0c-db36ba8e8338"), "32 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "3400000", "2300000", new Guid("de0528da-01be-297f-3d6f-59795657002f"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b05bfbbc-a414-5b05-69bb-590dfe2f04b6"), "48 m²", "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "5100000", "3100000", new Guid("d43e2322-4d95-0305-d0aa-1303db0dade7"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b0e953e6-7701-82e4-2173-a2310f0c1926"), "32 m²", "[\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "5900000", "4800000", new Guid("c798db8d-3381-10a2-4623-3a599a44ad4a"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b8dc13da-ecc1-6666-c42a-d5b3529a1b6c"), "24 m²", "[\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "3000000", "2500000", new Guid("d07f4322-2edb-544f-7286-265c1c258ce0"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c774f59f-78c9-27c7-08b6-68b731096f7b"), "32 m²", "[\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "5200000", "4100000", new Guid("6a695375-8160-a254-bce4-37be78bdbe63"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d075b846-c465-e5a8-a7be-61db00229313"), "24 m²", "[\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "3300000", "2800000", new Guid("22f4078a-1c46-d445-a3fb-c9ab91136022"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d205a310-226e-8ef9-19f5-a4b2b08bcf54"), "32 m²", "[\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "3600000", "2500000", new Guid("e50a45c4-40d6-316f-0e40-2e58860b0f8e"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("da3ad21d-bfc1-4aee-f3da-3086eb562d82"), "48 m²", "[\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "5500000", "3500000", new Guid("fce66f24-a18b-3b62-8473-12df889d6e6f"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dd22ef47-b31f-0842-94e6-7e3a794e01b3"), "48 m²", "[\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "5400000", "3400000", new Guid("e50a45c4-40d6-316f-0e40-2e58860b0f8e"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e00f4c6b-0af4-4d27-1440-1dc57d205f24"), "32 m²", "[\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Rộng rãi hơn với ban công riêng và góc thư giãn.", "[\"Ban công riêng\",\"Bồn tắm\",\"Wifi miễn phí\",\"Bàn làm việc\"]", false, "1 giường đôi lớn", 2, "4300000", "3200000", new Guid("6b3cd177-825d-b0a4-22df-db79721fa23e"), "Deluxe", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e1a988d7-f012-a4af-a3a3-0723f879d679"), "24 m²", "[\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "4700000", "4200000", new Guid("c798db8d-3381-10a2-4623-3a599a44ad4a"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e4941d73-3ee7-2539-9924-dc0ada32a0f2"), "48 m²", "[\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "5700000", "3700000", new Guid("1c319bb9-c82d-5a4a-22b3-2f5d6625fbd2"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e6e7478f-4a33-1db8-995a-78f13ae4a437"), "24 m²", "[\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "2400000", "1900000", new Guid("be9279af-57b7-1a64-3d9c-e69e8885cc0a"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e9af099d-3ced-64cc-42f2-292d42af1bcc"), "48 m²", "[\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "7000000", "5000000", new Guid("6a695375-8160-a254-bce4-37be78bdbe63"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eb8e560f-39fa-2491-6d0f-1285031c7021"), "48 m²", "[\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "7700000", "5700000", new Guid("c798db8d-3381-10a2-4623-3a599a44ad4a"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ee478102-c48b-4995-d01b-9b1f3c0a1c04"), "24 m²", "[\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Phòng tiêu chuẩn ấm cúng, đầy đủ tiện nghi cơ bản cho 2 khách.", "[\"Wifi miễn phí\",\"Điều hòa\",\"TV màn hình phẳng\",\"Minibar\"]", false, "1 giường đôi hoặc 2 giường đơn", 2, "2300000", "1800000", new Guid("f8598638-8a39-2092-c30f-1f4e69dc2511"), "Standard", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fed2fc75-8102-e282-9c6b-f46ffd6acd21"), "48 m²", "[\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\"]", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hạng phòng cao cấp nhất với phòng khách riêng và tầm nhìn đẹp.", "[\"Phòng khách riêng\",\"View đẹp\",\"Bồn tắm nằm\",\"Đưa đón sân bay\"]", false, "1 giường King + sofa", 3, "6300000", "4300000", new Guid("22f4078a-1c46-d445-a3fb-c9ab91136022"), "Suite", "/ đêm", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\"]", new List<string>(), new List<string> { "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>(), "<p>Sa Pa Cloud Retreat tọa lạc tại Sa Pa — không gian retreat tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Nghỉ dưỡng, Tham quan" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("22f4078a-1c46-d445-a3fb-c9ab91136022"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\"]", new List<string>(), new List<string> { "Điều hòa", "Phòng gym", "Spa", "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng" }, new List<string>(), "<p>Pinewood Wellness tọa lạc tại Đà Lạt — không gian wellness tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Nghỉ dưỡng, Tham quan" });

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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\"]", new List<string>(), new List<string> { "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng" }, new List<string>(), "<p>Azure Bay Resort tọa lạc tại Nha Trang — không gian resort tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Nghỉ dưỡng, Tham quan" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6a695375-8160-a254-bce4-37be78bdbe63"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\"]", new List<string>(), new List<string> { "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym", "Spa", "Đưa đón sân bay" }, new List<string>(), "<p>Lunar Bay Resort tọa lạc tại Phú Quốc — không gian resort tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Nghỉ dưỡng, Tham quan" });

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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\"]", new List<string>(), new List<string> { "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng" }, new List<string>(), "<p>Bay Wellness tọa lạc tại Hạ Long — không gian wellness tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Nghỉ dưỡng, Tham quan" });

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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new List<string>(), new List<string> { "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa" }, new List<string>(), "<p>Stella Hotel tọa lạc tại Đà Lạt — không gian hotel tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Công tác, Tham quan" });

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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\"]", new List<string>(), new List<string> { "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng" }, new List<string>(), "<p>Metropole Lune tọa lạc tại Hà Nội — không gian hotel tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Công tác, Tham quan" });

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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\"]", new List<string>(), new List<string> { "Lễ tân 24h", "Điều hòa", "Phòng gym", "Spa", "Đưa đón sân bay", "Quầy bar" }, new List<string>(), "<p>Hạ Long Pearl Hotel tọa lạc tại Hạ Long — không gian hotel tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Công tác, Tham quan" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c798db8d-3381-10a2-4623-3a599a44ad4a"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\"]", new List<string>(), new List<string> { "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng" }, new List<string>(), "<p>Pearl Cove Resort tọa lạc tại Phú Quốc — không gian resort tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Nghỉ dưỡng, Tham quan" });

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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\"]", new List<string>(), new List<string> { "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h", "Điều hòa", "Phòng gym" }, new List<string>(), "<p>Serenity Retreat tọa lạc tại Đà Lạt — không gian retreat tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Nghỉ dưỡng, Tham quan" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d43e2322-4d95-0305-d0aa-1303db0dade7"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\"]", new List<string>(), new List<string> { "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng", "Lễ tân 24h" }, new List<string>(), "<p>An Yên Boutique tọa lạc tại Hội An — không gian boutique hotel tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Nghỉ dưỡng, Cặp đôi" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("de0528da-01be-297f-3d6f-59795657002f"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\"]", new List<string>(), new List<string> { "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe" }, new List<string>(), "<p>Old Quarter Boutique tọa lạc tại Hà Nội — không gian boutique hotel tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Nghỉ dưỡng, Cặp đôi" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e50a45c4-40d6-316f-0e40-2e58860b0f8e"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\"]", new List<string>(), new List<string> { "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi", "Bữa sáng", "Bãi đỗ xe", "Nhà hàng" }, new List<string>(), "<p>Đà Nẵng Grand Hotel tọa lạc tại Đà Nẵng — không gian hotel tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Công tác, Tham quan" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f8598638-8a39-2092-c30f-1f4e69dc2511"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\",\"https://images.unsplash.com/photo-1571896349842-33c89424de2d?w=1400&q=70\",\"https://images.unsplash.com/photo-1618773928121-c32242e63f39?w=1400&q=70\",\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\"]", new List<string>(), new List<string> { "Spa", "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí", "Hồ bơi" }, new List<string>(), "<p>Ocean Pearl Hotel tọa lạc tại Nha Trang — không gian hotel tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Công tác, Tham quan" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("fce66f24-a18b-3b62-8473-12df889d6e6f"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1400&q=70\",\"https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70\",\"https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70\",\"https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70\",\"https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1400&q=70\",\"https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1400&q=70\"]", new List<string>(), new List<string> { "Phòng gym", "Spa", "Đưa đón sân bay", "Quầy bar", "Dịch vụ phòng", "Wifi miễn phí" }, new List<string>(), "<p>Maison de Lune tọa lạc tại Hội An — không gian boutique hotel tinh tế, dịch vụ tận tâm cho kỳ nghỉ trọn vẹn.</p><p>Phòng nghỉ thoáng đãng, khu vực chung được chăm chút, đội ngũ luôn sẵn sàng hỗ trợ suốt thời gian lưu trú.</p>", "Nghỉ dưỡng, Cặp đôi" });

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
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("0559c6c1-868c-0017-a07e-25c63e52bf9f"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("091cbcd6-efb3-c02a-b8e0-5ffd1cca30ee"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("0cf635ce-d52b-b513-ba6a-74ee39f25a6d"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("1a1268da-0ede-1f56-1c68-b666bcb31268"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d42b704-76bf-5fbc-86c0-9c4660cdd82d"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("29feb817-52b4-4987-43fd-93c40e1b9e64"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("31083de2-b476-7eb0-3500-22f86573d6ec"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("35b9f593-0042-95cb-1d01-7fc1d1944bf9"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e07e0f0-7c49-f8ee-4a1f-2a9bbc9989c4"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("4cede885-a106-edd7-0f33-00ea24d04576"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("5056c7b1-ef94-e9fa-de2c-3b80a7732955"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("51bc31fa-442f-4571-669c-523e6e01856d"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("672dc816-8bf9-25cd-b92a-c60449deb7f5"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("6938b7b7-9e45-d7b3-679d-b82907a5c369"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("69c064c0-4ab2-a8e3-58b2-31b21188a087"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("6a4f7b2f-5a2c-87a5-620f-a7551777ca7d"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("708f3f2b-a8c0-ad23-60c2-699655278658"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("761c3b3a-b4da-bfad-19cf-e1a8fec0dc0a"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("7742168d-1099-c9e8-56ea-52ec97cf5cfe"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("7830e8b6-acd3-aa5b-6a0b-1264c0470c08"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("78d4ee4f-9912-a914-689c-8384da89b713"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("93ecb381-650f-88a2-79a8-6cf950467964"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("9754a920-301e-09e5-17c0-b73889efa55b"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("9bdb6ad7-5f65-28e8-4b75-b0f64606ff52"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("9efcdd28-bbf2-e1bf-f0fc-79f323b19fac"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("a07c5c26-1d67-1785-77db-b74d17a7fa41"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("a3c67ce7-0778-c46c-7bd3-57522ab5c1af"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7ee2e0b-e247-98e1-6d62-2a427d0351fb"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac7b0224-7f7e-fee8-5d0c-db36ba8e8338"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("b05bfbbc-a414-5b05-69bb-590dfe2f04b6"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("b0e953e6-7701-82e4-2173-a2310f0c1926"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("b8dc13da-ecc1-6666-c42a-d5b3529a1b6c"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("c774f59f-78c9-27c7-08b6-68b731096f7b"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("d075b846-c465-e5a8-a7be-61db00229313"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("d205a310-226e-8ef9-19f5-a4b2b08bcf54"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("da3ad21d-bfc1-4aee-f3da-3086eb562d82"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("dd22ef47-b31f-0842-94e6-7e3a794e01b3"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("e00f4c6b-0af4-4d27-1440-1dc57d205f24"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("e1a988d7-f012-a4af-a3a3-0723f879d679"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4941d73-3ee7-2539-9924-dc0ada32a0f2"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("e6e7478f-4a33-1db8-995a-78f13ae4a437"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("e9af099d-3ced-64cc-42f2-292d42af1bcc"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("eb8e560f-39fa-2491-6d0f-1285031c7021"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("ee478102-c48b-4995-d01b-9b1f3c0a1c04"));

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("fed2fc75-8102-e282-9c6b-f46ffd6acd21"));

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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("22f4078a-1c46-d445-a3fb-c9ab91136022"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("6a695375-8160-a254-bce4-37be78bdbe63"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("c798db8d-3381-10a2-4623-3a599a44ad4a"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

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
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d43e2322-4d95-0305-d0aa-1303db0dade7"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("de0528da-01be-297f-3d6f-59795657002f"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("e50a45c4-40d6-316f-0e40-2e58860b0f8e"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f8598638-8a39-2092-c30f-1f4e69dc2511"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("fce66f24-a18b-3b62-8473-12df889d6e6f"),
                columns: new[] { "Album", "Destinations", "Facilities", "Highlight", "Introducetion", "PurposeOfTrip" },
                values: new object[] { "[]", new List<string>(), new List<string>(), new List<string>(), null, null });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("ffe5e382-0178-4c54-63ca-68bad28cf20a"),
                columns: new[] { "Destinations", "Facilities", "Highlight" },
                values: new object[] { new List<string>(), new List<string>(), new List<string>() });
        }
    }
}
