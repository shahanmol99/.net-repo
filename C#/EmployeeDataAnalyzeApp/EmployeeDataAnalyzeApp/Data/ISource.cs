using System;
using System.Collections.Generic;
using EmployeeDataAnalyzeApp.Model;
using System.Text;

namespace EmployeeDataAnalyzeApp.Data
{
    interface ISource
    {
        void readSourceData();
        List<Employee> getData();
    }
}
