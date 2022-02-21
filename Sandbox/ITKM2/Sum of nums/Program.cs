using System;
using System.Diagnostics;
using System.Linq;

namespace Sum_of_nums
{
    class Program
    {
        static void Main()
        {
            int n, s, t;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (n = 1111; n <= 1120; n++) // 1000 - 10000000
            {
                // Метод
                // Console.WriteLine($"{n} {s}");
            }
            Console.WriteLine(timer.Elapsed);

            //s = 0; t = n; //00:00:00.5560468
            //for (; t > 0; s += t % 10, t /= 10) ;
            //Console.WriteLine($"{n} {s}");

            //s = 0; t = n; // 00:00:00.5616030
            //while (t > 0)
            //{
            //    s += t % 10;
            //    t /= 10;
            //}
            ////Console.WriteLine($"{n} {s}");

            //s = 0; // 00:00:02.1422033
            //string num = n.ToString();
            //for (int i = 0; i < num.Length; i++)
            //    s += int.Parse(num[i].ToString());

            //// 00:00:03.1511042
            //s = n.ToString().Select(x => int.Parse(x.ToString())).Sum();

            //s = 0; // 00:00:05.7750841
            //for (int i = 0; i < n.ToString().Length; i++)
            //    s += int.Parse(n.ToString()[i].ToString());
            ////Console.WriteLine($"{n} {s}");
        }
    }
}