namespace TicTacToeKata
{
	public static class TicTacToeGameSetupExtensions
	{
		public static void APlayerWinsByTakingFirstRow(this TicTacToeGame game)
		{
			game.Play("X", 1);
			game.Play("O", 4);
			game.Play("X", 2);
			game.Play("O", 7);
			game.Play("X", 3);
		}

		public static void APlayerWinsByTakingSecondRow(this TicTacToeGame game)
		{
			game.Play("X", 4);
			game.Play("O", 1);
			game.Play("X", 5);
			game.Play("O", 8);
			game.Play("X", 6);
		}

		public static void APlayerWinsByTakingThirdRow(this TicTacToeGame game)
		{
			game.Play("X", 7);
			game.Play("O", 1);
			game.Play("X", 8);
			game.Play("O", 5);
			game.Play("X", 9);
		}

		public static void APlayerWinsByTakingFirstColumn(this TicTacToeGame game)
		{
			game.Play("X", 1);
			game.Play("O", 2);
			game.Play("X", 4);
			game.Play("O", 5);
			game.Play("X", 7);
		}

		public static void APlayerWinsByTakingSecondColumn(this TicTacToeGame game)
		{
			game.Play("X", 2);
			game.Play("O", 3);
			game.Play("X", 5);
			game.Play("O", 4);
			game.Play("X", 8);
		}

		public static void APlayerWinsByTakingThirdColumn(this TicTacToeGame game)
		{
			game.Play("X", 3);
			game.Play("O", 2);
			game.Play("X", 6);
			game.Play("O", 4);
			game.Play("X", 9);
		}

		public static void APlayerWinsByTakingDiagonalFieldsStartingFromFirstToNinthPosition(this TicTacToeGame game)
		{
			game.Play("X", 1);
			game.Play("O", 2);
			game.Play("X", 5);
			game.Play("O", 4);
			game.Play("X", 9);
		}

		public static void APlayerWinsByTakingDiagonalFieldsStartingFromThirdToSixthPosition(this TicTacToeGame game)
		{
			game.Play("X", 3);
			game.Play("O", 2);
			game.Play("X", 5);
			game.Play("O", 4);
			game.Play("X", 6);
		}

		public static void APlayerPlaysTwoTimesInARow(this TicTacToeGame game)
		{
			game.Play("X", 1);
			game.Play("X", 1);
			game.Play("X", 5);
			game.Play("O", 5);
			game.Play("X", 9);
		}

		public static void APlayerPlaysOnAlreadyTakenField(this TicTacToeGame game)
		{
			game.Play("X", 1);
			game.Play("O", 1);
			game.Play("X", 5);
			game.Play("O", 5);
			game.Play("X", 9);
		}

		public static void DrawGame(this TicTacToeGame game)
		{
			game.Play("X", 1);
			game.Play("O", 2);
			game.Play("X", 3);
			game.Play("O", 5);
			game.Play("X", 4);
			game.Play("O", 6);
			game.Play("X", 8);
			game.Play("O", 7);
			game.Play("X", 9);
		}
	}
}