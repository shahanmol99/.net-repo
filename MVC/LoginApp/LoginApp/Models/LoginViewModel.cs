using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp.Models
{
    public class LoginViewModel
    {
        public string UsernName { get; set; }
        public string UserPassWord { get; set; }
        public string ErrorMessage { get; set; }

    }
}