using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.StringAnagram
{
    class ArraySumOfPaier
    { 
        public void ArrsumPair(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    int sum = a[i] + a[j];
                    if (sum == 7)
                    {

                        Console.WriteLine(sum);
                    }
                }
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 7, 1, 2, 3, 0 };
            ArraySumOfPaier arraySumOfPaier = new ArraySumOfPaier();
            arraySumOfPaier.ArrsumPair(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
