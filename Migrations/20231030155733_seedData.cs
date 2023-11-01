using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeApp.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "FirstName", "LastName", "Password", "Role", "Username", "isAdmin" },
                values: new object[,]
                {
                    { 1, "Management", "michael.scott@nonamecompany.com", "Michael", "Scott", "randompassword", "CEO", "MScott", true },
                    { 2, "Marketing", "alice.rodriguez@nonamecompany.com", "Alice", "Rodriguez", "12345", "Marketing Manager", "ARodriguez", true },
                    { 3, "Human Resources", "olivia.patel@nonamecompany.com", "Olivia", "Patel", "12345", "HR Coordinator", "OPatel", true },
                    { 4, "IT", "david.nguyen@nonamecompany.com", "David", "Nguyen", "12345", "Software Developer", "DNguyen", false },
                    { 5, "Customer Service", "sophia.garcia@nonamecompany.com", "Sophia", "Garcia", "12345", "Customer Support Representative", "SGarcia", false },
                    { 6, "IT", "daniel.kim@nonamecompany.com", "Daniel", "Kim", "12345", "Systems Administrator", "DKim", false },
                    { 7, "Operations", "emily.ali@nonamecompany.com", "Emily", "Ali", "12345", "Operations Coordinator", "EAli", false },
                    { 8, "Sales", "amelia.williams@nonamecompany.com", "Amelia", "Williams", "12345", "Sales Analyst", "AWilliams", false },
                    { 9, "IT", "mia.davis@nonamecompany.com", "Mia", "Davis", "12345", "IT Support Specialist", "MDavis", false },
                    { 10, "Sales", "gabriel.hernandez@nonamecompany.com", "Gabriel", "Hernandez", "12345", "Sales Support Specialist", "GHernandez", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
