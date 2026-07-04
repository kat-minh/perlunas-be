using Cms.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <summary>
    /// Thêm cột Services.DurationText: thời lượng dạng CHUỖI TỰ DO admin nhập
    /// (vd "3 ngày 2 đêm", "1 tuần", "cuối tuần"). Hiển thị nguyên văn trên site;
    /// Day/Night chỉ còn là parse phụ trợ (không bắt buộc). Viết tay (không Designer)
    /// — runtime db.Database.Migrate() chỉ chạy Up(). Snapshot đã cập nhật kèm cột.
    /// </summary>
    [DbContext(typeof(AppDbContext))]
    [Migration("20260703140000_AddServiceDurationText")]
    public partial class AddServiceDurationText : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DurationText",
                table: "Services",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationText",
                table: "Services");
        }
    }
}
