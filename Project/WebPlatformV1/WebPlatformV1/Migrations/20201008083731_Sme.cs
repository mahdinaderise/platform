using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class Sme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_grades_Gradeid",
                table: "AspNetUsers");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_grades_Gradeid",
                table: "AspNetUsers",
                column: "Gradeid",
                principalTable: "grades",
                principalColumn: "IDGrade",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_grades_Gradeid",
                table: "AspNetUsers");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_grades_Gradeid",
                table: "AspNetUsers",
                column: "Gradeid",
                principalTable: "grades",
                principalColumn: "IDGrade",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
