using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class newss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_grades_Gradeid",
                table: "tbl_Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "Gradeid",
                table: "tbl_Tasks",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_grades_Gradeid",
                table: "tbl_Tasks",
                column: "Gradeid",
                principalTable: "grades",
                principalColumn: "IDGrade",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_grades_Gradeid",
                table: "tbl_Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "Gradeid",
                table: "tbl_Tasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_grades_Gradeid",
                table: "tbl_Tasks",
                column: "Gradeid",
                principalTable: "grades",
                principalColumn: "IDGrade",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
