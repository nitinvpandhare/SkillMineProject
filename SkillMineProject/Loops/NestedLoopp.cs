using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Loops
{
    //Pattern

    class StarPattern
    {
        static void Main(string[] args)
        {
            //rectangle pattern

            /*for(int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            //

            for(int i = 1; i <= 4; i++)
            {
                for(int n = 1; n <= i; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    // Quetions Pattern 1
    class Pattern1
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    Console.Write("{0}",j--);
                }
                Console.WriteLine();
            }
        }
    }

    // pattern 2
    class Pattern2
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("{0}",j);
                }
                Console.WriteLine();
            }
        }
    }

    //pattern 3

    class Pattern3
    {
        static void Main(string[] args)
        {
            for(int i = 1;i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    //pattern 4
    class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }

    //pattern5

    class Pattern5
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                   
                    Console.Write("{0}", k++);
                }
                Console.WriteLine();
            }
        }
    }

    //lagical apttern

    class ReactPattern
    {
        static void Main(string[] args)
        {
            for(int row = 1; row <= 5; row++)
            {
                for(int col = 1; col <= 5; col++)
                {
                    if (row == 1 || col == 1 || row == 5 || col == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }


    //pattern N 2

    class PatternN
    {
        static void Main(string[] args)
        {
          
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    if (col == 1 || col == 5 || (row == col && col != 0 && col != 5))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }

    //triangle Paattern 1

    class TriPattern
    {
        static void Main(string[] args)
        {
            for(int row = 1; row <= 4; row++)
            {
                for(int col = 1; col <= row; col++)
                {
                    //if (col == 1 || row == 5 || (row == col && col !=0 && col != 0))
                    if(row == 3 && col == 2)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    // Tri0 2 Pattern 4
    class Tri2Pattern
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (col % 2 == 0)
                    {
                        Console.Write("0 ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    //pattern 3
    class PlusPattern
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 4; i++)
            {
                for(int j = 0; j <= 4; j++)
                {
                    if(i==2 || j == 2)
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }

    //char pattern 1

    class CharPattern
    {
        static void Main(string[] args)
        {
            for(char i = 'A'; i <= 'D'; i++)
            {
                for(char j = 'A'; j <= 'D'; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    //char pattern 2
    class CharPat2
    {
        static void Main(string[] args)
        {
            for(char i = 'A'; i <= 'D'; i++)
            {
                for(char j = 'D'; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    //char pattern1
    class CharPatt1
    {
        static void Main(string[] args)
        {
            for(char i='A'; i <= 'D'; i++)
            {
                for(char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class NestedLoopp
    {
        static void Main(string[] args)
        {
          //Que1. to check the number is disarium or not.

            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            string numstr = num.ToString();
            int len = numstr.Length;
            int sum = 0;
            int rem = 0;
            int temp = num;
                      
            while (temp > 0)
            {
                rem = temp % 10;
                sum = sum + (int)Math.Pow(rem, len);
                len--;
                temp = temp / 10;
            }
            if (sum == num)
            {
                Console.WriteLine("is disarium no ");
            }
            else 

            {
                Console.WriteLine("Not a Disarium no");
            }

            /*Console.WriteLine("Input a number");
            int num = Convert.ToInt32(Console.ReadLine());
            string numStr = num.ToString();
            int length = numStr.Length;
            int divide = 0, sum = 0 ;
            int temp = num;
            while (temp > 0)
            {
                divide = temp % 10;
                sum = sum + (int)Math.Pow(divide, length);
                length--;
                temp = temp / 10;
            }
            if (sum == num)
            {
                Console.WriteLine("Disarium Number.");
            }
            else
            {
                Console.WriteLine("Not a Disarium Number.");
            }
            
            */
        }
    }

    //classs exap find the sum of prime no between 1 to 10  
    class SumOfPrimeNo
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                bool isPrime = true;
                for(int num = 2; num < i; num++)
                {
                    if (num % 2 == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine("............" + i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of prime no : " + sum);
        }
    }


    //KrishnaMurthiNumber

    class KrishnaMurthiNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any no");
            int num = int.Parse(Console.ReadLine());

            int temp = num;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                int fact = 1;

                for(int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("Number is Krishnamurthi");
            }
            else
            {
                Console.WriteLine("Number is not Krishnamurthi");
            }
        }
    }


    //Calculate the sum of factorial between 1 to 5 .  

    class SumOfFact
    {
        static void Main(string[] args)
        {
            int i, fact = 1;

            for (i = 1; i <= 5; i++)
            {
                fact = fact * i;
            }                

            Console.Write("The Factorial of {0} is: {1}\n", 5, fact);
        }
    }
}
