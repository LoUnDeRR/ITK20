﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Student
    {
        private string name;

        private double grade;


        public Student(string name, double grade)
        {

            Name = name;
            Grade = grade;

        }

        public string Name

        {
            get { return name; }
            set { name = value; }
        }

        public double Grade

        {
            get { return grade; }
            set { grade = value; }
        }



        public override string ToString()

        {

            return $"Student {Name} has {grade:F2}.";

        }
    }
}