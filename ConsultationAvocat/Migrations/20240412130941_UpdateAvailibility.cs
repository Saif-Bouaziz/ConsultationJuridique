using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultationAvocat.Migrations
{
    public partial class UpdateAvailibility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0bf22cc3-4236-4d17-8785-c18dfb26cad7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f576e0e-77f5-41db-9826-7beac117751c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8d24349-bfd1-464a-9392-db5fc5aff39b");

            migrationBuilder.AddColumn<string>(
                name: "AvocatName",
                table: "AvocatAvailabilities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "02eb0703-b2b7-4a51-b0e8-26d18069875d", "3", "Avocat", "Avocat" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d96e5ef2-ab1a-486f-97eb-8d07217e0210", "2", "Client", "Client" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e16bbf7b-536a-4091-91e8-c29c84dd7080", "1", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02eb0703-b2b7-4a51-b0e8-26d18069875d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d96e5ef2-ab1a-486f-97eb-8d07217e0210");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e16bbf7b-536a-4091-91e8-c29c84dd7080");

            migrationBuilder.DropColumn(
                name: "AvocatName",
                table: "AvocatAvailabilities");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0bf22cc3-4236-4d17-8785-c18dfb26cad7", "2", "Client", "Client" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f576e0e-77f5-41db-9826-7beac117751c", "1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a8d24349-bfd1-464a-9392-db5fc5aff39b", "3", "Avocat", "Avocat" });
        }
    }
}
