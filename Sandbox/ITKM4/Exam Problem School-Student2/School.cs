﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class School
    {
        private string name;

        private List<Student> students = new List<Student>();

        public School(string name)
        {
            Name = name;
        }



        public string Name

        {

            get { return name; }
            set { name = value; }

        }



        public List<Student> Students

        {

            get { return students; }
            set { students = value; }

        }



        public void AddStudent(string name, double grade)

        {

            Student student = new Student(name, grade);
            students.Add(student);

        }



        public double AverageResultInRange(int start, int end)

        {
            double sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += students[i].Grade;
            }
            return sum / (end - start + 1);
        }





        public List<string> RemoveStudentsByGrade(double grade)

        {
            List<string> names = students.FindAll(x => x.Grade < grade).Select(x => x.Name).ToList();
            students.RemoveAll(x => x.Grade < grade);
            return names;
        }



        public List<Student> SortAscendingByName()

        {
            students = students.OrderBy(x => x.Name).ToList();
            return students;

        }



        public List<Student> SortDescendingByGrade()

        {
            students = students.OrderByDescending(x => x.Grade).ToList();
            return students;

        }



        public bool CheckStudentIsInSchool(string name)

        {
            Student s = students.Find(x => x.Name == name);
            return s != null ? true : false;

        }



        public string[] ProvideInformationAboutAllStudents()

        {
            string[] printInfo = new string[students.Count];
            for (int i = 0; i < students.Count; i++)
            {
                printInfo[i] = students[i].ToString();
            }
            return printInfo;
        }
    }
}
