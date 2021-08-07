using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankApp.Models
{
    public class BankUserModel
    {
        [Required(ErrorMessage = "Please Enter The Username")]
        public string Name { get; set; }

        //[Range(500, double.MaxValue, ErrorMessage = "You have deposit At least 500 Rs/-")]
        //public int Balance { get; set; }

        [Required(ErrorMessage = "Please Enter The Password")]
        public string Password { get; set; }
        public string NameErrorMessage { get; internal set; }
        public string PasswordErrorMessage { get; internal set; }
        public string ErrorMessage { get; internal set; }
    }
}