using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDataAnalyzeApp.Model
{
    class Employee
    {
		private int _empId;
		private String _empName;
		private String _designation;
		private String _managerId;
		private String _doj;
		private double _salary;
		private String _comission;
		private int _deptNo;

        public Employee(int empId, string empName, string designation, string managerId, string doj, 
            double salary, string comission, int deptNo)
        {
            _empId = empId;
            _empName = empName;
            _designation = designation;
            _managerId = managerId;
            _doj = doj;
            _salary = salary;
            _comission = comission;
            _deptNo = deptNo;
        }

        public override bool Equals(object obj)
        {
            Employee other = (Employee)obj;
            if (_empId == other._empId)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return EmpId.GetHashCode();
        }

        public int EmpId
        {
            get
            {
                return _empId;
            }
        }
        public String EmpName
        {
            get
            {
                return _empName;
            }
        }
        public String Designation
        {
            get
            {
                return _designation;
            }
        }
        public String DOJ
        {
            get
            {
                return _doj;
            }
        }
        public String MangerId
        {
            get
            {
                return _managerId;
            }
        }
        public double Salary
        {
            get
            {
                return _salary;
            }
        }
        public String Commission
        {
            get
            {
                return _comission;
            }
        }
        public int DeptNo
        {
            get
            {
                return _deptNo;
            }
        }


    }
}
