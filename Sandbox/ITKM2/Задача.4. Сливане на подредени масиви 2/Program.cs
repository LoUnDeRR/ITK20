using System;
using System.Linq;

namespace Задача._4._Сливане_на_подредени_масиви_2
{
    class Program
    {
        static void Main()
        {
            int[] arrayFirst = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arraySecond = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] mixedArray = new int[arrayFirst.Length + arraySecond.Length];

            bool indexMaxReached = false;
            int aFIndex = 0;
            int aSIndex = 0;
            for (int i = 0; i < mixedArray.Length; i++)
            {
                if (aFIndex == arrayFirst.Length)
                {
                    indexMaxReached = true;
                    mixedArray[i] = arraySecond[aSIndex];
                    aSIndex++;
                }
                if (aSIndex == arraySecond.Length)
                {
                    indexMaxReached = true;
                    mixedArray[i] = arrayFirst[aFIndex];
                    aFIndex++;
                }

                else if (arrayFirst[aFIndex] <= arraySecond[aSIndex] && indexMaxReached == false)
                {
                    mixedArray[i] = arrayFirst[aFIndex];
                    aFIndex++;
                }
                else
                {
                    if (indexMaxReached == false)
                    {
                        mixedArray[i] = arraySecond[aSIndex];
                        aSIndex++;
                    }
                }
            }
            Console.WriteLine(String.Join(' ', mixedArray));
        }
    }
}
