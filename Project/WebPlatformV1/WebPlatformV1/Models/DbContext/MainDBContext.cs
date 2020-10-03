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
using WebPlatformV1.ViewModels.Consultant;

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

            #region seed data course

            builder.Entity<Tbl_Course>().HasData(new Tbl_Course()
            {
                IDCourse = 3,
                NameCourse = "ادبیات",
                grade = "3"

            },
            new Tbl_Course()
            {
                IDCourse = 4,
                NameCourse = "زبان فارسی",
                grade = "3"
            },
            new Tbl_Course()
            {
                IDCourse = 5,
                NameCourse = "عربی",
                grade = "3"
            },
                new Tbl_Course()
                {
                    IDCourse = 6,
                    NameCourse = "دین و زندگی",
                    grade = "3"
                },
                    new Tbl_Course()
                    {
                        IDCourse = 7,
                        NameCourse = "زبان انگلیسی",
                        grade = "3"
                    },
                        new Tbl_Course()

                        {
                            IDCourse = 8,
                            NameCourse = "زمین",
                            grade = "3"
                        },
                            new Tbl_Course()
                            {
                                IDCourse = 9,
                                NameCourse = "زیست",
                                grade = "3"
                            },

                                    new Tbl_Course()
                                    {
                                        IDCourse = 10,
                                        NameCourse = "فیزیک",
                                        grade = "3"
                                    },
                                    new Tbl_Course()
                                    {
                                        IDCourse = 11,
                                        NameCourse = "شیمی",
                                        grade = "3"
                                    }
                                    );
            #endregion
            #region seed data Paye
            builder.Entity<Tbl_grade>().HasData(new Tbl_grade()
            {
                IDGrade = 1,
                grade = "اول"

            },
          new Tbl_grade()
          {
              IDGrade = 2,
              grade = "دوم"
          },
          new Tbl_grade()
          {
              IDGrade = 3,
              grade = "سوم"
          },
              new Tbl_grade()
              {
                  IDGrade = 4,
                  grade = "چهارم"
              },
                  new Tbl_grade()
                  {
                      IDGrade = 5,
                      grade = "پنجم"
                  },
                      new Tbl_grade()

                      {
                          IDGrade = 6,
                          grade = "ششم"
                      },
                          new Tbl_grade()
                          {
                              IDGrade = 7,
                              grade = "هفتم"
                          },

                                  new Tbl_grade()
                                  {
                                      IDGrade = 8,
                                      grade = "هشتم"
                                  },
                                  new Tbl_grade()
                                  {
                                      IDGrade = 9,
                                      grade = "نهم"
                                  }, new Tbl_grade()
                                  {
                                      IDGrade = 10,
                                      grade = "دهم"
                                  }, new Tbl_grade()
                                  {
                                      IDGrade = 11,
                                      grade = "یازدهم"
                                  }, new Tbl_grade()
                                  {
                                      IDGrade = 12,
                                      grade = "دوازدهم"
                                  }
                                  );
            #endregion
            builder.Entity<Tbl_Balance>().HasData(new Tbl_Balance()
            {
                Id = 1,
                SumComosion = 0,
            });
            builder.Entity<Tbl_Comision>().HasData(new Tbl_Comision()
            {
                Id = 1,
                percent = 5,
                price=0
            }, new Tbl_Comision
            {
                Id = 2,
                price = 45000,
                percent = 0
            }, new Tbl_Comision
            {
                Id = 3,
                price = 5000,
                percent = 0
            }) ;

            base.OnModelCreating(builder);


        }
        public DbSet<Student> students { get; set; }
        public DbSet<Consultant> consultants { get; set; }

        public DbSet<Tbl_AddPanel> tbl_AddPanels { get; set; }
        public DbSet<Tbl_Attach> tbl_Attaches { get; set; }
        public DbSet<Tbl_Blog> tbl_Blogs { get; set; }
        public DbSet<Tbl_Course> tbl_Courses { get; set; }
        public DbSet<Tbl_Do> tbl_Dos { get; set; }
        public DbSet<Tbl_FinnialManegment> tbl_FinnialManegments { get; set; }
        public DbSet<Tbl_Finnial> Tbl_Finnials { get; set; }

        public DbSet<Tbl_Headline> tbl_Headlines { get; set; }
        public DbSet<Tbl_Tasks> tbl_Tasks { get; set; }
        public DbSet<Tbl_Wallet> tbl_Wallets { get; set; }
        public DbSet<Tbl_TodoAppStudent> Tbl_TodoAppStudents { get; set; }
        public DbSet<Tbl_TodoAppConsultant> Tbl_TodoAppConsultant { get; set; }
        public DbSet<SendDegree> SendDegree { get; set; }
        public DbSet<Tbl_grade> grades { get; set; }
        public DbSet<Tbl_AddPanelConsultant> PanelConsultant { get; set; }
        public DbSet<Tbl_Balance> Tbl_Balances { get; set; }
        public DbSet<Tbl_HistoryPey> Tbl_HistoryPeys { get; set; }
        public DbSet<Tbl_Comision> Tbl_Comisions { get; set; }
        public DbSet<Tbl_RequestPeyment> Tbl_RequestPeyment { get; set; }
        public DbSet<Tbl_RequestonlineclassStudent> tbl_Requestonlineclasses { get; set; }


    }
    //public class Tbl_Day
    //{
    //    [Key]
    //    public int ID { get; set; }
    //    public string Day { get; set; }

    //}
    public class Tbl_Times
    {
        public int id { get; set; }
        public string time { get; set; }
    }
    public class Tbl_Nobat
    {
        [Key]
        public int Id { get; set; }
        public string ConsultantId { get; set; }
        public string StudentId { get; set; }
        public DateTime Date { get; set; }
        public bool IsSelect { get; set; } = false;
        public int TimesID { get; set; }
        public ICollection<Consultant> consultants { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Tbl_Times> times { get; set; }


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
    {
        [Key]
        public int Id { get; set; }
        public bool IsSend { get; set; }
        public int state { get; set; }
        public string Description { get; set; }
        public string ConsultantId { get; set; }
        public string type { get; set; }

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
        public ICollection<Tbl_Headline> headlines { get; set; }
    }
    public class Tbl_grade
    {
        [Key]
        public int IDGrade { get; set; }
        public string grade { get; set; }
        public ICollection<Tbl_Tasks> tasks { get; set; }

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
        public int Gradeid { get; set; }
        //public bool isSpecial { get; set; }

        // Navigation 
        public Tbl_Course Course { get; set; }
        public Consultant Cansultant { get; set; }
        public Student Student { get; set; }
        public Tbl_Do Do { get; set; }
        public Tbl_grade grade { get; set; }

    }
    public class Tbl_FinnialManegment
    {
        [Key]
        public int IDFinancial { get; set; }
        public string IDConsultant { get; set; }
        public long NumReceipt { get; set; }
        public bool State { get; set; }
        public DateTime DatePey { get; set; }
        public Consultant consultant { get; set; }
        public Student student { get; set; }

    }
    public class Tbl_Finnial
    {
        [Key]
        public int IDFinancial { get; set; }
        public string IDConsultant { get; set; }
        public long NumReceipt { get; set; }
        public bool State { get; set; }
        public DateTime DatePey { get; set; }
        public Consultant consultant { get; set; }
    }
    public class Tbl_HistoryPey
    {
        public int Id { get; set; }
        public long RefId { get; set; }
        public int Peyamount { set; get; }
        public int comision { set; get; }
        public string ConsultantId { get; set; }
        public DateTime DatePey { get; set; }

        public ICollection<Consultant> consultants { get; set; }

    }
    public class Tbl_Comision
    {
        [Key]
        public int Id { get; set; }
        public int percent { get; set; }
        public int price { get; set; }
    }
    public class Tbl_Balance
    {
        [Key]
        public int Id { get; set; }
        public int SumComosion { get; set; }
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
    public class Tbl_AddPanelConsultant
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int Day { get; set; }
        [Required]
        public int Price { get; set; }
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
    public class Tbl_RequestPeyment
    {
        public int id { get; set; }
        public string CardNumber { get; set; }
        public string Shaba { get; set; }
        public bool IsPey { get; set; }

        public bool IsStatus { get; set; } 

        public string Descrontion { get; set; }
        public long refid { get; set; }
        public int value { get; set; }
        public string ConsultantID { get; set; }

        public ICollection<Consultant> consultants { get; set; }
    }
    public class Tbl_RequestonlineclassStudent
    {[Key]
        public int id { get; set; }
        public string ConsultantID { get; set; }

        public string StudentID { get; set; }
        public bool statusForConsultant { get; set; }
        public string RequestTextStudent { get; set; }
        public bool? statusForAdmin { get; set; }
        public bool? DisplayForAdmin { get; set; }

        public string RequestTextConsultant { get; set; }
        public ICollection<Consultant> consultants { get; set; }
        public ICollection<Student> students { get; set; }


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

