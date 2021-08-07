using System;
using System.Collections.Generic;
using System.Text;
using EmployeeDataAnalyzeApp.Model;
using System.IO;
using System.Net;

namespace EmployeeDataAnalyzeApp.Data
{
    class URL : ISource
    {
        List<Employee> _emps = new List<Employee>();

        public List<Employee> getData()
        {
            return _emps;
        }

        public void readSourceData()
        {
            String url = "https://swabhav-tech.firebaseapp.com/emp.txt";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            String empName, designation, doj, comission, managerId;
            int empId, deptNo;
            double salary;

            WebClient web = new WebClient();
            Stream stream = web.OpenRead(url);
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {

                while (!reader.EndOfStream)
                {
                    String empDetailsLine = reader.ReadLine();
                    String[] empDetails = empDetailsLine.Split(',');

                    empId = Int32.Parse(empDetails[0]);
                    bool sameId = false;
                    foreach (Employee e in _emps)
                    {
                        if (empId == e.EmpId)
                        {
                            sameId = true;
                            continue;
                        }
                    }

                    if (sameId)
                    {
                        continue;
                    }

                    empName = empDetails[1];
                    designation = empDetails[2];
                    managerId = empDetails[3];
                    doj = empDetails[4];
                    salary = Double.Parse(empDetails[5]);
                    comission = empDetails[6];
                    deptNo = Int32.Parse(empDetails[7]);

                    _emps.Add(new Employee(empId, empName, designation, managerId, doj, salary, comission, deptNo));

                }

            }
        }
    }
}
