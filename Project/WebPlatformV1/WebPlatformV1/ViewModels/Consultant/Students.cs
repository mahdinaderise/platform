using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models;

namespace WebPlatformV1.ViewModels.Consultant
{
    public class StudentsViewModel
    {
        public StudentsViewModel()
        {
            Students = new List<Student>();
        }
        public string idStudent { get; set; }
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [Display(Name = "کدملی")]
        public int NationlCode { get; set; }

        public List<Student> Students { get; set; }
    }
}
