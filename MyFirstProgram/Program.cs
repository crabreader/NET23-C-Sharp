// Alexander Doja
// NET23

namespace MyFirstProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num = 39;

            if (num > 10)
            {
                Console.WriteLine("Talet är stort!\n");
            } else
            {
                Console.WriteLine("Oj. Lågt tal!\n");  
            }

            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hej {name}!\n");
            
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}