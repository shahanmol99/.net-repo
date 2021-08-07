using System;
using System.ComponentModel.DataAnnotations;

namespace BankWebApi.Models
{
    public class RegisterDTO
    {
        [Required]
        public string UName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
        [Required]
        [Range(500, Double.MaxValue, ErrorMessage = "Balance Should Be Atleast 500")]
        public double Balance { get; set; }

    }
}