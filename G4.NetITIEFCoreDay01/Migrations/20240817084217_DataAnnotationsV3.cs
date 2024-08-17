using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G4.NetITIEFCoreDay01.Migrations
{
    /// <inheritdoc />
    public partial class DataAnnotationsV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "hr_Employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hr_Employee",
                table: "hr_Employee",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_hr_Employee",
                table: "hr_Employee");

            migrationBuilder.RenameTable(
                name: "hr_Employee",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }
    }
}
