using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.Consultant
{
    public class consultantpanel
    {
        public consultantpanel()
        {
            Panel = new List<Tbl_AddPanelConsultant>();
        }

        public int Day { get; set; }
        public int price { get; set; }
        public List<Tbl_AddPanelConsultant> Panel { get; set; }
    }
}
