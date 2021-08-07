using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmpApp.Model
{
    class Dept
    {
        [Key]
        public int DNo { get; set; }
        public string DName { get; set; }
        public string Loc { get; set; }

        public virtual List<Emp> Employee { get; set; }
    }
}
