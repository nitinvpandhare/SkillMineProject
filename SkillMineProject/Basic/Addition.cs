using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class Addition
    {
        static void Main(String[] args)
        {
            int num1, num2, result, mul, sub, div;
            num1 = 14;
            num2 = 34;
            result = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;

            Console.WriteLine("my_Ans = " );
            Console.WriteLine(result);
            Console.WriteLine(mul);
            Console.WriteLine(sub);
            Console.WriteLine(div);
        }
    }
}
