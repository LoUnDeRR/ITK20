using System;

namespace _temp
{
    class Program
    {
        static void Main()
        {
            int[] array = { 9, 8, 7, 6, 5, 4 };

            bool changed = true;
            while (changed == true)
            {
                changed = false;
                for (int i = 0; i < array.Length - 1; i++) // 7, 6, 4, 1, 9 ; 1, 4, 6, 7, 9
                {
                    if (array[i] > array[i + 1])
                    {
                        int t = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = t;
                        changed = true;
                    }
                }
            }
            Console.WriteLine(String.Join(' ', array));
        }
    }
}
