using System;

namespace Problem_3._Anonymous_Vox
{
    class Program
    {
        /*
        получаваме кодиран тест - стринг //
        получаваме стойности {value1}{value2}{value3}... //
        намираме кодираните плейсхолдъри 
        заменяме ги със стойностите спрямо индекса им (не са равни)
        пример за плейсхолдър {start}{placeholder}{end}
            start - Английски букви
            placeholder - ASCII
            end - copy на старт
        изписваме резултата
         */
        static void Main()
        {
            string encodedText = Console.ReadLine();
            string[] values = Console.ReadLine().Split(new string[] { "}{", "{", "}" }, StringSplitOptions.RemoveEmptyEntries);


        }
    }
}
