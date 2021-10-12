using Microsoft.EntityFrameworkCore.Migrations;

namespace PerfumeShop.Migrations
{
    public partial class Update_Product_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionProduct",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionProduct",
                table: "Products");
        }
    }
}
