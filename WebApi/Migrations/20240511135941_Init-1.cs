using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    decimal182 = table.Column<decimal>(name: "decimal(18,2)", type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "Name", "decimal(18,2)", "Stock" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 11, 17, 59, 41, 240, DateTimeKind.Local).AddTicks(6191), "product1.jpg", "Product 1", 100m, 10 },
                    { 2, new DateTime(2024, 5, 11, 17, 59, 41, 241, DateTimeKind.Local).AddTicks(5567), "product2.jpg", "Product 2", 200m, 20 },
                    { 3, new DateTime(2024, 5, 11, 17, 59, 41, 241, DateTimeKind.Local).AddTicks(5584), "product3.jpg", "Product 3", 300m, 30 },
                    { 4, new DateTime(2024, 5, 11, 17, 59, 41, 241, DateTimeKind.Local).AddTicks(5586), "product4.jpg", "Product 4", 400m, 40 },
                    { 5, new DateTime(2024, 5, 11, 17, 59, 41, 241, DateTimeKind.Local).AddTicks(5589), "product5.jpg", "Product 5", 500m, 50 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
