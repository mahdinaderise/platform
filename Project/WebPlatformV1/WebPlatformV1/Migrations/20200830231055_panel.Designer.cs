﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.Migrations
{
    [DbContext(typeof(MainDBContext))]
    [Migration("20200830231055_panel")]
    partial class panel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebPlatformV1.Models.ApplicationUsers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationUsers");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.SendDegree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConsultantId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSend")
                        .HasColumnType("bit");

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SendDegree");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_AddPanel", b =>
                {
                    b.Property<int>("IDAddPanel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConsultantID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IDAddPanel");

                    b.HasIndex("StudentID");

                    b.ToTable("tbl_AddPanels");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_AddPanelConsultant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PanelConsultant");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_Attach", b =>
                {
                    b.Property<int>("IDAttach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("blogID")
                        .HasColumnType("int");

                    b.HasKey("IDAttach");

                    b.HasIndex("blogID");

                    b.ToTable("tbl_Attaches");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_Blog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConsultantId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IDAttach")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ConsultantId");

                    b.ToTable("tbl_Blogs");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_Course", b =>
                {
                    b.Property<int>("IDCourse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameCourse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("grade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDCourse");

                    b.ToTable("tbl_Courses");

                    b.HasData(
                        new
                        {
                            IDCourse = 3,
                            NameCourse = "ادبیات",
                            grade = "3"
                        },
                        new
                        {
                            IDCourse = 4,
                            NameCourse = "زبان فارسی",
                            grade = "3"
                        },
                        new
                        {
                            IDCourse = 5,
                            NameCourse = "عربی",
                            grade = "3"
                        },
                        new
                        {
                            IDCourse = 6,
                            NameCourse = "دین و زندگی",
                            grade = "3"
                        },
                        new
                        {
                            IDCourse = 7,
                            NameCourse = "زبان انگلیسی",
                            grade = "3"
                        },
                        new
                        {
                            IDCourse = 8,
                            NameCourse = "زمین",
                            grade = "3"
                        },
                        new
                        {
                            IDCourse = 9,
                            NameCourse = "زیست",
                            grade = "3"
                        },
                        new
                        {
                            IDCourse = 10,
                            NameCourse = "فیزیک",
                            grade = "3"
                        },
                        new
                        {
                            IDCourse = 11,
                            NameCourse = "شیمی",
                            grade = "3"
                        });
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_Do", b =>
                {
                    b.Property<int>("IDdo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscriptiveTime")
                        .HasColumnType("int");

                    b.Property<int>("IDTasks")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NullTest")
                        .HasColumnType("int");

                    b.Property<int>("RevisionTime")
                        .HasColumnType("int");

                    b.Property<int>("TestTime")
                        .HasColumnType("int");

                    b.Property<int>("TrueTest")
                        .HasColumnType("int");

                    b.Property<int>("falseTest")
                        .HasColumnType("int");

                    b.Property<string>("studentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IDdo");

                    b.HasIndex("studentId");

                    b.ToTable("tbl_Dos");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_FinnialManegment", b =>
                {
                    b.Property<int>("IDFinancial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DatePayment")
                        .HasColumnType("int");

                    b.Property<int>("IDConsultant")
                        .HasColumnType("int");

                    b.Property<int>("NumReceipt")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("consultantId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("studentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IDFinancial");

                    b.HasIndex("consultantId");

                    b.HasIndex("studentId");

                    b.ToTable("tbl_FinnialManegments");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_Headline", b =>
                {
                    b.Property<int>("IDHeadline")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HeadlineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDCourse")
                        .HasColumnType("int");

                    b.Property<int?>("coursesIDCourse")
                        .HasColumnType("int");

                    b.HasKey("IDHeadline");

                    b.HasIndex("coursesIDCourse");

                    b.ToTable("tbl_Headlines");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_Tasks", b =>
                {
                    b.Property<int>("IDTasks")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConsultantId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CourseIDCourse")
                        .HasColumnType("int");

                    b.Property<string>("Descibtion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoIDdo")
                        .HasColumnType("int");

                    b.Property<string>("MyGrade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameTasks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SendDelivery")
                        .HasColumnType("datetime2");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SubmitDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Tbl_gradeIDGrade")
                        .HasColumnType("int");

                    b.Property<int>("TimeStudy")
                        .HasColumnType("int");

                    b.Property<bool>("isDo")
                        .HasColumnType("bit");

                    b.HasKey("IDTasks");

                    b.HasIndex("ConsultantId");

                    b.HasIndex("CourseIDCourse");

                    b.HasIndex("DoIDdo");

                    b.HasIndex("StudentId");

                    b.HasIndex("Tbl_gradeIDGrade");

                    b.ToTable("tbl_Tasks");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_TodoAppConsultant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConsultantID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFinally")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_TodoAppConsultant");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_TodoAppStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsFinally")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STudentID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_TodoAppStudents");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_Wallet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConsultantId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ConsultantId");

                    b.ToTable("tbl_Wallets");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_grade", b =>
                {
                    b.Property<int>("IDGrade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("grade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDGrade");

                    b.ToTable("grades");
                });

            modelBuilder.Entity("WebPlatformV1.Models.Consultant", b =>
                {
                    b.HasBaseType("WebPlatformV1.Models.ApplicationUsers");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreditTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Family")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSendDegree")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalCode")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePicUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shaba")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<int?>("Tbl_TodoAppConsultantId")
                        .HasColumnType("int");

                    b.Property<int?>("addPanelIDAddPanel")
                        .HasColumnType("int");

                    b.Property<bool>("isAcceptDegree")
                        .HasColumnType("bit");

                    b.Property<int?>("sendDegreeId")
                        .HasColumnType("int");

                    b.HasIndex("Tbl_TodoAppConsultantId");

                    b.HasIndex("addPanelIDAddPanel");

                    b.HasIndex("sendDegreeId");

                    b.HasDiscriminator().HasValue("Consultant");
                });

            modelBuilder.Entity("WebPlatformV1.Models.Student", b =>
                {
                    b.HasBaseType("WebPlatformV1.Models.ApplicationUsers");

                    b.Property<string>("ConsultantID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreditTime")
                        .HasColumnName("Student_CreditTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Family")
                        .HasColumnName("Student_Family")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnName("Student_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalCode")
                        .HasColumnName("Student_NationalCode")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePicUrl")
                        .HasColumnName("Student_ProfilePicUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("State")
                        .HasColumnName("Student_State")
                        .HasColumnType("bit");

                    b.Property<int?>("Tbl_TodoAppStudentId")
                        .HasColumnType("int");

                    b.HasIndex("Tbl_TodoAppStudentId");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebPlatformV1.Models.ApplicationUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebPlatformV1.Models.ApplicationUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebPlatformV1.Models.ApplicationUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebPlatformV1.Models.ApplicationUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_AddPanel", b =>
                {
                    b.HasOne("WebPlatformV1.Models.Student", "students")
                        .WithMany()
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_Attach", b =>
                {
                    b.HasOne("WebPlatformV1.Models.DbContext.Tbl_Blog", "blog")
                        .WithMany("tbl_Attaches")
                        .HasForeignKey("blogID");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_Blog", b =>
                {
                    b.HasOne("WebPlatformV1.Models.Consultant", "consultant")
                        .WithMany("blogs")
                        .HasForeignKey("ConsultantId");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_Do", b =>
                {
                    b.HasOne("WebPlatformV1.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentId");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_FinnialManegment", b =>
                {
                    b.HasOne("WebPlatformV1.Models.Consultant", "consultant")
                        .WithMany()
                        .HasForeignKey("consultantId");

                    b.HasOne("WebPlatformV1.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentId");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_Headline", b =>
                {
                    b.HasOne("WebPlatformV1.Models.DbContext.Tbl_Course", "courses")
                        .WithMany("headlines")
                        .HasForeignKey("coursesIDCourse");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_Tasks", b =>
                {
                    b.HasOne("WebPlatformV1.Models.Consultant", "Cansultant")
                        .WithMany("tasks")
                        .HasForeignKey("ConsultantId");

                    b.HasOne("WebPlatformV1.Models.DbContext.Tbl_Course", "Course")
                        .WithMany("tasks")
                        .HasForeignKey("CourseIDCourse");

                    b.HasOne("WebPlatformV1.Models.DbContext.Tbl_Do", "Do")
                        .WithMany("task")
                        .HasForeignKey("DoIDdo");

                    b.HasOne("WebPlatformV1.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.HasOne("WebPlatformV1.Models.DbContext.Tbl_grade", null)
                        .WithMany("tasks")
                        .HasForeignKey("Tbl_gradeIDGrade");
                });

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_Wallet", b =>
                {
                    b.HasOne("WebPlatformV1.Models.Consultant", "consultant")
                        .WithMany()
                        .HasForeignKey("ConsultantId");
                });

            modelBuilder.Entity("WebPlatformV1.Models.Consultant", b =>
                {
                    b.HasOne("WebPlatformV1.Models.DbContext.Tbl_TodoAppConsultant", null)
                        .WithMany("Consultantes")
                        .HasForeignKey("Tbl_TodoAppConsultantId");

                    b.HasOne("WebPlatformV1.Models.DbContext.Tbl_AddPanel", "addPanel")
                        .WithMany("Consultantes")
                        .HasForeignKey("addPanelIDAddPanel");

                    b.HasOne("WebPlatformV1.Models.DbContext.SendDegree", "sendDegree")
                        .WithMany("consultant")
                        .HasForeignKey("sendDegreeId");
                });

            modelBuilder.Entity("WebPlatformV1.Models.Student", b =>
                {
                    b.HasOne("WebPlatformV1.Models.DbContext.Tbl_TodoAppStudent", null)
                        .WithMany("students")
                        .HasForeignKey("Tbl_TodoAppStudentId");
                });
#pragma warning restore 612, 618
        }
    }
}
