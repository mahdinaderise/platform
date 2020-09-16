using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.ConsultantViewModel
{
    public class TasksStudents
    {
        public TasksStudents()
        {
            tasks = new List<Tbl_Tasks>();
        }
        public List<Tbl_Tasks> tasks { get; set; }
        public List<Student> Students { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
