using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class initialtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IDCansultantId",
                table: "studentOfCansultants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Family",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NationlCode",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_studentOfCansultants_IDCansultantId",
                table: "studentOfCansultants",
                column: "IDCansultantId");

            migrationBuilder.AddForeignKey(
                name: "FK_studentOfCansultants_AspNetUsers_IDCansultantId",
                table: "studentOfCansultants",
                column: "IDCansultantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_studentOfCansultants_AspNetUsers_IDCansultantId",
                table: "studentOfCansultants");

            migrationBuilder.DropIndex(
                name: "IX_studentOfCansultants_IDCansultantId",
                table: "studentOfCansultants");

            migrationBuilder.DropColumn(
                name: "IDCansultantId",
                table: "studentOfCansultants");

            migrationBuilder.DropColumn(
                name: "Family",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NationlCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AspNetUsers");
        }
    }
}
