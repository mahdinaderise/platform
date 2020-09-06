using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPlatformV1.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "ایمیل")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "نام ")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }
        [Required]
        [Display(Name = "کدملی")]
        public int NationalCode { get; set; }

        [Required]
        [Display(Name = "رمزعبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "تکرار رمزعبور")]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
