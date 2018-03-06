using System;
using FluentAssertions;
using Xunit;

namespace TicTacToeKata
{
    public class TicTacToeTestShould
    {
        [Fact]
        public void ReturnGameOverIfAllFieldsInAFirstRowAreTakenByAPlayer()
        {
	        var game = new TicTacToeGame();
	        game.APlayerWinsByTakingFirstRow();

			var result = game.GetResult();

	        result.Should().Be("Game Over! Player 'X' wins");
        }

	    [Fact]
	    public void ReturnGameOverIfAllFieldsInASecondRowAreTakenByAPlayer()
	    {
			var game = new TicTacToeGame();
		    game.APlayerWinsByTakingSecondRow();

			var result = game.GetResult();

		    result.Should().Be("Game Over! Player 'X' wins");
		}

	    [Fact]
	    public void ReturnGameOverIfAllFieldsInALastRowAreTakenByAPlayer()
	    {
		    var game = new TicTacToeGame();
		    game.APlayerWinsByTakingThirdRow();

		    var result = game.GetResult();

		    result.Should().Be("Game Over! Player 'X' wins");
	    }

	    [Fact]
	    public void ReturnGameOverIfAllFieldsInAFirstColumnAreTakenByAPlayer()
	    {
		    var game = new TicTacToeGame();
		    game.APlayerWinsByTakingFirstColumn();

			var result = game.GetResult();

		    result.Should().Be("Game Over! Player 'X' wins");
	    }

	    [Fact]
	    public void ReturnGameOverIfAllFieldsInASecondColumnAreTakenByAPlayer()
	    {
		    var game = new TicTacToeGame();
		    game.APlayerWinsByTakingSecondColumn();

			var result = game.GetResult();

		    result.Should().Be("Game Over! Player 'X' wins");
	    }

	    [Fact]
	    public void ReturnGameOverIfAllFieldsInAThirdColumnAreTakenByAPlayer()
	    {
		    var game = new TicTacToeGame();
			game.APlayerWinsByTakingThirdColumn();

		    var result = game.GetResult();

		    result.Should().Be("Game Over! Player 'X' wins");
	    }

	    [Fact]
	    public void ReturnGameOverIfAllFieldsInADiagonalFieldsFromOneToNineAreTakenByAPlayer()
	    {
		    var game = new TicTacToeGame();
			game.APlayerWinsByTakingDiagonalFieldsStartingFromFirstToNinthPosition();

		    var result = game.GetResult();

		    result.Should().Be("Game Over! Player 'X' wins");
	    }

	    [Fact]
	    public void ReturnGameOverIfAllFieldsInADiagonalFieldsFromThreeToSixAreTakenByAPlayer()
	    {
		    var game = new TicTacToeGame();
		    game.APlayerWinsByTakingDiagonalFieldsStartingFromThirdToSixthPosition();

		    var result = game.GetResult();

		    result.Should().Be("Game Over! Player 'X' wins");
	    }

		[Fact]
	    public void ThrowExceptionIfPlayerPlaysTwoTimesInARow()
	    {
			var game = new TicTacToeGame();

		    Action action = () => game.APlayerPlaysTwoTimesInARow();

		    action.Should().Throw<InvalidOperationException>("Player 'X' cannot play two times in a row!");
	    }

	    [Fact]
	    public void ThrowExceptionIfPlayerTriesToPlayOnAlredyTakenPositionInGame()
	    {
			var game = new TicTacToeGame();

		    Action action = () => game.APlayerPlaysOnAlreadyTakenField();

		    action.Should().Throw<InvalidOperationException>("This field is already taken!");
		}

	    [Fact]
	    public void ReturnGameDrawResultIfThereIsNoWinnerAfterNinthMove()
	    {
			var game = new TicTacToeGame();
		    game.DrawGame();

		    var result = game.GetResult();

		    result.Should().Be("Game Draw!");
		}

	}
}
