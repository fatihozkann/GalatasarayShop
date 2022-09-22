using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalatasarayShop.Data.Migrations
{
    public partial class cityproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 9, 23, 16, 33, 470, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 9, 23, 16, 33, 470, DateTimeKind.Local).AddTicks(6072));
        }
    }
}
