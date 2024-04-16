using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultationAvocat.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "269d7ef2-b275-4e73-b36c-020d07e8eb3b", "3", "Avocat", "Avocat" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43a5381a-88c7-4c71-bb4c-26b0b78c7f34", "2", "Client", "Client" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d444734-6e01-4841-ae41-7f394b9ac4e6", "1", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "269d7ef2-b275-4e73-b36c-020d07e8eb3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43a5381a-88c7-4c71-bb4c-26b0b78c7f34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d444734-6e01-4841-ae41-7f394b9ac4e6");
        }
    }
}
