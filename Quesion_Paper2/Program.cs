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
           // q7();
           // q8();
           // q9();
           // q10();
            //q11();
            q12();
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
        public static void q8()
        {
            Console.WriteLine("To Find Maximum Value");
            Console.WriteLine("Enter Number1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number3");
            int num3 = int.Parse(Console.ReadLine());
            int max = num1;
            if (num2>max)
            {
                max = num2; 
            }
            else if (num3>max)
            {
                max = num3;
            }
            Console.WriteLine("Maximum Number is:"+max);
        }
        public static void q9()
        {
            Console.WriteLine("To Find Minimum Value");
            Console.WriteLine("Enter Number1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number3");
            int num3 = int.Parse(Console.ReadLine());
            int min = num1;
            if (num2 < min)
            {
                min = num2;
            }
            else if (num3 < min)
            {
                min = num3;
            }
            Console.WriteLine("Minimum Value:"+min);
        }
        public static void q10()
        {
            Console.WriteLine("To Find Maximum Value");
            Console.WriteLine("Enter Number1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number3");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number4");
            int num4 = int.Parse(Console.ReadLine());
            int max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            else if (num3 > max)
            {
                max = num3;
            }
            else if (num4 > max)
            {
                max = num4;
            }
            Console.WriteLine("Maximum Number is:" + max);
        }
        public static void q11()
        {
            Console.WriteLine("Enter Number1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int b= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number3");
            int c = int.Parse(Console.ReadLine());
            int ab_diff =Math.Abs(a - b);
            int bc_diff =Math .Abs(b - c);
            int ac_diff =Math .Abs (a - c);
            if (ab_diff<bc_diff && ab_diff <ac_diff )
            {
                Console.WriteLine("A and B Closer");
            }
            if (bc_diff <ab_diff && bc_diff <ac_diff )
            {
                Console.WriteLine("B and C Closer");
            }
            if (ac_diff < ab_diff && ac_diff < bc_diff)
            {
                Console.WriteLine("C and A Closer");
            }           
        }
        public static void q12()
        {
            Console.WriteLine("Enter Number1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number3");
            int c = int.Parse(Console.ReadLine());
            int ab_diff = Math.Abs(a - b);
            int bc_diff = Math.Abs(b - c);
            int ac_diff = Math.Abs(a - c);
            if (ab_diff > bc_diff && ab_diff > ac_diff)
            {
                Console.WriteLine("A and B Farther");
            }
            if (bc_diff > ab_diff && bc_diff > ac_diff)
            {
                Console.WriteLine("B and C Farther");
            }
            if (ac_diff > ab_diff && ac_diff > bc_diff)
            {
                Console.WriteLine("C and A Farther");
            }
        }
    }
}
