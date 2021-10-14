using Microsoft.EntityFrameworkCore.Migrations;

namespace PerfumeShop.Migrations
{
    public partial class Seeding_Data_User_Role_UserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "1", "SystemAdmin", "System Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "2", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b74ddd14-6340-4840-95c2-db12554843e5", 0, "~/images/avatar.jpg", "a611bca7-179b-44c4-aef8-4ed3a97f31b5", "nhatnamtran100217@gmail.com", false, false, null, "nhatnamtran100217@gmail.com", "nam tran", "AQAAAAEAACcQAAAAEHJ52tv55A04xDLmHXO1XP1lvIKR+Mm9rshLp3ifXiZh43nEz/8jCPSB+QnhhgRxyg==", "0357373803", false, "0a24db06-5ba8-4a3a-9580-9dd029aa4fa3", false, "Nam Tran" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "b74ddd14-6340-4840-95c2-db12554843e5", "fab4fac1-c546-41de-aebc-a14da6895711" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b74ddd14-6340-4840-95c2-db12554843e5", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5");
        }
    }
}
