using System;
using System.Collections.Generic;
using StudentLib.Model;

namespace StudentLib.Repo
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> students;
        //private static StudentRepository instance;
        public StudentRepository()
        {
            students = new List<Student>();

            students.Add(new Student
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Abc",
                RollNo = 101,
                Age = 20,
                Email = "abc@sample.com",
                isMale = false,
                Date = "10/12/2020"
            });

            students.Add(new Student
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Test",
                RollNo = 102,
                Age = 22,
                Email = "Test@Test.com",
                isMale = true,
                Date = "22/05/2021"
            });

            students.Add(new Student
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Ram",
                RollNo = 103,
                Age = 24,
                Email = "ram@sample.com",
                isMale = true,
                Date = "07/06/2021"
            });

            students.Add(new Student
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Pam",
                RollNo = 104,
                Age = 20,
                Email = "pam@Test.com",
                isMale = false,
                Date = "01/08/2021"
            });

            students.Add(new Student
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Jim",
                RollNo = 105,
                Age = 24,
                Email = "jim@sample.com",
                isMale = true,
                Date = "22/05/2021"
            });
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public List<Student> Get()
        {
            return students;
        }

        //public static StudentRepository GetInstance()
        //{
        //    if(instance==null)
        //    {
        //        instance = new StudentRepository();
        //    }

        //    return instance;
        //}

        public Student GetStudent(string id)
        {
            var student = students.Find(s => s.Id == id);
            return student;
        }

        public void Delete(Student student)
        {
            students.Remove(students.Find(s => s.Id == student.Id));
        }

        public void Update(Student stud)
        {
            int index = students.FindIndex(s => s.Id == stud.Id);

            students[index] = stud; 
        }
    }
}
