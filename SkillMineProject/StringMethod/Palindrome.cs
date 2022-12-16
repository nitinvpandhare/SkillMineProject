using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SkillMineProject.StringMethod
{
    class Palindrome
    {

        public void CheckPali(string s)
        {
            bool flag = false;
            for(int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--)
            {
                if (s[i] == s[j])
                {
                    flag = true;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();

            //string s = "nitin";
            Palindrome p = new Palindrome();
            p.CheckPali(s);

        }
    }

    class Occurrence
    {
        static void Main(string[] args)
        {
            string str = "Hello to all, welcome all";

            int count = 0;

            foreach (var item in Regex.Matches(str, "all"))
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }

    class Toggels
    {
        public void Toggel()
        {

        }
        static void Main(string[] args)
        {
            string str = "Hello , welcome";

        }
    }
}
