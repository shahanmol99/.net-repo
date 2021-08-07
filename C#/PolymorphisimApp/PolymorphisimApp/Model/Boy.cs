using System;

namespace PolymorphisimApp.Model
{
    class Boy : Man
    {
        public override void Eat()
        {
            Console.WriteLine("Boy is Eating");
        }
        public void Play()
        {
            Console.WriteLine("Boy is Playing");
        }
    }
}
