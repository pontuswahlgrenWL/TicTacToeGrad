namespace TicTacToeGrad;

public class Board
{
    public char[,] board;
    public Board()
    {
        board = new char[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
    }
}

public class Player
{
    public string Name { get; }
    public char Mark { get; }

    public Player(string name, char mark)
    {
        Name = name;
        Mark = mark;
    }
}

public class Game
{
    public string Winner { get; }
    public Game(Board board, Player player1)
    {
        board.board[0,0] = 'X';
        board.board[0,1] = 'X';
        board.board[0,2] = 'X';
        if (WinConditions.CheckGameEnd(board))
        {
            Winner = player1.Name; 
        }
    } 
}

public class WinConditions
{
    public static bool CheckGameEnd(Board board)
    {
        return CheckWinnerHorizontally(board);
    }

    private static bool CheckWinnerHorizontally(Board board)
    {
        if (board.board[0, 0] == board.board[0, 1] && board.board[0, 1] == board.board[0, 2])
        {
            return true;
        }
        if (board.board[1, 0] == board.board[1, 1] && board.board[1, 1] == board.board[1, 2])
        {
            return true;
        }
        if (board.board[2, 0] == board.board[2, 1] && board.board[2, 1] == board.board[2, 2])
        {
            return true;
        }
        
        return false;
    }
}
