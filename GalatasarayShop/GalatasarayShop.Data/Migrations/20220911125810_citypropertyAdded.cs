using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalatasarayShop.Data.Migrations
{
    public partial class citypropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 11, 15, 58, 10, 142, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 11, 15, 58, 10, 142, DateTimeKind.Local).AddTicks(8528));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 11, 15, 52, 49, 755, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 11, 15, 52, 49, 755, DateTimeKind.Local).AddTicks(5529));
        }
    }
}
