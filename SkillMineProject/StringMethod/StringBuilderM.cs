using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.StringMethod
{
    class StringBuilderM
    {
        static void Main(string[] args)
        {
            //stringBuilder

            StringBuilder sb = new StringBuilder("hello to all");
            Console.WriteLine(sb);
            sb.Append("Welcome to session");
            Console.WriteLine(sb);

            double price = 54000;
            sb.AppendFormat("price is{0:C}", price);
            Console.WriteLine(sb);
            Console.WriteLine("---------------------------");

            //sb.Remove(0, 7);
            //Console.WriteLine(sb);
            Console.WriteLine("----------------------------");

            sb.Replace("to", "everyone");
            Console.WriteLine(sb);
            Console.WriteLine("----------------------------");


            //GetHashCode
            StringBuilder sb1 = new StringBuilder("hello to all");
            Console.WriteLine($"{sb1}-->{sb1.GetHashCode()}");

            sb.Append("welcome to session");
            Console.WriteLine($"{sb1}-->{sb1.GetHashCode()}");

            Console.WriteLine("----------string----------");

            string str = "hello to all";
            Console.WriteLine($"{str}-->{str.GetHashCode()}");
            str=str+"welcome to session";
            Console.WriteLine($"{str}-->{str.GetHashCode()}");

        }
    }
}
