using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Arrayoo
{
    class SearchEle
    {
        public bool IsPresent(int[] a,int n)
        {
            bool flag = false;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 3, 7, 9 };
            Console.WriteLine("Enter the value for Search ");

            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", arr));

            SearchEle SEobj = new SearchEle();
            bool isCheck = SEobj.IsPresent(arr, num);

            if (isCheck)
            {
                Console.WriteLine("Number is Present");
            }
            else
            {
                Console.WriteLine("Number is Not Present");
            }
        }
    }
}
