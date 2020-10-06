using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class Some : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_grades_Tbl_gradeIDGrade",
                table: "tbl_Tasks");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Tasks_Tbl_gradeIDGrade",
                table: "tbl_Tasks");

            migrationBuilder.DropColumn(
                name: "MyGrade",
                table: "tbl_Tasks");

            migrationBuilder.DropColumn(
                name: "Tbl_gradeIDGrade",
                table: "tbl_Tasks");

            migrationBuilder.AddColumn<int>(
                name: "Gradeid",
                table: "tbl_Tasks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Gradeid",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Student_Province",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Student_city",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Student_telephone",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tasks_Gradeid",
                table: "tbl_Tasks",
                column: "Gradeid");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Gradeid",
                table: "AspNetUsers",
                column: "Gradeid");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_grades_Gradeid",
                table: "AspNetUsers",
                column: "Gradeid",
                principalTable: "grades",
                principalColumn: "IDGrade",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_grades_Gradeid",
                table: "tbl_Tasks",
                column: "Gradeid",
                principalTable: "grades",
                principalColumn: "IDGrade",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_grades_Gradeid",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_grades_Gradeid",
                table: "tbl_Tasks");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Tasks_Gradeid",
                table: "tbl_Tasks");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Gradeid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gradeid",
                table: "tbl_Tasks");

            migrationBuilder.DropColumn(
                name: "Gradeid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Student_Province",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Student_city",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Student_telephone",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "MyGrade",
                table: "tbl_Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tbl_gradeIDGrade",
                table: "tbl_Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tasks_Tbl_gradeIDGrade",
                table: "tbl_Tasks",
                column: "Tbl_gradeIDGrade");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_grades_Tbl_gradeIDGrade",
                table: "tbl_Tasks",
                column: "Tbl_gradeIDGrade",
                principalTable: "grades",
                principalColumn: "IDGrade",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
