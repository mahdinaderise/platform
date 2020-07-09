using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class InitialMainDBs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_AddPanels",
                columns: table => new
                {
                    IDAddPanel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDStudent = table.Column<int>(nullable: false),
                    IDConsultant = table.Column<int>(nullable: false),
                    Date = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    CansultantId = table.Column<string>(nullable: true),
                    StudentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AddPanels", x => x.IDAddPanel);
                    table.ForeignKey(
                        name: "FK_tbl_AddPanels_AspNetUsers_CansultantId",
                        column: x => x.CansultantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_AddPanels_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Blogs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDConsultant = table.Column<int>(nullable: false),
                    IDAttach = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    CansultantId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Blogs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tbl_Blogs_AspNetUsers_CansultantId",
                        column: x => x.CansultantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Courses",
                columns: table => new
                {
                    IDCourse = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCourse = table.Column<string>(nullable: true),
                    grade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Courses", x => x.IDCourse);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Dos",
                columns: table => new
                {
                    IDdo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDStudent = table.Column<int>(nullable: false),
                    IDTasks = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    CountTest = table.Column<int>(nullable: false),
                    TimeStudy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Dos", x => x.IDdo);
                });

            migrationBuilder.CreateTable(
                name: "tbl_FinnialManegments",
                columns: table => new
                {
                    IDFinancial = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDConsultant = table.Column<int>(nullable: false),
                    NumReceipt = table.Column<int>(nullable: false),
                    DatePayment = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    StudentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FinnialManegments", x => x.IDFinancial);
                    table.ForeignKey(
                        name: "FK_tbl_FinnialManegments_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Tasks",
                columns: table => new
                {
                    IDTasks = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCansoltant = table.Column<int>(nullable: false),
                    IDStudent = table.Column<int>(nullable: false),
                    IDido = table.Column<int>(nullable: false),
                    NameTasks = table.Column<string>(nullable: true),
                    SendDelivery = table.Column<DateTime>(nullable: false),
                    CansultantId = table.Column<string>(nullable: true),
                    StudentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Tasks", x => x.IDTasks);
                    table.ForeignKey(
                        name: "FK_tbl_Tasks_AspNetUsers_CansultantId",
                        column: x => x.CansultantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_Tasks_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Attaches",
                columns: table => new
                {
                    IDAttach = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    blogID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Attaches", x => x.IDAttach);
                    table.ForeignKey(
                        name: "FK_tbl_Attaches_tbl_Blogs_blogID",
                        column: x => x.blogID,
                        principalTable: "tbl_Blogs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Headlines",
                columns: table => new
                {
                    IDHeadline = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCourse = table.Column<int>(nullable: false),
                    HeadlineName = table.Column<string>(nullable: false),
                    Tbl_CourseIDCourse = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Headlines", x => x.IDHeadline);
                    table.ForeignKey(
                        name: "FK_tbl_Headlines_tbl_Courses_Tbl_CourseIDCourse",
                        column: x => x.Tbl_CourseIDCourse,
                        principalTable: "tbl_Courses",
                        principalColumn: "IDCourse",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_TasksCourses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCourse = table.Column<int>(nullable: false),
                    IDTasks = table.Column<int>(nullable: false),
                    courseIDCourse = table.Column<int>(nullable: true),
                    tasksIDTasks = table.Column<int>(nullable: true)
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
                name: "IX_tbl_AddPanels_CansultantId",
                table: "tbl_AddPanels",
                column: "CansultantId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_AddPanels_StudentId",
                table: "tbl_AddPanels",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Attaches_blogID",
                table: "tbl_Attaches",
                column: "blogID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Blogs_CansultantId",
                table: "tbl_Blogs",
                column: "CansultantId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FinnialManegments_StudentId",
                table: "tbl_FinnialManegments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Headlines_Tbl_CourseIDCourse",
                table: "tbl_Headlines",
                column: "Tbl_CourseIDCourse");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tasks_CansultantId",
                table: "tbl_Tasks",
                column: "CansultantId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tasks_StudentId",
                table: "tbl_Tasks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TasksCourses_courseIDCourse",
                table: "tbl_TasksCourses",
                column: "courseIDCourse");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_TasksCourses_tasksIDTasks",
                table: "tbl_TasksCourses",
                column: "tasksIDTasks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_AddPanels");

            migrationBuilder.DropTable(
                name: "tbl_Attaches");

            migrationBuilder.DropTable(
                name: "tbl_Dos");

            migrationBuilder.DropTable(
                name: "tbl_FinnialManegments");

            migrationBuilder.DropTable(
                name: "tbl_Headlines");

            migrationBuilder.DropTable(
                name: "tbl_TasksCourses");

            migrationBuilder.DropTable(
                name: "tbl_Blogs");

            migrationBuilder.DropTable(
                name: "tbl_Courses");

            migrationBuilder.DropTable(
                name: "tbl_Tasks");
        }
    }
}
