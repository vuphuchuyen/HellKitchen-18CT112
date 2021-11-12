using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodWeb.Model

{
    public class LoginModel
    {
        [Required(ErrorMessage =" Mời bạn nhập UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = " Mời bạn nhập PassWord")]
        public string Password { get; set; }
        public bool RemeberMe { get; set; }
    }
}