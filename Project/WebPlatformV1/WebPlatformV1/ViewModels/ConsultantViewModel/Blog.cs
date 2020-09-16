using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.ConsultantViewModel
{
    public class Blog
    {
        public Blog()
        {
            blog = new List<Tbl_Blog>();
        }
        public List<Tbl_Blog> blog { get; set; }

        public string Name { get; set; }
        public string id { get; set; }
        public string Family { get; set; }
        public int CountPost { get; set; }
        public int CountStudent { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string ProfilePicUrl { get; set; }

        public string Tel { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public IFormFile Picture { get; set; }







    }
}
