using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class nullabeldo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_tbl_Dos_DoIDdo",
                table: "tbl_Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "DoIDdo",
                table: "tbl_Tasks",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_tbl_Dos_DoIDdo",
                table: "tbl_Tasks",
                column: "DoIDdo",
                principalTable: "tbl_Dos",
                principalColumn: "IDdo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_tbl_Dos_DoIDdo",
                table: "tbl_Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "DoIDdo",
                table: "tbl_Tasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_tbl_Dos_DoIDdo",
                table: "tbl_Tasks",
                column: "DoIDdo",
                principalTable: "tbl_Dos",
                principalColumn: "IDdo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
