using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject
{
    class AreaTriangale
    {
        static void Main(string[] args)
        {
            int  h, b, AreaTriangle;
            Console.WriteLine("enter the value height");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value base");
            b = int.Parse(Console.ReadLine());
            
            AreaTriangle = ((1/2) * b * h);

            Console.WriteLine("Area of triangle"+ AreaTriangle);

        }
    }
}
