using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.Admin
{
    public class DegreeCheck
    {
        public DegreeCheck()
        {
            Degree = new List<SendDegree>();
        }
        public List<SendDegree> Degree { get; set; }
    }
}
