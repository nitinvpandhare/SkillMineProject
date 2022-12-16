using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class SeprateTwoArray
    {
      public void Display(int[] arr)
        {
            int count = 0;
            for(int i=0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int[] even = new int[count];
            int[] odd = new int[arr.Length - count];
            int j = 0;
            int k = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[j] = arr[i];
                    j++;
                }
                else
                {
                    odd[k] = arr[i];
                    k++;
                }
            }
            Console.WriteLine("Even Array is =");
            for(int i = 0; i < even.Length; i++)
            {
                Console.Write(even[i] + "  ");
            }
            Console.WriteLine();

            Console.WriteLine("Odd Array is =");
            for (int i = 0; i < odd.Length; i++)
            {
                Console.Write(odd[i] + "  ");
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter array element");
            int[] arr = new int[a];
            for(int i = 0; i < a; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            SeprateTwoArray eo = new SeprateTwoArray();
            eo.Display(arr);
        }
    }
}
