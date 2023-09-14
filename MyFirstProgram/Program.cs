// Alexander Doja
// NET23

namespace MyFirstProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num = 39;

            // Check if the number is above 10.
            if (num > 10)
            {
                Console.WriteLine("Talet är stort!\n");
            } else
            {
                // If the number is not above 10 this code is executed.
                Console.WriteLine("Oj. Lågt tal!\n");  
            }

            // Ask the user for input.
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();

            // The string entered by the user is printed to console.
            Console.WriteLine($"Hej {name}!\n");
            
            // Print every number from 0 up to the number num.
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}