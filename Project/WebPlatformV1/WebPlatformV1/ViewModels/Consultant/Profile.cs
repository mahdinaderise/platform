using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models;

namespace WebPlatformV1.ViewModels.Consultant
{
    public class Profile
    {
        public Profile()
        {
            Consultants = new List<WebPlatformV1.Models.Consultant>();
        }
        public List<WebPlatformV1.Models.Consultant> Consultants { get; set; }

        public string Name { get; set; }
        public string Family { get; set; }
        public string PhoneNumber { get; set; }
        public bool State { get; set; }
        public string ProfilePicUrl { get; set; }
        public int CardNumber { get; set; }
        public string Address { get; set; }
        public string Shaba { get; set; }
        public IFormFile Picture { get; set; }

    }
}
