using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankApp.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "Please Enter The Username")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Fill The Balance")]
        [Range(500, double.MaxValue, ErrorMessage = "You have deposit At least 500 Rs/-")]
        public int Balance { get; set; }

        [Required(ErrorMessage = "Please Enter The Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Re-Enter The Password")]
        [Compare("Password", ErrorMessage = "Password Does Not Match")]
        public string RePassword { get; set; }

        public string NameErrorMessage { get; set; }
        public string RegisterErrorMessage { get; internal set; }
        public string RegisterSuccessMessage { get; internal set; }
    }
}