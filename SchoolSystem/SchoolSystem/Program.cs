using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Noor Ahmad";
            int age = 18;
            int grade = 12;
            double avg = 85.5;
            char gender = 'F';
            bool isActive = true;

            Console.WriteLine("===== Student Information =====");
            Console.WriteLine();
            Console.WriteLine("Student Name : " + name);
            Console.WriteLine("Student Age : " + age);
            Console.WriteLine("Student Grade : " + grade);
            Console.WriteLine("Student Average : " + avg);
            Console.WriteLine("Student Gender : " + gender);
            Console.WriteLine("Is Student Active : " + isActive);
            Console.WriteLine();
            Console.WriteLine();


            string[] stuNames = { "Amal Obaidat", "Heba Shaheen", "Mayar Safi", "Rahma Aldos", "Sarah Alshirsh" };
            Console.WriteLine("===== Students =====");
            Console.WriteLine();
            Console.WriteLine("Student 1 : " + stuNames[0]);
            Console.WriteLine("Student 2 : " + stuNames[1]);
            Console.WriteLine("Student 3 : " + stuNames[2]);
            Console.WriteLine("Student 4 : " + stuNames[3]);
            Console.WriteLine("Student 5 : " + stuNames[4]);
            Console.WriteLine();
            Console.WriteLine("Number of Students : " + stuNames.Length);
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("===== Before Changes =====");
            Console.WriteLine();
            Console.WriteLine("Student 1 : " + stuNames[0]);
            Console.WriteLine("Student 2 : " + stuNames[1]);
            Console.WriteLine("Student 3 : " + stuNames[2]);
            Console.WriteLine("Student 4 : " + stuNames[3]);
            Console.WriteLine("Student 5 : " + stuNames[4]);
            Console.WriteLine();



            stuNames[3] = "Fatema Mosleh";
            Console.WriteLine("===== After Changes =====");
            Console.WriteLine();
            Console.WriteLine("Student 1 : " + stuNames[0]);
            Console.WriteLine("Student 2 : " + stuNames[1]);
            Console.WriteLine("Student 3 : " + stuNames[2]);
            Console.WriteLine("Student 4 : " + stuNames[3]);
            Console.WriteLine("Student 5 : " + stuNames[4]);
            Console.WriteLine();
        }
    }
}
