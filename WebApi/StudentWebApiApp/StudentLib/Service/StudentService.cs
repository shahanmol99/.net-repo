using System;
using System.Collections.Generic;
using StudentLib.Model;
using StudentLib.Repo;

namespace StudentLib.Service
{
    public class StudentService : IStudentService
    {
        IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public void AddStudent(Student student)
        {
            _repo.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            _repo.Delete(student);
        }

        public List<Student> GetListOfStudents()
        {
            return _repo.Get();
        }

        public Student GetStudent(string id)
        {
            return _repo.GetStudent(id);
        }

        public void UpdateStudent(Student stud)
        {
             _repo.Update(stud);
        }
    }
}
