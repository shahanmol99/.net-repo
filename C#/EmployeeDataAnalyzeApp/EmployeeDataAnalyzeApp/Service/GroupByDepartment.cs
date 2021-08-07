using System;
using System.Collections.Generic;
using System.Text;
using EmployeeDataAnalyzeApp.Data;
using EmployeeDataAnalyzeApp.Model;


namespace EmployeeDataAnalyzeApp.Service
{
    class GroupByDepartment : IAnalyze
    {
        private ISource _file;
        private List<Employee> _emps;

        public GroupByDepartment(ISource file)
        {
            _file = file;
            _emps = file.getData();
        }

        public string AnalyzeEmpData()
        {
            Dictionary<int, int> deptNo = new Dictionary<int, int>();

            int tempDeptNo;
            StringBuilder str = new StringBuilder();

            foreach (Employee emp in _emps)
            {
                tempDeptNo = emp.DeptNo;

                if (deptNo.ContainsKey(tempDeptNo))
                {
                    deptNo[tempDeptNo] = deptNo[tempDeptNo] + 1;
                }
                else
                {
                    deptNo.Add(tempDeptNo, 1);
                }
            }

            foreach (KeyValuePair<int, int> deptNoKeyValue in deptNo)
            {
                str.Append("No of " + deptNoKeyValue.Key + " = " + deptNoKeyValue.Value);
                str.Append("\n");
            }

            return str.ToString();
        }
    }
}
