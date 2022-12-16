using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.StringMethod
{
    class StringMethods
    {
        static void Main(string[] args)
        {
            string str1 = "Hello Wolrd";
            //Length
            Console.WriteLine(str1.Length);

            string str2 = "Good Morning";

            //Concatnation
            string str = string.Concat(str1 + " " + str2);
            Console.WriteLine(str);

            //trim, trimstart, trimend
            string str4 = "  hi team  ";
            Console.WriteLine(str4.Trim());
            Console.WriteLine(str4.TrimStart()); //remove start space
            Console.WriteLine(str4.TrimEnd());  //remove end space

            Console.WriteLine("------------------");

            //IsNullOrEmpty
            string str0 = " ";
            bool res = string.IsNullOrEmpty(str0);
            Console.WriteLine(res);//false

            bool res1 = string.IsNullOrWhiteSpace(str0);
            Console.WriteLine(res1);//true
            Console.WriteLine("--------------------");

            //Toupper& Tolower
            string str5 = "Nitin Pandhare";
            Console.WriteLine(str5.ToUpper());

            Console.WriteLine(str5.ToLower());
            Console.WriteLine("-------------------------");

            //compare
            string str6 = "tEst";
            string str7 = "test";
            int a = string.Compare(str6, str7);
            Console.WriteLine(a);
            Console.WriteLine( "------------------------");

            //ToCharArray
            char[] ch = str5.ToCharArray();
            foreach (var item in ch)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");

            //Equals

            string str9 = "SkillMine";//true or false value 
            string str10 = "skillMine";
            bool res2 = str9.Equals(str10);
            Console.WriteLine(res2);
            Console.WriteLine("--------------------------");

            
        }
    }
}
