using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Статистика
{
    class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name { get { return name; } }
        public int Age { get { return age; } }
    }
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                people.Add(new Person(input[0], int.Parse(input[1])));
            }
            Console.WriteLine("---");
            foreach (var person in people.Where(x => x.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }
        }
    }
}