using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcBasic.Models
{
    public class Member
    {
        public int Id { get; set; }
        [DisplayName("氏名")]
        [Required(ErrorMessage ="{0}は必須です。")]
        [StringLength(100,ErrorMessage ="{0}は{1}文字以内で入力してください。")]
        public string Name { get; set; }
        [DisplayName("メールアドレス")]
        [Required(ErrorMessage = "{0}は必須です。")]
        [StringLength(55, ErrorMessage = "{0}は{1}を入力してください。")]
        public string Email { get; set; }
        [DisplayName("生年月日")]
        [Required(ErrorMessage = "{0}は必須です。")]
        public DateTime Birth { get; set; }
        [DisplayName("既婚")]
        public bool Married { get; set; }
        [DisplayName("自己紹介")]
        public string Memo { get; set; }
    }
}