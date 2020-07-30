using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class SomeEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdConsultant",
                table: "tbl_Tasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdStudent",
                table: "tbl_Tasks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Idcourse",
                table: "tbl_Tasks",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdConsultant",
                table: "tbl_Tasks");

            migrationBuilder.DropColumn(
                name: "IdStudent",
                table: "tbl_Tasks");

            migrationBuilder.DropColumn(
                name: "Idcourse",
                table: "tbl_Tasks");
        }
    }
}
