using System;
using System.Linq;

namespace Problem_3._Phoenix_Grid
{
    class Program
    {            /*
            Повтаряме до фраза "ReadMe" //
            Получаваме криптирани съобщения //
            Проверяваме дали е валидно //
            Проверяваме дали е палиндром //
            Принтираме YES или NO //



            Валидно криптирано съобщение има:
                поне една фраза//
                точки между фразите //
                3 знака//
                няма празно пространство или '_'//
                палиндром е//
            // asd.dsa”, “123.312”, “3@a.231”, “111”, “@sd”, “132.31$.ddd
             */
        // check if all phrases are 3 chars long



        static bool isPhraseLength3(string phrase)
        {
            string[] phraseArray = phrase.Split('.').ToArray(); // разделя валида на фрази
            bool lengthIs3 = false; // флаг за дължина 3
            for (int i = 0; i < phraseArray.Length; i++) // 
            {
                if (phraseArray[i].Length == 3 || phraseArray[i].Length == 0) // A phrase consists of exactly 3 characters. - не е спазено, защото е грешно условието
                {
                    lengthIs3 = true;
                }
            }
            return lengthIs3;
        }
        static void Main()
        {


            bool isValid = false;
            string phrase = Console.ReadLine(); // четем фразата
            while (phrase != "ReadMe") // докато не е "ReadMe"
            {
                if (isPhraseLength3(phrase) == true) // фразата е 3 знака по големина (или по-малко) // объркващо
                {
                    if (phrase.Any(Char.IsWhiteSpace) == false && phrase.Contains('_') == false) //не съдържа забранен знак
                    {
                        if (phrase == String.Join("", phrase.Reverse()) == true) //проверяваме дали е палиндром
                        {
                            isValid = true;
                        }
                    }
                }
                
                if (isValid == true)
                    Console.WriteLine("YES");
                if (isValid == false)
                    Console.WriteLine("NO");

                isValid = false;
                phrase = Console.ReadLine();
            }
        }
    }
}
