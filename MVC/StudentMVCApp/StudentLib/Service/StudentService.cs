using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLib.Repo;
using StudentLib.Model;

namespace StudentLib.Service
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _repo;

        public StudentService(StudentRepository repo)
        {
            _repo = repo;
        }

        public List<Student> GetStudents()
        {
            return _repo.Get();
        }

        public void AddStudents(Student student)
        {
            _repo.Add(student);
        }

        public void UpdateStudentDetails(Student student)
        {
            _repo.Update(student);
        }
    }
}
