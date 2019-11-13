using Microsoft.EntityFrameworkCore.Migrations;

namespace DossierPDP.Migrations
{
    public partial class SeedCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerFirstName", "CustomerLastName", "Email", "Telephonenumber" },
                values: new object[] { 1, "Nick", "Foulon", "foulonnick@gmail.com", "123456789" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerFirstName", "CustomerLastName", "Email", "Telephonenumber" },
                values: new object[] { 2, "Raf", "Gillisjans", null, null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerFirstName", "CustomerLastName", "Email", "Telephonenumber" },
                values: new object[] { 3, "Paul-Henry", "Decuvelier", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);
        }
    }
}
