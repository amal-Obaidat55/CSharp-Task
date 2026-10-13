using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolsystem_Task5
{
    internal class Person
    {
        public string name;
        public int Age { get; set; }

        //We can't access to this feild outside this class because it's private so this is the access scop of the feild only
        private string _internalCode;
        private string SName;
        private string stuName;
        private int stuAge;

        protected string SchoolName {
            get { return SName; } 
            set { SName = value; }
        }
        public Person(string stuName , int stuAge ,string schoolName) {
            name = stuName;
            Age = stuAge;
            SchoolName = schoolName;
        }

        public Person(string stuName, int stuAge)
        {
            name = stuName;
            Age = stuAge;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name : {name} \nStudent Age : {Age}");
        }
    }
}
