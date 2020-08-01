using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class editTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "tbl_Tasks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimeStudy",
                table: "tbl_Tasks",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "tbl_Tasks");

            migrationBuilder.DropColumn(
                name: "TimeStudy",
                table: "tbl_Tasks");
        }
    }
}
