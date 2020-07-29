﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models.DbContext;
using WebPlatformV1.Models;
namespace WebPlatformV1.ViewModels.Consultant
{
    public class CreateTask
    {
        public CreateTask()
        {
            course = new List<Tbl_Course>();
            tasks = new List<Tbl_Tasks>();
            Students = new List<Student>();
        }
        public List<Tbl_Tasks> tasks { get; set; }
        public List<Tbl_Course> course { get; set; }
        public List<Student> Students { get; set;}
        public string NameTasks { get; set; }
        public DateTime SendDelivery { get; set; }
        public int TimeStudy { get; set; }
        public string Subject { get; set; }
        public string Descibtion { get; set; }

    }
}