using System;
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

        public School()
        {

        }

        public School(string name)
        {
            //TODO: Добавете вашия код тук …                  
        }

        public string Name
        {
            get
            {
                return null; ///////////////////
            }                
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            //set
            //{

            //}
        }

        public void AddStudent(string name, double grade)
        {
            Student newStudent = new Student(name, grade); // added grade to a new list in class Student
            this.students.Add(newStudent);
        }

        public double AverageResultInRange(int start, int end)
        {
            List <Student> studentsInRange = students.GetRange(start, end + 1);
            double gradesSum = 0;
            foreach (var student in studentsInRange)
            {
                gradesSum += student.Grade;
            }
            return gradesSum / (end + 1 - start);
        }


        public List<string> RemoveStudentsByGrade(double grade)
        {
            List<string> leftStudents = new List<string>();
            List<Student> removedStudents = new List<Student>();

            foreach (var student in students)
            {
                if (student.Grade < grade)
                {
                    leftStudents.Add(student.Name);
                    removedStudents.Add(student);
                    
                }
            }

            foreach (var student in removedStudents)
            {
                students.Remove(student);
            }

            return leftStudents;
        }

        //public List<Student> SortAscendingByName() // error - has to return void
        //{
        //    return students.OrderBy(x => x.Name).ToList();               
        //}

        //public List<Student> SortDescendingByGrade() // error - has to return void
        //{
        //    return students.OrderByDescending(x => x.Grade).ToList();
        //}

        public void SortAscendingByName() // error - has to return void
        {
            students = students.OrderBy(x => x.Name).ToList();
        }

        public void SortDescendingByGrade() // error - has to return void
        {
            students = students.OrderByDescending(x => x.Grade).ToList();
        }

        public bool CheckStudentIsInSchool(string name)
        {
            foreach (var student in students)
            {
                if (student.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public string[] ProvideInformationAboutAllStudents()
        {
            List<string> info = new List<string>();
            foreach (var student in students)
            {
                info.Add(student.ToString());
            }
            return info.ToArray();              
        }

    }
}
