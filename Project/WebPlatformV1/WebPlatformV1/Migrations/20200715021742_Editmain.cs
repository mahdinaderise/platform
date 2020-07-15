using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class Editmain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Dos_tbl_Tasks_taskIDTasks",
                table: "tbl_Dos");

            migrationBuilder.DropTable(
                name: "Tbl_TasksOfStudents");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Dos_taskIDTasks",
                table: "tbl_Dos");

            migrationBuilder.DropColumn(
                name: "taskIDTasks",
                table: "tbl_Dos");

            migrationBuilder.AddColumn<int>(
                name: "DoIDdo",
                table: "tbl_Tasks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "tbl_Tasks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tasks_DoIDdo",
                table: "tbl_Tasks",
                column: "DoIDdo");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tasks_StudentID",
                table: "tbl_Tasks",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_tbl_Dos_DoIDdo",
                table: "tbl_Tasks",
                column: "DoIDdo",
                principalTable: "tbl_Dos",
                principalColumn: "IDdo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_students_StudentID",
                table: "tbl_Tasks",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_tbl_Dos_DoIDdo",
                table: "tbl_Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_students_StudentID",
                table: "tbl_Tasks");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Tasks_DoIDdo",
                table: "tbl_Tasks");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Tasks_StudentID",
                table: "tbl_Tasks");

            migrationBuilder.DropColumn(
                name: "DoIDdo",
                table: "tbl_Tasks");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "tbl_Tasks");

            migrationBuilder.AddColumn<int>(
                name: "taskIDTasks",
                table: "tbl_Dos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_TasksOfStudents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoIDdo = table.Column<int>(type: "int", nullable: true),
                    StudentID = table.Column<int>(type: "int", nullable: true),
                    TasksIDTasks = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TasksOfStudents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tbl_TasksOfStudents_tbl_Dos_DoIDdo",
                        column: x => x.DoIDdo,
                        principalTable: "tbl_Dos",
                        principalColumn: "IDdo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_TasksOfStudents_students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_TasksOfStudents_tbl_Tasks_TasksIDTasks",
                        column: x => x.TasksIDTasks,
                        principalTable: "tbl_Tasks",
                        principalColumn: "IDTasks",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Dos_taskIDTasks",
                table: "tbl_Dos",
                column: "taskIDTasks");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TasksOfStudents_DoIDdo",
                table: "Tbl_TasksOfStudents",
                column: "DoIDdo");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TasksOfStudents_StudentID",
                table: "Tbl_TasksOfStudents",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TasksOfStudents_TasksIDTasks",
                table: "Tbl_TasksOfStudents",
                column: "TasksIDTasks");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Dos_tbl_Tasks_taskIDTasks",
                table: "tbl_Dos",
                column: "taskIDTasks",
                principalTable: "tbl_Tasks",
                principalColumn: "IDTasks",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
