using System;

namespace Problem_2._Семейство
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
    class Family
    {
        int i = 0;
        Person[] people;
        public Family(int n)
        {
            people = new Person[n];
        }
        public void Add(Person person)
        {
            people[i] = person;
            i++;
        }
        public void Print()
        {
            for (int i = 0; i < people.Length; i++)
                Console.WriteLine($"{people[i].Name} {people[i].Age}");
        }
    }
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family(n);
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person person = new Person(input[0], int.Parse(input[1]));
                family.Add(person);
            }
            family.Print();
        }
    }
}
