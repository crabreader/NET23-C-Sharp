namespace TemperatureConfirm
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Vad är temperaturen utomhus i grader celsius?");
            int temp = Convert.ToInt16(Console.ReadLine());

            if (temp >= 30)
            {
                Console.WriteLine("Jättevarmt");
            } else if (temp >= 20)
            {
                Console.WriteLine("Varmt");
            } else
            {
                Console.WriteLine("Hösttemperatur");
            }
        }
    }
}