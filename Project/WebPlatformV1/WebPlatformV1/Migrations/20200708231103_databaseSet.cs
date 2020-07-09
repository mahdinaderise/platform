using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class databaseSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDStudent",
                table: "studentOfCansultants");

            migrationBuilder.AddColumn<string>(
                name: "IDStudentId",
                table: "studentOfCansultants",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_studentOfCansultants_IDStudentId",
                table: "studentOfCansultants",
                column: "IDStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_studentOfCansultants_AspNetUsers_IDStudentId",
                table: "studentOfCansultants",
                column: "IDStudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentOfCansultants_AspNetUsers_IDStudentId",
                table: "studentOfCansultants");

            migrationBuilder.DropIndex(
                name: "IX_studentOfCansultants_IDStudentId",
                table: "studentOfCansultants");

            migrationBuilder.DropColumn(
                name: "IDStudentId",
                table: "studentOfCansultants");

            migrationBuilder.AddColumn<int>(
                name: "IDStudent",
                table: "studentOfCansultants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
