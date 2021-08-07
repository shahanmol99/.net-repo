using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeLib;
using System;

namespace TicTacToe.Tests
{
    [TestClass]
    public class ResultAnalyzerTest
    {
        [TestMethod]
        public void CheckFirstRowForXWin()
        {
            Result expectedResult = Result.WIN;
            Board board = new Board(3);

            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            for(int i=0;i<3;i++)
            {
                board.SetMarkOnCell(i, Mark.X);
            }

            Result actualResult = resultAnalyzer.analyseResult();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckSecondRowForOWin()
        {
            Result expectedResult = Result.WIN;
            Board board = new Board(3);

            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            for (int i = 3; i < 6; i++)
            {
                board.SetMarkOnCell(i, Mark.O);
            }

            Result actualResult = resultAnalyzer.analyseResult();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckFirstColumnForOWin()
        {
            Result expectedResult = Result.WIN;
            Board board = new Board(3);

            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            for (int i = 0; i < 9; i=i+3)
            {
                board.SetMarkOnCell(i, Mark.X);
            }

            Result actualResult = resultAnalyzer.analyseResult();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckSecondColumnForXWin()
        {
            Result expectedResult = Result.WIN;
            Board board = new Board(3);

            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            for (int i = 1; i < 9; i=i+3)
            {
                board.SetMarkOnCell(i, Mark.X);
            }

            Result actualResult = resultAnalyzer.analyseResult();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckLeftDiagonalForXWin()
        {
            Result expectedResult = Result.WIN;
            Board board = new Board(3);

            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            for (int i = 0; i < 9; i=i+(board.GetSize()+1))
            {
                board.SetMarkOnCell(i, Mark.X);
            }

            Result actualResult = resultAnalyzer.analyseResult();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckRightDiagonalForOWin()
        {
            Result expectedResult = Result.WIN;
            Board board = new Board(3);

            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            for (int i = board.GetSize()-1; i < 9; i=i+board.GetSize()-1)
            {
                board.SetMarkOnCell(i, Mark.O);
            }

            Result actualResult = resultAnalyzer.analyseResult();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckForDraw()
        {
            Result expectedResult = Result.DRAW;
            Board board = new Board(3);

            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            for (int i = 0; i < 6; i++)
            {
                if(i%2==0)
                {
                    board.SetMarkOnCell(i, Mark.O);
                    continue;
                }
                board.SetMarkOnCell(i, Mark.X);
            }
            board.SetMarkOnCell(6, Mark.X);
            board.SetMarkOnCell(8, Mark.X);
            board.SetMarkOnCell(7, Mark.O);


            Result actualResult = resultAnalyzer.analyseResult();

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
