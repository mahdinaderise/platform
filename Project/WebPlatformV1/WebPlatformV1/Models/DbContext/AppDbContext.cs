using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace WebPlatformV1.Models.DbContext
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
       
        public AppDbContext(DbContextOptions dbContextOptions)
       : base(dbContextOptions)
        {

        }

        public DbSet<StudentOfCansultant> studentOfCansultants { get; set; }
    }
    public class StudentOfCansultant
    {[Key]
        public int ID { get; set; }
        public int IDStudent { get; set; }
        public virtual ApplicationUser IDCansultant { get; set; }
    }
    public class Tbl_Blog
    {
        [Key]
        public int ID { get; set; }
        public int IDConsultant { get; set; }
        public int IDAttach { get; set; }
        public string Note { get; set; }
        public AppDbContext Cansultant { get; set; }
        public List<Tbl_Attach> tbl_Attaches { get; set; }
    }
    public class Tbl_Attach
    {
        [Key]
        public int IDAttach { get; set; }
        public string Link { get; set; }
        public string Type { get; set; }
        public Tbl_Blog blog { get; set; }
    }
    //public class Tbl_Consultant: IdentityUser
    //{
    //    [Key]
    //    public int IDConsultant { get; set; }
    //    public string NameConsultant { get; set; }
    //    public string FamilyConsultant { get; set; }
    //    public int NationlCode { get; set; }
    //    public int Tell { get; set; }
    //    public Tbl_Blog blog { get; set; }

    //}
    public class Tbl_Course
    {
        [Key]
        public int IDCourse { get; set; }
        public string NameCourse { get; set; }
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
    }
    public class Tbl_FinnialManegment
    {
        [Key]
        public int IDFinancial { get; set; }
        public int IDConsultant { get; set; }
        public int NumReceipt { get; set; }
        public int DatePayment { get; set; }
        public string State { get; set; }
    }
    public class Tbl_Headline
    {
        [Key]
        public int IDHeadline { get; set; }
        public int IDCourse { get; set; }
        [Required]
        public string HeadlineName { get; set; }
    }
    public class Tbl_SendFileConsultant
    {
        [Key]
        public int IDAttach { get; set; }
        public string link { get; set; }
        public string type { get; set; }
    }
    //public class Tbl_Student: IdentityUser
    //{
    //    [Key]
    //    public int IDStudent { get; set; }
    //    [Required]
    //    public string NameStudent { get; set; }
    //    [Required]
    //    public string FamilyStudent { get; set; }
    //    [Required]
    //    public int NationalCode { get; set; }
    //    [Required]
    //    public string State { get; set; }
    //    public int Tell { get; set; }
    //    [Required]
    //    public string Address { get; set; }
    //}
    public class Tbl_Tasks
    {
        [Key]
        public int IDTasks { get; set; }
        public int IDCansoltant { get; set; }
        public int IDStudent { get; set; }
        public int IDido { get; set; }
        public string NameTasks { get; set; }
        public DateTime SendDelivery { get; set; }
        public AppDbContext Cansultant { get; set; }
        public AppDbContext Student { get; set; }


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

    }
    public class Tbl_TasksCourse
    {
        [Key]
        public int IDTasksCourse { get; set; }
        public int IDCourse { get; set; }
        public int IDTasks { get; set; }
    }
}
