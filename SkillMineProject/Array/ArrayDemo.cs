using System;

namespace SkillMineProject.Array
{

    //toggle
    class Toggle
    {
        public char [] ChangeArray(char[] cha)
        {
            for (int i = 0; i < cha.Length; i++)
            {
                if (cha[i] >= 'a' && cha[i] >= 'z')
                {
                    cha[i] = (char)(cha[i] - 32);
                }
                else if (cha[i] >= 'A' && cha[i] <= 'Z')
                {
                    cha[i] = (char)(cha[i] + 32);
                }
                else
                {
                    cha[i] = cha[i];
                }
            }
            return cha;
        }
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'K', 'w', 'R', 'i', 'T', 'f' };
            Console.WriteLine(string.Join(" ", arr));
            Toggle t = new Toggle();
            char[] myToggle = t.ChangeArray(arr);

            Console.WriteLine(string.Join("  " , myToggle));
        }
    }
    //Maximum Element
    class FindMax
    {
        public int FindMaximum(int[] a)
        {
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] arr = { 7, 3, 5, 2, 8, 1 };

            FindMax mnobj = new FindMax();
            Console.WriteLine("Max from Array " + mnobj.FindMaximum(arr));
        }
    }
    //char type array
    class CharArray
    {
        static void Main(string[] args)
        {
            char[] arrch = { 'a', 's', 'j', 's', '@' };

            char[] ch = new char[4];
            Console.WriteLine("Enter the array element");

            for(int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }

            foreach(char c in ch)
            {
                Console.WriteLine(c + "-----------------");
            }
        }
    }
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            //1
            int[] myArray = new int[5];
            myArray[0] = 2;
            myArray[1] = 3;
            myArray[2] = 5;
            myArray[3] = 7;
            myArray[4] = 9;
            //2.
            Console.WriteLine("Enter the array ele");
            for(int i = 0; i < myArray.Length; i++)
            {
                //1
                int x = int.Parse(Console.ReadLine());
                myArray[i] = x;
                //2
                myArray[i] = int.Parse(Console.ReadLine());
            }

            /*for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }*/

            foreach(int element in myArray)
            {
                Console.WriteLine(element);
            }
        }
    }

    // even no
    class EvenNumber
    {
        static void Main(string[] args)
        {
            int[] num= new int[6];
            for(int i = 0; i < 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < 5; i++)
            {
                bool flag = true;
                for(int j = 2; j < num[i]; j++)
                {
                    if (num[i] % 2 == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine(num[i]);
                }
            }
        }
    }
}
