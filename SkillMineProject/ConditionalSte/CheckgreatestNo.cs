using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalSte
{
    class CheckgreatestNo
        // Nested Ifelse 
    {
        static void Main(string[] args)
        {
            int year, marks;
            Console.WriteLine("enter the year");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the marks");
            marks = int.Parse(Console.ReadLine());

            if(year==2022)
            {
                if(marks>60)
                {
                    Console.WriteLine("candidate is eligibale for the interview");
                }
                else
                {
                    Console.WriteLine("Marks is less than 60%");
                }
            }
            else
            {
                Console.WriteLine("Candidate is not selected");
            }
        }
    }

    //Que1.  greatest no in between 3 number
    class Inbetween3No
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter the num1 value");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num2 value");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num3 value");
            num3 = int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine("num1 is greater");

                }
                else
                {
                    Console.WriteLine("num3 is grater");
                }
            }
            else
            {
                Console.WriteLine("num2 is grater");
            }
        }
    }

    //to check the either digit , charactor, or spacial char using nested if else.

    class Either
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter the char");
            ch = Convert.ToChar(Console.ReadLine());

            if ((ch <= 'A' && ch <= 'Z')||(ch<='a' && ch<='z'))
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch <= '0' && ch <= '9')
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("special char");
            }
        }
    }

    // to check given year is leep year or not

    class LeepYear
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter the year");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("leep year");
            }
            else if(year % 400 == 0)
            {
                Console.WriteLine("century Year");
            }
            else
            {
                Console.WriteLine("Not leep year");
            }
        }
    }

    //check leepyear
   /* class checkleepyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", Year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year.", Year);
                Console.ReadLine();
            }
        }        
    }*/

    //Que3.  5 subject marks % display
    class FiveSub
    {
        static void Main(string[] args)
        {
            int phy, che, math, eng, hin;
            Console.WriteLine("enter the phy marks");
            phy = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the che marks");
            che = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the math marks");
            math = int.Parse(Console.ReadLine());

            Console.WriteLine("entr the eng marks");
            eng = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the hin marks");
            hin = int.Parse(Console.ReadLine());

            int result = ((phy + che + math + eng + hin) / 500)*100;

            Console.WriteLine(result);

            if (result > 75)
            {
                Console.Write("Student grad is distingtion");
            }
            else if(result > 60 && result > 75)
            {
                Console.Write("Student grad is First class");
            }
            else if(result > 50 && result > 60)
            {
                Console.Write("Student grad is Second class");
            }
            else if(result > 35 && result > 50)
            {
                Console.Write("Student grad is pass");
            }
            else
            {
                Console.Write("Student grad is fail");
            }
        }
    }
}
