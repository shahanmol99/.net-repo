using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAnnotationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoReflection(typeof(RandomClass));
        }

        private static void DoReflection(Type className)
        {
            MethodInfo[] methods = className.GetMethods();

            Console.WriteLine("Annotated Methods Are: ");
            foreach(MethodInfo method in methods)
            {
                if (Attribute.IsDefined(method, typeof(NeedToRefactor))) 
                {
        		    Console.WriteLine(method);
                }
            }
        }
    }
}
