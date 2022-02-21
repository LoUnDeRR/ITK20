using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Сортиране_на_кратки_думи
{
    class Program
    {
        static void Main()
        {
            char[] splitters = { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            string[] text = Console.ReadLine().Split(splitters , StringSplitOptions.RemoveEmptyEntries);
            //text = text.Where(text => text.Length < 5).ToArray();
            //text = text.OrderBy(y => y).ToArray();
            //text = text.Select(x => x.ToLower()).ToArray();
            text = text.Where(text => text.Length < 5).OrderBy(y => y).Select(x => x.ToLower()).Distinct().ToArray();
            //List<string> textFiltered = new List<string>();
            //for (int i = 0; i < text.Length; i++)
            //    if (text[i].Length < 5)
            //        textFiltered.Add(text[i].ToLower());
            //textFiltered.Sort();

            Console.WriteLine(String.Join(", ", text));
        }
    }
}
