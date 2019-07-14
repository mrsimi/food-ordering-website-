using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrderingWebsite.Data.Migrations
{
    public partial class updatestatustabletoincludedatetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateTimeOrderCompleted",
                table: "DeliveryStatuses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeOrderCompleted",
                table: "DeliveryStatuses");
        }
    }
}
