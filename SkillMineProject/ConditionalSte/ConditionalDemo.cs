using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalSte
{
    class ConditionalDemo
    {
        //greatest number
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the num2");
            num2 = int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("num1 is greater");
            }
            else
            {
                Console.WriteLine("num2 is greater");
            }

        }
    }

    //Even Odd
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter thew number");
            num = int.Parse(Console.ReadLine());

            if (num %2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }
    }

    //ladder if else
    class VowelsTest
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the char");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch =='A')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'e')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'o')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'A')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'E')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'I')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'i')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
        }
    }
    // Vowels with logical opreator
    class VowelsLOP
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter char");
            ch = Convert.ToChar(Console.ReadLine());

            if(ch=='a'|| ch=='e' || ch=='o' || ch == 'i' || ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }

        }
    }
}
