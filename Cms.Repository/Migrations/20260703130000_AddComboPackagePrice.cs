using Cms.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <summary>
    /// Thêm cột Services.Price + Services.OriginalPrice: giá bán theo GÓI của combo
    /// (giá riêng ở cấp dịch vụ, thay vì gộp từ hạng phòng). Hạng phòng của combo từ
    /// nay chỉ mô tả, không mang giá. Tour/khách sạn không dùng 2 cột này (để null).
    /// Viết tay (không Designer) — runtime db.Database.Migrate() chỉ chạy Up().
    /// Snapshot (AppDbContextModelSnapshot) đã được cập nhật kèm 2 cột này.
    /// </summary>
    [DbContext(typeof(AppDbContext))]
    [Migration("20260703130000_AddComboPackagePrice")]
    public partial class AddComboPackagePrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Services",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginalPrice",
                table: "Services",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "Services");
        }
    }
}
