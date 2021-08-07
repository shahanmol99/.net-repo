using System;
using System.Text;

namespace EmpSalaryApp.Model 
{
    class Manager : Employee
    {
        private double _hra, _ta;
        public Manager(int eno, string name, double basic) : base(eno, name, basic)
        {
            _hra = (0.5 * _basic);
            _ta = (0.4 * _basic);
        }

        public override double CalculateCTC()
        {
            double ctc = (_basic + _hra + _ta);
            return ctc;
        }

        public override string GenerateCTCDetails()
        {
            StringBuilder details = new StringBuilder(50);
            details.Append("Name: " + _name);
            details.Append("<br>\n");
            details.Append("Role: Manager");
            details.Append("<br>\n");
            details.Append("-----Salary Details-----");
            details.Append("<br>\n");
            details.Append("Basic: " + _basic);
            details.Append("<br>\n");
            details.Append("HRA: " + _hra);
            details.Append("<br>\n");
            details.Append("TA: " + _ta);
            details.Append("<br>\n");
            details.Append("Total Salary: " + this.CalculateCTC());

            return details.ToString();
        }
    }
}
