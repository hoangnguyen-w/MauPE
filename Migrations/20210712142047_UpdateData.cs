using Microsoft.EntityFrameworkCore.Migrations;

namespace PE.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentsdepId",
                table: "professors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    depId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    max_employee = table.Column<int>(type: "int", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.depId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_professors_DepartmentsdepId",
                table: "professors",
                column: "DepartmentsdepId");

            migrationBuilder.AddForeignKey(
                name: "FK_professors_departments_DepartmentsdepId",
                table: "professors",
                column: "DepartmentsdepId",
                principalTable: "departments",
                principalColumn: "depId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_professors_departments_DepartmentsdepId",
                table: "professors");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropIndex(
                name: "IX_professors_DepartmentsdepId",
                table: "professors");

            migrationBuilder.DropColumn(
                name: "DepartmentsdepId",
                table: "professors");
        }
    }
}
