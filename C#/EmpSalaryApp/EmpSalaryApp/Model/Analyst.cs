using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSalaryApp.Model
{
    class Analyst : Employee
    {
        private double perks;
        public Analyst(int eno, string name, double basic) : base(eno, name, basic)
        {
            perks = _basic * 0.3;
        }

        public override double CalculateCTC()
        {
            return _basic + perks;
        }

        public override string GenerateCTCDetails()
        {
            StringBuilder details = new StringBuilder(50);
            details.Append("Name: " + _name);
            details.Append("<br>\n");
            details.Append("Role: Analyst");
            details.Append("<br>\n");
            details.Append("-----Salary Details-----");
            details.Append("<br>\n");
            details.Append("Basic: " + _basic);
            details.Append("<br>\n");
            details.Append("Perks: " + perks);
            details.Append("<br>\n");
            details.Append("Total Salary: " + this.CalculateCTC());

            return details.ToString();
        }
    }
}
