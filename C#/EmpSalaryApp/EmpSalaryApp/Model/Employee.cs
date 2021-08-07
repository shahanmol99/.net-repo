using System;

namespace EmpSalaryApp.Model
{
    abstract class Employee
    {
        protected int _eno;
        protected String _name;
        protected double _basic;
        public Employee(int eno, string name, double basic)
        {
            _eno = eno;
            _name = name;
            _basic = basic;
        }
        public int GetEno
        {
            get
            {
                return _eno;
            }
        }

        public String GetName
        {
            get
            {
                return _name;
            }
        }
        public double GetBasic
        {
            get
            {
                return _basic;
            }
        }
        public abstract double CalculateCTC();
        public abstract String GenerateCTCDetails();
    }
}
