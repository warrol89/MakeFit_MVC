using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MakeFitMVCWeb.Models
{
    public class LoginModel
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="UserName cannot be empty")]
        public string LoginName { get; set; }
        public string Password { get; set; }
    }
}