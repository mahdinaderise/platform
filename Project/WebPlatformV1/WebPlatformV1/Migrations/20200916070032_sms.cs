using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class sms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tbl_RequestonlineclassStudentid",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Student_Tbl_RequestonlineclassStudentid",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_Requestonlineclasses",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsultantID = table.Column<string>(nullable: true),
                    StudentID = table.Column<string>(nullable: true),
                    status = table.Column<bool>(nullable: false),
                    RequestText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Requestonlineclasses", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Tbl_RequestonlineclassStudentid",
                table: "AspNetUsers",
                column: "Tbl_RequestonlineclassStudentid");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Student_Tbl_RequestonlineclassStudentid",
                table: "AspNetUsers",
                column: "Student_Tbl_RequestonlineclassStudentid");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_tbl_Requestonlineclasses_Tbl_RequestonlineclassStudentid",
                table: "AspNetUsers",
                column: "Tbl_RequestonlineclassStudentid",
                principalTable: "tbl_Requestonlineclasses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_tbl_Requestonlineclasses_Student_Tbl_RequestonlineclassStudentid",
                table: "AspNetUsers",
                column: "Student_Tbl_RequestonlineclassStudentid",
                principalTable: "tbl_Requestonlineclasses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_tbl_Requestonlineclasses_Tbl_RequestonlineclassStudentid",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_tbl_Requestonlineclasses_Student_Tbl_RequestonlineclassStudentid",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "tbl_Requestonlineclasses");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Tbl_RequestonlineclassStudentid",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Student_Tbl_RequestonlineclassStudentid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Tbl_RequestonlineclassStudentid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Student_Tbl_RequestonlineclassStudentid",
                table: "AspNetUsers");
        }
    }
}
