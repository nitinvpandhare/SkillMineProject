using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Loops
{
    class WhileLoopp
    {
        static void Main(string[] args)
        {
            //class work

            //syntax
            //initiliazation
            //while(condition)
            /*{
                logical stat
                incement / decrement
            }*/

            //1.
            /*int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Hiii");
                i++;
            }*/

            //2.
            //while loop variations

            /*int i = 7;
            while (i > 1)
            {
                Console.WriteLine(i);   // 2 to 7
                i--;
            }*/

            //3
            /*int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);  //infinite loop
                i--;
            }*/

            //4.

            /*while (true)
            {
                Console.WriteLine("Hii");  //infinite loop

            }*/

        }
    }

    //Logical program:

    class SumOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            Console.WriteLine("sum of digit " + num);
        }
    }

    //Que1. to find the sum of odd numbers using while loop

    class SumOfOdd
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter the Number");
            int num1 = int.Parse(Console.ReadLine());*/

            int sum = 1;
            int count = 1;

            while (count <= 20)
            {
                if (count % 2 != 0)
                {
                    sum = sum + count;
                }
                count++;
            }
            Console.WriteLine("Sum of odd Number =" + sum);
        }
    }


    //Que\2.  to count the number of digits

    class CountNoDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number :");
            int N = int.Parse(Console.ReadLine());

            int count = 0;

            while (N != 0)
            {
                count = count + N % 10;
                N = N / 10;
                //count++;
            }
            Console.WriteLine("count number of digit =" + count);
        }
    }

    //break and continue exam

    class BCExam
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 6)
            {
                if (i % 2 == 0)
                {
                    i++;      //this i display infinite loop
                    continue;
                }
                Console.WriteLine(i);
                i++;   //this i only display 1,3,5
            }

            //using for loop

            for(int j = 1; j <= 6; j++)
            {
                if (j == 3)
                {
                    break;
                }
                Console.WriteLine("using for loop ="+j);
            }
        }
    }

    //Que4. write code to number betweemn 1 to 50 just keep the no whisch are divisible by 5;

    class KeepDivBy5
    {
        static void Main(string[] args)
        {
            int cnt = 0;
           for(int i=1;i<=50;i++)
            {
                if (i % 5 != 0)
                {
                    Console.WriteLine(i);
                    cnt++;
                }
            }
            Console.WriteLine("total no between 1 to {0} which are divisible by 5 are {1}", 50, cnt);
        }
    }

    //Que4. to perform the sum of 1 to 20  if the sum value is grater than 10 then stop the perform addition 

    class SumAdd10
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            while (i <= 20)
            {
                if (i == 11)
                {
                   // sum = sum + i;
                    break;
                }
                sum = sum + i;
                Console.WriteLine(i);
                Console.WriteLine(sum);
                i++;
            }
        }
    }

    //Que exam for to check the gussing Number

    class GussingNo
    {
        static void Main(string[] args)
        {
            int magicNo = 34;

            while (true)
            {
                Console.WriteLine("Enter the Number");
                int num = int.Parse(Console.ReadLine());

                if (num > magicNo)
                {
                    Console.WriteLine("Number is larger than the Gussing No pls try again");
                    continue;
                }
                else if (num < magicNo)
                {
                    Console.WriteLine("Number is less than the Gussing No pls try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("Wow Gussing nO is correct");
                    break;
                }
            }
        }
    }

    //Que Exam To check the number is Prime or not

    class CheckNoPrime
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

                int count = 0;
                for(int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                }
            if (count == 0)
            {
                Console.WriteLine("Number is prime ");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }*/


            //or

            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            int i = 1;
            //for (int i = 2; i < num; i++)
            bool isPrime = true;
            {
                if (num % i == 0)
                {
                    count++;
                    isPrime = false;
                   // break;
                }
            }
            if (isPrime==true )//(count == 0)
            {
                Console.WriteLine("Number is prime ");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }
        }
    }


    // Exam of armstrong Or Not

    class CheckArmstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the Nummber");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + (digit * digit * digit);
                num = num / 10;
            }
            num = temp;
            if (num == sum)  //temp==sum
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("number is not armstrong");
            }
        }
    }

    //Que.6 to check the number is spy or not

    class CheckSpy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int n=num, sum=0, product=1, digit;
            while (num > 0)
            {
                digit = num % 10;
                sum = sum + digit;
                product = product * digit;
                n = num / 10;
            }
            num = n;
            if (sum == product)
            {
                Console.WriteLine("number is spy no");
            }
            else
            {
                Console.WriteLine("number is not spy no");
            }
        }
    }
}
