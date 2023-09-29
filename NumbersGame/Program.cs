namespace NumbersGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            int number, userGuess, difficulty, maxGuesses;
            bool guessed, exit;

            maxGuesses = 5;
            exit = false;

            Console.WriteLine("Välkommen! Välj din svårighetsgrad (ange ett nummer, standard är 1): ");
            difficulty = GetUserInput();

            if (difficulty <= 0)
            {
                difficulty = 1;
            }
           
            while (!exit)
            {
                number = random.Next(1, 5 * difficulty);
                guessed = false;

                Console.WriteLine("Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök: ");

                for (int i = 0; (i < maxGuesses) && !guessed; i++)
                {
                    userGuess = GetUserInput();

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
                    Console.WriteLine("\nTyvärr, du lyckades inte gissa talet på fem försök!");
                }

                Console.WriteLine("Spela igen? (y/n): ");
                string? userChoice = Console.ReadLine();

                if (userChoice == "n")
                {
                    exit = true;
                }
            }
        }

        public static int GetUserInput()
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