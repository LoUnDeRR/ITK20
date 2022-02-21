using System;
using System.Linq;

namespace _4._Сгъни_и_събери
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int k = input.Length / 4;
            int[] topArray = new int[2 * k];

            int j = 0;
            for (int i = k - 1; i >= 0; i--, j++)
                topArray[j] = input[i];

            for (int i = input.Length - 1; i >= input.Length - k; i--, j++)
                topArray[j] = input[i];

            int[] bottomArray = new int[2 * k];
            int[] resultArray = new int[2 * k];

            j = 0;
            for (int i = k; i <= 3 * k - 1; i++, j++)
            {
                bottomArray[j] = input[i];
                resultArray[j] = topArray[j] + bottomArray[j];
            }

            Console.WriteLine(string.Join(' ', resultArray));
        }
    }
}