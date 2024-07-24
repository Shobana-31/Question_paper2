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
           // q12();
           // q13();
           // q14();
           // q15();
           // q16();
            //q17();
           // q18();
            //q19();
            q20();
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
        public static void q13()
        {
            Console.WriteLine("Enter Number1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number3");
            int c = int.Parse(Console.ReadLine());
            int min = a;
            if (b< min)
            {
                min = b;
            }
            else if (c < min)
            {
                min = c;
            }
            int max = a;
            if (b > max)
            {
                max = b;
            }
            else if (c > max)
            {
                max = c;
            }
            int add = a + b + c;
            int r= max+min;
            int mid = add - r;
            Console.WriteLine("Sort Numbers:");
            Console.WriteLine(min);
            Console.WriteLine(mid);
            Console.WriteLine(max);
        }
        public static void q14()
        {
            Console.WriteLine("Enter Value1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value3:");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 + num2 + num3 == 180)
            {
                Console.WriteLine("Triangle can be formed");
            }
            else
            {
                Console.WriteLine("Triangle can not be formed");
            }
        }
        public static void q15()
        {
            Console.WriteLine("Enter X value:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y value:");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y < 0)
            {
                Console.WriteLine("I Part");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("II Part");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("III Part");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("IV Part");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Starting..");
            }
            else if (x < 0 || x > 0 && y == 0)
            {
                Console.WriteLine("X Axis");
            }
            else if (y < 0 || y > 0 && x == 0)
            {
                Console.WriteLine("Y Axis");
            }
        }
        public static void q16()
        {
            Console.WriteLine("Enter a Character:");
            char character = char.Parse(Console.ReadLine());
            switch (character)
            {
                case 'a':
                    Console.WriteLine("Given Character is Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Given Character is Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Given Character is Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Given Character is Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Given Character is Vowel");
                    break;
                case 'A':
                    Console.WriteLine("Given Character is Vowel");
                    break;
                case 'E':
                    Console.WriteLine("Given Character is Vowel");
                    break;
                case 'I':
                    Console.WriteLine("Given Character is Vowel");
                    break;
                case 'O':
                    Console.WriteLine("Given Character is Vowel");
                    break;
                case 'U':
                    Console.WriteLine("Given Character is Vowel");
                    break;
                default :
                    Console.WriteLine("Given Character is Consonant");
                    break;
            }
        }
        public static void q17()
        {
            Console.Write("Enter the Number of Sides:");
            int side = int.Parse(Console.ReadLine());
            switch (side)
            {
                case 3:
                    Console.WriteLine("Triangle");
                    break;
                case 4:
                    Console.WriteLine("Square");
                    break;
                case 5:
                    Console.WriteLine("Pentagon");
                    break;
                case 6:
                    Console.WriteLine("Hexagon");
                    break;
                case 7:
                    Console.WriteLine("Heptagon");
                    break;
                case 8:
                    Console.WriteLine("Octagon");
                    break;
                case 9:
                    Console.WriteLine("Nonagon");
                    break;
                case 10:
                    Console.WriteLine("Decagon");
                    break;
                default:
                    Console.WriteLine("Invaild Input");
                    break;
            }
        }
        public static void q18()
        {
            Console.WriteLine("Enter Month:");
            string month = Console.ReadLine();
            if (month == "jan" || month == "mar" || month == "may" || month == "july" || month == "aug" || month == "oct" || month == "dec")
            {
                Console.WriteLine("31 Days");
            }
            else if (month == "apr" || month == "june" || month == "sep" || month == "nov")
            {
                Console.WriteLine("30 Days");
            }
            else if (month == "feb")
            {
                Console.WriteLine("28 Days");
            }
            else
            {
                Console.WriteLine("Invaild Input");
            } 
        }
        public static void q19()
        {
            Console.WriteLine("Enter Day:");
            int day = int.Parse(Console.ReadLine());
            if (day % 7 == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (day % 7 == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day % 7 == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (day % 7 == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (day % 7 == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (day % 7== 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (day % 7 == 0)
            {
                Console.WriteLine("Sunday");
            }
        }
        public static void q20()
        {
            Console.WriteLine("Enter Side1 Length");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Side2 Length");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Side3 Length");
            int c = int.Parse(Console.ReadLine());
            if ((a == b) && (b == c))
            {
                Console.WriteLine("Equilateral");
            }
            else if ((a > b) || (a > c))
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
        }
    }
}
