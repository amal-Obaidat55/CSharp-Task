using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolsystem_Task5
{
    internal class Student : Person
    {
        public int Grade {  get; set; }
        private int stuId;

        public Student(string stuName, int stuAge, string schoolName , int grade) : base(stuName, stuAge, schoolName)
        {
            Grade = grade;
        }

        public int StudentId { 
            get { return stuId; } 
            set { stuId = value; }
        }
        
        public void DisplaySName()
        {
            Console.WriteLine("School Name : "+ SchoolName);
        }

    }
}
