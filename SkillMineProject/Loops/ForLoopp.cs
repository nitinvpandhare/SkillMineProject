using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Loops
{
    class ForLoopp
    {
        static void Main(string[] args)
        {
            //for loop syntax

            /* for(initialization ; condition; increment or decrement)
             {
                 logical statment
             }
             Console.WriteLine(int);*/

            //1.
            /*int i;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Hiiii");   //5 time hi display
            }*/

            //2.
            /*for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);  //1 to 5 output
            }*/

            //3.
            /* for(int i = 34; i > 14; i--)
             {
                 Console.WriteLine(i);  //34 to 13 output
             }*/

            //4
            //for loop variations

            /*for(int i = 1; i <= 5;)
            {
                Console.WriteLine(i);   //infinite loop output
            }*/

            //5
            /*int i;
            for (i = 5; i <=1; i--)
            {
                Console.WriteLine("Hiii");    //no output
            }*/

            //6
            //int i = 9;      //infinite loop output
           /* int i = 1;
            for (; i >= 5; i++)
            {
                Console.WriteLine(i);   //no output
            }*/

            //7
            /* for(int i=1; ; i++)
             {
                 Console.WriteLine(i);  // infinit loop output
             }*/

            //8
            /* int i;
             for (i = 1; i <= 9; i++) ;
             {
                 Console.WriteLine("Hiii"); //one time output
             }*/

            //9
            /*  for(int i = 1; i <= 7; i++)
              {
                  Console.WriteLine("Hiii");  //7 hii and 7 i output
                  Console.WriteLine(i);
              }*/

            /*int i;
            for ( i = 1; i <= 7; i++) 
                Console.WriteLine("Hiii");
            Console.WriteLine(i);*/

            //10.
            /* for(; ; )
             {
                 Console.WriteLine("Hiii");  // infinite loop output
             }*/
        }
    }

    //Que1. to display number between 1 to 10

    class Display
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    //Que2. to display number between 75 to 61

    class DisplayNum
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 75; i >= 61; i--)
            {
                Console.WriteLine(i);
            }
        }
    }

    //Que3. to display number between 120 to 200

    class DisplayNumber
    {
        static void Main(string[] args)
        {
            for(int i = 120; i <= 200; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    //for exam to display of sum of even number

    class DisplaySumEven
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of even no ="+sum);
        }
    }

    //Que4 to calculate sum of 1 to 10 number

    class DisplaySum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i;
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("the sum of 1 to 10 num ="+sum);
        }
    }

    //Que5. to display odd number in between 120 to 81.

    class DisplayOddNo
    {
        static void Main(string[] args)
        {
            //int sum=0
            for (int n = 120; n > 81; n--)
            {
                if (n % 2 == 1)
                {
                    Console.WriteLine(" odd number is =" + n);
                }
            }
        }
    }

    //Que6. to count odd numbers between 1 to 20

    class CountOddNO
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 == 1)
                {
                    count = count + i;
                }
            }
            Console.WriteLine("count of odd numbers =" + count);
        }
    }

    //for exam calculate the factorial given number

    class FactorialNO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To enter number");
            int num = int.Parse(Console.ReadLine());

            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact = fact + i;
            }
            Console.WriteLine("factorial numbers is =" + fact);
        }
    }

    //Que7. to display table of number 

    class Tableno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter input number");
            int n = int.Parse(Console.ReadLine());

            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("table no {0} x {1} = {2} \n", n, i, n * i);
            }
        }
    }

    //display numbers which are divisible by 5 and 3 in between 1 to 50.

    class DivisibleBy
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());*/

            for(int i = 1; i <= 50; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
