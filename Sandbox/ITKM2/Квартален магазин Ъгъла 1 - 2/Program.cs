using System;
using System.Collections.Generic;
using System.Linq;

namespace Квартален_магазин_Ъгъла_1___2
{
    class Program
    {
        static void Main()
        {   // index item price amount
            Dictionary<KeyValuePair<int, string>, KeyValuePair<double, int>> stock = new Dictionary<KeyValuePair<int, string>, KeyValuePair<double, int>>();

            Console.WriteLine("INPUT:");
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "END")
            {
                stock[new KeyValuePair<int, string>(DateTime.Now.Ticks, input[0])] = new KeyValuePair<double, int>(double.Parse(input[1]), int.Parse(input[2]));

                input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in stock)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in stock.OrderBy(x => x.Key.Value))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in stock.OrderBy(x => x.Value.Value * x.Value.Key))
            {
                Console.WriteLine($"{item.Key.Value} - {item.Value.Value} броя X {item.Value.Key} лв. = {item.Value.Value * item.Value.Key}");
            }
        }
    }
}
