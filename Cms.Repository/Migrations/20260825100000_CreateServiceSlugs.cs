using System;
using Cms.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <summary>
    /// Phase 1 of moving service URLs out of Services.Slug.
    ///
    /// The existing Slug column intentionally remains in this migration so the
    /// currently deployed application keeps working.  Every existing service,
    /// including soft-deleted ones, receives one canonical ServiceSlug row.
    /// A later migration will remove Services.Slug after application code has
    /// been switched to this table.
    /// </summary>
    [DbContext(typeof(AppDbContext))]
    [Migration("20260825100000_CreateServiceSlugs")]
    public partial class CreateServiceSlugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Do not silently skip malformed legacy values: that would leave a
            // service without a canonical URL after this migration.
            migrationBuilder.Sql("""
                DO $$
                BEGIN
                    IF EXISTS (
                        SELECT 1
                        FROM "Services"
                        WHERE "Slug" IS NULL OR BTRIM("Slug") = ''
                    ) THEN
                        RAISE EXCEPTION
                            'Cannot migrate Services.Slug: one or more services have an empty slug.';
                    END IF;
                END $$;
                """);

            migrationBuilder.CreateTable(
                name: "ServiceSlugs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Slug = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    IsCanonical = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RetiredAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSlugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceSlugs_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.CheckConstraint(
                        name: "CK_ServiceSlugs_Slug_NotBlank",
                        sql: "BTRIM(\"Slug\") <> ''");
                });

            // A slug can belong to only one service for its entire lifetime.
            migrationBuilder.CreateIndex(
                name: "IX_ServiceSlugs_Slug",
                table: "ServiceSlugs",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSlugs_ServiceId",
                table: "ServiceSlugs",
                column: "ServiceId");

            // PostgreSQL partial unique index: exactly one canonical slug per service.
            migrationBuilder.CreateIndex(
                name: "IX_ServiceSlugs_ServiceId_Canonical",
                table: "ServiceSlugs",
                column: "ServiceId",
                unique: true,
                filter: "\"IsCanonical\" = TRUE");

            // Id = ServiceId is safe for the initial one-to-one backfill and
            // avoids requiring a database UUID extension.  Future historical
            // rows will receive normal application-generated GUIDs.
            migrationBuilder.Sql("""
                INSERT INTO "ServiceSlugs"
                    ("Id", "ServiceId", "Slug", "IsCanonical", "CreatedAt", "UpdatedAt", "RetiredAt")
                SELECT
                    "Id", "Id", "Slug", TRUE, "CreatedAt", "UpdatedAt", NULL
                FROM "Services";
                """);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Services.Slug has not been changed in phase 1, so rolling back
            // only removes the new, backfilled table.
            migrationBuilder.DropTable(name: "ServiceSlugs");
        }
    }
}
