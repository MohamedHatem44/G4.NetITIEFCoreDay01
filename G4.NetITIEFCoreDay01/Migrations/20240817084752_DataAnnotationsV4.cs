using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G4.NetITIEFCoreDay01.Migrations
{
    /// <inheritdoc />
    public partial class DataAnnotationsV4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_hr_Employee",
                table: "hr_Employee");

            migrationBuilder.RenameTable(
                name: "hr_Employee",
                newName: "hr_Employees");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "hr_Employees",
                newName: "EMP_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hr_Employees",
                table: "hr_Employees",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_hr_Employees",
                table: "hr_Employees");

            migrationBuilder.RenameTable(
                name: "hr_Employees",
                newName: "hr_Employee");

            migrationBuilder.RenameColumn(
                name: "EMP_Name",
                table: "hr_Employee",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hr_Employee",
                table: "hr_Employee",
                column: "Id");
        }
    }
}
