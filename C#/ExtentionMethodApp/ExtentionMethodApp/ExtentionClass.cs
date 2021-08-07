using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethodApp
{
    static class ExtentionClass
    {
        public static String Foo(this String s)
        {
            return ("Writing From Foo \n" + "Hello " + s);
        }

        public static String SnakeCase(this String s)
        {
            StringBuilder sb = new StringBuilder();

            for(int i=0;i<s.Length;i++)
            {
                char c = s[i];
                if(char.IsUpper(c))
                {
                    sb.Append("_");
                    sb.Append(char.ToLower(c));
                    continue;
                }
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
