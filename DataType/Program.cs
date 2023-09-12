using System.Formats.Asn1;
using System.Text;

namespace DataType
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = "Tobias";
            // Värdetyp
            int x = 15;
            int y = x;
            x = 30;
            Console.WriteLine(y);

            // Referenstyper
            StringBuilder strb1 = new StringBuilder("Hej");
            StringBuilder strb2 = strb1;
            strb1.AppendLine();
            strb1.Append("Hur mår du?");

            Console.WriteLine(strb2.ToString());

            Console.WriteLine("Signerat heltal:");
            Console.WriteLine($"int {int.MinValue} till {int.MaxValue}");
            Console.WriteLine("Osignerat heltal:");
            Console.WriteLine($"uint {uint.MinValue} till {uint.MaxValue}");
            Console.WriteLine("Decimaltal:");
            Console.WriteLine($"decimal {decimal.MinValue} till {decimal.MaxValue}\n");

            Console.WriteLine("uint overflow:");
            uint a = uint.MaxValue;
            uint b = a + 1;
            Console.WriteLine(b + "\n");

            bool svar = true;
            svar = false;
            Console.WriteLine(svar);
            string name2 = "Alexander";
            Console.WriteLine(name2);

            int a2 = 25;
            //int b2 = 4;
            if (a2 > 20)
            {
                Console.WriteLine("större");
            }
            else if (a2 <20)
            {
                Console.WriteLine("mindre");
            }
            else
            {
                Console.WriteLine("lika");
            }
        }
    }
}