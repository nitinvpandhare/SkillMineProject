using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalSte
{
    class TarnaryOp
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

            string result1 = num % 2 == 0 ? "Even" : "Odd";

            Console.WriteLine(result1);
        }
    }
    class TernaryDemo
    {
        //Que6.  to check greatest no in between 3 number using tarnary oprator
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter the num1 value");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num2 value");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num3 value");
            num3 = int.Parse(Console.ReadLine());

            //int res = (num1 > num2 && num1 > num3) ? num1 + "is grater" : (num2 > num1 && num2 > num3) ? num2 + "is grater" : (num3 > num1 && num3 > num2) ? num3 + "is grater";
            int res = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
            Console.WriteLine(res +" "+ "is greatest");
        }
    }

    //Que5. check the number is divisibal by  5 & 11 using tarnary opreator

    class Divisib
    {
        static void Main(string[] args)
        {
            int num, num1;
            Console.WriteLine("enter the num number");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the num1 number");
            num1 = int.Parse(Console.ReadLine());

          /*  int result = num > num1 ? num : num1;
            Console.WriteLine(result);*/

          if(num % 5 == 0 )//|| num1 % 11 == 0)
            {
                Console.WriteLine("number is divisibl by 5");
            }
            else if(num1 % 11 == 0)
            {
                Console.WriteLine("number is divisible by 11");
            }
            else
            {
                Console.WriteLine("Not a number is divisibl by 5 or 11");
            }
        }
    }
}
