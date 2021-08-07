using System;
using System.Collections.Generic;
using System.Text;
using EmployeeDataAnalyzeApp.Data;
using EmployeeDataAnalyzeApp.Model;

namespace EmployeeDataAnalyzeApp.Service
{
    class MaxSalary : IAnalyze
    {
		private ISource _file;
		private List<Employee> _emps;

        public MaxSalary(ISource file)
        {
            _file = file;
            _emps = file.getData();
        }

        public string AnalyzeEmpData()
        {
			Employee maxSalaryEmp = null;
			double maxSalary = 0;

			foreach(Employee emp in _emps)
			{
				if (emp.Salary > maxSalary)
				{
					maxSalaryEmp = emp;
					maxSalary = emp.Salary;
				}
			}
			StringBuilder str = new StringBuilder();
			str.Append("Name: " + maxSalaryEmp.EmpName);
			str.Append(" Designation: " + maxSalaryEmp.Designation);
			str.Append(" Salary: " + maxSalaryEmp.Salary);

			return str.ToString();
		}
	}
}
