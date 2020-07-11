using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.Models
{
    public class ConsultantDashboardViewModel
    {
        public ConsultantDashboardViewModel()
        {
            Consultant = new List<MainDBContext>();
        }
        public string IDConsultant { get; set; }
        public List<MainDBContext> Consultant { get; set; }

    }
}
