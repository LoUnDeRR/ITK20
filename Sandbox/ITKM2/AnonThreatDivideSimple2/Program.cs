using System;
class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int parts = int.Parse(Console.ReadLine());

        int partLength = s.Length / parts;

        int pos = 0;
        for (int p = 1; p < parts; p++, pos += partLength)
            Console.Write(s.Substring(pos, partLength) + ' ');
        Console.Write(s.Substring(pos));
    }
}