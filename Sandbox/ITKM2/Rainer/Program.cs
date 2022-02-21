using System;
using System.Collections.Generic;
using System.Linq;

namespace Rainer
{
    class Program
    {
        static void Main()
        {
            /* Получаваме масив от интове; последният е началната позиция
             * На всяка стъпка намаляме всички интове с 1
             * Получаваме инт, който е следващата стъпка на Доналд
             * Повтаряме докато Доналд 
             * 
             * Поемаме оригиналния масив //
             * Запазваме последния елемент в нова променлива //
             * Запазваме всички останали в друг масив и работим с него //
             */


            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int posDonald = inputList[inputList.Count - 1];
            inputList.RemoveAt(inputList.Count - 1);
            int[] sequence = inputList.ToArray();

            int steps = 0;
            do
            {
                for (int i = 0; i <= sequence.Length - 1; i++) 
                    sequence[i]--;
                if (sequence[posDonald] == 0) 
                    break;
                else
                    for (int i = 0; i <= sequence.Length - 1; i++)
                        if (sequence[i] == 0) 
                            sequence[i] = inputList[i];

                steps++;
                posDonald = int.Parse(Console.ReadLine());
            }
            while (true);

            Console.WriteLine(String.Join(' ', sequence));
            Console.WriteLine(steps);
        }
    }
}