using RegistrationApp.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationApp.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please Enter Correct Email")]
        public string Email { get; set; }

        [Range(18,35, ErrorMessage = "Enter Age Between 18-35")]
        public int Age { get; set; }

        [MinRange(15000, ErrorMessage = "Salary Must Be Greater Than 15000")]
        public double Salary { get; set; }
    }
}