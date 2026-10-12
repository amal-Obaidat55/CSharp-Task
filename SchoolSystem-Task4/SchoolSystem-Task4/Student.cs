using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem_Task4
{
    internal class Student
    {
        public string name;
        public int age;
        public int grade;

        public Student()
        {
            name = "Undefined";
            age = 18;
            grade = 12;
        }
        public Student(string stName, int stAge, int stGrade)
        {
            this.name = stName;
            this.age = stAge;
            this.grade = stGrade;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Student Name : " + name + "\nStudent Age : " + age + "\nStudent Grade : " + grade);
            Console.WriteLine();

        }
    }
}
