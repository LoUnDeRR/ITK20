using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Телефонен_указател_2
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>(); // A Nakov 0888080808

            string[] input = Console.ReadLine().Split();
            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phonebook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (phonebook.TryGetValue(input[1], out string fNumber))
                    {
                        Console.WriteLine($"{input[1]} -> {fNumber}");
                    }
                    else 
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }

                input = Console.ReadLine().Split();
            }
        }
    }
}
