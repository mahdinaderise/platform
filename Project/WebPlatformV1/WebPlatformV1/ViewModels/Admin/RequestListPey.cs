using Microsoft.Data.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.Admin
{
    public class RequestListPey
    {
        public RequestListPey()
        {
            Request = new List< Tbl_RequestPeyment>();
            SRequest = new Tbl_RequestPeyment();
        }
        public List<Tbl_RequestPeyment> Request { get; set; }
        public Tbl_RequestPeyment SRequest { get; set; }

        public string CardNumber { get; set; }
        public string Shaba { get; set; }
        public bool IsPey { get; set; }
        public string Descrontion { get; set; }
        public long refid { get; set; }
        public int values1 { get; set; }
        public string ConsultantID { get; set; }
    }
}
