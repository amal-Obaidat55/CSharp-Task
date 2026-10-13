using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolsystem_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 =new Student("Amal Obaidat" , 21 ,"Tabaria" , 12);
            Student s2 = new Student("Noor Obaidat", 11, "Tonis", 6);
            Student s3 = new Student("Heba Shaheen", 15, "Alshamleh", 9);

            Teacher t1 = new Teacher("Alaa Alawneh", 41, "Math");
            Teacher t2 = new Teacher("Tuqa Obaidat", 33, "English");

            s1.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine();

            s2.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine();

            s3.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine(); 
            Console.WriteLine();

            SchoolReport sr = new SchoolReport("Test");
            sr.DisplayReportTitle();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("               another methods                ");
            Console.WriteLine("==============================================");
            Console.WriteLine();
            s1.DisplaySName();
            Console.WriteLine();
            Console.WriteLine();
            t1.DisplayTeacherInfo();

        }
    }
}
