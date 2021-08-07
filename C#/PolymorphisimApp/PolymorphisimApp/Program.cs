using System;
using PolymorphisimApp.Model;
namespace PolymorphisimApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man x = new Boy();
            x.Eat();
            x.Read();
        }
    }
}
