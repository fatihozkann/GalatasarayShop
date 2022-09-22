using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalatasarayShop.Data.Migrations
{
    public partial class end : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 17, 21, 12, 11, 378, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 17, 21, 12, 11, 378, DateTimeKind.Local).AddTicks(3456));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
