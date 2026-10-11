using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rand = random.Next(50, 76);
            int count = 0;


            Console.WriteLine("================== Guessing Game ==================");
            Console.WriteLine();
            Console.WriteLine();
            while (true) {
                Console.Write("Guess a number between 50 and 75 : ");
                int num = Convert.ToInt32(Console.ReadLine());
                count++;
                if (rand == num)
                {
                    Console.WriteLine("Congratulations !");
                    break;
                }
                else
                {
                    if (rand >= num)
                    {
                        Console.WriteLine("Try a higher number");
                    }
                    else
                    {
                        Console.WriteLine("Try a lower number");
                    }
                }
            }

            int points = 0;
            switch (count)
            {
                case 1: 
                    points = 10;
                    break;
                case 2:
                    points = 7;
                    break;
                case 3:
                    points = 5;
                    break;
                default:
                    points = 0;
                    break;
            }

            Console.WriteLine("Attemps : "+count);
            Console.WriteLine("Points : "+ points);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            string[] stuName = { "Ahmad", "Sara", "Omar", "Lina", "Yazan" };
            Console.WriteLine("Student Names : ");
            for (int i=0; i<stuName.Length;i++) {
                Console.Write(i+1 + ". " + stuName[i] +"\n");
            }
            Console.WriteLine();
            Console.WriteLine("Student Grades : ");
            int[] grades = { 85, 92, 68, 75, 90 };
            foreach (int grade in grades) {
                Console.Write(grade + "\n");
            }
            Console.WriteLine();

            Console.Write("Enter Student Name to search for him : ");
            string name=Console.ReadLine();
            int x = stuName.Length-1;
            bool isFound = false;
            while (x>=0)
            {
                if (name==stuName[x])
                {
                    isFound = true;
                    break;
                }
                else
                {
                    isFound=false;
                }
                x--;
            }
            if (isFound == true) {
                Console.WriteLine("Student Found!!");
            }
            else
            {
                Console.WriteLine("Student Not Found!!");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter the student result : ");
            int stuGrade = Convert.ToInt32(Console.ReadLine());

            if (stuGrade <= 100 && stuGrade >= 90) {
                Console.WriteLine("Excellent..");
            }
            else if(stuGrade <= 89 &&  stuGrade >= 80)
            {
                Console.WriteLine("Very Good..");
            }
            else if( stuGrade <= 79 && stuGrade >= 70)
            {
                Console.WriteLine("Good..");
            }
            else if(stuGrade <= 69 && stuGrade >= 60)
            {
                Console.WriteLine("Pass..");
            }
            else
            {
                Console.WriteLine("Fail!");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("======== School System ========");
            Console.WriteLine();

            
            
 

            int choice = 0;
            do
            {
                Console.Write("1. Display Students \n 2. Search for Student \n 3. Check Student Result \n 4. Exit \n Choose a number : ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (choice) {
                    case 1:
                        for (int i = 0; i < stuName.Length; i++)
                        {
                            Console.Write(i + 1 + ". " + stuName[i] + "\n");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Enter Student Name to search for him : ");
                        name = Console.ReadLine();
                        x = stuName.Length - 1;
                        isFound = false;
                        while (x >= 0)
                        {
                            if (name == stuName[x])
                            {
                                isFound = true;
                                break;
                            }
                            else
                            {
                                isFound = false;
                            }
                            x--;
                        }
                        if (isFound == true)
                        {
                            Console.WriteLine("Student Found!!");
                        }
                        else
                        {
                            Console.WriteLine("Student Not Found!!");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Enter the student result : ");
                        stuGrade = Convert.ToInt32(Console.ReadLine());

                        if (stuGrade <= 100 && stuGrade >= 90)
                        {
                            Console.WriteLine("Excellent..");
                        }
                        else if (stuGrade <= 89 && stuGrade >= 80)
                        {
                            Console.WriteLine("Very Good..");
                        }
                        else if (stuGrade <= 79 && stuGrade >= 70)
                        {
                            Console.WriteLine("Good..");
                        }
                        else if (stuGrade <= 69 && stuGrade >= 60)
                        {
                            Console.WriteLine("Pass..");
                        }
                        else
                        {
                            Console.WriteLine("Fail!");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 4:
                        break;
                    default: 
                        Console.WriteLine("Enter valid number");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                }
            }
            while (choice!=4);
            

        }
    }
}
