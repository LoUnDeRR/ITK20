using System;

namespace IOOP_Basic
{
    class Participant
    {
        private string _name;
        private int _age;
        public string LastName { private get; set; } 

        public Participant(string name, int age)
        {
            _name = name;
            _age = age;
            Console.WriteLine("!");
        }
        public Participant(string name)// : this (name, -1) // ! + !!
        {
            _name = name; // remove if using " : this(...)" ("this.name = name;" repeats)
            Console.WriteLine("!!");
        }
        
        public void MyMethod(string myString)
        {
            Console.WriteLine("This is MyMethod!");
            Console.WriteLine(_name + " - " + _age + " // " + myString);
        }

        public string Name
        {
            get
            {
                return _name + " (get)";
            }
            set
            {
                _name = value + " (set)";
            }
        }
        
        //public string GetName()
        //{
        //    return name;
        //}
        //public void SetName(string newName)
        //{
        //    name = newName;
        //}
    }

    class Program
    {
        static void Main()
        {
            Participant myP = new Participant("Name"); // ! / !!
            myP.MyMethod("My String");
            Console.WriteLine(myP.Name); // get
            myP.Name = "NewName"; // set
            Console.WriteLine(myP.Name); // (set) get
        }
    }
}