
using System.ComponentModel.DataAnnotations;

namespace EFConsoleApp.Model
{
    class Customer
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int balance { get; set; }
       // public string Type { get; set; }

    }
}
