using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalatasarayShop.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 9, 16, 38, 55, 598, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 9, 16, 38, 55, 598, DateTimeKind.Local).AddTicks(1472));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 8, 13, 2, 18, 583, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 8, 13, 2, 18, 583, DateTimeKind.Local).AddTicks(8872));
        }
    }
}
