using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class UserInput
    {
        //user input
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the value " );
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);

            int num1;
            Console.WriteLine("enter the value ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);

            Console.WriteLine("enter the value percentage");
            float per = float.Parse(Console.ReadLine());
            Console.WriteLine("per "+ per);

            Console.WriteLine("enter the value double");
            double var = double.Parse(Console.ReadLine());
            Console.WriteLine("double " + var);

            char ch;
            Console.WriteLine("enter the value char");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(ch);

            Console.WriteLine("enter the boolean value");
            bool var4 = true;
            Console.WriteLine(var4? true : false);

        }
    }
}
