using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSalaryApp.Model
{
    class Developer : Employee
    {
        private double projAllowance, pa;
        public Developer(int eno, string name, double basic) : base(eno, name, basic)
        {
            projAllowance = 0.4 * _basic;
            pa = 0.3 * _basic;
        }

        public override double CalculateCTC()
        {
            return _basic + projAllowance + pa;
        }

        public override string GenerateCTCDetails()
        {  
            StringBuilder details = new StringBuilder(50);
            details.Append("Name: " + _name);
            details.Append("<br>\n");
            details.Append("Role: Developer");
            details.Append("<br>\n");
            details.Append("-----Salary Details-----");
            details.Append("<br>\n");
            details.Append("Basic: " + _basic);
            details.Append("<br>\n");
            details.Append("Project Allowance: " + projAllowance);
            details.Append("<br>\n");
            details.Append("PA: " + pa);
            details.Append("<br>\n");
            details.Append("Total Salary: " + this.CalculateCTC());

            return details.ToString();
        }
}
}
