using System;
using System.Collections.Generic;

namespace AnonThreatDivide
{
    class Program
    {
        static void Main()
        {
            // Example: {abcdef2, ghi, jkl} -> divide 0 3 -> {ab, cd, ef2, ghi, jkl}
            string[] inputLine = Console.ReadLine().Split(' '); // alpha[0] bravo[1] charlie[2] delta[3]
            string[] command = Console.ReadLine().Split(); // divide {index} {partitions}

            int index = int.Parse(command[1]);
            int partitions = int.Parse(command[2]);


            List<char> chars = new List<char>();
            chars.AddRange(inputLine[int.Parse(command[1])].ToCharArray());


            if (partitions > inputLine[index].Length)
                partitions = inputLine[index].Length;


            int charCount = chars.Count;


            for (int i = 1, y = 0; i <= inputLine[index].Length;)
            {
                if (i % ((int)(chars.Count / partitions)) == 0)
                {
                    chars.Insert(i + y, ' ');
                    i += (int)(charCount / partitions);
                    y++;
                }
                else i++;
            }
            for (int i = 0, y = 0; i < chars.Count; i++)
            {
                if (chars[i] == ' ')
                {
                    y++;
                }
                if (y >= partitions)
                {
                    chars.RemoveAt(i);
                }
            }
            // he ll ow orld
            Console.WriteLine(string.Join("", chars));
        }
    }
}