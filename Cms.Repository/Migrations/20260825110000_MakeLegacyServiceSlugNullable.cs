using Cms.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <summary>
    /// Compatibility step between the ServiceSlugs migration and removal of the
    /// legacy Services.Slug column. New application code no longer writes it.
    /// </summary>
    [DbContext(typeof(AppDbContext))]
    [Migration("20260825110000_MakeLegacyServiceSlugNullable")]
    public partial class MakeLegacyServiceSlugNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Services",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                UPDATE "Services"
                SET "Slug" = ''
                WHERE "Slug" IS NULL;
                """);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Services",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}
