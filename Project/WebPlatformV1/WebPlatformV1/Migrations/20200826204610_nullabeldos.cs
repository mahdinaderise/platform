using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class nullabeldos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_tbl_Courses_CourseIDCourse",
                table: "tbl_Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "CourseIDCourse",
                table: "tbl_Tasks",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_tbl_Courses_CourseIDCourse",
                table: "tbl_Tasks",
                column: "CourseIDCourse",
                principalTable: "tbl_Courses",
                principalColumn: "IDCourse",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_tbl_Courses_CourseIDCourse",
                table: "tbl_Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "CourseIDCourse",
                table: "tbl_Tasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_tbl_Courses_CourseIDCourse",
                table: "tbl_Tasks",
                column: "CourseIDCourse",
                principalTable: "tbl_Courses",
                principalColumn: "IDCourse",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
