using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.Admin
{
    public class ConsultantProfile
    {
        public ConsultantProfile()
        {
            HistoryPeys = new List<Tbl_HistoryPey>();
        }
        public List<Tbl_HistoryPey> HistoryPeys { get; set; }
        public int Credit { get; set; }
        public int Creditforadd { get; set; }
        public int CreditforSub { get; set; }


    }
}
