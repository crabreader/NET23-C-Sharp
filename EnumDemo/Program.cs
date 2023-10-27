namespace EnumDemo
{
    internal class Program
    {
        public enum Suit
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

        private static void Main(string[] args)
        {
            Random random = new Random();

            Suit yourSuit;
            yourSuit = (Suit)random.Next(0, 4);

            switch (yourSuit)
            {
                case Suit.Hearts:
                    Console.WriteLine("You got Hearts");
                    break;
                case Suit.Diamonds:
                    Console.WriteLine("You got Diamonds");
                    break;
                case Suit.Clubs:
                    Console.WriteLine("You got Clubs");
                    break;
                case Suit.Spades:
                    Console.WriteLine("You got Spades");
                    break;
            }
        }
    }
}