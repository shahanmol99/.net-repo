using System;
using System.Collections.Generic;
using System.Linq;
using EmpApp.Model;

namespace EmpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            AurionproDbContext db = new AurionproDbContext();

            AddDataToDb(db);
            DisplayAllEmployees(db);
            DisplayEmployeeWithDeptName(db);    
        }

        private static void DisplayEmployeeWithDeptName(AurionproDbContext db)
        {
            var empList = from emp in db.Emps
                          join dept in db.Depts
                          on emp.Department.DNo equals dept.DNo
                          select new { EmpNo = emp.ENo, Name = emp.EName, DName = dept.DName } ;

            foreach (var emp in empList)
            {
                Console.WriteLine(emp.EmpNo + " " + emp.Name + " " + emp.DName);
            }
        }

        private static void AddDataToDb(AurionproDbContext db)
        {
            Dept d = new Dept { DNo = 10, DName = "IT", Loc = "Mumbai" };
            //var emp = new Emp { ENo = 101, EName = "Abc", Department = d };
            d.Employee = new List<Emp>();
            d.Employee.Add(new Emp { ENo = 101, EName = "Abc", Department = d });
            d.Employee.Add(new Emp { ENo = 102, EName = "Pqr", Department = d });
            d.Employee.Add(new Emp { ENo = 103, EName = "Xyz", Department = d });

            Dept d2 = new Dept { DNo = 20, DName = "Sales", Loc = "Mumbai" };
            //var emp = new Emp { ENo = 101, EName = "Abc", Department = d };
            d2.Employee = new List<Emp>();
            d2.Employee.Add(new Emp { ENo = 111, EName = "Test", Department = d2 });
            d2.Employee.Add(new Emp { ENo = 112, EName = "Ok", Department = d2 });
            d2.Employee.Add(new Emp { ENo = 113, EName = "Welcome", Department = d2 });

            db.Depts.Add(d);
            db.Depts.Add(d2);
            db.SaveChanges();
        }

        private static void DisplayAllEmployees(AurionproDbContext db)
        {
            var empList = from emp in db.Emps
                          select emp;

            foreach(Emp emp in empList)
            {
                Console.WriteLine(emp.ENo + " " + emp.EName + " " + emp.Department.DNo);
            }

            Console.WriteLine();
        }
    }
}
