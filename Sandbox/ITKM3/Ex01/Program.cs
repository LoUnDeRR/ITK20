using System;

namespace Ex01
{
    class Participant
    {
        private string name;
        private int age;
        private double money;

        public Participant(string name, int age, double money)
        {
            this.name = name;
            this.age = age;
            this.money = money;
        }
        public Participant(string name, int age) : this(name, age, 50)
        {
        }

        public void SayHello()
        {
            Console.WriteLine($"Здравей от {name}.");
        }
        public string GetName()
        {
            if (age >= 18)
            {
                return name;
            }
            return "Този човек е твърде млад!";
        }
        public void SetName(string newName)
        {
            if (newName != "")
            {
                name = newName;
            }
            else
            {
                name = "никой";
            }
        }
        public int GetAge()
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
        public void SetAge(int newAge)
        {
            if (newAge > 0)
            {
                age = newAge;
            }
        }
        public double GetMoney()
        {
            return money;
        }
        public void SetMoney(double newMoney) // 30
        {
            if (newMoney < 50)
                newMoney = 50;
            else if (newMoney > 100)
                newMoney = 100;
            money = newMoney;
        }


    }
    class Program
    {
        static void Main()
        {
            Participant myParticipant = new Participant("Тошо", 12);
            Console.WriteLine(myParticipant.GetMoney());
            Console.WriteLine(myParticipant.GetName());
            Console.WriteLine(myParticipant.GetAge());
        }
    }
}
