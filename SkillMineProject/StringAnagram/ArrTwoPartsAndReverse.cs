using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.StringAnagram
{
    class ArrTwoPartsAndReverse
    {  
        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0, j = arr.Length / 2; i < arr.Length / 2 && j < arr.Length; i++, j++)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            
        }

        
    }
}
