using System;

namespace Задача._3._Множество_от_сумите_на_последните_k_числа
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); //6
            int k = int.Parse(Console.ReadLine()); //3

            int[] array = new int[n];
            array[0] = 1;
            for (int y = 1; y < n; y++)
            {
                for (int i = 0; i <= k && i <= y; i++)
                {
                    array[y] += array[y - i];
                }
            }
            Console.WriteLine(string.Join(' ', array));
        }
    }
}
