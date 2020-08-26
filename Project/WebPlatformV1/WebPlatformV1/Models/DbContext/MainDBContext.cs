using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
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
          //  builder.Entity<Tbl_Student>()
          //.HasMany(p =>p.addPanels)
          //.WithOne(e => e.students);
            
            //builder.Entity<Tbl_Consultant>().HasNoKey();
            //builder.Entity<Tbl_Student>().HasNoKey();
           
           base.OnModelCreating(builder);
           


        }
        public DbSet<Student> students { get; set; }
        public DbSet<Consultant> consultants { get; set; }
        //public DbSet<Tbl_Consultant> consultants { get; set; }
        //public DbSet<Tbl_Student> students { get; set; }
        //public DbSet<StudentsOfConsultant> studentOfCansultants { get; set; }
        public DbSet<Tbl_AddPanel> tbl_AddPanels { get; set; }
        public DbSet<Tbl_Attach> tbl_Attaches { get; set; }
        public DbSet<Tbl_Blog> tbl_Blogs { get; set; }
        public DbSet<Tbl_Course> tbl_Courses { get; set; }
        public DbSet<Tbl_Do> tbl_Dos { get; set; }
        public DbSet<Tbl_FinnialManegment> tbl_FinnialManegments { get; set; }
        public DbSet<Tbl_Headline> tbl_Headlines { get; set; }
        public DbSet<Tbl_Tasks> tbl_Tasks { get; set; }
        public DbSet<Tbl_Wallet> tbl_Wallets { get; set; }
        public DbSet<Tbl_TodoAppStudent> Tbl_TodoAppStudents { get; set; }
        public DbSet<Tbl_TodoAppConsultant> Tbl_TodoAppConsultant { get; set; }

        public DbSet<SendDegree> SendDegree { get; set; }

        //public DbSet<Tbl_TasksCourse> tbl_TasksCourses { get; set; }

    }


    public class Tbl_Blog
    {
        [Key]
        public int ID { get; set; }
        public int IDAttach { get; set; }
        public string Note { get; set; }
        public string ConsultantId { get; set; }
        public ICollection<Tbl_Attach> tbl_Attaches { get; set; }
        public Consultant consultant { get; set; }
    }
    public class SendDegree
    {   [Key]
        public int Id { get; set; }
        public bool IsSend { get; set; }
        public int state { get; set; }
        public string Description { get; set; }
        public string ConsultantId { get; set; }
        public ICollection<Consultant> consultant { get; set; }



    }
    public class Tbl_Attach
    {
        [Key]
        public int IDAttach { get; set; }
        public string Link { get; set; }
        public string Type { get; set; }
        public Tbl_Blog blog { get; set; }   
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
        public int IDTasks { get; set; }
        // مدت فعالیت
        public int DiscriptiveTime { get; set; }
        public int TestTime { get; set; }
        public int RevisionTime { get; set; }
        //توضیحات فعالیت
        public string Note { get; set; }
        // تعداد تست ها

        [Required]
        public int TrueTest { get; set; }
        public int falseTest { get; set; }
        public int NullTest { get; set; }

        public ICollection<Tbl_Tasks> task { get; set; }
        public virtual Student student { get; set; }
    }
    public class Tbl_Tasks
    {
        [Key]
        public int IDTasks { get; set; }
        public string NameTasks { get; set; }
        public DateTime SendDelivery { get; set; }
        public DateTime SubmitDate { get; set; }
        public string Descibtion { get; set; }
        public int TimeStudy { get; set; }
        public string Subject { get; set; }
        public bool isDo { get; set; } = false;
        public string StudentId { get; set; }
        public string ConsultantId { get; set; }
        public int? CourseIDCourse { get; set; }
        public int? DoIDdo { get; set; }

        //public bool isSpecial { get; set; }

        // Navigation 
        public Tbl_Course Course { get; set; }
        public  Consultant Cansultant { get; set; }
        public  Student Student { get; set; }
        public  Tbl_Do Do { get; set; }

    }
    public class Tbl_FinnialManegment
    {
        [Key]
        public int IDFinancial { get; set; }
        public int IDConsultant { get; set; }
        public int NumReceipt { get; set; }
        public int DatePayment { get; set; }
        public string State { get; set; }
        public Consultant consultant { get; set; }
        public Student student { get; set; }

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


    //public class Tbl_TasksOfStudent
    //{
    //    [Key]
    //    public int ID { get; set; }
    //    //Navigation Property
    //    public virtual Tbl_Tasks Tasks { get; set; }
    //    public virtual Tbl_Do Do { get; set; }

    //    public virtual Tbl_Student  Student{ get; set; } 

    //}
    public class Tbl_Wallet
    {
        public int ID { get; set; }
        public string ConsultantId { get; set; }
        public int Credit { get; set; }

        public Consultant consultant { get; set; }
    }
    public class Tbl_AddPanel
    {
        [Key]
        public int IDAddPanel { get; set; }
        public string ConsultantID { get; set; }
        public string StudentID { get; set; }
        public bool Status { get; set; } = false;

        [Required]
        public int Day { get; set; }
        [Required]
        public int Price { get; set; }
        public ICollection<Consultant> Consultantes { get; set; }
        public Student students { get; set; }



    }
    public class Tbl_TodoAppStudent
    {
        public int Id { get; set; }
        public string STudentID { get; set; }
        public string Note { get; set; }
        public bool IsFinally { get; set; } = false;
        public ICollection<Student> students { get; set; }
    }
    public class Tbl_TodoAppConsultant
    {
        public int Id { get; set; }
        public string ConsultantID { get; set; }
        public string Note { get; set; }
        public bool IsFinally { get; set; } = false;
        public ICollection<Consultant> Consultantes { get; set; }
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

