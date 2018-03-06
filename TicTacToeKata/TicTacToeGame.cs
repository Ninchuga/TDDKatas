using System;

namespace TicTacToeKata
{
	public class TicTacToeGame
	{
		private const int MinNumberOfMovesToWin = 5;
		private int _numberOfMoves;
		private string _result;
		private string _previousPlayerThatPlayed = string.Empty;
		private readonly string[] _gameFields = new string[10]; // ignoring zero based position
		
		public void Play(string player, int position)
		{
			if(_previousPlayerThatPlayed.Equals(player))
				throw new InvalidOperationException($"Player '{player}' cannot play two times in a row!");
			if(_gameFields[position] != null)
				throw new InvalidOperationException("This field is already taken!");

			if(_result != null)
				return;

			_numberOfMoves++;
			_previousPlayerThatPlayed = player;
			_gameFields[position] = player;

			if (_numberOfMoves >= MinNumberOfMovesToWin)
				_result = GetResult();
		}

		public string GetResult()
		{
			var rowWinner = CheckRowsForWinner();
			if (rowWinner != null)
				return rowWinner;

			var columnWinner = CheckColumnsForWinner();
			if (columnWinner != null)
				return columnWinner;

			var diagonalWinner = CheckDiagonalFieldsForWinner();
			if (diagonalWinner == null && _numberOfMoves == 9)
				return "Game Draw!";

			return diagonalWinner;
		}

		private string CheckRowsForWinner()
		{
			var firstRowValues = _gameFields[1] + _gameFields[2] + _gameFields[3];
			var secondRowValues = _gameFields[4] + _gameFields[5] + _gameFields[6];
			var thirdRowValues = _gameFields[7] + _gameFields[8] + _gameFields[9];

			if (firstRowValues == "XXX" || firstRowValues == "OOO")
				return $"Game Over! Player '{_gameFields[1]}' wins";
			if (secondRowValues == "XXX" || secondRowValues == "OOO")
				return $"Game Over! Player '{_gameFields[4]}' wins";
			if (thirdRowValues == "XXX" || thirdRowValues == "OOO")
				return $"Game Over! Player '{_gameFields[7]}' wins";

			return null;
		}

		private string CheckColumnsForWinner()
		{
			var firstColumnValues = _gameFields[1] + _gameFields[4] + _gameFields[7];
			var secondColumnValues = _gameFields[2] + _gameFields[5] + _gameFields[8];
			var thirdColumnValues = _gameFields[3] + _gameFields[6] + _gameFields[9];

			if (firstColumnValues == "XXX" || firstColumnValues == "OOO")
				return $"Game Over! Player '{_gameFields[1]}' wins";
			if (secondColumnValues == "XXX" || secondColumnValues == "OOO")
				return $"Game Over! Player '{_gameFields[2]}' wins";
			if (thirdColumnValues == "XXX" || thirdColumnValues == "OOO")
				return $"Game Over! Player '{_gameFields[3]}' wins";

			return null;
		}

		private string CheckDiagonalFieldsForWinner()
		{
			var diagonalFirstCombination = _gameFields[1] + _gameFields[5] + _gameFields[9];
			var diagonalSecondCombination = _gameFields[3] + _gameFields[5] + _gameFields[6];

			if (diagonalFirstCombination == "XXX" || diagonalFirstCombination == "OOO")
				return $"Game Over! Player '{_gameFields[1]}' wins";
			if (diagonalSecondCombination == "XXX" || diagonalSecondCombination == "OOO")
				return $"Game Over! Player '{_gameFields[3]}' wins";

			return null;
		}
	}
}