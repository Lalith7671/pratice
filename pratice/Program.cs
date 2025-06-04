using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //even();
            //voter();
            //leapyear();
            //number();
            // maximum();
            //maxandmin();
            upper();
        }
        public static void even()
        {
            Console.WriteLine("enter a value:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} is an even number", a);
            }
            else
            {
                Console.WriteLine("{0} is an odd number", a);

            }

        }
        public static void voter()
        {
            Console.WriteLine("enter age of voter:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("voter is eligible for voting");

            }
            else
            {
                Console.WriteLine("voter is not eligible for voting");

            }

        }
        public static void leapyear()
        {
            Console.WriteLine("enter any year:");
            int leap = Convert.ToInt32(Console.ReadLine());
            if (leap % 4 ==0)
            {
                if(leap%100==0)
                {
                    if (leap % 400 == 0)
                    {
                        Console.WriteLine("{0} it is a leap year", leap);
                    }
                }
            }
            else
            {
                Console.WriteLine("{0} it is not a leap year",leap);

            }
        }
        public static void number()
        {
            Console.WriteLine("enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("it is positive number");

            }
            else if (a==0)
            {
                Console.WriteLine("it is a zero");

            }
            else
            {
                Console.WriteLine("it is a negative number");

            }

        }
        public static void maximum()
        {
            Console.WriteLine("enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b number:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} is maximum number",a);

            }
            else
            {
                Console.WriteLine("{0} is maximum number",b);

            }

        }
        public static void maxandmin()
        {
            Console.WriteLine("enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c number:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a>c) 
            {
                Console.WriteLine("{0} is maximum number", a);

            }
            else if (b > c && b>a)
            {
                Console.WriteLine("{0} is maximum number", b);

            }
            else
            {
                Console.WriteLine("{0} is maximum number", c);

            }

        }
        public static void upper()
        {
            Console.WriteLine("enter a charater:");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch >= 'A' && ch<='Z')
            {
                Console.WriteLine("upper case");

            }
            else if (ch>= 'a'&&ch<='z')
            {
                Console.WriteLine("lower case");

            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("digit");

            }
            else if (ch == ' ')
            {
                Console.WriteLine("space");

            }
            else
            {
                Console.WriteLine("spical charater");

            }

        }



    }
}
