using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrderingWebsite.Data.Migrations
{
    public partial class initialcreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resturants",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ResturantName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    OpeningHours = table.Column<string>(nullable: true),
                    ResturantImagesUriConcatenated = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resturants", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ResturantID = table.Column<int>(nullable: false),
                    FoodName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    FoodImagesUriConcatenated = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Foods_Resturants_ResturantID",
                        column: x => x.ResturantID,
                        principalTable: "Resturants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_ResturantID",
                table: "Foods",
                column: "ResturantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Resturants");
        }
    }
}
