using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class EditInitiial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tbl_TasksIDTasks",
                table: "tbl_Dos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Dos_Tbl_TasksIDTasks",
                table: "tbl_Dos",
                column: "Tbl_TasksIDTasks");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Dos_tbl_Tasks_Tbl_TasksIDTasks",
                table: "tbl_Dos",
                column: "Tbl_TasksIDTasks",
                principalTable: "tbl_Tasks",
                principalColumn: "IDTasks",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Dos_tbl_Tasks_Tbl_TasksIDTasks",
                table: "tbl_Dos");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Dos_Tbl_TasksIDTasks",
                table: "tbl_Dos");

            migrationBuilder.DropColumn(
                name: "Tbl_TasksIDTasks",
                table: "tbl_Dos");
        }
    }
}
