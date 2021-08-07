using System.ComponentModel.DataAnnotations;

namespace QueryableEnumerableApp.Model
{
    class Student
    {
        [Key]
        public string ID { get; set; }

        public string Name { get; set; }

        public float Cgpa { get; set; }
    }
}
