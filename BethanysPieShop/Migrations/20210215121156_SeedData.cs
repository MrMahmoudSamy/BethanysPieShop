using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Fruit Pie", "All fruit pie" },
                    { 2, "Cheese cakes", "Chees" },
                    { 3, "Coffee", "Coffee beans makes drinks" },
                    { 4, "Fruit Juice", "All fruit juice" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductOftheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "~/images/59b13b33-a1fd-47b3-a376-f735af81c40a.jpg", null, false, false, null, "Strawberry Pie", 15.95m, null },
                    { 2, 1, "~/images/ApplePie.jpg", null, false, false, null, "Appel Pie", 15.95m, null },
                    { 3, 2, "~/images/CheeseCacke.jpg", null, false, false, null, "Cheese cake", 15.95m, null },
                    { 4, 3, "~/images/turkish-coffee.jpg", null, false, false, null, "Turkey coffe", 15.95m, null },
                    { 5, 4, "~/images/strawberrysmoothie.jpg", null, false, false, null, "Strawberry Smoothy", 15.95m, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
