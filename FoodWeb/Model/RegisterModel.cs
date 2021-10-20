using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodWeb.Model
{
    public class RegisterModel
    {
        [Key]
        public long ID { set; get; }
        [Display(Name="Tên đăng nhập ")]
        [Required(ErrorMessage ="Tên đăng nhập không được bỏ trống !")]
        public string UserName { set; get; }
        [Display(Name="Mật khẩu")]
       [StringLength(20,MinimumLength =6, ErrorMessage ="Nhập ít nhất 6 ký tự")]
       [Required(ErrorMessage ="Mật khẩu không được để trống")]
        public string Password { set; get; }
        [Display(Name ="Xác nhận mật khẩu")]
        [Compare("Password",ErrorMessage ="Xác nhận mật khẩu không đúng !")]
        public string confirmPassword { set; get; }
        [Display(Name ="Họ tên")]
        [Required(ErrorMessage ="Họ tên bạn không được để trống")]
        public string Name { set; get; }
        [Display(Name="Địa chỉ")]
        [Required(ErrorMessage ="Địa chỉ không được bỏ trống!")]
        public string Address { set; get; }
        [Display(Name="Email")]
        [Required(ErrorMessage ="Email không được bỏ trống")]
        public string Email { set; get; }
        [Display(Name="Số điện thoại")]
        [Required(ErrorMessage ="Số điện thoại không được bỏ trống!")]
        public int Phone { set; get; }
        
    }
}