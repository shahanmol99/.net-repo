using System;
using EmployeeDataAnalyzeApp.Data;
using EmployeeDataAnalyzeApp.Service;

namespace EmployeeDataAnalyzeApp
{
    class Program
    {
        static void Main(string[] args)
        {
			int choice;
			ISource file = null;

			Console.WriteLine("1-----Read From CSV File-------");
			Console.WriteLine("2-----Read From URL-------");
			Console.Write("Enter your choice: ");
			choice = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			if (choice == 1)
			{
				file = new CSVFile();
				Console.WriteLine("Reading Data From CSV File......");
				file.readSourceData();
			}
			else if (choice == 2)
			{
				file = new URL();
				Console.WriteLine("Reading Data From Web......");
				file.readSourceData();
			}

			Console.WriteLine();
			Console.WriteLine("Employee with max salary: ");
			ExecuteOperations(new MaxSalary(file));

			Console.WriteLine("Group Employee by Department: ");
			ExecuteOperations(new GroupByDepartment(file));

			Console.WriteLine("Group Employee by Designation: ");
			ExecuteOperations(new GroupByDesignation(file));

		}

		private static void ExecuteOperations(IAnalyze x)
		{
			Console.WriteLine(x.AnalyzeEmpData());
			Console.WriteLine();
		}
	}
}
