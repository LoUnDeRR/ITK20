using System;
using System.Linq;
using System.Collections.Generic;

namespace AnonThreat
{
    class Program
    {
        static void Main()
        {
            List<string> inputLine = Console.ReadLine().Split(' ').ToList();

            string[] command = Console.ReadLine().Split();
            while (command[0] != "3:1")
            {
                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);

                if (startIndex < 0)
                    startIndex = 0;
                else if (startIndex > inputLine.Count - 1)
                    startIndex = inputLine.Count - 1;

                if (endIndex < 0)
                    endIndex = 0;
                else if (endIndex > inputLine.Count - 1)
                    endIndex = inputLine.Count - 1;

                if (command[0] == "merge") // merge {startIndex} {endIndex}
                {
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        inputLine[startIndex] += inputLine[startIndex + 1];
                        inputLine.RemoveAt(startIndex + 1);
                    }
                }


                else if (command[0] == "divide") // divide {index} {partitions}
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);

                    string div = inputLine[index]; // правим копие на елемента, който ще цепим

                    inputLine.RemoveAt(index); // изтриваме копирания елемент

                    int partLength = div.Length / partitions;

                    int listOffset, divPos = 0;
                    for (listOffset = 0; listOffset < partitions - 1; listOffset++, divPos += partLength)
                        inputLine.Insert(index + listOffset, div.Substring(divPos, partLength));
                    inputLine.Insert(index + listOffset, div.Substring(divPos));
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(' ', inputLine));
        }
    }
}