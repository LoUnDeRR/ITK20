using System;
using System.Linq;

namespace Задача._2._Безопасна_обработка_на_масив
{
    class Program
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split();
            const string endCMD = "END";

            string[] command = Console.ReadLine().Split();
            while (command[0] != endCMD)
            {
                if (command[0] == "Reverse")
                    Array.Reverse(array);
                else if (command[0] == "Distinct")
                    array = array.Distinct().ToArray();
                //                                   command[0] command[1] command[2]
                else if (command[0] == "Replace") // Replace    {index}    {string}
                    if (int.Parse(command[1]) < array.Length && int.Parse(command[1]) >= 0)
                        array[int.Parse(command[1])] = command[2];
                    else Console.WriteLine("Index out of range!");
                else
                    Console.WriteLine("Invalid Command!");
                Console.WriteLine(string.Join(' ', array));

                command = Console.ReadLine().Split();
            }
        }
    }
}
