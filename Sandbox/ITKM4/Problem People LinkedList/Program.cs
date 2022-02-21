using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_People_LinkedList
{
    class Program
    {
        static void Main()
        {
            LinkedList<Person> people = new LinkedList<Person>();
            string[] command;
            while ((command = Console.ReadLine().Split())[0] != "End")
            {
                switch (command[0]) // John Atanasov 22 Male
                {
                    case "Add": // Add John Atanasov 22 Male
                        people.AddLast(new Person(command[1], command[2], int.Parse(command[3]), command[4]));
                        break;
                    case "InsertAt": // InsertAt 2 John Atanasov 22 Male
                        var node = people.First;
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            node = node.Next;
                        }
                        people.AddBefore(node, new LinkedListNode<Person>(new Person(command[2], command[3], int.Parse(command[4]), command[5])));
                        break;
                    case "RemoveItem": // RemoveItem John Atanasov
                        var itemNode = people.First;
                        for (int i = 0; i < people.Count; i++)
                        {
                            if (itemNode.Value.Name == command[1] && itemNode.Value.Name == command[2])
                            {
                                people.Remove(itemNode);
                                break;
                            }
                            itemNode = itemNode.Next;
                        }
                        break;
                    case "RemoveIndex": // RemoveIndex 0
                        var indexNode = people.First;
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            indexNode = indexNode.Next;
                        }
                        people.Remove(indexNode);
                        break;
                    case "SortBy": // SortBy Name/Age/Gender A/D
                        switch (command[1])
                        {
                            case "Name":
                                if (command[2] == "A")
                                {
                                    people = new LinkedList<Person>(people.OrderBy(x => x.Name).ThenBy(x => x.Surname));
                                }
                                else
                                {
                                    people = new LinkedList<Person>(people.OrderByDescending(x => x.Name).ThenBy(x => x.Surname));
                                }
                                break;
                            case "Age":
                                if (command[2] == "A")
                                {
                                    people = new LinkedList<Person>(people.OrderBy(x => x.Age));
                                }
                                else
                                {
                                    people = new LinkedList<Person>(people.OrderByDescending(x => x.Age));
                                }
                                break;
                            case "Gender":
                                if (command[2] == "A")
                                {
                                    people = new LinkedList<Person>(people.OrderBy(x => x.Gender).ToArray());
                                }
                                else
                                {
                                    people = new LinkedList<Person>(people.OrderByDescending(x => x.Gender));
                                }
                                break;
                        }
                        break;
                    case "Print":
                        foreach (var person in people)
                        {
                            Console.WriteLine($"{person.Name} {person.Surname} {person.Age} {person.Gender}");
                        }
                        break;
                }
            }
        }
    }
}
