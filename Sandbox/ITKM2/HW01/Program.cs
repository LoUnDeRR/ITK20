using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] thePlane = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int currentIndex = int.Parse(Console.ReadLine());
        int planeLength = thePlane.Length;
        int initDamage = 1;
        const string endCommand = "Supernova";

        string[] command = Console.ReadLine().Split();
        while (command[0] != endCommand)
        {
            string direction = command[0];
            int steps = int.Parse(command[1]);

            int dirNum;
            if (direction == "left") dirNum = -1;
            else dirNum = 1;

            for (int i = 0; i < steps; i++)
            {
                currentIndex += dirNum;
                if (currentIndex == -1)
                {
                    currentIndex = planeLength - 1;
                    initDamage++;
                }
                else if (currentIndex == planeLength)
                {
                    currentIndex = 0;
                    initDamage++;
                }
                thePlane[currentIndex] -= initDamage;
            }
            command = Console.ReadLine().Split();
        }
        Console.WriteLine(String.Join(' ', thePlane));
    }
}