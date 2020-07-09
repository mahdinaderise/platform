using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class InitialMainDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentOfCansultants_AspNetUsers_IDCansultantId",
                table: "studentOfCansultants");

            migrationBuilder.DropForeignKey(
                name: "FK_studentOfCansultants_AspNetUsers_IDStudentId",
                table: "studentOfCansultants");

            migrationBuilder.DropIndex(
                name: "IX_studentOfCansultants_IDCansultantId",
                table: "studentOfCansultants");

            migrationBuilder.DropIndex(
                name: "IX_studentOfCansultants_IDStudentId",
                table: "studentOfCansultants");

            migrationBuilder.DropColumn(
                name: "IDCansultantId",
                table: "studentOfCansultants");

            migrationBuilder.DropColumn(
                name: "IDStudentId",
                table: "studentOfCansultants");

            migrationBuilder.AddColumn<string>(
                name: "CansultantId",
                table: "studentOfCansultants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "studentOfCansultants",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_studentOfCansultants_CansultantId",
                table: "studentOfCansultants",
                column: "CansultantId");

            migrationBuilder.CreateIndex(
                name: "IX_studentOfCansultants_StudentId",
                table: "studentOfCansultants",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_studentOfCansultants_AspNetUsers_CansultantId",
                table: "studentOfCansultants",
                column: "CansultantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_studentOfCansultants_AspNetUsers_StudentId",
                table: "studentOfCansultants",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentOfCansultants_AspNetUsers_CansultantId",
                table: "studentOfCansultants");

            migrationBuilder.DropForeignKey(
                name: "FK_studentOfCansultants_AspNetUsers_StudentId",
                table: "studentOfCansultants");

            migrationBuilder.DropIndex(
                name: "IX_studentOfCansultants_CansultantId",
                table: "studentOfCansultants");

            migrationBuilder.DropIndex(
                name: "IX_studentOfCansultants_StudentId",
                table: "studentOfCansultants");

            migrationBuilder.DropColumn(
                name: "CansultantId",
                table: "studentOfCansultants");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "studentOfCansultants");

            migrationBuilder.AddColumn<string>(
                name: "IDCansultantId",
                table: "studentOfCansultants",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IDStudentId",
                table: "studentOfCansultants",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_studentOfCansultants_IDCansultantId",
                table: "studentOfCansultants",
                column: "IDCansultantId");

            migrationBuilder.CreateIndex(
                name: "IX_studentOfCansultants_IDStudentId",
                table: "studentOfCansultants",
                column: "IDStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_studentOfCansultants_AspNetUsers_IDCansultantId",
                table: "studentOfCansultants",
                column: "IDCansultantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_studentOfCansultants_AspNetUsers_IDStudentId",
                table: "studentOfCansultants",
                column: "IDStudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
