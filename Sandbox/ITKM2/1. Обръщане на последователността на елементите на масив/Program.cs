using System;

namespace _1._Обръщане_на_последователността_на_елементите_на_масив
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = n - 1; i >= 0; i--)
                array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(' ', array));
        }
    }
}
