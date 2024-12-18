using FluentAssertions;
using TicTacToeGrad;

namespace Test;

public class UnitTest1
{
    [Fact(DisplayName="Creation of empty board should be of size 3x3 with empty cells")]
    public void CreateEmptyBoard_ShouldReturnEmptyBoard()
    {   
        // Act
        var board = TicTacToeGrad.Board.CreateBoard();

        // Assert
        Assert.Equal(3, board.GetLength(0));
        Assert.Equal(3, board.GetLength(1));
        foreach (var cell in board)
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
}