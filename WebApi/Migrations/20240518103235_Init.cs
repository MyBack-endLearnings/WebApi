using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Category 1" },
                    { 2, "Category 2" },
                    { 3, "Category 3" },
                    { 4, "Category 4" },
                    { 5, "Category 5" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "ImagePath", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(6732), "product1.jpg", "Product 1", 100m, 10 },
                    { 6, 1, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7061), "product6.jpg", "Product 6", 600m, 60 },
                    { 11, 1, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7070), "product11.jpg", "Product 11", 1100m, 110 },
                    { 2, 2, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7053), "product2.jpg", "Product 2", 200m, 20 },
                    { 7, 2, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7063), "product7.jpg", "Product 7", 700m, 70 },
                    { 12, 2, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7072), "product12.jpg", "Product 12", 1200m, 120 },
                    { 3, 3, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7055), "product3.jpg", "Product 3", 300m, 30 },
                    { 8, 3, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7064), "product8.jpg", "Product 8", 800m, 80 },
                    { 13, 3, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7074), "product13.jpg", "Product 13", 1300m, 130 },
                    { 4, 4, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7057), "product4.jpg", "Product 4", 400m, 40 },
                    { 9, 4, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7066), "product9.jpg", "Product 9", 900m, 90 },
                    { 14, 4, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7075), "product14.jpg", "Product 14", 1400m, 140 },
                    { 5, 5, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7059), "product5.jpg", "Product 5", 500m, 50 },
                    { 10, 5, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7068), "product10.jpg", "Product 10", 1000m, 100 },
                    { 15, 5, new DateTime(2024, 5, 18, 14, 32, 35, 647, DateTimeKind.Local).AddTicks(7077), "product15.jpg", "Product 15", 1500m, 150 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
