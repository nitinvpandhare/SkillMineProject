using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.OOPs
{
    class GreaterNo
    {      
        public int FindMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    result = num1;
                }
                else
                {
                    result = num3;
                }
            }
            else
            {
                result = num2;
            }
            return result;
        }

        static void Main(string[] args)
        {
            GreaterNo max = new GreaterNo();
           // max.FindMax(34, 14, 44);
            //or
            Console.WriteLine(max.FindMax(34, 14, 44));
            //or
            int greater= max.FindMax(34, 14, 44);
            Console.WriteLine("max value is "+ greater);

            Console.ReadLine();
        }
    }
}
