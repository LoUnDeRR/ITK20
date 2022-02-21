using System;
using System.Linq;

namespace OOP_Tests
{
    public class Bure
    {
        public string m;
        public double r;
        public double h;
        public double Volume()
        {
            return 3.14 * r * r * h;
        }
        public Bure()
        {

        }
    }

    class Program
    {


        static void Main()
        {
            Bure[] myBure = new Bure[5];
            myBure[0].m = "myModel";
            myBure[0].r = 12;
            myBure[0].h = 24;

            Console.WriteLine(myBure[0].Volume());

        }
    }
}
