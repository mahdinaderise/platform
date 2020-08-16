using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class editpanel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_AddPanels_AspNetUsers_studentsId",
                table: "tbl_AddPanels");

            migrationBuilder.DropIndex(
                name: "IX_tbl_AddPanels_studentsId",
                table: "tbl_AddPanels");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "tbl_AddPanels");

            migrationBuilder.DropColumn(
                name: "studentsId",
                table: "tbl_AddPanels");

            migrationBuilder.AddColumn<string>(
                name: "ConsultantID",
                table: "tbl_AddPanels",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "tbl_AddPanels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StudentID",
                table: "tbl_AddPanels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_AddPanels_StudentID",
                table: "tbl_AddPanels",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_AddPanels_AspNetUsers_StudentID",
                table: "tbl_AddPanels",
                column: "StudentID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_AddPanels_AspNetUsers_StudentID",
                table: "tbl_AddPanels");

            migrationBuilder.DropIndex(
                name: "IX_tbl_AddPanels_StudentID",
                table: "tbl_AddPanels");

            migrationBuilder.DropColumn(
                name: "ConsultantID",
                table: "tbl_AddPanels");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "tbl_AddPanels");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "tbl_AddPanels");

            migrationBuilder.AddColumn<int>(
                name: "Date",
                table: "tbl_AddPanels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "studentsId",
                table: "tbl_AddPanels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_AddPanels_studentsId",
                table: "tbl_AddPanels",
                column: "studentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_AddPanels_AspNetUsers_studentsId",
                table: "tbl_AddPanels",
                column: "studentsId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
