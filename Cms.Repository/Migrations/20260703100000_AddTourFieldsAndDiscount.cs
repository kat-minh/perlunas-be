using Cms.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <summary>
    /// Thêm 2 cột cho tour:
    ///  - Services.TripInfoJson: 4 ô "Thông tin chính về chuyến đi" (theo từng tour).
    ///  - DepartureSchedules.OriginalPrice: giá gốc (trước giảm) để gạch ngang.
    /// Viết tay (không có Designer) — runtime db.Database.Migrate() chỉ chạy Up().
    /// Snapshot (AppDbContextModelSnapshot) đã được cập nhật kèm 2 cột này.
    /// </summary>
    [DbContext(typeof(AppDbContext))]
    [Migration("20260703100000_AddTourFieldsAndDiscount")]
    public partial class AddTourFieldsAndDiscount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TripInfoJson",
                table: "Services",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginalPrice",
                table: "DepartureSchedules",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TripInfoJson",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "DepartureSchedules");
        }
    }
}
