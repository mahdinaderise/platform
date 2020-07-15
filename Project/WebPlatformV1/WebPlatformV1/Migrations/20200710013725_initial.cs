using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformV1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    NationalCode = table.Column<int>(nullable: false),
                    State = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "studentOfCansultants",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CansultantId = table.Column<string>(nullable: true),
                    StudentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentOfCansultants", x => x.ID);
                    table.ForeignKey(
                        name: "FK_studentOfCansultants_AspNetUsers_CansultantId",
                        column: x => x.CansultantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_studentOfCansultants_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "tbl_Dos",
                columns: table => new
                {
                    IDdo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDStudent = table.Column<int>(nullable: false),
                    IDTasks = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    CountTest = table.Column<int>(nullable: false),
                    TimeStudy = table.Column<int>(nullable: false),
                    Tbl_TasksIDTasks = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Dos", x => x.IDdo);
                    table.ForeignKey(
                        name: "FK_tbl_Dos_tbl_Tasks_Tbl_TasksIDTasks",
                        column: x => x.Tbl_TasksIDTasks,
                        principalTable: "tbl_Tasks",
                        principalColumn: "IDTasks",
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_studentOfCansultants_CansultantId",
                table: "studentOfCansultants",
                column: "CansultantId");

            migrationBuilder.CreateIndex(
                name: "IX_studentOfCansultants_StudentId",
                table: "studentOfCansultants",
                column: "StudentId");

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
                name: "IX_tbl_Dos_Tbl_TasksIDTasks",
                table: "tbl_Dos",
                column: "Tbl_TasksIDTasks");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "studentOfCansultants");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "tbl_Blogs");

            migrationBuilder.DropTable(
                name: "tbl_Courses");

            migrationBuilder.DropTable(
                name: "tbl_Tasks");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
