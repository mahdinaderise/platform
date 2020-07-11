using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPlatformV1.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int NationlCode { get; set; }
        public string State { get; set; }
    }
}
