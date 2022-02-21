using System;
using System.Linq;

namespace Задача._4._Сливане_на_подредени_масиви
{
    class Program
    {
        static void Main()
        {
            int[] arrayFirst = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arraySecond = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] arrayMixed = new int[arrayFirst.Length + arraySecond.Length];



            int aFIndex = 0;
            int aSIndex = 0;
            int aMIndex = 0;

            while (aMIndex < arrayMixed.Length)
            {
                if (arrayFirst[aFIndex] < arraySecond[aSIndex])
                {
                    if (aFIndex < arrayFirst.Length)
                    {
                        arrayMixed[aMIndex] = arrayFirst[aFIndex];
                        aFIndex++;
                        aMIndex++;
                    }
                    else
                    {
                        arrayMixed[aMIndex] = arraySecond[aSIndex];
                        aSIndex++;
                        aMIndex++;
                    }
                }
                else
                {
                    if (aSIndex < arraySecond.Length)
                    {
                        arrayMixed[aMIndex] = arraySecond[aSIndex];
                        aSIndex++;
                        aMIndex++;
                    }
                    else
                    {
                        arrayMixed[aMIndex] = arrayFirst[aFIndex];
                        aFIndex++;
                        aMIndex++;
                    }
                }
            }

            Console.WriteLine(String.Join(' ', arrayMixed));
        }
    }
}
