using System;
using System.Linq;
using System.Collections.Generic;

namespace Задача._4._Извличане_на_средните_1__2_или_3_елемента
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> output = new List<int>();
            if (array.Length % 2 == 0) // ако четно
            {
                output.Add(array[(array.Length) / 2 - 1]);
                output.Add(array[(array.Length) / 2]);
            }
            else if (array.Length < 3)
                output.Add(array[(int)(array.Length / 2 - 0.5)]);
            else
            {
                output.Add(array[(int)((array.Length - 1) / 2 - 0.5)]);
                output.Add(array[(int)((array.Length - 1) / 2 + 0.5)]);
                output.Add(array[(int)((array.Length - 1) / 2 + 1.5)]);
            }
            Console.WriteLine("{ " + string.Join(", ", output) + " }");
        }
    }
}
