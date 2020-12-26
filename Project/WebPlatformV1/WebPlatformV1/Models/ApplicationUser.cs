using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.Models
{
    public class ApplicationUsers:IdentityUser
    {
     
    }
    public class Student : ApplicationUsers
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int NationalCode { get; set; }
        public string telephone { get; set; }
        public int? Gradeid { get; set; }

        public bool State { get; set; }
        public string Province { get; set; }
        public string city { get; set; }
        public string ConsultantID { get; set; }
        public string ProfilePicUrl { get; set; }
        public string Magh { get; set; }
        public string Reshteh { get; set; }
        public DateTime CreditTime { get; set; }
        public Tbl_grade grade { get; set; }

    }
    public class Consultant : ApplicationUsers
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int NationalCode { get; set; }
        public bool State { get; set; }
        public bool IsSendDegree { get; set; } = false;
        public bool isAcceptDegree { get; set; } = false;
        public string Bio { get; set; }
        public string about { get; set; }
        public string ProfilePicUrl { get; set; }
        public string CardNumber { get; set; }
        public string Province { get; set; }
        public string city { get; set; }
        public string telephone { get; set; }
        public string Address { get; set; }
        public string Shaba { get; set; }
        public DateTime CreditTime { get; set; }
        public SendDegree sendDegree { get; set; }
        public Tbl_AddPanel addPanel { get; set; }
        public Tbl_Wallet Wallet { get; set; }
        public Tbl_RequestPeyment RequestPeyment { get; set; }
        public ICollection<Tbl_Tasks> tasks { get; set; }
        public ICollection<Tbl_Blog> blogs { get; set; }

    }
}
