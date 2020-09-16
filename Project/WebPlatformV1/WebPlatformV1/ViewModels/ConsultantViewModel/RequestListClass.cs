using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.ConsultantViewModel
{
    public class RequestListClass
    {
        public RequestListClass()
        {
            Request = new List<Tbl_RequestonlineclassStudent>();
            SRequest = new Tbl_RequestonlineclassStudent();

        }
        public List<Tbl_RequestonlineclassStudent> Request { get; set; }
        public Tbl_RequestonlineclassStudent SRequest { get; set; }
        
    }
}
