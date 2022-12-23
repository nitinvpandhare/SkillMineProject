using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Arrayoo
{
    class OccuranceArray
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 4, 2, 7, 7, 1, 2 };

            for(int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for(int j = 1 + i; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i] + " " + count);
                }
            }
        }
    }
}
