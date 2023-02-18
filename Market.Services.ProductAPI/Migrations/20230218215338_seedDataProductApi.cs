using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Market.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedDataProductApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Glossery", "An Excellent Product of Wood", "", "P1", 1000 },
                    { 2, "TV", "An Excellent Product in TV", "", "P2", 3000 },
                    { 3, "Glossery", "An Excellent Product of Vahid's land", "", "P3", 500 },
                    { 4, "Glossery", "An Excellent Product of Delsa's Hand", "", "P4", 1000 },
                    { 5, "Mobile", "An Excellent Product of Apple", "", "P5", 10000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 5);
        }
    }
}
