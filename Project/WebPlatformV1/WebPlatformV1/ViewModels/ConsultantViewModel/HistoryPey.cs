using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.ConsultantViewModel
{
    public class HistoryPey
    {
        public HistoryPey()
        {
            HistoryPeys = new List<Tbl_HistoryPey>();

        }
        public List<Tbl_HistoryPey> HistoryPeys { get; set; }

    }
}
