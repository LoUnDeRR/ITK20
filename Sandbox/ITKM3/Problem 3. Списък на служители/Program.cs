using System;
using System.Collections.Generic;

namespace Problem_3._Списък_на_служители
{
    class Employee
    {
        private string name;
        private double salary; // salary
        private string position;
        private string department; // key

        private string email;
        private int age;
        
        public string Assign()
        {
            string[] input = Console.ReadLine().Split();
            name = input[0];
            salary = double.Parse(input[1]);
            position = input[2];
            department = input[3];

            email = input[4];
            age = int.Parse(input[5]);
            return $"{name} {salary} {position} {department} {email} {age}";
        }
    }
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> outputEmployees = new List<string>();
            for (int i = 0; i < n; i++)
            {
                Employee employee = new Employee();
                
            }
        }
    }
}
