using StudentLib.Model;
using System.Collections.Generic;

namespace StudentLib.Repo
{
    public interface IStudentRepository
    {
        void Update(Student student);
        void Add(Student student);
        List<Student> Get();
    }
}