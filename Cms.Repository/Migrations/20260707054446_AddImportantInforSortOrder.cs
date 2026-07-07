using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddImportantInforSortOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "ImportantInfors",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0001-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0001-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0001-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0001-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0001-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0001-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0002-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0002-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0002-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0002-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0002-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0002-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0003-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0003-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0003-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0003-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0003-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0003-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0004-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0004-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0004-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0004-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0004-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0004-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0005-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0005-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0005-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0005-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0005-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0005-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0006-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0006-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0006-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0006-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0006-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0006-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0007-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0007-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0007-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0007-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0007-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0007-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0008-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0008-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0008-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0008-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0008-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0008-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0009-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0009-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0009-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0009-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0009-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0009-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0010-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0010-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0010-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0010-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0010-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0010-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0011-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0011-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0011-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0011-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0011-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0011-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0012-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0012-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0012-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0012-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0012-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0012-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0013-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0013-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0013-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0013-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0013-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0013-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0014-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0014-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0014-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0014-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0014-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("cccf0014-0000-0000-0000-000000000006"),
                column: "SortOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0001-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0001-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0001-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0001-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0001-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0002-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0002-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0002-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0002-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0002-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0003-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0003-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0003-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0003-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0003-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0004-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0004-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0004-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0004-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0004-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0005-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0005-0000-0000-0000-000000000002"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0005-0000-0000-0000-000000000003"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0005-0000-0000-0000-000000000004"),
                column: "SortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ImportantInfors",
                keyColumn: "Id",
                keyValue: new Guid("eeee0005-0000-0000-0000-000000000005"),
                column: "SortOrder",
                value: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "ImportantInfors");

        }
    }
}
