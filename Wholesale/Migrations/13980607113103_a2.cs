using Microsoft.EntityFrameworkCore.Migrations;

namespace Wholesale.Migrations
{
    public partial class a2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_productID",
                table: "ProductImages",
                column: "productID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_productID",
                table: "ProductImages",
                column: "productID",
                principalTable: "Products",
                principalColumn: "productID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_productID",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_productID",
                table: "ProductImages");
        }
    }
}
