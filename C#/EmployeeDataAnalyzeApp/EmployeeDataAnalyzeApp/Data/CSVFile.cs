using EmployeeDataAnalyzeApp.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeDataAnalyzeApp.Data
{
    class CSVFile : ISource
    {
        List<Employee> _emps = new List<Employee>();

        public List<Employee> getData()
        {
            return _emps;
        }

        public void readSourceData()
        {
            String _filePath = "dataFile.txt";
            StreamReader reader = null;

            if (File.Exists(_filePath))
            {
                reader = new StreamReader(File.OpenRead(_filePath));

                String empName, designation, doj, comission, managerId;
                int empId, deptNo;
                double salary;

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

                    if(sameId)
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
                reader.Close();
            }
            else
            {
                throw new Exception("No Emp Data To Analyse");
            }
        }
    }
}
