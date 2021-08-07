using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmpApp.Model
{
    class Emp
    {
        [Key]
        public int ENo { get; set; }
        public string EName { get; set; }
        public virtual Dept Department { get; set; }
    }
}
