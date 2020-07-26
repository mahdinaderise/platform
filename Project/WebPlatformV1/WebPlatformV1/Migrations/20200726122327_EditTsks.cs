using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class EditTsks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descibtion",
                table: "tbl_Tasks",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDo",
                table: "tbl_Tasks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descibtion",
                table: "tbl_Tasks");

            migrationBuilder.DropColumn(
                name: "isDo",
                table: "tbl_Tasks");
        }
    }
}
