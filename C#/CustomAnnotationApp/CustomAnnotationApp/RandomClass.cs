using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAnnotationApp
{
    class RandomClass
    {
        [NeedToRefactor]
        public void RandomMethod1()
        {
            Console.WriteLine("This is RandomMethod1");
        }

        [NeedToRefactor]
        public void RandomMethod2()
        {
            Console.WriteLine("This is RandomMethod2");
        }

        public void RandomMethod3()
        {
            Console.WriteLine("This is RandomMethod3");
        }


    }
}
