Console.WriteLine("Enter a number: ");
int num =  Int32.Parse(Console.ReadLine());

// Override default newline behaviour.
Console.Out.NewLine = "";

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