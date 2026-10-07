using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name please : ");
            string name = Console.ReadLine();

            Console.Write("Enter your age please : ");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter your grade please : ");
            int grade = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter your average please : ");
            double avg =Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your gender please : ");
            char gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("====== Student Report ======");
            Console.WriteLine();
            Console.WriteLine($"Welcome {name}!..");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Grade : {grade}");
            Console.WriteLine($"Average : {avg}");
            Console.WriteLine($"Gender : {gender}");



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("====== Name Information ======");
            Console.WriteLine();
            Console.WriteLine($"Original Name : {name}");
            Console.WriteLine($"Uppercase : {name.ToUpper()}");
            Console.WriteLine($"Lowercase : {name.ToLower()}");
            Console.WriteLine($"First Character : {name[0]}");

            double newAvg = avg + 5;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("====== Bonus Mark ======");
            Console.WriteLine();
            Console.WriteLine($"Original Average : {avg}");
            Console.WriteLine($"Bonus Marks : 5");
            Console.WriteLine($"New Average : {newAvg}");


            bool isPassed, isAdult ;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("====== Student Status ======");
            Console.WriteLine();
            if(age >= 18)
            {
                isAdult = true;
            }
            else
            {
                isAdult=false;
            }
            if (avg >= 50)
            {
                isPassed = true;
            }
            else
            {
                isPassed = false;
            }
            Console.WriteLine($"New Average : {avg+5}");
            Console.WriteLine($"Passed : {isPassed}");
            Console.WriteLine($"Adult : {isAdult}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.WriteLine("           Student Summary            ");
            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Welcome {name.ToUpper()}!..");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Grade : {grade}");
            Console.WriteLine($"Average : {avg}");
            Console.WriteLine($"New Average : {newAvg}");
            Console.WriteLine($"Gender : {gender}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Passed : {isPassed}");
            Console.WriteLine($"Adult : {isAdult}");
            Console.WriteLine("======================================");






        }
    }
}
