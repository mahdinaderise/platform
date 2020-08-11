﻿using Microsoft.AspNetCore.Identity;
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
        public bool State { get; set; }
        public string ConsultantID { get; set; }
        public string ProfilePicUrl { get; set; }


    }
    public class Consultant : ApplicationUsers
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int NationalCode { get; set; }
        public bool State { get; set; }
        public string ProfilePicUrl { get; set; }
        public Tbl_AddPanel addPanel { get; set; }
        public ICollection<Tbl_Tasks> tasks { get; set; }
        public ICollection<Tbl_Blog> blogs { get; set; }

    }
}
