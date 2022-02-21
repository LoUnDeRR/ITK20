using System;
using System.Linq;

namespace Преобразуване_на_масив_в_число
{
    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (nums.Length > 1)
            {
                while (nums.Length > 1)
                {
                    int[] condensed = new int[nums.Length - 1];
                    for (int i = 0; i < condensed.Length; i++)
                    {
                        condensed[i] = nums[i] + nums[i + 1];
                    }
                    nums = condensed;
                }
                Console.WriteLine(nums[0]);
            }
            else
                Console.WriteLine(nums[0] + " is already condensed to number");

        }
    }
}