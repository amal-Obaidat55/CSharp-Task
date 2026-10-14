using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolsystem_Task5
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(string TName, int TAge, string sub) : base(TName, TAge )
        {
            Subject = sub;
        }
        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Teacher Name : {name}  \nTeacher Age : {Age} \nTeacher Subject : {Subject}");
        }
    }
}
