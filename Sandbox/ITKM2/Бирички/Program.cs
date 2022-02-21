using System;
using System.Linq;

namespace Бирички
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double maxVol = 0;
            string maxModel = "";

            for (int i = 1; i <= n; i++)
            {
                string currModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currVol = Math.PI * radius * radius * height;
                if (currVol > maxVol)
                {
                    maxVol = currVol;
                    maxModel = currModel;
                }
            }
            Console.WriteLine(maxModel);


        }
    }
}