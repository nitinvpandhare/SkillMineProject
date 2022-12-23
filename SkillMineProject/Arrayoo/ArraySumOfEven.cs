using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Arrayoo
{

    //class 
    class EvenNoOfEle
    {
        //method
        public void DisplayEvenNo(int[] arr)
        {
            for(int i = 0; i <= arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("Even no =" + arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter the array element");

            for(int i = 0; i <= a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            EvenNoOfEle myobj = new EvenNoOfEle();
            myobj.DisplayEvenNo(a);
        }
    }
    class ArraySumOfEven
    {
        //Que1. Write a code to find out sum of even element from the array.
        public int DisplaySumOfEven(int [] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum = sum + arr[i];
                }                
            }
            return sum;
            //Console.WriteLine("Sum of even element "+sum);
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[4];
            Console.WriteLine("Enter the array  of element");
            for(int i = 0; i <= arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            //obj
            ArraySumOfEven myobj = new ArraySumOfEven();
             Console.WriteLine(myobj.DisplaySumOfEven(arr1));
        }
    }

    //Que2. Write code to count odd element from the array.
    class ArrayCountOfOddEle
    {

        public int CountOfOdd(int [] arr)
        {
            int count = 0;
            for(int i = 0; i <= arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    count = count + arr[i];
                }
            }
            return count;
            //Console.WriteLine("count of odd element " + count);
        }
        static void Main(string[] args)
        {
            int[] arr2 = new int[7];
            Console.WriteLine("Enter the array of element");

            for (int i = 0; i <= arr2.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            //
            ArrayCountOfOddEle myobj = new ArrayCountOfOddEle();
            Console.WriteLine(myobj.CountOfOdd(arr2));
        }
    }
    //Que.3 write aa code to display vowels from the array
    class Vowel
    {
        static void Main(string[] args)
        {
            char[] arrchar = { 'a', 'e', 'o', 'i', 'u' };

            char[] achar = new char[5];
            Console.WriteLine("Enter the array element");

            for (int i = 0; i < achar.Length; i++)
            {
                achar[i] = Convert.ToChar(Console.ReadLine());
            }

            //display

            for (int i = 0; i < achar.Length; i++)
            {
                Console.WriteLine("Vowel----------" + achar[i]);
            }
            //or

            /*foreach (char c in achar)
            {
                Console.WriteLine("Vowel----------"+c);
            }*/
        }
    }

    //Que.4 find out the min value from the int array.
    class FindMin
    {
        //method
        public int FindMinimum(int [] a)
        {
            int min = 1;
            for(int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 7, 9, 5, 8 };

            FindMin mnobj = new FindMin();
            Console.WriteLine("min from array = " + mnobj.FindMinimum(arr));
        }
    }

    //Que.5 Find out the min and max valu from the char array
    class FindMinMax
    {
        /*public char DisplayMinMax(char[] a)
        {
            
        }*/
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'k', 'w', 'r', 'i', 't', 'f' };
            Console.WriteLine(string.Join(" ", arr));

            FindMinMax mnobj = new FindMinMax();
           //Console.WriteLine(mnobj.DisplayMinMax(arr));
        }
    }

    //Que.6 write code to creat char  type of arra and replace element by its alternate charactor .
    class ReplaceEle
    {
        //Method
        public void ReplaceArryEle(char[] ch)
        {
            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'y' || ch[i] == 'Y' || ch[i] == 'z' || ch[i] == 'Z')
                {
                    ch[i] = (char)(ch[i] - 24);
                }
                else
                {
                    ch[i] = (char)(ch[i] + 2);
                }
                Console.WriteLine("--------" + string.Join(" ", ch));
            }
        }
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'K', 'w', 'R', 'i', 'T', 'f' };
            char ch = Convert.ToChar(Console.ReadLine());

            ReplaceEle charobj = new ReplaceEle();
            charobj.ReplaceArryEle(arr);
            Console.WriteLine();
        }
    }

    //Que.8 write code to perform the sum of array element.
    class ArraySum
    {
        //method
        public int FindArraySum(int [] arr1)
        {
            int sum = 0;
            for (int i= 0; i < arr1.Length; i++)
            {
                sum = sum + i;
            }
            return sum;
            //Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array element");

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            ArraySum sumobj = new ArraySum();
            Console.WriteLine(sumobj.FindArraySum(arr));
        }
    }

    //Que.10 write code to display prime number from the array.

    class DisplayPrimeNo
    {
        //method
        public int FindPrimeNo(int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Number Is prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
            return count;

            /////////////////////////
            /* foreach (int number in arr)
             {
                 if (IsPrime(number, number / 2))
                 {
                     count = count + number;
                 }
             }
             return count;
             static bool IsPrime(int n1, int i)
             {
                 if (i == 1)
                 {
                     return true;
                 }
                 else
                 {
                     if (n1 % i == 0)
                     {
                         return false;
                     }

                     else
                     {
                         return IsPrime(n1, i - 1);
                     }                        
                 }
             }*/
        }
        static void Main(string[] args)
        {
            int[] num = new int[5];
            Console.WriteLine("Enter the array element");

            for(int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            DisplayPrimeNo primeobj = new DisplayPrimeNo();
            Console.WriteLine(primeobj.FindPrimeNo(num));
        }
    }

    //Que.9 write code replace the element by zero if it is divisible by 3
    class ReplaceArrayEle
    {
        static void Main(string[] args)
        {

        }
    }
}
