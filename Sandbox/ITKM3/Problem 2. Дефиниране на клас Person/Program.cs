using System;

namespace Problem_2._Дефиниране_на_клас_Person
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
    class Program
    {
        static void Main()
        {
            Person p1 = new Person();
            p1.Name = "Pesho";
            p1.Age = 20;

            Person p2 = new Person();
            p2.Name = "Gosho";
            p2.Age = 18;

            Person p3 = new Person();
            p3.Name = "Stamat";
            p3.Age = 43;
            Console.WriteLine(p1.Name + " " + p1.Age);
            Console.WriteLine(p2.Name + " " + p2.Age);
            Console.WriteLine(p3.Name + " " + p3.Age);
        }
    }
}
