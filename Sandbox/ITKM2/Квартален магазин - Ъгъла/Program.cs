using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace Квартален_магазин___Ъгъла
{
    class Program
    {
        static void Main()
        {
            CultureInfo cc = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone(); // Copy of the current culture
            // cc.NumberFormat.NumberDecimalSeparator = "."; // input: 1,50 -> 1.50
            cc.NumberFormat.CurrencyDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = cc;


            // <DateTime, item>, <price, amount>
            Dictionary<KeyValuePair<DateTime, string>, KeyValuePair<double, int>> sales = new Dictionary<KeyValuePair<DateTime, string>, KeyValuePair<double, int>>();


            string[] input = Console.ReadLine().Split(); // item price amount
            while (input[0] != "КРАЙ")
            {
                // <DateTime, item>
                KeyValuePair<DateTime, string> sale = new KeyValuePair<DateTime, string>(DateTime.Now, input[0]);

                // Dictionary[<DateTime, item>] = <price, amount>
                sales[sale] = new KeyValuePair<double, int>(double.Parse(input[1]), int.Parse(input[2]));

                input = Console.ReadLine().Split();
            }

            Console.WriteLine("\nПРОДАЖБИТЕ ПО РЕДА СИ:");
            foreach (var sale in sales)
                Console.WriteLine($"[{sale.Key.Key:dd-MMMM-yyyy HH:mm:ss.fff}] {sale.Key.Value} {sale.Value.Key:c} {sale.Value.Value}"); // Хляб 1,50 лв. 3

            Console.WriteLine("\nПРОДАЖБИТЕ ПО АРТИКУЛ:");
            foreach (var sale in sales.OrderBy(sale => sale.Key.Value))
                Console.WriteLine($"{sale.Key.Value} {sale.Value.Key:c} {sale.Value.Value}");

            Console.WriteLine("\nПРОДАЖБИТЕ ПО СТОЙНОСТ:");
            foreach (var sale in sales.OrderBy(x => x.Value.Value * x.Value.Key))
                Console.WriteLine($"{sale.Key.Value,-8} {"-",4} {sale.Value.Value,6} броя {"x",4} {sale.Value.Key,12:c} = {sale.Value.Value * sale.Value.Key,12:c}"); // Хляб - 2 броя X 2.00 лв. = 4.80 лв.

            Console.WriteLine("\nПРОДАЖБИТЕ ПО СТОЙНОСТ В ОБРАТЕН РЕД:");
            foreach (var sale in sales.OrderByDescending(x => x.Value.Value * x.Value.Key))
                Console.WriteLine($"{sale.Key.Value,-8} {"-",4} {sale.Value.Value,6} броя {"x",4} {sale.Value.Key,12:c} = {sale.Value.Value * sale.Value.Key,12:c}"); // Хляб - 2 броя X 2.00 лв. = 4.80 лв.
        
            Console.WriteLine("\nПРОДАЖБИТЕ ПО АРТИКУЛ И ЦЕНА В ОБРАТЕН РЕД:");
            foreach (var sale in sales.OrderBy(x => x.Key.Value)
                .ThenByDescending(x => x.Value.Key))
                Console.WriteLine($"{sale.Key.Value,-8} {"-",4} {sale.Value.Value,6} броя {"x",4} {sale.Value.Key,12:c} = {sale.Value.Value * sale.Value.Key,12:c}"); // Хляб - 2 броя X 2.00 лв. = 4.80 лв.
        }
    }
}