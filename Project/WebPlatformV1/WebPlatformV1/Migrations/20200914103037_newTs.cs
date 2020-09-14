using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class newTs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Tbl_RequestPeyment");

            migrationBuilder.AddColumn<int>(
                name: "value",
                table: "Tbl_RequestPeyment",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "value",
                table: "Tbl_RequestPeyment");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Tbl_RequestPeyment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
