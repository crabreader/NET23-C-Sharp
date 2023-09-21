namespace VarDynamic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var myValue = 45;
            //var myValue2 = "ああああああああ";

            // myValue = "あああああ";
            // dynamic myValue3 = 35;
            // Console.WriteLine(myValue3);

            // myValue3 = "ああああああ";
            // Console.WriteLine(myValue3);

            // int myInt = 5;
            // float myFloat = 34.346F;
            // double myDouble;
            // myDouble = myFloat;
            // //myFloat = myDouble;
            // Console.WriteLine(myDouble);

            // char myChar = '\u0041';
            // Console.WriteLine(myChar);
            // int myInt = (int)myChar;

            // Console.WriteLine(myInt);

            // bool myBool = false;

            // Console.WriteLine(Convert.ToDouble(myInt) + 0.512);

            // Console.WriteLine(myBool);

            // string myNumber = "87";
            // int i = int.Parse(myNumber);
            // Console.WriteLine(i + 5);

            // string myNumber = "34a";
            // int result;

            // //result = Convert.ToInt32(myNumber);

            // try
            // {
            //     result = int.Parse(myNumber);
            // }
            // catch (System.Exception)
            // {
            //     result = 0;
            //     Console.WriteLine("Invalid number");
            // }

            // //bool success = int.TryParse(myNumber, out result);

            // Console.WriteLine(result);


        //     int[] numberArray = new int[4] {2, 3, 4, 5};

        //     int[] secondArray = {1, 343, 45, 7};

        //     var thirdArray = new int[5];

        //     numberArray[0] = 6;
        //     numberArray[2] = 145;

        //     foreach (int number in numberArray)
        //     {
        //         Console.WriteLine(number);
        //     }

            // int[,] emptyTable = new int[3,5];
            // emptyTable[0,0] = 1;            
            // emptyTable[1,0] = 2;            
            // emptyTable[2,0] = 3;

            var array = new int[4][];
            array[0] = new int [1];
            array[1] = new int [2];
            array[2] = new int [3];
            array[3] = new int [4];

            for (int i = 0; i < 4; i++)
            {
                foreach (int item in array[i])
                {
                    Console.Write(item);
                }

                Console.Write("\n");
            }

            // foreach (int number in emptyTable)
            // {
            //     Console.Write(number + " ");
            // }
        }
    }
}