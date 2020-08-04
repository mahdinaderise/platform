﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.Migrations
{
    [DbContext(typeof(MainDBContext))]
    partial class MainDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
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

            modelBuilder.Entity("WebPlatformV1.Models.DbContext.Tbl_AddPanel", b =>
                {
                    b.Property<int>("IDAddPanel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("studentsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IDAddPanel");

                    b.HasIndex("studentsId");

                    b.ToTable("tbl_AddPanels");
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

                    b.Property<int>("IDAttach")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("consultantId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("consultantId");

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

                    b.Property<string>("CansultantId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Descibtion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoIDdo")
                        .HasColumnType("int");

                    b.Property<string>("IdConsultant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdStudent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idcourse")
                        .HasColumnType("int");

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

                    b.Property<int>("TimeStudy")
                        .HasColumnType("int");

                    b.Property<int?>("courseIDCourse")
                        .HasColumnType("int");

                    b.Property<bool>("isDo")
                        .HasColumnType("bit");

                    b.HasKey("IDTasks");

                    b.HasIndex("CansultantId");

                    b.HasIndex("DoIDdo");

                    b.HasIndex("StudentId");

                    b.HasIndex("courseIDCourse");

                    b.ToTable("tbl_Tasks");
                });

            modelBuilder.Entity("WebPlatformV1.Models.Consultant", b =>
                {
                    b.HasBaseType("WebPlatformV1.Models.ApplicationUsers");

                    b.Property<string>("Family")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalCode")
                        .HasColumnType("int");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<int?>("addPanelIDAddPanel")
                        .HasColumnType("int");

                    b.HasIndex("addPanelIDAddPanel");

                    b.HasDiscriminator().HasValue("Consultant");
                });

            modelBuilder.Entity("WebPlatformV1.Models.Student", b =>
                {
                    b.HasBaseType("WebPlatformV1.Models.ApplicationUsers");

                    b.Property<string>("ConsultantID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Family")
                        .HasColumnName("Student_Family")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnName("Student_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalCode")
                        .HasColumnName("Student_NationalCode")
                        .HasColumnType("int");

                    b.Property<bool>("State")
                        .HasColumnName("Student_State")
                        .HasColumnType("bit");

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
                        .HasForeignKey("studentsId");
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
                        .HasForeignKey("consultantId");
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
                        .HasForeignKey("CansultantId");

                    b.HasOne("WebPlatformV1.Models.DbContext.Tbl_Do", "Do")
                        .WithMany("task")
                        .HasForeignKey("DoIDdo");

                    b.HasOne("WebPlatformV1.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.HasOne("WebPlatformV1.Models.DbContext.Tbl_Course", "course")
                        .WithMany("tasks")
                        .HasForeignKey("courseIDCourse");
                });

            modelBuilder.Entity("WebPlatformV1.Models.Consultant", b =>
                {
                    b.HasOne("WebPlatformV1.Models.DbContext.Tbl_AddPanel", "addPanel")
                        .WithMany("Consultantes")
                        .HasForeignKey("addPanelIDAddPanel");
                });
#pragma warning restore 612, 618
        }
    }
}
