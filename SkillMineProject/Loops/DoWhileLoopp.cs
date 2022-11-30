using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Loops
{
    class DoWhileLoopp
    {
        //class work
        static void Main(string[] args)
        {
            //syntax
            /*
             * initiliazation
             * do
             * {
             * logical part
             * increment / decrement
             * } while(condition)
             *   exit
             */

            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i >= 0);
        }
    }

    //exam menu driven

    class MenuDriv
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("enter the num1");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter the num2");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter choice from folloeing menu");
                Console.WriteLine("1.add\n 2.sub\n 3.mul\n 4.div");

                Console.WriteLine("enter choice");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("add " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("sub " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("mul " + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("div " + (num1 / num2));
                        break;
                }
                //ask another choice
                Console.WriteLine("do you want to continue....");

                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y' && ch == 'Y');
        }
    }

    //Que7. to find out the sum of even digit from the number

    class SumOfEvenDigitNo
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("enter the  number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            //int n;

            for(int i = 1; i <= num; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);*/


            
            Console.Write("Enter value a Number:");
            int Number = Convert.ToInt32(Console.ReadLine());

            int sum = 0, i = 2;
            while (i <= Number)
            {
                sum = sum + i;
                i = i + 2;
            }
            Console.WriteLine(sum);
        }
    }

    //Que8. to find out sum of odd digit from the number

    class SumOddDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter from Number");
            int from = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter to Number");
            int to = int.Parse(Console.ReadLine());

            int sum = 0;
            if (from < to)
            {
                for (int i = from; i <= to; i++)
                {
                    if (i % 2 == 1)
                        sum = sum + i;
                }
                Console.WriteLine("sum of odd digit :"+sum);
            }
            else
            {
                Console.Write("Invalid From and To Numbers");
            }

        }
    }


    //Que9. to find out the sum of first digit and last digit from the number.

    class FirstNLastNoAdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int lastDigit, firstDigit;

            lastDigit = num % 10;
            firstDigit = num;

            while (num >= 10)
            {
                num = num / 10;
            }

            firstDigit = num;
            sum = firstDigit + lastDigit;

            Console.WriteLine("sum of firstDigit and lastDigit : " + sum);
        }
    }
}
