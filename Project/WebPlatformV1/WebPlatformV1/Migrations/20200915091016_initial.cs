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
                name: "grades",
                columns: table => new
                {
                    IDGrade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grades", x => x.IDGrade);
                });

            migrationBuilder.CreateTable(
                name: "PanelConsultant",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanelConsultant", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SendDegree",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsSend = table.Column<bool>(nullable: false),
                    state = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ConsultantId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendDegree", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Balances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SumComosion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Balances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Comisions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    percent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Comisions", x => x.Id);
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
                name: "Tbl_HistoryPeys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefId = table.Column<long>(nullable: false),
                    Peyamount = table.Column<int>(nullable: false),
                    comision = table.Column<int>(nullable: false),
                    ConsultantId = table.Column<string>(nullable: true),
                    DatePey = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_HistoryPeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_TodoAppConsultant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsultantID = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    IsFinally = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TodoAppConsultant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_TodoAppStudents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STudentID = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    IsFinally = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TodoAppStudents", x => x.Id);
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
                name: "tbl_Headlines",
                columns: table => new
                {
                    IDHeadline = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCourse = table.Column<int>(nullable: false),
                    HeadlineName = table.Column<string>(nullable: false),
                    coursesIDCourse = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Headlines", x => x.IDHeadline);
                    table.ForeignKey(
                        name: "FK_tbl_Headlines_tbl_Courses_coursesIDCourse",
                        column: x => x.coursesIDCourse,
                        principalTable: "tbl_Courses",
                        principalColumn: "IDCourse",
                        onDelete: ReferentialAction.Restrict);
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
                });

            migrationBuilder.CreateTable(
                name: "tbl_AddPanels",
                columns: table => new
                {
                    IDAddPanel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsultantID = table.Column<string>(nullable: true),
                    StudentID = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Day = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_AddPanels", x => x.IDAddPanel);
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
                    Discriminator = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    NationalCode = table.Column<int>(nullable: true),
                    State = table.Column<bool>(nullable: true),
                    IsSendDegree = table.Column<bool>(nullable: true),
                    isAcceptDegree = table.Column<bool>(nullable: true),
                    ProfilePicUrl = table.Column<string>(nullable: true),
                    CardNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Shaba = table.Column<string>(nullable: true),
                    CreditTime = table.Column<DateTime>(nullable: true),
                    sendDegreeId = table.Column<int>(nullable: true),
                    addPanelIDAddPanel = table.Column<int>(nullable: true),
                    Tbl_HistoryPeyId = table.Column<int>(nullable: true),
                    Tbl_TodoAppConsultantId = table.Column<int>(nullable: true),
                    Student_Name = table.Column<string>(nullable: true),
                    Student_Family = table.Column<string>(nullable: true),
                    Student_NationalCode = table.Column<int>(nullable: true),
                    Student_State = table.Column<bool>(nullable: true),
                    ConsultantID = table.Column<string>(nullable: true),
                    Student_ProfilePicUrl = table.Column<string>(nullable: true),
                    Student_CreditTime = table.Column<DateTime>(nullable: true),
                    Tbl_TodoAppStudentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Tbl_HistoryPeys_Tbl_HistoryPeyId",
                        column: x => x.Tbl_HistoryPeyId,
                        principalTable: "Tbl_HistoryPeys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Tbl_TodoAppConsultant_Tbl_TodoAppConsultantId",
                        column: x => x.Tbl_TodoAppConsultantId,
                        principalTable: "Tbl_TodoAppConsultant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_tbl_AddPanels_addPanelIDAddPanel",
                        column: x => x.addPanelIDAddPanel,
                        principalTable: "tbl_AddPanels",
                        principalColumn: "IDAddPanel",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_SendDegree_sendDegreeId",
                        column: x => x.sendDegreeId,
                        principalTable: "SendDegree",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Tbl_TodoAppStudents_Tbl_TodoAppStudentId",
                        column: x => x.Tbl_TodoAppStudentId,
                        principalTable: "Tbl_TodoAppStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Blogs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDAttach = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    ConsultantId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Blogs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tbl_Blogs_AspNetUsers_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Dos",
                columns: table => new
                {
                    IDdo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDTasks = table.Column<int>(nullable: false),
                    DiscriptiveTime = table.Column<int>(nullable: false),
                    TestTime = table.Column<int>(nullable: false),
                    RevisionTime = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    TrueTest = table.Column<int>(nullable: false),
                    falseTest = table.Column<int>(nullable: false),
                    NullTest = table.Column<int>(nullable: false),
                    studentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Dos", x => x.IDdo);
                    table.ForeignKey(
                        name: "FK_tbl_Dos_AspNetUsers_studentId",
                        column: x => x.studentId,
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
                    IDConsultant = table.Column<string>(nullable: true),
                    NumReceipt = table.Column<long>(nullable: false),
                    State = table.Column<bool>(nullable: false),
                    DatePey = table.Column<DateTime>(nullable: false),
                    consultantId = table.Column<string>(nullable: true),
                    studentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FinnialManegments", x => x.IDFinancial);
                    table.ForeignKey(
                        name: "FK_tbl_FinnialManegments_AspNetUsers_consultantId",
                        column: x => x.consultantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_FinnialManegments_AspNetUsers_studentId",
                        column: x => x.studentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Finnials",
                columns: table => new
                {
                    IDFinancial = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDConsultant = table.Column<string>(nullable: true),
                    NumReceipt = table.Column<long>(nullable: false),
                    State = table.Column<bool>(nullable: false),
                    DatePey = table.Column<DateTime>(nullable: false),
                    consultantId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Finnials", x => x.IDFinancial);
                    table.ForeignKey(
                        name: "FK_Tbl_Finnials_AspNetUsers_consultantId",
                        column: x => x.consultantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Wallets",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsultantId = table.Column<string>(nullable: true),
                    Credit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Wallets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tbl_Wallets_AspNetUsers_ConsultantId",
                        column: x => x.ConsultantId,
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
                name: "tbl_Tasks",
                columns: table => new
                {
                    IDTasks = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTasks = table.Column<string>(nullable: true),
                    SendDelivery = table.Column<DateTime>(nullable: false),
                    SubmitDate = table.Column<DateTime>(nullable: false),
                    Descibtion = table.Column<string>(nullable: true),
                    TimeStudy = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    isDo = table.Column<bool>(nullable: false),
                    StudentId = table.Column<string>(nullable: true),
                    ConsultantId = table.Column<string>(nullable: true),
                    CourseIDCourse = table.Column<int>(nullable: true),
                    DoIDdo = table.Column<int>(nullable: true),
                    MyGrade = table.Column<string>(nullable: true),
                    Tbl_gradeIDGrade = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Tasks", x => x.IDTasks);
                    table.ForeignKey(
                        name: "FK_tbl_Tasks_AspNetUsers_ConsultantId",
                        column: x => x.ConsultantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_Tasks_tbl_Courses_CourseIDCourse",
                        column: x => x.CourseIDCourse,
                        principalTable: "tbl_Courses",
                        principalColumn: "IDCourse",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_Tasks_tbl_Dos_DoIDdo",
                        column: x => x.DoIDdo,
                        principalTable: "tbl_Dos",
                        principalColumn: "IDdo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_Tasks_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_Tasks_grades_Tbl_gradeIDGrade",
                        column: x => x.Tbl_gradeIDGrade,
                        principalTable: "grades",
                        principalColumn: "IDGrade",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Tbl_Balances",
                columns: new[] { "Id", "SumComosion" },
                values: new object[] { 1, 0 });

            migrationBuilder.InsertData(
                table: "Tbl_Comisions",
                columns: new[] { "Id", "percent" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "grades",
                columns: new[] { "IDGrade", "grade" },
                values: new object[,]
                {
                    { 10, "دهم" },
                    { 9, "نهم" },
                    { 8, "هشتم" },
                    { 7, "هفتم" },
                    { 6, "ششم" },
                    { 5, "پنجم" },
                    { 4, "چهارم" },
                    { 3, "سوم" },
                    { 2, "دوم" },
                    { 1, "اول" },
                    { 11, "یازدهم" },
                    { 12, "دوازدهم" }
                });

            migrationBuilder.InsertData(
                table: "tbl_Courses",
                columns: new[] { "IDCourse", "NameCourse", "grade" },
                values: new object[,]
                {
                    { 11, "شیمی", "3" },
                    { 10, "فیزیک", "3" },
                    { 9, "زیست", "3" },
                    { 8, "زمین", "3" },
                    { 7, "زبان انگلیسی", "3" },
                    { 6, "دین و زندگی", "3" },
                    { 5, "عربی", "3" },
                    { 4, "زبان فارسی", "3" },
                    { 3, "ادبیات", "3" }
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
                name: "IX_AspNetUsers_Tbl_HistoryPeyId",
                table: "AspNetUsers",
                column: "Tbl_HistoryPeyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Tbl_TodoAppConsultantId",
                table: "AspNetUsers",
                column: "Tbl_TodoAppConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_addPanelIDAddPanel",
                table: "AspNetUsers",
                column: "addPanelIDAddPanel");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_sendDegreeId",
                table: "AspNetUsers",
                column: "sendDegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Tbl_TodoAppStudentId",
                table: "AspNetUsers",
                column: "Tbl_TodoAppStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_AddPanels_StudentID",
                table: "tbl_AddPanels",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Attaches_blogID",
                table: "tbl_Attaches",
                column: "blogID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Blogs_ConsultantId",
                table: "tbl_Blogs",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Dos_studentId",
                table: "tbl_Dos",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FinnialManegments_consultantId",
                table: "tbl_FinnialManegments",
                column: "consultantId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_FinnialManegments_studentId",
                table: "tbl_FinnialManegments",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Finnials_consultantId",
                table: "Tbl_Finnials",
                column: "consultantId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Headlines_coursesIDCourse",
                table: "tbl_Headlines",
                column: "coursesIDCourse");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tasks_ConsultantId",
                table: "tbl_Tasks",
                column: "ConsultantId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tasks_CourseIDCourse",
                table: "tbl_Tasks",
                column: "CourseIDCourse");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tasks_DoIDdo",
                table: "tbl_Tasks",
                column: "DoIDdo");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tasks_StudentId",
                table: "tbl_Tasks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tasks_Tbl_gradeIDGrade",
                table: "tbl_Tasks",
                column: "Tbl_gradeIDGrade");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Wallets_ConsultantId",
                table: "tbl_Wallets",
                column: "ConsultantId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_AddPanels_AspNetUsers_StudentID",
                table: "tbl_AddPanels",
                column: "StudentID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_AddPanels_AspNetUsers_StudentID",
                table: "tbl_AddPanels");

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
                name: "PanelConsultant");

            migrationBuilder.DropTable(
                name: "tbl_Attaches");

            migrationBuilder.DropTable(
                name: "Tbl_Balances");

            migrationBuilder.DropTable(
                name: "Tbl_Comisions");

            migrationBuilder.DropTable(
                name: "tbl_FinnialManegments");

            migrationBuilder.DropTable(
                name: "Tbl_Finnials");

            migrationBuilder.DropTable(
                name: "tbl_Headlines");

            migrationBuilder.DropTable(
                name: "tbl_Tasks");

            migrationBuilder.DropTable(
                name: "tbl_Wallets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "tbl_Blogs");

            migrationBuilder.DropTable(
                name: "tbl_Courses");

            migrationBuilder.DropTable(
                name: "tbl_Dos");

            migrationBuilder.DropTable(
                name: "grades");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tbl_HistoryPeys");

            migrationBuilder.DropTable(
                name: "Tbl_TodoAppConsultant");

            migrationBuilder.DropTable(
                name: "tbl_AddPanels");

            migrationBuilder.DropTable(
                name: "SendDegree");

            migrationBuilder.DropTable(
                name: "Tbl_TodoAppStudents");
        }
    }
}
