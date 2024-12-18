using FluentAssertions;

namespace Test;

public class UnitTest1
{
    [Fact]
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
}