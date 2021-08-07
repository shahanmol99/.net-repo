using System;

namespace StudentLib.Model
{
    public class Student
    {
        private string _id;

        public Student()
        {
            Guid guid = Guid.NewGuid();
            _id = guid.ToString();
        }

        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public int RollNo { get; set; }
        public string Name { get; set; }
        public float CGPA { get; set; }

    }
}
