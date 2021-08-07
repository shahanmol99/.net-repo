using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib.Model
{
    public class Customer
    {
        [Key]
        public string ID { get; set; }
        public string Name { set; get; }
        public string Location { get; set; }
    }
}
