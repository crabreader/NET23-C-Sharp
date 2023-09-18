namespace MethodDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Program.Print("Jiiku Hairu!");       

            Program jin = new Program();
            jin.PrintEvenNumbers(5);

            Program.Print("Jiiku Hairu!");
            Program.PrintOddNumbers(5);
        }

        public static void Print(string s) 
        {
            Console.WriteLine(s);
        }

        public static void PrintOddNumbers(int limit)
        {
            int start = 1;
            while (start <= limit)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }

        public void PrintEvenNumbers(int limit) 
        {
            int i = 0;
            while (i <= limit)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }        
    }
}