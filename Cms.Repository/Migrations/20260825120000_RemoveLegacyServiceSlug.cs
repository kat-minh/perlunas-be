using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <summary>
    /// Phase 2 of the service-slug migration. All service URL data now lives in
    /// ServiceSlugs, so the transitional Services.Slug column and its unique
    /// index can be safely removed.
    /// </summary>
    [Migration("20260825120000_RemoveLegacyServiceSlug")]
    public partial class RemoveLegacyServiceSlug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Services_Slug",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Services");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Rebuild the removed legacy value from the canonical ServiceSlug,
            // so a rollback does not lose the current public URL.
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Services",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.Sql("""
                UPDATE "Services" AS s
                SET "Slug" = ss."Slug"
                FROM "ServiceSlugs" AS ss
                WHERE ss."ServiceId" = s."Id"
                  AND ss."IsCanonical" = TRUE;
                """);

            migrationBuilder.Sql("""
                DO $$
                BEGIN
                    IF EXISTS (
                        SELECT 1
                        FROM "Services"
                        WHERE "Slug" IS NULL OR BTRIM("Slug") = ''
                    ) THEN
                        RAISE EXCEPTION
                            'Cannot restore Services.Slug: one or more services have no canonical ServiceSlug.';
                    END IF;
                END $$;
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

            migrationBuilder.CreateIndex(
                name: "IX_Services_Slug",
                table: "Services",
                column: "Slug",
                unique: true);
        }
    }
}
