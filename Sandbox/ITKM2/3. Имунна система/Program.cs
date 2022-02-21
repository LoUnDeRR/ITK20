using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Имунна_система
{
    class Program
    {
        static void Main()
        {
            // сумата от кодовете на всички букви в името на вируса, разделена на 3 = силата на вируса
            // силата на вируса умножено по дължината на името на вируса = времето за побеждаване на вируса
            // превърнете времето в минути и секунди, като не използвате водещи нули
            // Ако имунната система победи вируса: “{virusName}defeated in {virusDefeatMinutes}m {virusDefeatSeconds}s.”
            // в противен случай изведете “Immune System Defeated.”
            // След като вируса е победен, имунната система си възвръща 20% от нейната сила
            // Ако 20-те процента надвишават първоначалната сила на имунната система, задайте състоянието ѝ до нейната първоначална сила.
            // Ако се срещне един и същ вирус последователно, НЕ намалявайте времето за неговата победа допълнително
            // Когато получите “end”, изведете статуса на имунната система във формата “Final Health: {finalHealth}”.

            int iSystemStrength = int.Parse(Console.ReadLine());
            int iSystemStrOriginal = iSystemStrength;
            List<string> defeatedViruses = new List<string>();
            string lastVirus = "";
            string virus = Console.ReadLine();
            while (virus != "end")
            {

                int virusStrength = 0; // Това е сумата от кодовете на всички букви в името на вируса, разделена на 3.
                foreach (char letter in virus)
                    virusStrength += (int)letter;
                virusStrength /= 3;


                int virusDefeatSeconds = virusStrength * virus.Length;
                if (defeatedViruses.Contains(virus) && lastVirus != virus)
                    virusDefeatSeconds /= 3;
                else
                    defeatedViruses.Add(virus);
                TimeSpan virusDefeatTime = TimeSpan.FromSeconds(virusDefeatSeconds);

                Console.WriteLine($"Virus {virus}: {virusStrength} => {virusDefeatSeconds} seconds");
                if (iSystemStrength > virusStrength)
                {
                    Console.WriteLine($"{virus} defeated in {virusDefeatTime.Minutes}m {virusDefeatTime.Seconds}s.");

                    iSystemStrength = iSystemStrength - virusDefeatSeconds;
                    if (iSystemStrength > iSystemStrOriginal)
                        iSystemStrength = iSystemStrOriginal;

                    Console.WriteLine($"Remaining health: {iSystemStrength}");
                    iSystemStrength += (int)(iSystemStrength * 0.2);
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }




                lastVirus = virus;
                virus = Console.ReadLine();
            }
            if (virus == "end")
            {
                Console.WriteLine($"Final Health: {iSystemStrength}");

            }


        }
    }
}
