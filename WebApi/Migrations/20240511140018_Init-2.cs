using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "decimal(18,2)",
                table: "Product",
                newName: "Price");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 18, 0, 18, 232, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 18, 0, 18, 234, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 18, 0, 18, 234, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 18, 0, 18, 234, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 18, 0, 18, 234, DateTimeKind.Local).AddTicks(422));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Product",
                newName: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 17, 59, 41, 240, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 17, 59, 41, 241, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 17, 59, 41, 241, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 17, 59, 41, 241, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 11, 17, 59, 41, 241, DateTimeKind.Local).AddTicks(5589));
        }
    }
}
