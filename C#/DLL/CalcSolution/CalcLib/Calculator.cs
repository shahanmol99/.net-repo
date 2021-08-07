using System;
using System.Collections.Generic;
using System.Text;

namespace CalcLib
{
    public delegate void ResultObtained(int result);
    public class Calculator
    {
        public event ResultObtained AddCompletion;

        public void Add(int x, int y)
        {
            int result = x + y;

            if (AddCompletion != null)
            {
                AddCompletion(result);
            }
        }

        public bool CheckEven(int no)
        {
            if(no%2==0)
            {
                return true;
            }
            return false;
        }

    }
}
