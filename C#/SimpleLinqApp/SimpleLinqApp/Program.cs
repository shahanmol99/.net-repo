using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach(string s in args)
            //{
            //    Console.WriteLine(s);
            //}
            Console.WriteLine("-----Using Func-------");
            DisplayTop3NamesFunc(args);
            Console.WriteLine("-----Using Query-------");
            DisplayTop3NamesQuery(args);
        }

        private static void DisplayTop3NamesQuery(string[] names)
        {
            var longNames = (from n in names
                            where n.Length > 5
                            select n).Take(3);

            foreach(string s in longNames)
            {
                Console.WriteLine(s);
            }
        }

        private static void DisplayTop3NamesFunc(string[] args)
        {
            IEnumerable<string> names = args;

            var longNames = names.Where(n => n.Length > 5);
            var top3_longNames = longNames.Take(3);
            var top3_longNamesAsec = top3_longNames.OrderBy(n => names);
            String[] top3_namesArr = top3_longNames.ToArray();

            //doNothing(top3_longNames, top3_namesArr);

            foreach (string s in top3_longNamesAsec)
            {
                Console.WriteLine(s);
            }

            var asecNames = names.OrderBy(s => s);
            var containsVowel = names.Where(s => ContainsVowel(s));
            var first4Letters = names.Select(s => s.Substring(0, 4));


            Console.WriteLine("----Order By Names------");
            foreach (string s in asecNames)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----Contains Vowel------");
            foreach (string s in containsVowel)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----Selection First Four Letters------");
            foreach (string s in first4Letters)
            {
                Console.WriteLine(s);
            }

        }

        public static bool ContainsVowel(string word)
        {
            char[] vowels = new[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            foreach (char vowel in vowels)
            {
                if (word.Contains(vowel))
                {
                    return true;
                }
            }
            return false;
        }

        private static void doNothing(IEnumerable<string> top3_longNames, string[] top3_namesArr)
        {
            Console.WriteLine(top3_longNames);
            Console.WriteLine(top3_namesArr);
        }
    }
}
