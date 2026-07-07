using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddScheduleSortOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Schedules",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0001-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0001-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0002-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0002-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0002-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0003-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0003-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0004-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0004-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0004-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0004-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0005-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0005-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0005-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0006-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0006-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0006-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0007-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0007-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0007-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0007-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0008-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0008-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0009-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0009-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0009-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0010-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0010-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0010-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0011-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0011-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0012-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0012-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0012-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0013-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0013-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0014-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0014-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cbbb0014-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0001-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0001-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0001-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0002-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0002-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0002-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0003-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0003-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0003-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0003-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0004-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0004-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0004-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0005-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0005-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: new Guid("cccc0005-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Schedules");

        }
    }
}
