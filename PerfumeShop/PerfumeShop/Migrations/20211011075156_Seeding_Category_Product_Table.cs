using Microsoft.EntityFrameworkCore.Migrations;

namespace PerfumeShop.Migrations
{
    public partial class Seeding_Category_Product_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description", "Status" },
                values: new object[] { 1, "Nước Hoa Nam", "Nước hoa thường thượng nam tính", true });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description", "Status" },
                values: new object[] { 2, "Nước Hoa Nữ", "Quyến rũ", true });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "DescriptionProduct", "Pictures", "Price", "ProductName", "Quantity", "Trademark" },
                values: new object[] { 1, 1, "Chanel luôn nằm trong danh sách mẫu nước hoa đắt đỏ bán chạy nhất", "~/images/chanel.jpg", 18000000, "Chanel", 12, "Chanel" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "DescriptionProduct", "Pictures", "Price", "ProductName", "Quantity", "Trademark" },
                values: new object[] { 2, 2, "Shalimar là chai nước hoa được sáng tạo bởi Jacques Guerlain", "~/images/shalimar.jpg", 12000000, "Shalimar", 10, "Guerlain" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
