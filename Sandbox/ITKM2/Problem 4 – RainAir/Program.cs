using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4___RainAir
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<int>> customerFlights = new Dictionary<string, List<int>>();
            string[] input = Console.ReadLine().Split(); // Georgi 312 412 524
            while (String.Join(' ', input) != "I believe I can fly!")
            {
                if (input[1] != "=") // {customerName} {customerFlight1} {customerFlight2} {customerFlight3} ...
                    if (customerFlights.ContainsKey(input[0])) // checks if dict key exists
                        for (int i = 1; i < input.Length; i++)
                            customerFlights[input[0]].Add(int.Parse(input[i])); // adds all flights to the list
                    else
                    {
                        customerFlights[input[0]] = new List<int>(); // creates list
                        for (int i = 1; i < input.Length; i++)
                            customerFlights[input[0]].Add(int.Parse(input[i])); // adds all flights to the list
                    }
                else // {customerName} = {customer2Name}
                    customerFlights[input[0]] = customerFlights[input[2]].ToList(); // МНОГО ВАЖЕН И ПОУЧИТЕЛЕН РЕД
                input = Console.ReadLine().Split();
            }

            foreach (var customer in customerFlights.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                customer.Value.Sort();
                Console.WriteLine($"#{customer.Key} ::: {String.Join(", ", customer.Value)}");
            }
        }
    }
}
