using System.Diagnostics;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = Check<double>.GenericIsEqual(5, 2.3);
            bool result2 = Check<string>.GenericIsEqual("a", "b");
            if (result)
            {
                Console.WriteLine("Is equal");
            }
            else
            {
                Console.WriteLine("Is not equal");
            }
        }
    }

    public class Check<T>
    {
        public T _field;

         public static bool IsEqual(int value1, int value2)
        {
            return value1 == value2;
        }

        public static bool IsEqual(string value1, string value2)
        {
            return value1 == value2;
        }

        public static bool GenericIsEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}