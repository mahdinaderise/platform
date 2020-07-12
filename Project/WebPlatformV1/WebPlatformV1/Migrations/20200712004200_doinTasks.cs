using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class doinTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDStudent",
                table: "tbl_Tasks");

            migrationBuilder.DropColumn(
                name: "IDido",
                table: "tbl_Tasks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IDStudent",
                table: "tbl_Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDido",
                table: "tbl_Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
