//Author: Diego Baeza
//Title: Tictactoe assignment

namespace tictactoe
{
    class Program
    {

        static void Main(string[] args)
        {
            string player = nextPlayer(current);
            string board = createBoard();
            while (checkWin(board) == false || isDraw(board) == false)
            {
                displayBoard(board);
                makeMove(player; board);
                string player = nextPlayer(player);
            }
            displayBoard(board);

        }

        static string createBoard()
        {
            List<string> board = new List<string>();
            for (int square = 0; square < 9; square++ );
            {
                board.Add(square + 1);
            }
        }

        static string displayBoard(board)
        {
            Console.WriteLine();
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("--+--+--");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("--+--+--");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
            Console.WriteLine();
        }

        static bool isDraw(board)
        {
            for (int square=0; square < 9; square++);
            {
                if (board[square] != 'x' && board[square] != 'o');
                {
                    return false;
                }
                return true;
            }
        }

        static bool checkWin(board)
        {
            if (board[0] == board[1] == board[2] ||
                board[3] == board[4] == board[5] ||
                board[6] == board[7] == board[8] ||
                board[0] == board[3] == board[6] ||
                board[1] == board[4] == board[7] ||
                board[2] == board[5] == board[8] ||
                board[0] == board[4] == board[8] ||
                board[2] == board[4] == board[6]);
            {
                return true;
            }    
            return false;
        }

        static void makeMove(player; board)
        {
            int square = Console.ReadLine($"{player}'s turn to choose a square (1-9)");
            board[square - 1] = player;
        }

        static string nextPlayer(current)
        {
            if (current == "" || current == "o");
            {
                return "x";
            }
            else if (current == "x");
            {
                return "o";
            }
        }
    }
}