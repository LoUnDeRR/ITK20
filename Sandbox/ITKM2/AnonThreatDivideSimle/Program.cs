using System;

namespace AnonThreatDivideSimple
{
    class Program
    {
        static void Main()
        {
            // Example: {abcdef, ghi, jkl} -> divide 0 3 -> {ab, cd, ef, ghi, jkl}
            // helloworld 4
            // he ll ow orld
            string input = Console.ReadLine(); // string
            int partitions = int.Parse(Console.ReadLine()); // partitions

            int sizePartitions = (int)(input.Length / partitions); // he ll ow or|ld|

            string[] output = new string[partitions + partitions + 2]; //he ll ow or*ld*
            // int(length / partitions)
            for (int i = 0; i < input.Length; i += 2) // h e l l o w o r l d
                if (i % sizePartitions == 0)
                {
                    output[i] = input.Substring(i, sizePartitions);
                    output[i + 1] = " ";
                }
            Console.WriteLine(string.Join("", output));

            //string.substring()
            //string.lastindexof("")
            //string.replace(match, replacement)
            //trim(char)
            //trimstart
            //trimend

        }
    }
}
