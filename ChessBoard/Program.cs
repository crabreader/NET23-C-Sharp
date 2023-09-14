Console.WriteLine("What size should the chessboard be? (enter a number): ");
int num =  Int32.Parse(Console.ReadLine());

// Override the default newline behaviour.
Console.Out.NewLine = "";

// Newline for readability.
Console.WriteLine("\n");

for (int i = 0; i < num; i++)
{
    for (int j = 0; j < num; j++)
    {
        if ((i + j) % 2 == 0)
        {
            Console.WriteLine("◼︎ ");
        }
        else
        {
            Console.WriteLine("◻︎ ");
        }
    }

    Console.WriteLine("\n");
}