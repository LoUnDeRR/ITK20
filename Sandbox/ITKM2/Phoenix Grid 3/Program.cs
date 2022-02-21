using System;

class Program
{
    static void Main()
    {
        string message = Console.ReadLine();
        while (message != "ReadMe")
        {
            bool isValid = true;
            if (message.Contains(' ') || message.Contains('_') || message.Contains('\t')) isValid = false;
            else
                for (int i = 3; i <= message.Length - 1; i += 4)
                    if (message[i] != '.') { isValid = false; break; }

            bool isPalindrome = true;
            for (int i = 0; i <= message.Length / 2; i++)
                if (message[i] != message[message.Length - 1 - i])
                { isPalindrome = false; break; }

            if (isValid && isPalindrome) Console.WriteLine("YES");
            else Console.WriteLine("NO");
            message = Console.ReadLine();
        }
    }
}

