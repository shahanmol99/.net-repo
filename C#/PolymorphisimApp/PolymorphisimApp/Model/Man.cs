using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphisimApp.Model
{
    abstract class Man
    {
        public virtual void Eat()
        {
            Console.WriteLine("Man is Eating");
        }

        public void Read()
        {
            Console.WriteLine("Man is Reading");
        }
    }
}
