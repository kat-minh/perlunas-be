using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedComboTierImages : Migration
    {
        // 3 "viên ngọc" (Akoya / Tahiti / South Sea) trên trang Phân loại Combo có
        // thêm ô ẢNH — sửa cùng chỗ với tagline/mô tả/story ở tab "Nội dung trang →
        // Phân loại Combo". Bỏ trống → site tự dùng icon ngọc mặc định.
        private static readonly Guid AkoyaImage = new Guid("aa11bb22-0000-0000-0000-000000000201");
        private static readonly Guid TahitiImage = new Guid("aa11bb22-0000-0000-0000-000000000202");
        private static readonly Guid SouthSeaImage = new Guid("aa11bb22-0000-0000-0000-000000000203");

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var seedDate = new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var columns = new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" };

            migrationBuilder.InsertData(
                table: "PageContents",
                columns: columns,
                values: new object[] { AkoyaImage, "", seedDate, false, "tier.akoya.image", "image", "Akoya: ảnh viên ngọc", "Phân loại Combo", null, "", 227, seedDate });

            migrationBuilder.InsertData(
                table: "PageContents",
                columns: columns,
                values: new object[] { TahitiImage, "", seedDate, false, "tier.tahiti.image", "image", "Tahiti: ảnh viên ngọc", "Phân loại Combo", null, "", 228, seedDate });

            migrationBuilder.InsertData(
                table: "PageContents",
                columns: columns,
                values: new object[] { SouthSeaImage, "", seedDate, false, "tier.south-sea.image", "image", "South Sea: ảnh viên ngọc", "Phân loại Combo", null, "", 229, seedDate });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            foreach (var id in new[] { AkoyaImage, TahitiImage, SouthSeaImage })
            {
                migrationBuilder.DeleteData(
                    table: "PageContents",
                    keyColumn: "Id",
                    keyValue: id);
            }
        }
    }
}
