using StudentLinqApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentLinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>();

            studentList.Add(new Student(101, "Bob", "Mumbai", 7.9));
            studentList.Add(new Student(102, "John", "Delhi", 6.5));
            studentList.Add(new Student(103, "Kev", "Indore", 10));
            studentList.Add(new Student(104, "Dev", "Bhopal", 9.1));
            studentList.Add(new Student(105, "Anmol", "Mumbai", 8.1));
            studentList.Add(new Student(106, "Ram", "Delhi", 7.1));
            studentList.Add(new Student(107, "Bill", "Banglore", 7.5));
            studentList.Add(new Student(108, "Kartik", "Chennai", 8));
            studentList.Add(new Student(109, "Pqr", "Kolkata", 6.9));
            studentList.Add(new Student(110, "Xyz", "xyz", 7.3));

            Console.WriteLine("----Top 5 Students With Highest Cgpa----");
            FilterFirst5StudentsWithHighestCGPA(studentList);
            Console.WriteLine();
            Console.WriteLine("----Students With City Mumbai----");
            FilterStudentsBasedOnLocation(studentList, "Mumbai");
            Console.WriteLine();

            Console.WriteLine("----Select Only Name and Cgpa----");
            var newStudentList = (from s in studentList
                                  select s.StudentName + " " + s.StudentCgpa).ToList();


            foreach (String s in newStudentList)
            {
                Console.WriteLine(s);
            }


        }

        private static void FilterStudentsBasedOnLocation(IList<Student> studentList, string city)
        {
            var filteredStudentList = (from s in studentList
                                     where s.StudentCity.Equals(city)
                                     orderby s.StudentName
                                     select s).ToList();

            studentList.Add(new Student(111, "Lee", "Mumbai", 8.5)); //immidiate execution

            foreach (Student s in filteredStudentList)
            {
                Console.WriteLine(s.StudentId + " " + s.StudentName + " " + s.StudentCity);
            }
        }

        private static void FilterFirst5StudentsWithHighestCGPA(IList<Student> studentList)
        {
            var top5_studenlist = (from s in studentList
                                   orderby s.StudentCgpa descending
                                   select s).Take(5);

            studentList.Add(new Student(111, "Lee", "xyz", 8.5)); //defered execution

            foreach (Student s in top5_studenlist)
            {
                Console.WriteLine(s.StudentId + " " + s.StudentName + " " + s.StudentCgpa);
            }

        }
    }
}
