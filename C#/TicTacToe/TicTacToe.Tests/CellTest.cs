using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeLib;

namespace TicTacToe.Tests
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void TestForMarkIsX()
        {
            Mark expectedMark = Mark.X;
            Cell c1 = new Cell();

            c1.SetMark(Mark.X);
            Mark actualMark = c1.GetMark();

            Assert.AreEqual(expectedMark, actualMark);
        }

        [TestMethod]
        public void TestForMarkIsO()
        {
            Mark expectedMark = Mark.O;
            Cell c1 = new Cell();

            c1.SetMark(Mark.O);
            Mark actualMark = c1.GetMark();

            Assert.AreEqual(expectedMark, actualMark);
        }

        [TestMethod]
        public void TestForMarkIsEmpty()
        {
            Mark expectedMark = Mark.EMPTY;
            Cell c1 = new Cell();

            Mark actualMark = c1.GetMark();

            Assert.AreEqual(expectedMark, actualMark);
        }


    }
}
