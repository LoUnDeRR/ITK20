using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentations_HW_testing
{
    class Program
    {
        static void Main()
        {
            string myString = "Hello world!";

            string copyMyString = myString;

            myString = "Hello";

            Console.WriteLine(copyMyString);
            //// Защо string е референтен тип, при положение че когато променим оригинала, копието не се променя, както при string[]

            //int[] myInt = new int[] { 1, 2, 3, 4, 5, 6 };
            //object obj = 42;
            ////object не е напълно ясен. Не разбирам защо бихме го ползвали, когато можем да ползваме string

            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //    arr[i] = int.Parse(Console.ReadLine());
            ////
            //string values = Console.ReadLine();
            //string[] items = values.Split(' ');
            ////
            //int[] arr = items.Select(int.Parse).ToArray();



            //for (int i = 0; i < nums.Length; i++)
            //    roundedNums[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);

            //int[] arr = { 10, 20, 30, 40, 50 };
            //foreach (var element in arr)
            //    Console.WriteLine(element)

            //int pos = 1;
            //int countOfZero = 2;
            //int[] arr = new int[] { 2, 4, -5, 1, 10 };
            //Array.Clear(arr, pos, countOfZero);
            //Console.WriteLine(string.Join(" ", arr));

            //int[] source = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            //int[] destination = new int[source.Length];

            //for (int i = 0; i < source.Length; i++)
            //    //  писане       четене
            //    destination[i] = source[i];
            //Console.WriteLine(string.Join(' ', destination));

            //Метод, който има 2 параметъра (sourceArray, startIndex, endIndex) връща масив "destinationArray"  



            //Array.Copy(source, 4, destination, 2, 3);
            //source.CopyTo(destination, 0);
            //Console.WriteLine(string.Join(" ", destination));
            // Каква е разликата между Copy и CopyTo 


            //List<string> names = new List<string>(); // създава списък от низове
            //names.Add("Peter");
            //names.Add("Maria");
            //names.Add("George");
            //foreach (var name in names)
            //    Console.WriteLine(name); names.Remove("Maria");
            //names.Insert(1, "Insert");
            //Console.WriteLine(String.Join(", ", names));
            var items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(' ', items));














        }
    }
}
