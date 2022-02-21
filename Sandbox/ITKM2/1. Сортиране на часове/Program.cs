using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace _1._Сортиране_на_часове
{
    class Program
    {
        static void Main()
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;


            foreach (var item in Console.ReadLine().Split().Select(DateTime.Parse).OrderBy(x => x))
                Console.WriteLine($"{item:hh:mm tt}");
        }
    }
}
