using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class editdo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountTest",
                table: "tbl_Dos");

            migrationBuilder.DropColumn(
                name: "TimeStudy",
                table: "tbl_Dos");

            migrationBuilder.AddColumn<int>(
                name: "DiscriptiveTime",
                table: "tbl_Dos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NullTest",
                table: "tbl_Dos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RevisionTime",
                table: "tbl_Dos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TestTime",
                table: "tbl_Dos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrueTest",
                table: "tbl_Dos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "falseTest",
                table: "tbl_Dos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscriptiveTime",
                table: "tbl_Dos");

            migrationBuilder.DropColumn(
                name: "NullTest",
                table: "tbl_Dos");

            migrationBuilder.DropColumn(
                name: "RevisionTime",
                table: "tbl_Dos");

            migrationBuilder.DropColumn(
                name: "TestTime",
                table: "tbl_Dos");

            migrationBuilder.DropColumn(
                name: "TrueTest",
                table: "tbl_Dos");

            migrationBuilder.DropColumn(
                name: "falseTest",
                table: "tbl_Dos");

            migrationBuilder.AddColumn<int>(
                name: "CountTest",
                table: "tbl_Dos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TimeStudy",
                table: "tbl_Dos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
