using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPlatformV1.Models
{
    public class ApplicationUsers:IdentityUser
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int NationalCode { get; set; }
        public bool State { get; set; }
    }
}
