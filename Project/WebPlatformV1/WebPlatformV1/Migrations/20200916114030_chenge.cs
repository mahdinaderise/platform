using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class chenge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestText",
                table: "tbl_Requestonlineclasses");

            migrationBuilder.DropColumn(
                name: "status",
                table: "tbl_Requestonlineclasses");

            migrationBuilder.AddColumn<string>(
                name: "RequestTextConsultant",
                table: "tbl_Requestonlineclasses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestTextStudent",
                table: "tbl_Requestonlineclasses",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "statusForAdmin",
                table: "tbl_Requestonlineclasses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "statusForConsultant",
                table: "tbl_Requestonlineclasses",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestTextConsultant",
                table: "tbl_Requestonlineclasses");

            migrationBuilder.DropColumn(
                name: "RequestTextStudent",
                table: "tbl_Requestonlineclasses");

            migrationBuilder.DropColumn(
                name: "statusForAdmin",
                table: "tbl_Requestonlineclasses");

            migrationBuilder.DropColumn(
                name: "statusForConsultant",
                table: "tbl_Requestonlineclasses");

            migrationBuilder.AddColumn<string>(
                name: "RequestText",
                table: "tbl_Requestonlineclasses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "tbl_Requestonlineclasses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
