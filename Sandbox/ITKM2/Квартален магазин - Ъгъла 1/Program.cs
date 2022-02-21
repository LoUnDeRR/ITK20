using System;
using System.Collections.Generic;
using System.Linq;

namespace Квартален_магазин___Ъгъла_1
{
    class Program
    {
        static void Main()
        {
            // Bread, 1.50, 3
            Dictionary<string, KeyValuePair<double, int>> stock = new Dictionary<string, KeyValuePair<double, int>>();

            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "END")
            {
                if (stock.ContainsKey(input[0]))
                {
                    stock[input[0]] = new KeyValuePair<double, int>(stock[input[0]].Key + double.Parse(input[1]), stock[input[0]].Value + int.Parse(input[2]));
                }
                else
                {
                    stock[input[0]] = new KeyValuePair<double, int>(double.Parse(input[1]), int.Parse(input[2]));
                }
                input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in stock.OrderBy(x => x.Key))
            {
                Console.WriteLine(item);
            }
            foreach (var item in stock.OrderBy(x => x.Value.Key))
            {
                Console.WriteLine(item);
            }
        }
    }
}
