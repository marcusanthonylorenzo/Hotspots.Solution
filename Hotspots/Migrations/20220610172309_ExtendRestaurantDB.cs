using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotspots.Migrations
{
    public partial class ExtendRestaurantDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "City", "Cuisine", "Name" },
                values: new object[,]
                {
                    { 7, "Melbourne", "Bar/Tapas", "Peaches" },
                    { 8, "Melbourne", "Bar/Thai", "Cookie" },
                    { 9, "Sydney", "Thai", "Holy Basil" },
                    { 10, "Sydney", "Chicken Shop", "El Jannah" },
                    { 11, "Richmond", "Sandwiches", "Hectors Deli" },
                    { 12, "Collingwood", "Vegan/Pizza", "Red Sparrow Pizza" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
