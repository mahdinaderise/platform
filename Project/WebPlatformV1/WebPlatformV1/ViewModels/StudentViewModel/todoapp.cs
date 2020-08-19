using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.StudentViewModel
{
    public class todoapp
    {
        public todoapp()
        {
            Todo = new List<Tbl_TodoAppStudent>();
        }
        public int id { get; set; }

        public string STudentID { get; set; }
        public string Note { get; set; }
        public bool IsFinally { get; set; } = false;
        public List<Tbl_TodoAppStudent> Todo { get; set; }
    }
}
