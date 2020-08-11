using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class consultant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Blogs_AspNetUsers_consultantId",
                table: "tbl_Blogs");

            migrationBuilder.RenameColumn(
                name: "consultantId",
                table: "tbl_Blogs",
                newName: "ConsultantId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Blogs_consultantId",
                table: "tbl_Blogs",
                newName: "IX_tbl_Blogs_ConsultantId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Blogs_AspNetUsers_ConsultantId",
                table: "tbl_Blogs",
                column: "ConsultantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Blogs_AspNetUsers_ConsultantId",
                table: "tbl_Blogs");

            migrationBuilder.RenameColumn(
                name: "ConsultantId",
                table: "tbl_Blogs",
                newName: "consultantId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Blogs_ConsultantId",
                table: "tbl_Blogs",
                newName: "IX_tbl_Blogs_consultantId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Blogs_AspNetUsers_consultantId",
                table: "tbl_Blogs",
                column: "consultantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
