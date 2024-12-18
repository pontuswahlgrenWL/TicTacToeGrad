namespace TicTacToeGrad;

public class Board
{
    public static char[,] CreateBoard()
    {
        var board = new char[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
        
        return board;
    }
}

public class Player
{
    public string Name { get;}
    public char Mark { get;}

    public Player(string name, char mark)
    {
        Name = name;
        Mark = mark;
    }
}

public class Game
{
    public string Winner { get;}
    public Game()
    {
        throw new NotImplementedException();
    } 
}
