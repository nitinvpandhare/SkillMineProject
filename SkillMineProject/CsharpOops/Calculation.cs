using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.CsharpOops
{
    //overloading
    public class Calculation
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public double Add(double a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public double Sub(int a,double b)
        {
            return a - b; 
        }
    }
}
