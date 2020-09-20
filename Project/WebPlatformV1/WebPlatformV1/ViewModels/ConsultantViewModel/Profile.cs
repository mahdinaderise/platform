using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.ConsultantViewModel
{
    public class Profile
    {
        public Profile()
        {
            Degree = new List<SendDegree>();
        }
        public List<SendDegree> Degree { get; set; }

        public string id { get; set; }

        public string Name { get; set; }
        public string Family { get; set; }
        public string PhoneNumber { get; set; }
        public bool State { get; set; }
        public string ProfilePicUrl { get; set; }
        public string CardNumber { get; set; }
        public string city { get; set; }
        public string Province { get; set; }
        public string telephone { get; set; }
        public string Bio { get; set; }
        public string about { get; set; }
        public string Address { get; set; }
        public string Shaba { get; set; }
        public IFormFile Picture { get; set; }
        public IFormFile DegreemeliPic { get; set; }
        public IFormFile DegreePic { get; set; }


    }
}
