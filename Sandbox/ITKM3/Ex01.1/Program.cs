using System;

namespace Ex01._1
{
    class Participant
    {
        private string name;
        private int age;
        private double money;
        public string LastName { private get; set; } // кратка версия (прави и поле, и свойство)

        public Participant(string name, string lastName, int age, double money)
        {
            this.name = name;
            this.LastName = lastName;
            this.age = age;
            this.money = money;

            ////
            //Money = money; // not a good practice 
            ////

            ////
            //if (money < 50)
            //    money = 50;
            //else if (money > 100)
            //    money = 100;
            //this.money = money;
            ////
        }
        public Participant(string name, string lastName, int age) : this(name, lastName, age, 50) { }
        public void SayHello()
        {
            Console.WriteLine($"Здравей от {name} {LastName}.");
        }

        public string Name
        {
            get
            {
                if (age >= 18)
                {
                    return name;
                }
                return "Този човек е твърде млад!";
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    name = "никой";
                }
            }
        }

        //public string LastName
        //{
        //    get { return lastName; }
        //    set { lastName = value; }
        //}



        public int Age
        {
            get
            {
                if (age >= 18)
                {
                    return age;
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value < 50)
                    value = 50;
                else if (value > 100)
                    value = 100;
                money = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Participant myParticipant = new Participant("", "Тошев", 18, 150);
            Console.WriteLine(myParticipant.Money);
            myParticipant.Money = 149;
            Console.WriteLine(myParticipant.Money);
            ////myParticipant.Money = 200;
            //Console.WriteLine(myParticipant.Money);
            //Console.WriteLine(myParticipant.LastName);
        }
    }
}