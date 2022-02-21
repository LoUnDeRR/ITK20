using System;
using System.Linq;

namespace IcarusOptim
{
    class Program
    {
        static void Main()
        {
            int[] thePlane = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currentIndex = int.Parse(Console.ReadLine());
            int planeLength = thePlane.Length;

            string[] command = { "one", "two" };


            while (true)
            {
                command = Console.ReadLine().Split();
                if (command[0] != "Supernova")
                {
                    command = Console.ReadLine().Split();
                    string direction = command[0];
                    int steps = int.Parse(command[1]);
                }
                else continue;

            }
        }
    }
}
