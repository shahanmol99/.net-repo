using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
    public class ResultAnalyzer
    {
		private Board _board;
		private int _size;

		public ResultAnalyzer(Board board)
		{
			_board = board;
			_size = board.GetSize();
		}

		private Result checkRow()
		{
			int markO;
			int row = 0;

			while (row < _size)
			{
				markO = 0;

				for (int i = 0; i < _size; i++)
				{
					if (_board.GetCells().ElementAt(_size * row + i).GetMark().Equals(Mark.O))
					{
						markO++;
					}
					else if (_board.GetCells().ElementAt(_size * row + i).GetMark().Equals(Mark.X))
					{
						markO--;
					}
				}

				row++;
				if (Math.Abs(markO) == _size)
				{
					return Result.WIN;
				}
			}

			return Result.PROCESS;
		}

		private Result checkColumn()
		{
			int markO;
			int column = 0;

			while (column < _size)
			{
				markO = 0;

				for (int i = 0; i < _size; i++)
				{
					if (_board.GetCells().ElementAt(i * _size + column).GetMark().Equals(Mark.O))
					{
						markO++;
					}
					else if (_board.GetCells().ElementAt(i * _size + column).GetMark().Equals(Mark.X))
					{
						markO--;
					}
				}

				column++;

				if (Math.Abs(markO) == _size)
				{
					return Result.WIN;
				}
			}

			return Result.PROCESS;
		}

		private Result checkLeftDiagonal()
		{
			int markO = 0;

			for (int i = 0; i < _size; i++)
			{
				if (_board.GetCells().ElementAt((i * (_size + 1))).GetMark().Equals(Mark.O))
				{
					markO++;
				}
				else if (_board.GetCells().ElementAt((i * (_size + 1))).GetMark().Equals(Mark.X))
				{
					markO--;
				}
			}

			if (Math.Abs(markO) == _size)
			{
				return Result.WIN;
			}

			return Result.PROCESS;

		}

		private Result checkRightDiagonal()
		{
			int markO = 0;

			for (int i = 0; i < _size; i++)
			{
				if (_board.GetCells().ElementAt(((i + 1) * (_size - 1))).GetMark().Equals(Mark.O))
				{
					markO++;
				}
				else if (_board.GetCells().ElementAt(((i + 1) * (_size - 1))).GetMark().Equals(Mark.X))
				{
					markO--;
				}
			}

			if (Math.Abs(markO) == _size)
			{
				return Result.WIN;
			}

			return Result.PROCESS;

		}

		private Result checkDraw()
		{

			if (_board.IsBoardFull())
			{
				return Result.DRAW;
			}

			return Result.PROCESS;

		}

		public Result analyseResult()
		{

			if (this.checkRow().Equals(Result.WIN))
			{
				return this.checkRow();
			}

			if (this.checkColumn().Equals(Result.WIN))
			{
				return this.checkColumn();
			}

			if (this.checkLeftDiagonal().Equals(Result.WIN))
			{
				return this.checkLeftDiagonal();
			}

			if (this.checkRightDiagonal().Equals(Result.WIN))
			{
				return this.checkRightDiagonal();
			}

			if (this.checkDraw().Equals(Result.DRAW))
			{
				return this.checkDraw();
			}

			return Result.PROCESS;

		}
	}
}
