using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("========== Student Information ==========");
            Console.WriteLine();
            Console.WriteLine("*** Question 1,2,3 ***");
            Console.WriteLine();
            Student st1 = new Student();
            st1.name = "Amal";
            st1.age = 21;
            st1.grade = 12;

            st1.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*** Question 4 ***");
            Console.WriteLine();
            Student stu1 = new Student();
            Student stu2 = new Student();
            Student stu3 = new Student();

            stu1.name = "Ahmad";
            stu2.name = "Sara";
            stu3.name = "Omar";

            stu1.DisplayInfo();
            stu2.DisplayInfo();
            stu3.DisplayInfo();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*** Question 5 ***");
            Console.WriteLine();
            Student student = new Student("Tuqa" , 12 , 20);
            student.DisplayInfo();


        }
    }
}
