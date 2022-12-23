using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillMineProject.StringAnagram
{
  
    public class MoveZerosSE
    {
       public void MovetoStart(int[] a)
       {
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[j] == 0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
       }

        public void MovetoEnd(int[] b)
        {
            for (int i = 0; i < b.Length+1; i++)
            {
                for (int j = 0; j< b.Length; j++)
                {
                    if (b[j] != 0)
                    {
                        int temp = b[i];
                        b[i] = b[j];
                        b[j] = temp;
                        j++;
                    }
                }
            }
        }

         static void Main(string[] args)
         {
            int[] arr = { 2, 10, 0, 5, 3, 0, 4, 1 };
            MoveZerosSE a1 = new MoveZerosSE();
            a1.MovetoStart(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            a1.MovetoEnd(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            //move to end
           /* int[] arr0 = { 2, 10, 0, 5, 3, 0, 4, };
            int n = arr.Length;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    j++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }*/


        }
    }

}
