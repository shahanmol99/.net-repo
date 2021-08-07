using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinqApp.Model
{
    class Student
    {
        private int _id;
        private string _name;
        private string _city;
        private double _cgpa;

        public Student(int id, string name, string city, double cgpa)
        {
            _id = id;
            _name = name;
            _city = city;
            _cgpa = cgpa;
        }

        public int StudentId
        {
            get
            {
                return _id;
            }
        }
        public string StudentName
        {
            get
            {
                return _name;
            }
        }
        public string StudentCity
        {
            get
            {
                return _city;
            }
        }
        public double StudentCgpa
        {
            get
            {
                return _cgpa;
            }
        }
    }
}
