using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays...
            /* fixed sized
             * type of array we want... double, int, string etc.
             * declare length of arrays
            */

            string[] firstNames = new string[10];
            firstNames[0] = "Cal";
            firstNames[1] = "Danneh";
            Console.WriteLine(firstNames[1]);
            Console.ReadKey();

            int[] numbers = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                numbers[i] = i + 1;
                Console.WriteLine(numbers[i]);
            }

            double[] decimalNumbers = new double[3] { 34, 55, 77 };
            Console.WriteLine(decimalNumbers[2]);
            decimalNumbers[2] = 78;
            Console.WriteLine(decimalNumbers[2]);
            Console.ReadKey();
        }
    }
}
