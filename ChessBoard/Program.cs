internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("What size should the chessboard be? (enter a number): ");
        // int num = int.Parse(Console.ReadLine());

        int boardSize = 8;
        char[,] board = new char[boardSize, boardSize];

        string[] initialBoardState = {"Ra1", "Nb1", "Bc1", "Qd1", "Ke1", "Bf1", "Ng1", "Rh1", "a2", "b2", "c2", "d2", "e2", "f2", "g2", "h2", "a7*", "b7*", "c7*", "d7*", "e7*", "f7*", "g7*", "h7*", "Ra8*", "Nb8*", "Bc8*", "Qd8*", "Ke8*", "Bf8*", "Ng8*", "Rh8*"};

        // Newline for readability.
        //Console.WriteLine("\n");

        CreateBoard(board, boardSize);
        PopulateBoard(board, boardSize, initialBoardState);
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
                    board[i, j] = '◼';
                }
                else
                {
                    board[i, j] = '◻';
                }
            }
        }
    }

    public static void PrintBoard(char[,] board, int boardSize)
    {
        string spacer = "  ";

        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                Console.Write(board[i, j] + spacer);
            }

            Console.Write("\n");
        }
    }

    public static char ParsePiece(string str)
    {
        int length = str.Length;
        char notation = str[0];
        char piece;

        switch (notation)
        {
            case 'R':
                if (str[length - 1] == '*')
                {
                    piece = '♜';
                }
                else
                {
                    piece = '♖';   
                }

                break;
            case 'N':
                if (str[length - 1] == '*')
                {
                    piece = '♞';
                }
                else
                {
                    piece = '♘';   
                }            

                break;
            case 'B':
                if (str[length - 1] == '*')
                {
                    piece = '♝';
                }
                else
                {
                    piece = '♗';   
                }    

                break;
            case 'Q':
                if (str[length - 1] == '*')
                {
                    piece = '♛';
                }
                else
                {
                    piece = '♕';   
                }   

                break;
            case 'K':
                if (str[length - 1] == '*')
                {
                    piece = '♚';
                }
                else
                {
                    piece = '♔';   
                }  

                break;
            default:
                if (str[length - 1] == '*')
                {
                    piece = '♟';
                }
                else
                {
                    piece = '♙';   
                }  

                break;
        }

        return piece;
    }

    public static (int, int) ParseSquare(string str)
    {
        int file, rank;

        int length = str.Length;
        int fileNotationPos, rankNotationPos;

        if (str[length - 1] == '*')
        {
            fileNotationPos = length - 3;
            rankNotationPos = length - 2;
        }
        else
        {
            fileNotationPos = length - 2;
            rankNotationPos = length - 1;
        }

        char fileNotation = str[fileNotationPos];
        char rankNotation = str[rankNotationPos];

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

        rank = 9 - (rankNotation - '0');

        return (rank, file);
    }

    public static void PopulateBoard(char[,] board, int boardSize, string[] boardState)
    {
        (int, int) square;
        char piece;

        foreach (string str in boardState)
        {
            square = ParseSquare(str);
            piece = ParsePiece(str);

            board[square.Item1 - 1, square.Item2] = piece;
        }
    }
}