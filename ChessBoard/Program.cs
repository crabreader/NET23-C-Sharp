// Alexander Doja
// NET23

internal class Program
{
    private static void Main(string[] args)
    {
        int boardSizeDefault = 8;
        string[] boardStateDefault = {"Ra1", "Nb1", "Bc1", "Qd1", "Ke1", "Bf1", "Ng1", "Rh1", "a2", "b2", "c2", "d2", "e2", "f2", "g2", "h2", "a7*", "b7*", "c7*", "d7*", "e7*", "f7*", "g7*", "h7*", "Ra8*", "Nb8*", "Bc8*", "Qd8*", "Ke8*", "Bf8*", "Ng8*", "Rh8*"};
        char[,] board; // The chess board is a 2d array of characters.


        bool exit = false;
        int userChoice;

        while (!exit)
        {
            PrintMenu();
            userChoice = GetUserChoice();

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Enter board size (leave blank for default): ");
                    int boardSize = GetUserChoice();

                    if (boardSize == 0)
                    {
                        boardSize = boardSizeDefault;
                    }

                    board = new char[boardSize, boardSize]; 

                    CreateBoard(board, boardSize);
                    PrintBoard(board, boardSize);

                    break;
                case 2:
                    Console.WriteLine("Enter board state in algebraic notation as a comma separated list, use '*' for black pieces like in 'a1*' (leave blank for default): ");
                    string? userInput = Console.ReadLine();

                    string[] boardState;

                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        boardState = boardStateDefault;
                    }
                    else
                    {
                        boardState = GetBoardState(userInput);
                    }

                    board = new char[boardSizeDefault, boardSizeDefault]; 

                    CreateBoard(board, boardSizeDefault);
                    PopulateBoard(board, boardState);
                    PrintBoard(board, boardSizeDefault);

                    break;
                case 3:
                    Console.WriteLine("\nGoodbye!");
                    exit = true; // This will exit the loop.

                    break;
                default:
                    break; // If no valid choice was entered, break and re-enter the loop.
            }
        }
    }

    public static void PrintMenu()
    {
        Console.WriteLine("\nChessBoard menu: \n");
        Console.WriteLine("1. Print board.");
        Console.WriteLine("2. Print board with pieces.");
        Console.WriteLine("3. Exit.");
    }

    public static int GetUserChoice()
    {
        int parsedInput;
        bool success = int.TryParse(Console.ReadLine(), out parsedInput);

        return parsedInput;
    }

    public static void CreateBoard(char[,] board, int boardSize)
    {
        for (int i = 0; i < boardSize; i++) // Loops over rows.
        {
            for (int j = 0; j < boardSize; j++) // Loops over columns.
            {
                if ((i + j) % 2 == 0) // Switch between black and white squares while keeping previous rows in mind.
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
        string spacer = "  "; // A spacer to make the output look nicer.

        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                Console.Write(board[i, j] + spacer);
            }

            Console.Write("\n");
        }
    }

    public static void PopulateBoard(char[,] board, string[] boardState)
    {
        (int, int) square;
        char piece;

        foreach (string str in boardState)
        {
            // Check that the string is not shorter than the minimum length.
            if (str.Length < 2)
            {
                Console.WriteLine($"Invalid notation: {str}");
            }
            else
            {
                square = ParseSquare(str);
                piece = ParsePiece(str);

                try
                {
                    board[square.Item1 - 1, square.Item2] = piece;
                }
                catch (System.Exception)
                {
                    Console.WriteLine($"Invalid notation: {str}");
                }                
            }

        }
    }

    public static string[] GetBoardState(string pieceList)
    {
        string[] boardState = pieceList.Split(',');

        return boardState;
    }

    public static char ParsePiece(string str)
    {
        int length = str.Length;
        char notation = str[0]; // The piece will always be decided based on the first character.
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
            // If no character matched the piece is considererd a pawn.
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
        int file, rank, fileNotationPos, rankNotationPos;
        int length = str.Length;

        // Deal with varying string length
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

        // Count ranks from the bottom of the board
        rank = 9 - (rankNotation - '0');

        return (rank, file);
    }
}