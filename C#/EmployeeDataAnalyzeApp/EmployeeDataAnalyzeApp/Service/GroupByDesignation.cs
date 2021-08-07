using System;
using System.Collections.Generic;
using EmployeeDataAnalyzeApp.Data;
using EmployeeDataAnalyzeApp.Model;
using System.Text;

namespace EmployeeDataAnalyzeApp.Service
{
    class GroupByDesignation : IAnalyze
    {
        private ISource _file;
        private List<Employee> _emps;

        public GroupByDesignation(ISource file)
        {
            _file = file;
            _emps = file.getData();
        }

        public string AnalyzeEmpData()
        {
            Dictionary<String, int> designationCount = new Dictionary<string, int>();

            String designation;
            StringBuilder str = new StringBuilder();

            foreach (Employee emp in _emps)
            {
                designation = emp.Designation;

                if (designationCount.ContainsKey(designation))
                {
                    designationCount[designation] = designationCount[designation] + 1;
                }
                else
                {
                    designationCount.Add(designation, 1);
                }
            }

            foreach(KeyValuePair<String, int> designationKeyValue in designationCount)
            {
                str.Append("No of " + designationKeyValue.Key + " = " + designationKeyValue.Value);
                str.Append("\n");
            }

            return str.ToString();
        }
    }
}

