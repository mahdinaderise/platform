using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.Admin
{
    public class ConsultantDeactive
    {
        public ConsultantDeactive()
        {
        }
        public string id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public int nationalcode { get; set; }

    }
}