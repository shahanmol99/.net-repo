using StudentLib.Model;
using System.Collections.Generic;

namespace StudentLib.Service
{
    public interface IStudentService
    {
        void AddStudents(Student student);
        List<Student> GetStudents();
        void UpdateStudentDetails(Student student);
    }
}