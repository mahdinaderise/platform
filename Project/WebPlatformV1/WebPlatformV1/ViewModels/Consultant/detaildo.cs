using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPlatformV1.ViewModels.Consultant
{
    public class detaildo
    {
        public int DiscriptiveTime { get; set; }
        public int TestTime { get; set; }
        public int RevisionTime { get; set; }
        //توضیحات فعالیت
        public string Note { get; set; }
        // تعداد تست ها

        [Required]
        public int TrueTest { get; set; }
        public int falseTest { get; set; }
        public int NullTest { get; set; }
    }
}
