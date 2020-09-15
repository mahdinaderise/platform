using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class somech : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tbl_RequestPeyment_Tbl_RequestPeymentid",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Tbl_RequestPeymentid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Tbl_RequestPeymentid",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "RequestPeymentid",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RequestPeymentid",
                table: "AspNetUsers",
                column: "RequestPeymentid");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tbl_RequestPeyment_RequestPeymentid",
                table: "AspNetUsers",
                column: "RequestPeymentid",
                principalTable: "Tbl_RequestPeyment",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tbl_RequestPeyment_RequestPeymentid",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RequestPeymentid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RequestPeymentid",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Tbl_RequestPeymentid",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Tbl_RequestPeymentid",
                table: "AspNetUsers",
                column: "Tbl_RequestPeymentid");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tbl_RequestPeyment_Tbl_RequestPeymentid",
                table: "AspNetUsers",
                column: "Tbl_RequestPeymentid",
                principalTable: "Tbl_RequestPeyment",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
