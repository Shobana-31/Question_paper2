using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quesion_Paper2
{
    class Program
    {
        static void Main(string[] args)
        {
            //q1();
            //q2();
            //q3();
           // q4();
            //q5();
            //q6();
            q7();
        }
        public static void q1()
        {
            Console.WriteLine("Enter the Number:");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("It's a Positive Number");
            }
            else if (number < 0)
            {
                Console.WriteLine("It's a Negative Number");
            }
            else if (number == 0)
            {
                Console.WriteLine("It's a Zero");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
        }
        public static void q2()
        {
            Console.WriteLine("Enter First Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Numbers are equal");
            }
            else if (num1 != num2)
            {
                Console.WriteLine("Numbers are Not equal");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
        }
        public static void q3()
        {
            Console.WriteLine("Enter First Number:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            float num2 = float.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Numbers are equal");
            }
            else if (num1 != num2)
            {
                Console.WriteLine("Numbers are Not equal");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
        }
        public static void q4()
        {
            Console.Write("Enter the Number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("It's a Even Number");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine("It's a Odd Number");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
        }
        public static void q5()
        {
            Console.WriteLine("Enter a Year:");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else if (year % 4 != 0)
            {
                Console.WriteLine("Not a Leap Year");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
        }
        public static void q6()
        {
            Console.WriteLine("Enter Your Age:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18 && age<=100)
            {
                Console.WriteLine("You are Eligible to Vote");
            }
            else if (age > 0 && age <= 17)
            {
                Console.WriteLine("You are Not Eligible to Vote");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
        }
        public static void q7()
        {
            Console.Write("Enter Your Height:");
            int height = int.Parse(Console.ReadLine());
            if (height <= 250 && height >= 150)
            {
                Console.WriteLine("Tall");
            }
            else if (height <150 && height >=100)
            {
                Console.WriteLine("Medium");
            }
            else if (height < 100)
            {
                Console.WriteLine("short");
            }
            else
            {
                Console.WriteLine("Invaild Data");
            }

        }

    }
}
