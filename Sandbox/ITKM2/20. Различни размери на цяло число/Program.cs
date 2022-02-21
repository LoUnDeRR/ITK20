using System;

namespace _20._Различни_размери_на_цяло_число
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            decimal n = decimal.MaxValue;

            try
            {
                n = long.Parse(input);
            }
            catch (Exception i)
            {
                Console.WriteLine(i.Message);
            }


            
            if (n < long.MaxValue && n > long.MinValue)
                Console.WriteLine($"{n} can fit in:");

            if (n < sbyte.MaxValue && n > sbyte.MinValue)
                Console.WriteLine("* sbyte");
            if (n < byte.MaxValue && n > byte.MinValue)
                Console.WriteLine("* byte");
            if (n < short.MaxValue && n > short.MinValue)
                Console.WriteLine("* short");
            if (n < ushort.MaxValue && n > ushort.MinValue)
                Console.WriteLine("* ushort");
            if (n < int.MaxValue && n > int.MinValue)
                Console.WriteLine("* int");
            if (n < uint.MaxValue && n > uint.MinValue)
                Console.WriteLine("* uint");
            if (n < long.MaxValue && n > long.MinValue)
                Console.WriteLine("* long");

        }
    }
}
