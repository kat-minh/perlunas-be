using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedContactSocialUrls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "ContentValue", "CreatedAt", "IsDeleted", "Key", "Kind", "Label", "PageKey", "ParentId", "SectionKey", "SoftOrder", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("cfc69857-e9fa-f5be-7b39-5fbfe403deab"), "https://zalo.me/0900000000", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.message.zalo.url", "text", "Liên hệ: URL link Zalo", "Liên hệ", null, "", 94, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55d8d588-b7b1-b34a-17ad-04935f9269d9"), "https://m.me/perlunas", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, "contact.message.messenger.url", "text", "Liên hệ: URL link Messenger", "Liên hệ", null, "", 95, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            foreach (var id in new[] { "cfc69857-e9fa-f5be-7b39-5fbfe403deab", "55d8d588-b7b1-b34a-17ad-04935f9269d9" })
                migrationBuilder.DeleteData(table: "PageContents", keyColumn: "Id", keyValue: new Guid(id));
        }
    }
}
