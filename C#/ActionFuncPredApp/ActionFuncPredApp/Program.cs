using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFuncPredApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Using Predicate------------");

            Predicate<String> checkName = isBigName;
            Console.WriteLine(checkName("Anmol Shah"));

            Predicate<int> isEvenNumber = delegate (int no) { return no % 2 == 0; };
            Console.WriteLine(isEvenNumber(44));

            Predicate<int> isPrimeNumber = (no) =>
                                                    {
                                                        for (int i = 2; i < no / 2; i++)
                                                        {
                                                            if (no % i == 0)
                                                            {
                                                                return false;
                                                            }
                                                        }
                                                        return true;
                                                    };

            Console.WriteLine(isPrimeNumber(17));

            Console.WriteLine("------------Using Func------------");
            Func<int, long, double> Add = addNumbers;
            Console.WriteLine(Add(2, 50000));

            Func<string, string> GetLowercase = delegate (string s) { return s.ToLower(); };
            Console.WriteLine(GetLowercase("ANMOL"));

            Func<int, int> FindSquare = (no) => { return no * no; };
            Console.WriteLine(FindSquare(17));


            Console.WriteLine("------------Using Action------------");
            Action<string> SayHello = PrintHello;
            SayHello("Anmol");

            Action<string> SayBye = delegate (string name) { Console.WriteLine("GoodBye " + name); };
            SayBye("Anmol");

            Action DoNothing = () => { Console.WriteLine("Does Nothing"); };
            DoNothing();
        }

        private static void PrintHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        private static double addNumbers(int no1, long no2)
        {
            return Convert.ToDouble(no1 + no2);
        }

        private static bool isBigName(string name)
        {
            return name.Length >= 8;
        }
    }
}
