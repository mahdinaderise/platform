using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.Consultant
{
    public class TasksStudent
    {
        public TasksStudent()
        {
            tasks = new List<Tbl_Tasks>();
        }
        public List<Tbl_Tasks> tasks { get; set; }
    }
}
