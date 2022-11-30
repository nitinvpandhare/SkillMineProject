using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalSte

    //All Que
{
    //check number is positiv or nigativ
    class NumberPoN
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the Number ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("num is +ve");
            }
            else
            {
                Console.WriteLine("num is -ve");
            }
        }
    }
    //check the number is divisibale by 3 or 9

    class Nodivisible
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 3 == 0) // || num % 9 == 0
            {
                Console.WriteLine("number is divisible by 3");
            }
            else
            {
                Console.WriteLine("number is divisible by 9");
            }
        }
    }

    //check the dayNo from user and display dayName as per the input

    class DaynoDayname
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the num ");
            num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("Day is Monday");
            }
            else if (num == 1)
            {
                Console.WriteLine("day is Thursday");
            }
            else if (num == 2)
            {
                Console.WriteLine("day is WWendnesday");
            }
            else if (num == 3)
            {
                Console.WriteLine("day is Tuesday");
            }
            else if (num == 4)
            {
                Console.WriteLine("day is Friday");
            }
            else if (num == 5)
            {
                Console.WriteLine("day is Saturday");
            }
            else if (num == 6)
            {
                Console.WriteLine("day is Sunday");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
        }
    }

    // check th no is divisibale by 5 or not

    class Divisibale5
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 5 == 0)
            {
                Console.WriteLine("no is divisibale by 5");
            }
            else
            {
                Console.WriteLine("no is not divisibale by 5");
            }
        }
    }
}
