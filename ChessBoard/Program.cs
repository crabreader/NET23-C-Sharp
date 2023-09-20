internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("What size should the chessboard be? (enter a number): ");
        // int num = int.Parse(Console.ReadLine());

        int boardSize = 8;
        char[,] board = new char[boardSize, boardSize];

        string[] initialBoardState = {"Ra1", "Nb1", "Bc1", "Qd1", "Ke1", "Bf1", "Ng1", "Rh1"};

        // Override the default newline behaviour.
        Console.Out.NewLine = "";

        // Newline for readability.
        //Console.WriteLine("\n");

        CreateBoard(board, boardSize);
        PrintBoard(board, boardSize);
        PopulateBoard(board, boardSize, initialBoardState);

        Console.WriteLine("\n");

        PrintBoard(board, boardSize);
    }

    public static void CreateBoard(char[,] board, int boardSize)
    {
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    board[i, j] = '\u25FC';
                }
                else
                {
                    board[i, j] = '\u25FB';
                }
            }
        }
    }

    public static void PrintBoard(char[,] board, int boardSize)
    {
        string spacer = " ";

        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                Console.WriteLine(board[i, j] + spacer);
            }

            Console.WriteLine("\n");
        }
    }

    public static char ParsePiece(string str)
    {
        char notation = str[0];
        char piece;

        switch (notation)
        {
            case 'R':
                piece = '♖';
                break;
            case 'N':
                piece = '♘';
                break;
            case 'B':
                piece = '♗';
                break;
            case 'Q':
                piece = '♕';
                break;
            case 'K':
                piece = '♔';
                break;
            default:
                piece = '♙';
                break;
        }

        return piece;
    }

    public static (int, int) ParseSquare(string str)
    {
        char fileNotation = str[1];
        char rankNotation = str[2];
        int file;
        int rank;

        switch (fileNotation)
        {
            case 'a':
                file = 0;
                break;
            case 'b':
                file = 1;
                break;
            case 'c':
                file = 2;
                break;
            case 'd':
                file = 3;
                break;
            case 'e':
                file = 4;
                break;
            case 'f':
                file = 5;
                break;
            case 'g':
                file = 6;
                break;
            case 'h':
                file = 7;
                break;
            default:
                file = -1;
                break;
        }

        rank = rankNotation - '0';

        return (file, rank);
    }

    public static void PopulateBoard(char[,] board, int boardSize, string[] boardState)
    {
        (int, int) square;
        char piece;

        foreach (string str in boardState)
        {
            square = ParseSquare(str);
            piece = ParsePiece(str);

            board[square.Item1, square.Item2 - 1] = piece;
        }
    }
}