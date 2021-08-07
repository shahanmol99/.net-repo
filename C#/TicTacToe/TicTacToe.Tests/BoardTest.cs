using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;
using System.Collections.Generic;
using System;
using System.Linq;

namespace TicTacToe.Tests
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void TestForMarkingXOnBoardAtIndex5()
        {
            Mark expectedMark = Mark.X;

            Board board = new Board(3);
            board.SetMarkOnCell(5, Mark.X);

            Mark actualMark = board.GetCells().ElementAt(5).GetMark();

            Assert.AreEqual(expectedMark, actualMark);
        }

        [TestMethod]
        public void TestForMarkingOOnBoardAtIndex2()
        {
            Mark expectedMark = Mark.O;

            Board board = new Board(3);
            board.SetMarkOnCell(2, Mark.O);

            Mark actualMark = board.GetCells().ElementAt(2).GetMark();

            Assert.AreEqual(expectedMark, actualMark);
        }

        [TestMethod]
        public void TestIsBoardFullFalse()
        {
            bool expectedIsBoardFull = false;

            Board board = new Board(3);
            bool actualIsBoardFull = board.IsBoardFull();

            Assert.AreEqual(expectedIsBoardFull, actualIsBoardFull);
        }


        [TestMethod]
        public void TestIsBoardFullTrue()
        {
            bool expectedIsBoardFull = true;

            Board board = new Board(3);
            for(int i=0;i<3*3;i++)
            {
                if(i%2==0)
                {
                    board.SetMarkOnCell(i, Mark.O);
                    continue;
                }
                board.SetMarkOnCell(i, Mark.X);
            }

            bool actualIsBoardFull = board.IsBoardFull();

            Assert.AreEqual(expectedIsBoardFull, actualIsBoardFull);
        }

    }
}
