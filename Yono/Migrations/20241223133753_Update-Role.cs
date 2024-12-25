using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yono.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartmentId1",
                schema: "Employee",
                table: "Roles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_DepartmentId1",
                schema: "Employee",
                table: "Roles",
                column: "DepartmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Departments_DepartmentId1",
                schema: "Employee",
                table: "Roles",
                column: "DepartmentId1",
                principalSchema: "Employee",
                principalTable: "Departments",
                principalColumn: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Departments_DepartmentId1",
                schema: "Employee",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_DepartmentId1",
                schema: "Employee",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                schema: "Employee",
                table: "Roles");
        }
    }
}
