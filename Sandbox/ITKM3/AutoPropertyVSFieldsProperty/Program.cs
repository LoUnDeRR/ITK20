using System;
using System.Collections.Generic;
using System.Linq;
class Employee
{
    public string name;
    public double salary;
    public string position;
    public string dept;
    public string mail;
    public int age;


    public Employee(string[] args) //6
    {
        this.name = args[0];
        this.salary = double.Parse(args[1]);
        this.position = args[2];
        this.dept = args[3];

        if (args.Length >= 5)
            this.mail = args[4];
        else
            this.mail = "n/a";

        if (args.Length == 6)
            this.age = int.Parse(args[5]);
        else
            this.age = -1;

    }
}
class Program
{
    static void Main()
    {
        List<Employee> Employees = new List<Employee>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            Employees.Add(new Employee(input));
        }
        Dictionary<string, List<string>> depts = new Dictionary<string, List<string>>();
        foreach (var employee in Employees)
        {
            if (depts.ContainsKey(employee.dept))
            {
                depts[employee.dept].Add($"{employee.name} {employee.salary:f2} {employee.mail} {employee.age}");
            }
            else
            {
                depts[employee.dept] = new List<string>();
                depts[employee.dept].Add($"{employee.name} {employee.salary:f2} {employee.mail} {employee.age}");
            }
        }

        KeyValuePair<string, double> deptAvg = new KeyValuePair<string, double>(null, 0);
        foreach (var pair in depts)
        {
            double sum = 0;
            foreach (var itemInList in pair.Value)
            {
                sum += double.Parse(itemInList.Split()[1]); // иска преработка

            }
            if (deptAvg.Value <= sum / pair.Value.Count)
            {
                deptAvg = new KeyValuePair<string, double>(pair.Key, sum / pair.Value.Count);
            }

        }
        Console.WriteLine($"Highest Average Salary: {deptAvg.Key}");
        foreach (var list in depts.Values)
        {
            list.Sort();
            //list.OrderBy(info => info.Split()[1]);
        }
        foreach (var item in depts[deptAvg.Key].OrderBy(info => info.Split()[1]))
        {
            Console.WriteLine(item);
        }
    }
}