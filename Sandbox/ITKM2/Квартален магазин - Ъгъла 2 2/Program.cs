using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace Квартален_магазин___Ъгъла_2_2
{
    class Program
    {
        static void Main()
        {
            // Слага десетичен знак "."
            CultureInfo currentCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone(); // Copy of the current culture
            // cc.NumberFormat.NumberDecimalSeparator = "."; // input: 1,50 -> 1.50
            currentCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = currentCulture;


            // <DateTime, item>, <price, amount>
            Dictionary<KeyValuePair<DateTime, string>, KeyValuePair<double, int>> sales = new Dictionary<KeyValuePair<DateTime, string>, KeyValuePair<double, int>>();
            // <артикул, [средна цена, обща бройка, реален тотал за хляба, обща цена, общ брой]>
            Dictionary<string, double[]> totals = new Dictionary<string, double[]>();


            string[] input = Console.ReadLine().Split(", "); // item price amount
            while (input[0] != "КРАЙ")
            {
                // <DateTime, item>
                KeyValuePair<DateTime, string> sale = new KeyValuePair<DateTime, string>(DateTime.Now, input[0]);
                // Dictionary[<DateTime, item>] = <price, amount>
                sales[sale] = new KeyValuePair<double, int>(double.Parse(input[1]), int.Parse(input[2]));

                string itemName = input[0];


                if (totals.ContainsKey(itemName))
                {
                    totals[itemName][3] += double.Parse(input[1]); // Натрупване на всички цени
                    totals[itemName][4]++; // Натрупване на срещания
                    totals[itemName][0] = totals[itemName][3] / totals[itemName][4]; // Смятане на средната цена
                    totals[itemName][1] += double.Parse(input[2]); // натрупваме бройката
                    totals[itemName][2] += double.Parse(input[1]) * double.Parse(input[2]); // Натрупана сума
                }
                else
                {
                    double startPrice = double.Parse(input[1]); // Първата цена
                    double firstOccur = 1; // Първото срещане
                    double startPriceAvg = startPrice / firstOccur; // Смятане на средната цена за първи път
                    double startAmount = double.Parse(input[2]); // Първата бройка
                    double startTotal = double.Parse(input[1]) * double.Parse(input[2]); // Първата сума

                    totals[itemName] = new double[] { startPriceAvg, startAmount, startTotal, startPrice, firstOccur };
                    //Console.WriteLine(totals[itemName][3]);
                }
                input = Console.ReadLine().Split(", ");
            }

            Console.WriteLine("\nПРОДАЖБИТЕ ПО РЕДА СИ:");
            foreach (var sale in sales)
                Console.WriteLine($"{sale.Key.Value}: {sale.Value.Key:c} x {sale.Value.Value} = {sale.Value.Key * sale.Value.Value:c}"); // Хляб 1,50 лв. 3
            Console.WriteLine("\nТОТАЛИЗАЦИЯ:");
            foreach (var item in totals)
                Console.WriteLine($"{item.Key}: Средна цена: {item.Value[0]:c2}, Обща бройка: {item.Value[1]}, Обща сума: {item.Value[2],10:c}");
        }
    }
}