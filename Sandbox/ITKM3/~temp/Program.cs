using System;
using System.Linq;
using System.Collections.Generic;

class Employee
{
    private string name; // Име
    private double salary; // Заплата
    private string position; // Длъжност
    private string department; // Отдел
    private string email; // Ел. поща
    private int age; // Възраст

    public Employee(string name, double salary, string position, string department, string email, int age)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = email;
        this.age = age;
    }

    public Employee(string name, double salary, string position, string department, string email) : this(name, salary, position, department, email, -1)
    {

    }

    public Employee(string name, double salary, string position, string department, int age) : this(name, salary, position, department, "n/a", age)
    {

    }

    public Employee(string name, double salary, string position, string department) : this(name, salary, position, department, "n/a", -1)
    {

    }
}

class MainApp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // <department, List<Employee>>
        Dictionary<string, List<Employee>> employees = new Dictionary<string, List<Employee>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            if (input.Length == 4)
            {
                if (employees.ContainsKey(input[3]))
                {
                    employees[input[3]].Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3]));
                }
                else
                {
                    employees[input[3]] = new List<Employee>(); // Правим отдела
                    employees[input[3]].Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3]));
                }
            }
            else if (input.Length == 6)
            {
                if (employees.ContainsKey(input[3]))
                {
                    employees[input[3]].Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], input[4], int.Parse(input[5])));
                }
                else
                {
                    employees[input[3]] = new List<Employee>(); // Правим отдела
                    employees[input[3]].Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], input[4], int.Parse(input[5])));
                }
            }
            else
            {
                var myInput;
                if (int.TryParse(input[4], out int result))
                {
                    if (employees.ContainsKey(input[3]))
                    {
                        var myVar = 1;
                        employees[input[3]].Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], int.Parse(input[4])));
                    }
                    else
                    {
                        employees[input[3]] = new List<Employee>(); // Правим отдела
                        employees[input[3]].Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], int.Parse(input[4])));
                    }
                }
                else
                {
                    if (employees.ContainsKey(input[3]))
                    {
                        employees[input[3]].Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], input[4]));
                    }
                    else
                    {
                        employees[input[3]] = new List<Employee>(); // Правим отдела
                        employees[input[3]].Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], input[4]));
                    }
                }
            }
        }
    }
}