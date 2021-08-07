using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentApp.Models
{
    public class UpdateStudentModel
    {
        public string ID { get; set; }

        [Required(ErrorMessage = "Please Enter RollNo")]
        public int RollNo { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter RollNo")]
        [Range(1, 10, ErrorMessage = "Cgpa should be between 1-10")]
        public float Cgpa { get; set; }

    }
}