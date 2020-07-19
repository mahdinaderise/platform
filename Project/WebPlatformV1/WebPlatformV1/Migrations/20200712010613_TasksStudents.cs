using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class TasksStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_TasksOfStudents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TasksIDTasks = table.Column<int>(nullable: true),
                    DoIDdo = table.Column<int>(nullable: true),
                    StudentId = table.Column<string>(nullable: true)
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
                        name: "FK_Tbl_TasksOfStudents_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_TasksOfStudents_tbl_Tasks_TasksIDTasks",
                        column: x => x.TasksIDTasks,
                        principalTable: "tbl_Tasks",
                        principalColumn: "IDTasks",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TasksOfStudents_DoIDdo",
                table: "Tbl_TasksOfStudents",
                column: "DoIDdo");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TasksOfStudents_StudentId",
                table: "Tbl_TasksOfStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TasksOfStudents_TasksIDTasks",
                table: "Tbl_TasksOfStudents",
                column: "TasksIDTasks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_TasksOfStudents");
        }
    }
}
