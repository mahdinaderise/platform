using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.Consultant
{
    public class todoappc
    {
        public todoappc()
        {
            Todo = new List<Tbl_TodoAppConsultant>();
        }
        public int id { get; set; }

        public string consultantid { get; set; }
        public string Note { get; set; }
        public bool IsFinally { get; set; } = false;
        public List<Tbl_TodoAppConsultant> Todo { get; set; }
    }
}
