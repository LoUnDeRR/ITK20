using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_4._Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> squads = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" -> ");
            string creature = input[0];
            string squadMate = input[1];
            while (creature != "Blaze it!")
            {
                squadMate = input[1];

                if (creature != squadMate)
                {
                    if (!squads.ContainsKey(creature))
                    {
                        squads[creature] = new List<string>();
                        squads[creature].Add(squadMate);
                    }
                    else
                        if (!squads[creature].Contains(squadMate))
                        squads[creature].Add(squadMate);
                }

                input = Console.ReadLine().Split(" -> ");
                creature = input[0];
            }

            foreach (var squad in squads)
                foreach (var mate in squad.Value.ToList())
                    if (squads.ContainsKey(mate) && squads[mate].Contains(squad.Key))
                    {
                        squads[mate].Remove(squad.Key);
                        squads[squad.Key].Remove(mate);
                    }

            foreach (var item in squads.OrderByDescending(x => x.Value.Count))
                Console.WriteLine(item.Key + " : " + item.Value.Count);
        }
    }
}
