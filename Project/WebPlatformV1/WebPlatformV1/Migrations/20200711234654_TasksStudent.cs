using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class TasksStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_AspNetUsers_StudentId",
                table: "tbl_Tasks");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Tasks_StudentId",
                table: "tbl_Tasks");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "tbl_Tasks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "tbl_Tasks",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tasks_StudentId",
                table: "tbl_Tasks",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_AspNetUsers_StudentId",
                table: "tbl_Tasks",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
