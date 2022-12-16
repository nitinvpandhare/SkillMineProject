using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.CsharpOops
{
    class KeywordsP
    {

        //Ref keyword
        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        //out
        static void Calc(int n, int p, out int sum,out int sub, out int mul)
        {
            sum = n + p;
            sub = n - p;
            mul = n * p;
        }

        //params
        static void AcceptNames(params string[] names)
        {
            Console.WriteLine(" \nvalues " + names.Length);
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]);
            }
        }

        static void Main(string[] args)
        {
            //ref
            int a = 24, b = 34;
            Console.WriteLine($"Before call the method a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After call the method a={a}, b={b}");

            //out
            int n = 24, p = 34, sum, sub, mul;
            Calc(n, p, out sum, out sub, out mul);
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);

            //params
            AcceptNames(" nitin", " suraj");
            AcceptNames(" sangola", " radhanagari", " capital", " thane");
            AcceptNames(" nitin", " suraj", " vedant", " parag", " night");
        }
    }
}
