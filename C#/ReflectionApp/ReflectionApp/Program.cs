using System;
using System.Reflection;
using ReflectionApp.Model;

namespace ReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoReflections(typeof(Account));
        }
        private static void DoReflections(Type className)
        {
            Console.WriteLine(className.Name);
            MethodInfo[] methods = className.GetMethods();
            Console.WriteLine("No of Methods: " + methods.Length);
            int gettersCount, settersCount;
            gettersCount = 0;
            settersCount = 0;
            foreach(MemberInfo method in methods)
            {
                Console.WriteLine(method.Name);

                if(method.Name.StartsWith("get"))
                {
                    gettersCount = gettersCount + 1;
                }
                if (method.Name.StartsWith("set"))
                {
                    settersCount = settersCount + 1;
                }
            }
            Console.WriteLine("No of Get Methods: " + gettersCount);
            Console.WriteLine("No of Set Methods: " + settersCount);

        }
    }
}
