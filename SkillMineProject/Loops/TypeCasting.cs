using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Loops
{
    class TypeCasting
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    Console.Write((char)(j + 64));
                }
                Console.WriteLine();
            }
        }
    }
}
