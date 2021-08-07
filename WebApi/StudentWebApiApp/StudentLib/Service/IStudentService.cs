using StudentLib.Model;
using System.Collections.Generic;

namespace StudentLib.Service
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        List<Student> GetListOfStudents();
        Student GetStudent(string id);
        void DeleteStudent(Student student);
        void UpdateStudent(Student stud);
    }
}