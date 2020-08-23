using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class statusinpanel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "tbl_AddPanels",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "tbl_AddPanels");
        }
    }
}
