using System;

namespace Problem_1._Дефиниране_на_клас_Банкова_сметка
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = ID;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = Balance;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            BankAccount acc = new BankAccount();
            acc.ID = 1;
            acc.Balance = 15;
        }
    }
}
