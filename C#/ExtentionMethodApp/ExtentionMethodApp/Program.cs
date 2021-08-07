using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "anmolShah";
            Console.WriteLine(name.Foo());
            Console.WriteLine(name.SnakeCase());
            
        }
    }
}
