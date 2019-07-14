using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrderingWebsite.Data.Migrations
{
    public partial class changeddatetimeordercompletedtodatetimedatatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTimeOrderCompleted",
                table: "DeliveryStatuses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateTimeOrderCompleted",
                table: "DeliveryStatuses",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
