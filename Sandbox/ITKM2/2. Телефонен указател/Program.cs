using System;
using System.Collections.Generic;

namespace _2._Телефонен_указател
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
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
                input = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join("\n", output));
        }
    }
}
