using System;

namespace Phoenix_Grid_Palindrome
{
    class Program
    {
        static void Main()
        {
            string message = Console.ReadLine();
            bool isPalindrome = true;
            for (int i = 0; i < message.Length / 2; i++)
                if (message[i] != message[message.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            Console.WriteLine(isPalindrome);
        }
    }
}
