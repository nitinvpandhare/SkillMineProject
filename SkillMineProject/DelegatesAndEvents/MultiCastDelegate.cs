using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.DelegatesAndEvents
{
    //delegate declaration
    public delegate int myDel4(int s, int t);
   public class MultiCastD
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Mul(int c, int d)
        {
            return c * d;
        }
        public int Div(int c, int d)
        {
            return c / d;
        }
    }

    class MultiCastDelegate
    {
        static void Main(string[] args)
        {
            MultiCastD t2 = new MultiCastD();

            myDel4 d4 = new myDel4(t2.Add);
            d4 += new myDel4(t2.Mul);
            d4 += new myDel4(t2.Div);

            Delegate[] list = d4.GetInvocationList();
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.DynamicInvoke(78, 34));
            }
        }
    }
}
