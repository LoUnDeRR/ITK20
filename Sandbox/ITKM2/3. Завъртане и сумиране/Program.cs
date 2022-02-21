using System;
using System.Linq;

namespace _3._Завъртане_и_сумиране
{
    class Program
    {
        static void Main()
        {
            int[] rotationOld = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 1 2 3 4
            int k = int.Parse(Console.ReadLine()); // 2 пъти

            int[] rotation = new int[rotationOld.Length];
            int[] sum = new int[rotationOld.Length];
            for (int i = 0; i < k; i++) // 2 пъти се повтаря
            {
                int lastNum = rotationOld[rotation.Length - 1]; // x x x 4
                for (int y = 0; y < rotationOld.Length - 1; y++)
                    rotation[y + 1] = rotationOld[y]; // 1 1 2 3

                rotation[0] = lastNum; // 1 1 2 3 => 4 1 2 3
                for (int y = 0; y < rotationOld.Length; y++) 
                { 
                    sum[y] += rotation[y]; // сумираме стойностите на rotation[]-ите (начален е 0 0 0 0)
                    rotationOld[y] = rotation[y]; // правим rotationOld да е равен на rotation[]
                }
            }
            Console.WriteLine(string.Join(' ', sum));
        }
    }
}