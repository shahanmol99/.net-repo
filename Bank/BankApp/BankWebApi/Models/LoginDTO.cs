using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankWebApi.Models
{
    public class LoginDTO
    {

        [Required]
        public string UName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}