using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
	public class Game
	{
		private Board _board;
		private List<Player> _players;
		private bool _isPlayer1Turn;
		private Result _gameStatus;

		public Game(Board board)
		{
			_board = board;
			_players = new List<Player>();
			_isPlayer1Turn = true;
			_gameStatus = Result.PROCESS;
		}
		public void AddPlayers(Player player)
		{
			this._players.Add(player);
		}

		public void Play(int index)
		{

			Player currentPlayer = this.GetCurrentPlayer();
			ResultAnalyzer checkResult = new ResultAnalyzer(_board);

			_board.SetMarkOnCell(index, currentPlayer.GetMark());

			this.SetGameStatus(checkResult.analyseResult());

			this.SetPlayer1Turn();
		}

		private void SetGameStatus(Result gameStatus)
		{
			_gameStatus = gameStatus;
		}

		private void SetPlayer1Turn()
		{
			if (_isPlayer1Turn)
			{
				_isPlayer1Turn = false;
				return;
			}
			_isPlayer1Turn = true;
		}

		public Board getBoard()
		{
			return _board;
		}

		public Player GetCurrentPlayer()
		{
			if (_isPlayer1Turn)
			{
				return _players.ElementAt(0);
			}
			return _players.ElementAt(1);
		}

		public Result GetGameStatus()
		{
			return _gameStatus;
		}

		public Player GetNextPlayer()
		{
			if (_isPlayer1Turn)
			{
				return _players.ElementAt(1);
			}
			return _players.ElementAt(0);
		}

        public object getCurrentPlayer()
        {
            throw new NotImplementedException();
        }
    }
}


