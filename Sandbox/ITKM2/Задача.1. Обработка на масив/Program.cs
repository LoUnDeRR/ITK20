using System;
using System.Linq;

namespace Задача._1._Обработка_на_масив
{
    class Program
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Reverse")
                {
                    Array.Reverse(array);
                }
                else if (command[0] == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                                                  //command[0] command[1] command[2]
                else if (command[0] == "Replace") // Replace    {index}    {string}
                {
                    array[int.Parse(command[1])] = command[2];
                }
                Console.WriteLine(string.Join(' ', array));
            }
            
        }
    }
}
