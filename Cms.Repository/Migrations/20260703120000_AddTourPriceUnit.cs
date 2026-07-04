using Cms.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <summary>
    /// Thêm cột Services.PriceUnit: đơn vị giá tour (vd "/ khách") admin nhập ở form.
    /// Viết tay (không Designer) — runtime db.Database.Migrate() chỉ chạy Up().
    /// Snapshot (AppDbContextModelSnapshot) đã được cập nhật kèm cột này.
    /// </summary>
    [DbContext(typeof(AppDbContext))]
    [Migration("20260703120000_AddTourPriceUnit")]
    public partial class AddTourPriceUnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PriceUnit",
                table: "Services",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceUnit",
                table: "Services");
        }
    }
}
