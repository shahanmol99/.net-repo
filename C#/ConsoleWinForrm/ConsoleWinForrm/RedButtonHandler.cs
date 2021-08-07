using System;

namespace ConsoleWinForrm
{
    internal class RedButtonHandler
    {
        public RedButtonHandler()
        {
        }

        public static void ChangeColor(object sender, EventArgs e)
        {
            Console.WriteLine(e);
        }
    }
}