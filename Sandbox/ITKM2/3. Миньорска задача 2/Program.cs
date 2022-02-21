using System;
using System.Collections.Generic;

namespace _3._Миньорска_задача_2
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> resQuantity = new Dictionary<string, int>();

            while (true)
            {
                string res = Console.ReadLine();
                if (res == "stop") 
                    break;
                int quantity = int.Parse(Console.ReadLine());

                if (resQuantity.ContainsKey(res))
                    resQuantity[res] += quantity;
                else
                    resQuantity[res] = quantity;
            }
            foreach (var item in resQuantity)
                Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }
}
