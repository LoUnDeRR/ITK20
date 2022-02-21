using System;

namespace AnonThreatMerge
{
    class Program
    {
        static void Main()
        {
            string[] inputLine = Console.ReadLine().Split(' '); // alpha[0] bravo[1] charlie[2] delta[3]
            string[] command = Console.ReadLine().Split(); // merge {startIndex} {endIndex}

            int startIndex = int.Parse(command[1]); // 3
            int endIndex = int.Parse(command[2]); // 7

            if (endIndex > inputLine.Length - 1)
                endIndex = inputLine.Length - 1;
            string output = "";
            if (command[0] == "merge") // merge {startIndex} {endIndex}
            {
                for (; startIndex < endIndex; startIndex += 2)
                {
                    // output += string.Concat(inputLine[startIndex], inputLine[startIndex + 1]);
                    output += inputLine[startIndex] + inputLine[startIndex + 1];
                }
            }
            Console.WriteLine(output);
        }
    }
}
