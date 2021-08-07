using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
    public class Cell
    {
		private Mark _mark;

		public Cell()
		{
			_mark = Mark.EMPTY;
		}

		public void SetMark(Mark mark1) 
		{
		if(_mark.Equals(Mark.EMPTY)) {
			_mark = mark1;
		}
		else
			throw new Exception("This cell is already marked");
		}

		public Mark GetMark()
		{
			return _mark;
		}

	}
}
