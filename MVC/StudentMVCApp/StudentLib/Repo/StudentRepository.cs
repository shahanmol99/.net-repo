using StudentLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentLib.Repo
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _students;
        private static StudentRepository instance;
        public StudentRepository()
        {
            _students = new List<Student>();

            _students.Add(new Student { Name = "Anmol", RollNo = 337, CGPA = 8.23F });
            _students.Add(new Student { Name = "Dev", RollNo = 479, CGPA = 7.73F });
            _students.Add(new Student { Name = "Bill", RollNo = 165, CGPA = 9.66F });
            _students.Add(new Student { Name = "Jon", RollNo = 519, CGPA = 6.49F });
            _students.Add(new Student { Name = "Jean", RollNo = 222, CGPA = 8.12F });
        }

        public void Update(Student student)
        {
            var updateStudent = _students.Where(s => s.ID == student.ID).First();
            _students.RemoveAll(s => s.ID == student.ID);
            updateStudent = student;
            _students.Add(updateStudent);
        }

        public List<Student> Get()
        {
            return _students;
        }

        public void Add(Student student)
        {
            _students.Add(student);
        }

        //public static StudentRepository GetInstance()
        //{
        //    if (instance == null)
        //    {
        //        instance = new StudentRepository();
        //    }

        //    return instance;
        //}
    }
}
