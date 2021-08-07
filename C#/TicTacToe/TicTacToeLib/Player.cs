using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
    public class Player
    {
		private String _pName;
		private Mark _pMark;

		public Player(String pName, Mark pMark)
		{
			_pName = pName;
			_pMark = pMark;
		}

		public String GetName()
		{
			return _pName;
		}

		public Mark GetMark()
		{
			return _pMark;
		}

	}
}
