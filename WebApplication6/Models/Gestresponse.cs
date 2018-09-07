using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Gestresponse
    {
        [Required(ErrorMessage = "请输入姓名")]
        public string Name { get; set; }

        [Required(ErrorMessage = "请输入电子邮箱地址")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "请输入有效的电子邮箱")]
        public string Email { get; set; }
        [Required(ErrorMessage = "请输入手机号码")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "请确认是否参加")]
        public bool? WillAttend { get; set; }
    }
}