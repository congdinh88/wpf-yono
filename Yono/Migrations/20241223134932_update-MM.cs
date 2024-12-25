using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yono.Migrations
{
    /// <inheritdoc />
    public partial class updateMM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "DepartmentRole",
                schema: "Employee",
                columns: table => new
                {
                    DepartmentsDepartmentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RolesRoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentRole", x => new { x.DepartmentsDepartmentId, x.RolesRoleId });
                    table.ForeignKey(
                        name: "FK_DepartmentRole_Departments_DepartmentsDepartmentId",
                        column: x => x.DepartmentsDepartmentId,
                        principalSchema: "Employee",
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentRole_Roles_RolesRoleId",
                        column: x => x.RolesRoleId,
                        principalSchema: "Employee",
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentRole_RolesRoleId",
                schema: "Employee",
                table: "DepartmentRole",
                column: "RolesRoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentRole",
                schema: "Employee");

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
    }
}
