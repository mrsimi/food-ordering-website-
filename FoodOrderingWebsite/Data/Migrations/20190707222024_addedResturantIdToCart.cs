using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrderingWebsite.Data.Migrations
{
    public partial class addedResturantIdToCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResturantId",
                table: "Carts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResturantId",
                table: "Carts");
        }
    }
}
