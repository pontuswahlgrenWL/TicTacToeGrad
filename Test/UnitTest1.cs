using System.Security.Policy;
using FluentAssertions;
using TicTacToeGrad;

namespace Test;

public class UnitTest1
{
    [Fact(DisplayName="Creation of empty board should be of size 3x3 with empty cells")]
    public void CreateEmptyBoard_ShouldReturnEmptyBoard()
    {   
        // Act
        var board = new Board();

        // Assert
        Assert.Equal(3, board.board.GetLength(0));
        Assert.Equal(3, board.board.GetLength(1));
        foreach (var cell in board.board)
        {
            Assert.Equal(' ', cell);
        }
    }
    
    [Fact(DisplayName="Creation of players should return one player with marker X and one player with marker O")]
    public void CreatePlayers_ShouldReturnOnePlayerXAndOnePlayerO()
    {   
        // Arrange
        var player1 = new Player("Player 1", 'X');
        var player2 = new Player("Player 2", 'O');

        // Assert
        Assert.Equal('X', player1.Mark);
        Assert.Equal('O', player2.Mark);
    }
    
    [Fact(DisplayName="Player X should win with three equal markers horizontally")]
    public void PlayerX_ShouldWinWithThreeEqualMarkersHorizontally()
    {   
        // Arrange
        var board = new Board();
        var player1 = new Player("Player 1", 'X');
        
        // Act
        var result = new Game(board, player1);

        // Assert
        Assert.Equal(player1.Name, result.Winner);
    }
}