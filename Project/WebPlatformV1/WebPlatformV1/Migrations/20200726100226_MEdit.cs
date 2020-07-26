using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class MEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_FinnialManegments_AspNetUsers_StudentId",
                table: "tbl_FinnialManegments");

            migrationBuilder.DropColumn(
                name: "IDCansoltant",
                table: "tbl_Tasks");

            migrationBuilder.DropColumn(
                name: "IDStudent",
                table: "tbl_Dos");

            migrationBuilder.DropColumn(
                name: "IDConsultant",
                table: "tbl_Blogs");

            migrationBuilder.DropColumn(
                name: "IDConsultant",
                table: "tbl_AddPanels");

            migrationBuilder.DropColumn(
                name: "IDStudent",
                table: "tbl_AddPanels");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "tbl_FinnialManegments",
                newName: "studentId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_FinnialManegments_StudentId",
                table: "tbl_FinnialManegments",
                newName: "IX_tbl_FinnialManegments_studentId");

            migrationBuilder.AddColumn<string>(
                name: "consultantId",
                table: "tbl_FinnialManegments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FinnialManegments_consultantId",
                table: "tbl_FinnialManegments",
                column: "consultantId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_FinnialManegments_AspNetUsers_consultantId",
                table: "tbl_FinnialManegments",
                column: "consultantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_FinnialManegments_AspNetUsers_studentId",
                table: "tbl_FinnialManegments",
                column: "studentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_FinnialManegments_AspNetUsers_consultantId",
                table: "tbl_FinnialManegments");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_FinnialManegments_AspNetUsers_studentId",
                table: "tbl_FinnialManegments");

            migrationBuilder.DropIndex(
                name: "IX_tbl_FinnialManegments_consultantId",
                table: "tbl_FinnialManegments");

            migrationBuilder.DropColumn(
                name: "consultantId",
                table: "tbl_FinnialManegments");

            migrationBuilder.RenameColumn(
                name: "studentId",
                table: "tbl_FinnialManegments",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_FinnialManegments_studentId",
                table: "tbl_FinnialManegments",
                newName: "IX_tbl_FinnialManegments_StudentId");

            migrationBuilder.AddColumn<int>(
                name: "IDCansoltant",
                table: "tbl_Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDStudent",
                table: "tbl_Dos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDConsultant",
                table: "tbl_Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDConsultant",
                table: "tbl_AddPanels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDStudent",
                table: "tbl_AddPanels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_FinnialManegments_AspNetUsers_StudentId",
                table: "tbl_FinnialManegments",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
