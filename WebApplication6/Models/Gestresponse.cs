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
        [RegularExpression("^((13[0-9])|(14[5,7])|(15[0-3,5-9])|(17[0,3,5-8])|(18[0-9])|166|198|199|(147))\\d{8}$", ErrorMessage = "请输入有效的手机号码")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "请确认是否参加")]
        public bool? WillAttend { get; set; }
    }
}