using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace Квартален_магазин___Ъгъла_2
{
    class Program
    {
        static void Main()
        {
            // <<id, item>, <price, amount>>
            Dictionary<KeyValuePair<DateTime, string>, KeyValuePair<double, int>> stock = new Dictionary<KeyValuePair<DateTime, string>, KeyValuePair<double, int>>();
            Dictionary<string, double> totals = new Dictionary<string, double>();
            string[] input = Console.ReadLine().Split(", "); // Хляб, 1.50, 4
            while (input[0] != "КРАЙ")
            {
                // stock[id+item] = price+amount
                stock[new KeyValuePair<DateTime, string>(DateTime.Now, input[0])] = new KeyValuePair<double, int>(double.Parse(input[1]), int.Parse(input[2]));

                input = Console.ReadLine().Split(", ");
            }

            // <item, <priceTotal, count>>
            Dictionary<string, KeyValuePair<double, int>> inDicCounter = new Dictionary<string, KeyValuePair<double, int>>(); // counts the amount of times we encounter an item
            Dictionary<string, int> amountCount = new Dictionary<string, int>();
            foreach (var item in stock)
            {
                if (inDicCounter.ContainsKey(item.Key.Value))
                    inDicCounter[item.Key.Value] = new KeyValuePair<double, int>(inDicCounter[item.Key.Value].Key + item.Value.Key, inDicCounter[item.Key.Value].Value + 1/*add to priceTotal, add to count*/); // adds 1 to counter
                else
                    inDicCounter[item.Key.Value] = new KeyValuePair<double, int>(item.Value.Key, 1)/*keep priceTotal, make count = 1*/; // creates key for counter 

                if (amountCount.ContainsKey(item.Key.Value))
                    amountCount[item.Key.Value] += item.Value.Value;
                else
                    amountCount[item.Key.Value] = item.Value.Value;

                if (totals.ContainsKey(item.Key.Value))
                {
                    totals[item.Key.Value] += item.Value.Key * item.Value.Value;
                }
                else
                {
                    totals[item.Key.Value] = item.Value.Key * item.Value.Value;
                }

            }

            List<string> output = new List<string>();

            foreach (var item in stock)
            {
                if (inDicCounter[item.Key.Value].Value > 1)
                {
                    if (!output.Contains($"{item.Key.Value}, {inDicCounter[item.Key.Value].Key / inDicCounter[item.Key.Value].Value:c2}, {amountCount[item.Key.Value]}бр, {totals[item.Key.Value]:c2}"))
                    {
                        output.Add($"{item.Key.Value}, {inDicCounter[item.Key.Value].Key / inDicCounter[item.Key.Value].Value:c2}, {amountCount[item.Key.Value]}бр, {totals[item.Key.Value]:c2}");
                    }
                }
                else
                {
                    if (!output.Contains($"{item.Key.Value}: {item.Value.Key:c2} x {item.Value.Value}бр = {item.Value.Key * item.Value.Value:c2}"))
                        output.Add($"{item.Key.Value}: {item.Value.Key:c2} x {item.Value.Value}бр = {item.Value.Key * item.Value.Value:c2}");
                }
            }
            Console.WriteLine(String.Join("\n", output));
        }
    }
}
