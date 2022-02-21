using System;

namespace AnonThreatDivideSimple2
{
    class Program
    {
        static void Main()
        {
            // Example: {abcdef, ghi, jkl} -> divide 0 3 -> {ab, cd, ef, ghi, jkl}
            // he ll ow orld 4
            string input = Console.ReadLine(); // string
            int partitions = int.Parse(Console.ReadLine()); // partitions


            /*
            10/4 = int(2)
            10%4 = 2
             
            int10/4 | int10/4 | int10/4 + 10%4

             */

            string[] output = new string[partitions];

            for (int i = 0; i < partitions; i++)
            {
                output[i] = input.Substring((int)(input.Length / partitions));
            }
            output[output.Length - 1] = ((int)(input.Length / partitions) + input.Length % partitions).ToString();

            Console.WriteLine(string.Join(' ', output));




















            //string.substring()
            //string.lastindexof("")
            //string.replace(match, replacement)
            //trim(char)
            //trimstart
            //trimend

        }
    }
}

