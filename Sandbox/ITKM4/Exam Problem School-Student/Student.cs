using System;
using System.Collections.Generic;

namespace Exam1
{
    class Student
    {
        private string name;
        private List<double> grades;

        public Student()
        {

        }

        public Student(string name, double grade)
        {
            Name = name;
            this.grades = new List<double>(); // maybe useless
            Grade = grade; // adds to grades via prop
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public double Grade
        {
            get
            {
                return grades[0]; // potential error
            }     
            set
            {
                grades.Add(value);
            }
        }

        public override string ToString()
        {
            string returnStudentInfo = $"Student {this.Name} has {this.Grade:f2}.";
            return returnStudentInfo;
        }

    }
}
