using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class Main : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_AddPanels_AspNetUsers_CansultantId",
                table: "tbl_AddPanels");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_AddPanels_AspNetUsers_StudentId",
                table: "tbl_AddPanels");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Blogs_AspNetUsers_CansultantId",
                table: "tbl_Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Dos_tbl_Tasks_Tbl_TasksIDTasks",
                table: "tbl_Dos");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Headlines_tbl_Courses_Tbl_CourseIDCourse",
                table: "tbl_Headlines");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_AspNetUsers_CansultantId",
                table: "tbl_Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_TasksOfStudents_AspNetUsers_StudentId",
                table: "Tbl_TasksOfStudents");

            migrationBuilder.DropTable(
                name: "tbl_TasksCourses");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Headlines_Tbl_CourseIDCourse",
                table: "tbl_Headlines");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Dos_Tbl_TasksIDTasks",
                table: "tbl_Dos");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Blogs_CansultantId",
                table: "tbl_Blogs");

            migrationBuilder.DropIndex(
                name: "IX_tbl_AddPanels_CansultantId",
                table: "tbl_AddPanels");

            migrationBuilder.DropIndex(
                name: "IX_tbl_AddPanels_StudentId",
                table: "tbl_AddPanels");

            migrationBuilder.DropColumn(
                name: "Tbl_CourseIDCourse",
                table: "tbl_Headlines");

            migrationBuilder.DropColumn(
                name: "Tbl_TasksIDTasks",
                table: "tbl_Dos");

            migrationBuilder.DropColumn(
                name: "CansultantId",
                table: "tbl_Blogs");

            migrationBuilder.DropColumn(
                name: "CansultantId",
                table: "tbl_AddPanels");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "tbl_AddPanels");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Tbl_TasksOfStudents",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_TasksOfStudents_StudentId",
                table: "Tbl_TasksOfStudents",
                newName: "IX_Tbl_TasksOfStudents_StudentID");

            migrationBuilder.RenameColumn(
                name: "CansultantId",
                table: "tbl_Tasks",
                newName: "CansultantID");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Tasks_CansultantId",
                table: "tbl_Tasks",
                newName: "IX_tbl_Tasks_CansultantID");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Tbl_TasksOfStudents",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CansultantID",
                table: "tbl_Tasks",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "courseIDCourse",
                table: "tbl_Tasks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "coursesIDCourse",
                table: "tbl_Headlines",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "studentID",
                table: "tbl_Dos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "taskIDTasks",
                table: "tbl_Dos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "consultantID",
                table: "tbl_Blogs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "studentsID",
                table: "tbl_AddPanels",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "consultants",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CansultantId = table.Column<string>(nullable: true),
                    NameConsultant = table.Column<string>(nullable: true),
                    FamilyConsultant = table.Column<string>(nullable: true),
                    NationlCode = table.Column<int>(nullable: false),
                    addPanelIDAddPanel = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consultants", x => x.ID);
                    table.ForeignKey(
                        name: "FK_consultants_AspNetUsers_CansultantId",
                        column: x => x.CansultantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_consultants_tbl_AddPanels_addPanelIDAddPanel",
                        column: x => x.addPanelIDAddPanel,
                        principalTable: "tbl_AddPanels",
                        principalColumn: "IDAddPanel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(nullable: true),
                    NameStudent = table.Column<string>(nullable: false),
                    FamilyStudent = table.Column<string>(nullable: false),
                    NationalCode = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    addPanelIDAddPanel = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_students_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_students_tbl_AddPanels_addPanelIDAddPanel",
                        column: x => x.addPanelIDAddPanel,
                        principalTable: "tbl_AddPanels",
                        principalColumn: "IDAddPanel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tasks_courseIDCourse",
                table: "tbl_Tasks",
                column: "courseIDCourse");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Headlines_coursesIDCourse",
                table: "tbl_Headlines",
                column: "coursesIDCourse");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Dos_studentID",
                table: "tbl_Dos",
                column: "studentID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Dos_taskIDTasks",
                table: "tbl_Dos",
                column: "taskIDTasks");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Blogs_consultantID",
                table: "tbl_Blogs",
                column: "consultantID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_AddPanels_studentsID",
                table: "tbl_AddPanels",
                column: "studentsID");

            migrationBuilder.CreateIndex(
                name: "IX_consultants_CansultantId",
                table: "consultants",
                column: "CansultantId");

            migrationBuilder.CreateIndex(
                name: "IX_consultants_addPanelIDAddPanel",
                table: "consultants",
                column: "addPanelIDAddPanel");

            migrationBuilder.CreateIndex(
                name: "IX_students_StudentId",
                table: "students",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_students_addPanelIDAddPanel",
                table: "students",
                column: "addPanelIDAddPanel");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_AddPanels_students_studentsID",
                table: "tbl_AddPanels",
                column: "studentsID",
                principalTable: "students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Blogs_consultants_consultantID",
                table: "tbl_Blogs",
                column: "consultantID",
                principalTable: "consultants",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Dos_students_studentID",
                table: "tbl_Dos",
                column: "studentID",
                principalTable: "students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Dos_tbl_Tasks_taskIDTasks",
                table: "tbl_Dos",
                column: "taskIDTasks",
                principalTable: "tbl_Tasks",
                principalColumn: "IDTasks",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Headlines_tbl_Courses_coursesIDCourse",
                table: "tbl_Headlines",
                column: "coursesIDCourse",
                principalTable: "tbl_Courses",
                principalColumn: "IDCourse",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_consultants_CansultantID",
                table: "tbl_Tasks",
                column: "CansultantID",
                principalTable: "consultants",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_tbl_Courses_courseIDCourse",
                table: "tbl_Tasks",
                column: "courseIDCourse",
                principalTable: "tbl_Courses",
                principalColumn: "IDCourse",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_TasksOfStudents_students_StudentID",
                table: "Tbl_TasksOfStudents",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_AddPanels_students_studentsID",
                table: "tbl_AddPanels");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Blogs_consultants_consultantID",
                table: "tbl_Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Dos_students_studentID",
                table: "tbl_Dos");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Dos_tbl_Tasks_taskIDTasks",
                table: "tbl_Dos");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Headlines_tbl_Courses_coursesIDCourse",
                table: "tbl_Headlines");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_consultants_CansultantID",
                table: "tbl_Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Tasks_tbl_Courses_courseIDCourse",
                table: "tbl_Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_TasksOfStudents_students_StudentID",
                table: "Tbl_TasksOfStudents");

            migrationBuilder.DropTable(
                name: "consultants");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Tasks_courseIDCourse",
                table: "tbl_Tasks");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Headlines_coursesIDCourse",
                table: "tbl_Headlines");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Dos_studentID",
                table: "tbl_Dos");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Dos_taskIDTasks",
                table: "tbl_Dos");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Blogs_consultantID",
                table: "tbl_Blogs");

            migrationBuilder.DropIndex(
                name: "IX_tbl_AddPanels_studentsID",
                table: "tbl_AddPanels");

            migrationBuilder.DropColumn(
                name: "courseIDCourse",
                table: "tbl_Tasks");

            migrationBuilder.DropColumn(
                name: "coursesIDCourse",
                table: "tbl_Headlines");

            migrationBuilder.DropColumn(
                name: "studentID",
                table: "tbl_Dos");

            migrationBuilder.DropColumn(
                name: "taskIDTasks",
                table: "tbl_Dos");

            migrationBuilder.DropColumn(
                name: "consultantID",
                table: "tbl_Blogs");

            migrationBuilder.DropColumn(
                name: "studentsID",
                table: "tbl_AddPanels");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Tbl_TasksOfStudents",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_TasksOfStudents_StudentID",
                table: "Tbl_TasksOfStudents",
                newName: "IX_Tbl_TasksOfStudents_StudentId");

            migrationBuilder.RenameColumn(
                name: "CansultantID",
                table: "tbl_Tasks",
                newName: "CansultantId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Tasks_CansultantID",
                table: "tbl_Tasks",
                newName: "IX_tbl_Tasks_CansultantId");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Tbl_TasksOfStudents",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CansultantId",
                table: "tbl_Tasks",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tbl_CourseIDCourse",
                table: "tbl_Headlines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tbl_TasksIDTasks",
                table: "tbl_Dos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CansultantId",
                table: "tbl_Blogs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CansultantId",
                table: "tbl_AddPanels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "tbl_AddPanels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_TasksCourses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCourse = table.Column<int>(type: "int", nullable: false),
                    IDTasks = table.Column<int>(type: "int", nullable: false),
                    courseIDCourse = table.Column<int>(type: "int", nullable: true),
                    tasksIDTasks = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TasksCourses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tbl_TasksCourses_tbl_Courses_courseIDCourse",
                        column: x => x.courseIDCourse,
                        principalTable: "tbl_Courses",
                        principalColumn: "IDCourse",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_TasksCourses_tbl_Tasks_tasksIDTasks",
                        column: x => x.tasksIDTasks,
                        principalTable: "tbl_Tasks",
                        principalColumn: "IDTasks",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Headlines_Tbl_CourseIDCourse",
                table: "tbl_Headlines",
                column: "Tbl_CourseIDCourse");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Dos_Tbl_TasksIDTasks",
                table: "tbl_Dos",
                column: "Tbl_TasksIDTasks");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Blogs_CansultantId",
                table: "tbl_Blogs",
                column: "CansultantId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_AddPanels_CansultantId",
                table: "tbl_AddPanels",
                column: "CansultantId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_AddPanels_StudentId",
                table: "tbl_AddPanels",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TasksCourses_courseIDCourse",
                table: "tbl_TasksCourses",
                column: "courseIDCourse");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TasksCourses_tasksIDTasks",
                table: "tbl_TasksCourses",
                column: "tasksIDTasks");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_AddPanels_AspNetUsers_CansultantId",
                table: "tbl_AddPanels",
                column: "CansultantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_AddPanels_AspNetUsers_StudentId",
                table: "tbl_AddPanels",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Blogs_AspNetUsers_CansultantId",
                table: "tbl_Blogs",
                column: "CansultantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Dos_tbl_Tasks_Tbl_TasksIDTasks",
                table: "tbl_Dos",
                column: "Tbl_TasksIDTasks",
                principalTable: "tbl_Tasks",
                principalColumn: "IDTasks",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Headlines_tbl_Courses_Tbl_CourseIDCourse",
                table: "tbl_Headlines",
                column: "Tbl_CourseIDCourse",
                principalTable: "tbl_Courses",
                principalColumn: "IDCourse",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Tasks_AspNetUsers_CansultantId",
                table: "tbl_Tasks",
                column: "CansultantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_TasksOfStudents_AspNetUsers_StudentId",
                table: "Tbl_TasksOfStudents",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
