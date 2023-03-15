using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore_rtj34.Migrations
{
    public partial class CheckoutUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "Checkout",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Checkout");
        }
    }
}
