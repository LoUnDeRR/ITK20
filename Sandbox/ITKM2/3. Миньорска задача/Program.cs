using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Миньорска_задача
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> oreAmount = new Dictionary<string, int>();
            while (true)
            {
                string ore = Console.ReadLine().ToLower();
                if (ore == "stop")
                    break;
                int amount = int.Parse(Console.ReadLine());
                if (oreAmount.ContainsKey(ore))
                    oreAmount[ore] += amount;
                else
                    oreAmount[ore] = amount;
            }
            foreach (var item in oreAmount)
                Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }
}
