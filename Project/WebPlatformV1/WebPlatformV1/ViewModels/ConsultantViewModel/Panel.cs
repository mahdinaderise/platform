﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.ViewModels.ConsultantViewModel
{
    public class Panel
    {
        public Panel()
        {
            Panel1 = new Tbl_AddPanel();
        }
        public int Day { get; set; }
        public int price { get; set; }
        public string studentid { get; set; }
        public string consultantid { get; set; }
        public Tbl_AddPanel Panel1 { get; set; }
    }
}
