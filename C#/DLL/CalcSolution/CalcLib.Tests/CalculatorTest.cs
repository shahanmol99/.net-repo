using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CalcLib.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CheckingNo2isEven()
        {
            Calculator cal = new Calculator();
            //Arrange
            bool expected = false;
            int inputValue = 2;

            bool actualValue = cal.CheckEven(inputValue);

            Assert.AreEqual(expected, actualValue);
        }
    }
}
