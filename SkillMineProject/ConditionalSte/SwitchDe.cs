using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalSte
{
    class SwitchDe
    {
        //int type exam in switch case
        static void Main(string[] args)
        {
            int daynumber;
            Console.WriteLine("enter the daynumber");
            daynumber = int.Parse(Console.ReadLine());

            switch (daynumber)
            {
                default:
                    Console.WriteLine("Invalid day");
                    break;
                case 1: 
                    Console.WriteLine("MOn");
                    break;
                case 2:
                    Console.WriteLine("Tue");
                    break;
                case 3:
                    Console.WriteLine("Wen");
                    break;
                case 4:
                    Console.WriteLine("thur");
                    break;
                case 6:
                    Console.WriteLine("Fri");
                    break;
                case 5:
                    Console.WriteLine("Sat");
                    break;
                case 7:
                    Console.WriteLine("sun");
                    break;


            }
        }
    }

    //char type exam in switch case

    class SwitchChar
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char ope;
            Console.WriteLine("enter the num1");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the num2");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the ope");
            ope = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("(+) addition");
            Console.WriteLine("(-) substraction");
            Console.WriteLine("(*) multiplication");
            Console.WriteLine("(/) division");

            Console.WriteLine("enter the operator(sign) for the operation");
            ope = Convert.ToChar(Console.ReadLine());

            switch (ope)
            {
                case '1':Console.WriteLine("addition =" + (num1 + num2));
                    break;

                case '2':Console.WriteLine("substraction =" + (num1 - num2));
                    break;

                case '3':Console.WriteLine("multiplication =" + (num1 * num2));
                    break;

                case '4':Console.WriteLine("division =" + (num1 / num2));
                    break;

                default:Console.WriteLine("invalid");
                    break;
            }
        }
    }

    //Que7. simple calculator using switch case creat menu 1,2,3,4.

    class CreatMenu
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char ope1;

            Console.WriteLine("enter num1");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter num2");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the ope1");
            ope1 = Convert.ToChar(Console.ReadLine());

            //menu
            Console.WriteLine("(1) addition");
            Console.WriteLine("(2) substraction");
            Console.WriteLine("(3) multiplication");
            Console.WriteLine("(4) division");

            Console.WriteLine("enter the menu no to perform the operatipon");
            //int menu = int.Parse(Console.ReadLine());
            ope1 = Convert.ToChar(Console.ReadLine());
            switch (ope1)
            {
                default:Console.WriteLine("invalide no");
                    break;
                case '1':Console.WriteLine("addition =" + (num1 + num2));
                    break;
                case '2':Console.WriteLine("substraction =" + (num1 - num2));
                    break;
                case '3':Console.WriteLine("mul =" + (num1 * num2));
                    break;
                case '4':Console.WriteLine("div =" + (num1 / num2));
                    break;
            }
        }
    }

    //Que8. check the char is vowel or not

    class CheckVowel
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter the vowels");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':Console.WriteLine("Vowel");
                    break;
                case 'e': Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                default:Console.WriteLine("Not a vowel");
                    break;

            }
        }
    }

    //que9. check the number is odd or even using switch case

    class CheckOddEven
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num % 2 == 0)
            {
                case true:
                    Console.WriteLine(num + "number is even");
                    break;
                case false:
                    Console.WriteLine(num + "number is odd");
                    break;
               /* default:
                    Console.WriteLine("invalid");
                    break;*/
            }
        }
    }

    //city

    class CheckCity
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the city name");
            string city = Console.ReadLine();

            switch (city)
            {
                case "pune":Console.WriteLine("wlc to pune");
                    break;
                case "Mumbai":Console.WriteLine("wlc to mumbai");
                    break;
                case "delhi":Console.WriteLine("wlc to delhi");
                    break;
                case "Mangalwedha":Console.WriteLine("wlc to m.wedha");
                    break;
                case "P.pur":Console.WriteLine("wlc to p.pur");
                    break;
                default:Console.WriteLine("Please city name");
                    break;
            }
        }
    }
}
