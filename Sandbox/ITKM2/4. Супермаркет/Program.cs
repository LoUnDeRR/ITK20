using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace _4._Супермаркет
{
    class Program
    {
        static void Main()
        {
            // Sets the current culture ($)
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            // Creates dictionary | <string, KeyValuePair<double, int>>
            Dictionary<string, KeyValuePair<double, int>> stock = new Dictionary<string, KeyValuePair<double, int>>(); // {име} {цена} {количество}

            // Takes the input and repeats until "stocked"
            string[] item = Console.ReadLine().Split();
            while (item[0] != "stocked")
            {
                // Checks if the item already exists and updates the details
                if (stock.ContainsKey(item[0]))
                    stock[item[0]] = new KeyValuePair<double, int>(double.Parse(item[1]), int.Parse(item[2]) + stock[item[0]].Value);
                // Creates a new item in the dictionary and sets it's details
                else
                    stock[item[0]] = new KeyValuePair<double, int>(double.Parse(item[1]), int.Parse(item[2]));
                item = Console.ReadLine().Split();
            }

            double grandTotal = 0;

            // Outputs the details and calculates the grand total
            foreach (var _item in stock)
            {
                Console.WriteLine($"{_item.Key}: {_item.Value.Key:c2} * {_item.Value.Value} = {_item.Value.Key * _item.Value.Value:c2}"); 
                grandTotal += _item.Value.Key* _item.Value.Value;
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: {grandTotal:c2}");
        }
    }
}
