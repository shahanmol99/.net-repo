using System;
using System.Collections.Generic;
using System.Linq;
using QueryableEnumerableApp.Model;

namespace QueryableEnumerableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDbContext db = new StudentDbContext();
            //AddStudents(db);
            DisplayStudemts(db);
            QueryableCase1(db);
            QueryableCase2(db);

        }

        private static void QueryableCase2(StudentDbContext db)
        {
            var NameStartingWithS = db.Students
                                        .Where(s => s.Name.StartsWith("S"))
                                        .AsEnumerable()
                                        .Select(s => new { Name = s.Name.Split(' ')[0], s.Cgpa });
            Console.WriteLine("SQL Expression Is Built");
            Console.WriteLine(NameStartingWithS);
            Console.WriteLine();

            var NameStartingWithSList = NameStartingWithS.ToList();
            foreach (var s in NameStartingWithSList)
            {
                Console.WriteLine(s.Name + " " + s.Cgpa);
            }
            Console.WriteLine();
        }

        private static void QueryableCase1(StudentDbContext db)
        {
            var NameStartingWithS = db.Students
                                        .Where(s => s.Name.StartsWith("S"))
                                        .Select(s => new { s.Name, s.Cgpa });

            Console.WriteLine("SQL Expression Is Built");
            Console.WriteLine(NameStartingWithS);
            Console.WriteLine();

            var NameStartingWithSList = NameStartingWithS.ToList();
            foreach (var s in NameStartingWithSList)
            {
                Console.WriteLine(s.Name + " " + s.Cgpa);
            }
            Console.WriteLine();

        }

        private static void DisplayStudemts(StudentDbContext db)
        {
            foreach(var s in db.Students)
            {
                Console.WriteLine(s.ID + " " + s.Name + " " + s.Cgpa);
            }
            Console.WriteLine();
        }

        private static void AddStudents(StudentDbContext db)
        {
            db.Students.Add(new Student { ID = Guid.NewGuid().ToString(), Name = "Sachin Tendulkar", Cgpa = 9.2f });
            db.Students.Add(new Student { ID = Guid.NewGuid().ToString(), Name = "Saurabh Test1", Cgpa = 7.25f });
            db.Students.Add(new Student { ID = Guid.NewGuid().ToString(), Name = "Anmol Shah", Cgpa = 8.23f });
            db.Students.Add(new Student { ID = Guid.NewGuid().ToString(), Name = "Siddhesh Yellaram", Cgpa = 6.59f });
            db.Students.Add(new Student { ID = Guid.NewGuid().ToString(), Name = "Test Test", Cgpa = 8f });

            db.SaveChanges();
            Console.WriteLine("Added Successfully");
        }
    }
}
