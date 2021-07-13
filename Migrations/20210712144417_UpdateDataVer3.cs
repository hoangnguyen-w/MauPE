using Microsoft.EntityFrameworkCore.Migrations;

namespace PE.Migrations
{
    public partial class UpdateDataVer3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_professors_departments_DepartmentsdepId",
                table: "professors");

            migrationBuilder.RenameColumn(
                name: "photo",
                table: "professors",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "professors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "married",
                table: "professors",
                newName: "Married");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "professors",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "depId",
                table: "professors",
                newName: "DepId");

            migrationBuilder.RenameColumn(
                name: "birthDate",
                table: "professors",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "professors",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "professors",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "DepartmentsdepId",
                table: "professors",
                newName: "DepartmentsDepId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "professors",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_professors_DepartmentsdepId",
                table: "professors",
                newName: "IX_professors_DepartmentsDepId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "departments",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "max_employee",
                table: "departments",
                newName: "Max_employee");

            migrationBuilder.RenameColumn(
                name: "location",
                table: "departments",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "depId",
                table: "departments",
                newName: "DepId");

            migrationBuilder.AlterColumn<int>(
                name: "DepId",
                table: "professors",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_professors_departments_DepartmentsDepId",
                table: "professors",
                column: "DepartmentsDepId",
                principalTable: "departments",
                principalColumn: "DepId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_professors_departments_DepartmentsDepId",
                table: "professors");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "professors",
                newName: "photo");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "professors",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Married",
                table: "professors",
                newName: "married");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "professors",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "DepartmentsDepId",
                table: "professors",
                newName: "DepartmentsdepId");

            migrationBuilder.RenameColumn(
                name: "DepId",
                table: "professors",
                newName: "depId");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "professors",
                newName: "birthDate");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "professors",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "professors",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "professors",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_professors_DepartmentsDepId",
                table: "professors",
                newName: "IX_professors_DepartmentsdepId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "departments",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Max_employee",
                table: "departments",
                newName: "max_employee");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "departments",
                newName: "location");

            migrationBuilder.RenameColumn(
                name: "DepId",
                table: "departments",
                newName: "depId");

            migrationBuilder.AlterColumn<string>(
                name: "depId",
                table: "professors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_professors_departments_DepartmentsdepId",
                table: "professors",
                column: "DepartmentsdepId",
                principalTable: "departments",
                principalColumn: "depId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
