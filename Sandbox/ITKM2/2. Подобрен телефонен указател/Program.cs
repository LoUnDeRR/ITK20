using System;
using System.Collections.Generic;

namespace _2._Подобрен_телефонен_указател
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            
            List<string> output = new List<string>();

            string[] input = Console.ReadLine().Split();
            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phonebook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        output.Add($"{input[1]} -> {phonebook[input[1]]}");
                    }
                    else
                    {
                        output.Add($"Contact {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        output.Add($"{item.Key} -> {item.Value}");
                    }
                    
                }
                input = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join("\n", output));
        }
    }
}
