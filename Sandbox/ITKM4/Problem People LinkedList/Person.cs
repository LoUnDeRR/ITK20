using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_People_LinkedList
{
    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Gender;

        public Person(string name, string surname, int age, string gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
    }
}
