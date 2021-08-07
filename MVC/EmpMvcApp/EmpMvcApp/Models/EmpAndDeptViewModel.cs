using EmpLib.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmpMvcApp.Models
{
    public class EmpAndDeptViewModel
    {
        public List<Dept> dept { get; set; }
        public List<Employee> emps { get; set; }
        [Required(ErrorMessage = "Please Select a department")]
        public string deptNo { get; set; }
    }
}