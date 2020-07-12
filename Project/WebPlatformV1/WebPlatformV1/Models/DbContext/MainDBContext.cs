﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace WebPlatformV1.Models.DbContext
{
    public class MainDBContext : IdentityDbContext<ApplicationUsers>
    {
        public MainDBContext(DbContextOptions dbContextOptions)
      : base(dbContextOptions)
        {
            

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tbl_Student>()
          .HasMany(p =>p.addPanels)
          .WithOne(e => e.students);           
           //base.OnModelCreating(builder);


        }
        public DbSet<Tbl_Consultant> consultants { get; set; }
        public DbSet<Tbl_Student> students { get; set; }
        public DbSet<StudentOfCansultant> studentOfCansultants { get; set; }
        public DbSet<Tbl_AddPanel> tbl_AddPanels { get; set; }
        public DbSet<Tbl_Attach> tbl_Attaches { get; set; }
        public DbSet<Tbl_Blog> tbl_Blogs { get; set; }
        public DbSet<Tbl_Course> tbl_Courses { get; set; }
        public DbSet<Tbl_Do> tbl_Dos { get; set; }
        public DbSet<Tbl_FinnialManegment> tbl_FinnialManegments { get; set; }
        public DbSet<Tbl_Headline> tbl_Headlines { get; set; }
        public DbSet<Tbl_Tasks> tbl_Tasks { get; set; }
        //public DbSet<Tbl_TasksCourse> tbl_TasksCourses { get; set; }
        public DbSet<Tbl_TasksOfStudent> Tbl_TasksOfStudents { get; set; }

    }
    public class StudentOfCansultant
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(450)]
        //public string IDStudent { get; set; }
        public virtual ApplicationUsers Cansultant { get; set; }
        public virtual ApplicationUsers Student { get; set; }

    }
    public class Tbl_Blog
    {
        [Key]
        public int ID { get; set; }
        public int IDConsultant { get; set; }
        public int IDAttach { get; set; }
        public string Note { get; set; }
        public ICollection<Tbl_Attach> tbl_Attaches { get; set; }
        public Tbl_Consultant consultant { get; set; }
    }

    public class Tbl_Attach
    {
        [Key]
        public int IDAttach { get; set; }
        public string Link { get; set; }
        public string Type { get; set; }
        public Tbl_Blog blog { get; set; }   
    }
    public class Tbl_Consultant
    {
        [Key]
        public ApplicationUsers Cansultant { get; set; }
        public string NameConsultant { get; set; }
        public string FamilyConsultant { get; set; }
        public int NationlCode { get; set; }
        public Tbl_AddPanel addPanel { get; set; }
        public ICollection<Tbl_Tasks> tasks { get; set; }
        public ICollection<Tbl_Blog> blogs { get; set; }

    }
    public class Tbl_Student 
    {
        [Key]
        public  ApplicationUsers Student { get; set; }
        [Required]
        public string NameStudent { get; set; }
        [Required]
        public string FamilyStudent { get; set; }
        [Required]
        public int NationalCode { get; set; }
        [Required]
        public string Address { get; set; }
        public Tbl_AddPanel addPanel { get; set; }
        public ICollection<Tbl_Do> dos { get; set; }
        public ICollection<Tbl_AddPanel> addPanels { get; set; }
    }
    public class Tbl_Course
    {
        [Key]
        public int IDCourse { get; set; }
        public string NameCourse { get; set; }
        public string grade { get; set; }
        public ICollection<Tbl_Tasks> tasks { get; set; }
        //public IList<Tbl_TasksCourse> Tbl_TasksCourses { get; set; }
        public ICollection<Tbl_Headline>headlines { get; set; }
    }
    public class Tbl_Do
    {
        [Key]
        public int IDdo { get; set; }
        public int IDStudent { get; set; }
        public int IDTasks { get; set; }
        public string Note { get; set; }
        [Required]
        public int CountTest { get; set; }
        [Required]
        public int TimeStudy { get; set; }
        public Tbl_Tasks task { get; set; }
        public Tbl_Student student { get; set; }
    }
    public class Tbl_FinnialManegment
    {
        [Key]
        public int IDFinancial { get; set; }
        public int IDConsultant { get; set; }
        public int NumReceipt { get; set; }
        public int DatePayment { get; set; }
        public string State { get; set; }
        public ApplicationUsers Student { get; set; }
    }
    public class Tbl_Headline
    {
        [Key]
        public int IDHeadline { get; set; }
        public int IDCourse { get; set; }
        [Required]
        public string HeadlineName { get; set; }
        public Tbl_Course courses { get; set; }
    }
    //public class Tbl_SendFileConsultant
    //{
    //    [Key]
    //    public int IDAttach { get; set; }
    //    public string link { get; set; }
    //    public string type { get; set; }
    //}
    
    public class Tbl_Tasks
    {
        [Key]
        public int IDTasks { get; set; }
        public int IDCansoltant { get; set; }
        public string NameTasks { get; set; }
        public DateTime SendDelivery { get; set; }
        //public IList<Tbl_TasksCourse> Tbl_TasksCourses { get; set; }
        public Tbl_Course course { get; set; }
        public Tbl_Consultant Cansultant { get; set; }
        

    }
    public class Tbl_TasksOfStudent
    {
        [Key]
        public int ID { get; set; }
        //Navigation Property
        public virtual Tbl_Tasks Tasks { get; set; }
        public virtual Tbl_Do Do { get; set; }

        public virtual Tbl_Student  Student{ get; set; } 

    }
    public class Tbl_AddPanel
    {
        [Key]
        public int IDAddPanel { get; set; }
        public int IDStudent { get; set; }
        public int IDConsultant { get; set; }
        [Required]
        public int Date { get; set; }
        [Required]
        public int Price { get; set; }
        public ICollection<Tbl_Consultant> Consultantes { get; set; }
        public Tbl_Student students { get; set; }



    }
    //public class Tbl_TasksCourse
    //{
    //    [Key]
    //    public int ID { get; set; }

    //    public int IDCourse { get; set; }

    //    public int IDTasks { get; set; }

    //    public virtual Tbl_Course course { get; set; }
    //    public virtual Tbl_Tasks tasks { get; set; }
    //}
}

