using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.StringAnagram
{
    class StringAnagram
    {
       /* public void Max(int[][] arr1)
        {
            int max = 0;
            int[] arr1 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < arr1[i].Length; j++)
                {
                    if (arr1[i, j] > max)
                    {
                        max = arr1[i][j];
                    }
                }
            }
        }*/
        static void Main(string[] args)
        {
            int[,] arr =
            {
                {1,3,4,5 },
                {3,5,6,7 },
                {4,6,7,8 }
            };


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            //String is anagram
            /*string str11 = "silent";
            string str22 = "lisen";

            char[] ch11 = str11.ToCharArray();
            char[] ch22 = str22.ToCharArray();

            Array.Sort(ch11);
            Array.Sort(ch22);
            string str33 = new string(ch11);
            string str44 = new string(ch22);

            if (str33 == str44)
            {
                Console.WriteLine("String is anagram");
            }
            else
            {
                Console.WriteLine("string is not anagram");
            }*/

            //fibonacci seris

            /*Console.WriteLine("Enter fibo num : ");
            int num = int.Parse(Console.ReadLine());
            int num1 = 0, num2 = 1;

            for (int i = 0; i < num; i++)
            {
                int num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                Console.Write(num3 + " ");
            }*/



        }
    }
}
