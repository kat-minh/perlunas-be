using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddRoomCategorySortOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "RoomCategories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("0559c6c1-868c-0017-a07e-25c63e52bf9f"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("091cbcd6-efb3-c02a-b8e0-5ffd1cca30ee"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("0cf635ce-d52b-b513-ba6a-74ee39f25a6d"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("1a1268da-0ede-1f56-1c68-b666bcb31268"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d42b704-76bf-5fbc-86c0-9c4660cdd82d"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("29feb817-52b4-4987-43fd-93c40e1b9e64"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("31083de2-b476-7eb0-3500-22f86573d6ec"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("35b9f593-0042-95cb-1d01-7fc1d1944bf9"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e07e0f0-7c49-f8ee-4a1f-2a9bbc9989c4"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("4cede885-a106-edd7-0f33-00ea24d04576"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("5056c7b1-ef94-e9fa-de2c-3b80a7732955"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("51bc31fa-442f-4571-669c-523e6e01856d"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("672dc816-8bf9-25cd-b92a-c60449deb7f5"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("6938b7b7-9e45-d7b3-679d-b82907a5c369"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("69c064c0-4ab2-a8e3-58b2-31b21188a087"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("6a4f7b2f-5a2c-87a5-620f-a7551777ca7d"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("708f3f2b-a8c0-ad23-60c2-699655278658"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("761c3b3a-b4da-bfad-19cf-e1a8fec0dc0a"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("7742168d-1099-c9e8-56ea-52ec97cf5cfe"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("7830e8b6-acd3-aa5b-6a0b-1264c0470c08"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("78d4ee4f-9912-a914-689c-8384da89b713"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("93ecb381-650f-88a2-79a8-6cf950467964"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("9754a920-301e-09e5-17c0-b73889efa55b"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("9bdb6ad7-5f65-28e8-4b75-b0f64606ff52"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("9efcdd28-bbf2-e1bf-f0fc-79f323b19fac"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("a07c5c26-1d67-1785-77db-b74d17a7fa41"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("a3c67ce7-0778-c46c-7bd3-57522ab5c1af"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7ee2e0b-e247-98e1-6d62-2a427d0351fb"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac7b0224-7f7e-fee8-5d0c-db36ba8e8338"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("b05bfbbc-a414-5b05-69bb-590dfe2f04b6"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("b0e953e6-7701-82e4-2173-a2310f0c1926"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("b8dc13da-ecc1-6666-c42a-d5b3529a1b6c"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("c774f59f-78c9-27c7-08b6-68b731096f7b"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0001-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0002-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0003-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0004-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0005-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0006-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0007-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0008-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0009-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0010-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0011-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0012-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0013-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("caaa0014-0000-0000-0000-000000000001"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("d075b846-c465-e5a8-a7be-61db00229313"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("d205a310-226e-8ef9-19f5-a4b2b08bcf54"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("da3ad21d-bfc1-4aee-f3da-3086eb562d82"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("dd22ef47-b31f-0842-94e6-7e3a794e01b3"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("e00f4c6b-0af4-4d27-1440-1dc57d205f24"),
                column: "SortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("e1a988d7-f012-a4af-a3a3-0723f879d679"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4941d73-3ee7-2539-9924-dc0ada32a0f2"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("e6e7478f-4a33-1db8-995a-78f13ae4a437"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("e9af099d-3ced-64cc-42f2-292d42af1bcc"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("eb8e560f-39fa-2491-6d0f-1285031c7021"),
                column: "SortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("ee478102-c48b-4995-d01b-9b1f3c0a1c04"),
                column: "SortOrder",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: new Guid("fed2fc75-8102-e282-9c6b-f46ffd6acd21"),
                column: "SortOrder",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "RoomCategories");

        }
    }
}
