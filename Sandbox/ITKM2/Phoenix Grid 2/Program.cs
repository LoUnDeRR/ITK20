using System;

namespace Phoenix_Grid_2
{
    class Program
    {
        static bool Valid(string s)
        {
            if ((s.Length - 3) % 4 != 0) return false; // невалидна дължина
            for (int i = 0; i < s.Length; i++)
                if ((i + 1) % 4 != 0) // не е на позиция на точка
                {
                    if (s[i] == ' ' || s[i] == '\t' || s[i] == '_') //char.IsWhiteSpace + '_'
                        return false;
                }
                else // е на позиция на точка
                    if (s[i] != '.') return false;
            return true;
        }

        static bool Palindrome(string message)
        {
            for (int i = 0; i < message.Length / 2; i++)
                if (message[i] != message[message.Length - 1 - i])
                    return false;
            return true;
        }

        static void Main() // палиндром 123.321 обхождаме от двете страни
        {
            string input = Console.ReadLine();
            while (input != "ReadMe")
            {
                if (Valid(input) == true && Palindrome(input) == true)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
                input = Console.ReadLine();
            }

        }
    }
}
