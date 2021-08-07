using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
   public class Board
    {
		private List<Cell> _cells = new List<Cell>();
		private int _size;

		public Board(int size)
		{
			_size = size;
			for (int i = 0; i < _size * _size; i++)
				_cells.Add(new Cell());
		}

		public void SetMarkOnCell(int index, Mark mark) 
		{
			_cells.ElementAt(index).SetMark(mark);
		}

		public bool IsBoardFull()
		{
			foreach(Cell cell in _cells)
			{
				if (cell.GetMark().Equals(Mark.EMPTY))
					return false;
			}
			return true;
		}

		public List<Cell> GetCells()
		{
			return _cells;
		}

		public int GetSize()
		{
			return _size;
		}

	}
}
