using System.Collections.Generic;
using Cms.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <summary>
    /// Thêm 2 cột Services.PickupPoints / Services.DropoffPoints (text[]): điểm đón /
    /// điểm trả RIÊNG của từng tour (admin chọn nhiều từ danh mục nhóm "pickup").
    /// Viết tay (không Designer) — runtime db.Database.Migrate() chỉ chạy Up().
    /// Snapshot đã cập nhật kèm 2 cột.
    /// </summary>
    [DbContext(typeof(AppDbContext))]
    [Migration("20260710120000_AddTourPickupDropoffPoints")]
    public partial class AddTourPickupDropoffPoints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<List<string>>(
                name: "PickupPoints",
                table: "Services",
                type: "text[]",
                nullable: false,
                defaultValue: new List<string>());

            migrationBuilder.AddColumn<List<string>>(
                name: "DropoffPoints",
                table: "Services",
                type: "text[]",
                nullable: false,
                defaultValue: new List<string>());
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "PickupPoints", table: "Services");
            migrationBuilder.DropColumn(name: "DropoffPoints", table: "Services");
        }
    }
}
