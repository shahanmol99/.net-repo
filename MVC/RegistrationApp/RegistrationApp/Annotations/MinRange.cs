using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationApp.Annotations
{
    public class MinRange : ValidationAttribute
    {
        private double minVal;

        public MinRange(double minVal)
        {
            this.minVal = minVal;
        }

        public MinRange(int minVal)
        {
            this.minVal = Convert.ToDouble(minVal);
        }

        public override bool IsValid(object value)
        {
            double inputValue = Convert.ToDouble(value);
            return inputValue >= minVal;
        }
    }
}