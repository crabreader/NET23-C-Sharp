namespace NumbersGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 20);
            int userGuess;
            bool guessed = false;

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            for (int i = 0; (i < 5) && !guessed; i++)
            {
                userGuess = GetUserGuess();

                if (GuessIsCorrect(number, userGuess))
                {
                    guessed = true;
                    Console.WriteLine("Wohoo! Du klarade det!");
                }
                else
                {
                    if (userGuess < number)
                    {
                        Console.WriteLine("Tyvärr, du gissade för lågt!");
                    }
                    else
                    {
                        Console.WriteLine("Tyvärr, du gissade för högt!");
                    }
                }
            }

            if (!guessed)
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
            }
        }

        public static int GetUserGuess()
        {
            int parsedInput;
            bool success = int.TryParse(Console.ReadLine(), out parsedInput);

            return parsedInput;
        }

        public static bool GuessIsCorrect(int number, int guess)
        {
            if (number == guess)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}