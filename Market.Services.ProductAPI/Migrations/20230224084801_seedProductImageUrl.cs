using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Market.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedProductImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://drive.google.com/file/d/14FaHqkl3tdAzCK7LdnTDOiXTjgPkQuOs/view?usp=share_link");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://drive.google.com/file/d/1wGdfFJ9D8FCEBpNSK6N-YBZn7o8OYtDA/view?usp=share_link");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://drive.google.com/file/d/1mflyDEZJPoHEsGoaDINJExFPZH-GgJlR/view?usp=share_link");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://drive.google.com/file/d/1tviPDv5KFEk4-c21vy5jak27jOr54rrV/view?usp=share_link");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://drive.google.com/file/d/14ViuJVRMnrSmnJq-ohfcyMO-zJAVJ6eS/view?usp=share_link");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ImageUrl",
                value: "");
        }
    }
}
