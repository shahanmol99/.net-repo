using StudentLib.Model;
using System.Collections.Generic;

namespace StudentLib.Repo
{
    public interface IStudentRepository
    {
        void Add(Student student);
        List<Student> Get();
        Student GetStudent(string id);
        void Delete(Student student);
        void Update(Student stud);
    }
}