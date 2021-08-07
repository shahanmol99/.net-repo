using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentWebApiApp.Models
{
    public class StudentModel
    {
        public string Id { get
            {
                return Id;
            }
            set
            {
                Id = Guid.NewGuid().ToString();
            } 
        }

        [Required]
        public string Name { get; set; }
        [Required]
        public int RollNo { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public bool isMale { get; set; }
        [Required]
        public string Date { get; set; }
    }
}