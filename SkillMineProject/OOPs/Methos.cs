using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.OOPs
{
    class Methos
    {
        //1.No Return_type No Parameter
        public void show()
        {
            Console.WriteLine("Hiii Show method");
        }

        //2.No Return_type with Parameter
        public void Additin(int x,float y)
        {
            float ans= x + y;
            Console.WriteLine(ans);
        }
        //3. with Return_type with Parameter
        public int SumFactor(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Methos d = new Methos();
            d.show();

            Methos add = new Methos();
            add.Additin(3, 3.4f);

            int result = d.SumFactor(6);
            Console.WriteLine(result);
        }
    }
}
