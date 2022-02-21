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
            string bravo = "firstDataSet";
            Dictionary<string, List<KeyValuePair<string, int>>> dataSets = new Dictionary<string, List<KeyValuePair<string, int>>>();
            dataSets.Add(bravo, new List<KeyValuePair<string, int>>());
            dataSets[bravo].Add(new KeyValuePair<string, int>("asd", 5));
            foreach (var dataSet in dataSets)
            {
                if (dataSet.Value.Count != 0)
                {
                    Console.WriteLine("hi");
                }
            }
        }
    }
}