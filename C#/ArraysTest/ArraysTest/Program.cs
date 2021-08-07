using System;

namespace ArraysTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            int[] myNum = { 10, 20, 30, 40 };
    
            for(int i=0;i<myNum.Length;i++)
            {
                Console.WriteLine(myNum[i]);
            }

        }
    }
}
