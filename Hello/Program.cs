namespace Hello
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Welcome, {name} today is {currentDate:d}");
        }
    }
}