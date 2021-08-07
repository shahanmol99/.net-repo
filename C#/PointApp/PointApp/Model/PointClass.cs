using System;
using System.Collections.Generic;
using System.Text;

namespace PointApp.Model
{
    class PointClass
    {
        private int _x, _y;
        public PointClass(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public void UpdatePoint(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public void PrintDetails()
        {
            Console.WriteLine(_x + " " + _y);
        }

    }
}
