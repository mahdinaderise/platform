using Microsoft.AspNetCore.Mvc;
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
        [Remote("IsUserNameInUse","Account")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "ایمیل")]
        [EmailAddress]
        [Remote("IsEmailInUse", "Account")]
        public string Email { get; set; }
        [Display(Name = "نام ")]
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }
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
