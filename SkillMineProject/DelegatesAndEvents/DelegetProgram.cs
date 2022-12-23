using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.DelegatesAndEvents
{
    public delegate int mydel1(int s, int p);
    public delegate string mydel2(string s);
    public class Test
    {
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public string Name(string name)
        {
            return name.ToUpper();
        }
    }
    class DelegetProgram
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            mydel1 d1 = new mydel1(t1.Sub);
            mydel2 d2 = new mydel2(t1.Name);

            int sum = d1.Invoke(78, 34);
            Console.WriteLine(sum);

            string s = d2.Invoke("ThinkMind");
            Console.WriteLine(s);
        }
    }
}
