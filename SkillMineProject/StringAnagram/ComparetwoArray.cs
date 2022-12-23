using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.StringAnagram
{
    class ComparetwoArray
    {
        static void Main(string[] args)
        {
            int[] arrr1 = new int[] { 1, 2, 3, 4, 1, 3 };
            int[] arrr2 = new int[] { 5, 6, 8, 7, 5, 7 };

            HashSet<int> list = new HashSet<int>();
            for(int i = 0; i < arrr1.Length; i++)
            {
                list.Add(arrr1[i]);
            }
            for(int i = 0; i < arrr2.Length; i++)
            {
                list.Add(arrr2[i]);
            }
            foreach (var ct in list)
            {
                Console.WriteLine(ct);
            }
        }
    }
}
