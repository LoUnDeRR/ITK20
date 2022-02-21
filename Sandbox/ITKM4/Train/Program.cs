using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main()
        {
            string[] command = Console.ReadLine().Split();

            switch (command[0])
            {
                case "Add": // Add <номер на влак> <име  на влак> <вид> 
                    AddNewTrain(int.Parse(command[1]), command[2], command[3]);
                    break;
                case "Travel":
                    TravelAllow();
                    break;
                case "Next":
                    NextPrint();
                    break;
            }
            void AddNewTrain(int number, string name, string type)
            {

            }
            void TravelAllow()
            {
                //При тази команда, вие трябва да изведете информацията за влака, 
                //който отпътува и да го премахнете от информацията с чакащи влакове
            }
            void NextPrint()
            {
                // "Next train: <номер на влак> <име на влак> <вид>"
            }
        }
    }
}
