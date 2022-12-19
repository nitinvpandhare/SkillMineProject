using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.CsharpOops
{
   
    class Car
    {
        /*public string model;
        private double mprice;*/
        /* public Car()
         {
             model = "farari";

         }
         static void Main(string[] args)
         {
             Car myCar = new Car();
             Console.WriteLine(myCar.model);
         }*/

        /*public Car(string modelName)
        {
            model = modelName;
        }
        static void Main(string[] args)
        {
            Car myCar = new Car("farari");
            Console.WriteLine(myCar.model);

        }*/


        /*public Car(string modelName, double mprice)
        {
            this.model = modelName;
            this.mprice = mprice;
        }
        static void Main(string[] args)
        {
            Car myCar = new Car("farari", 234567.89);
            Console.WriteLine(myCar.model+" "+myCar.mprice);
        }*/

        //methods


    }

    class Test
    {
       /* public void myFoo()
        {
            Console.WriteLine("my name is arun");
        }
        static void Main(string[] args)
        {
            Test name = new Test();
            name.myFoo();
        }*/

      /*  public void MyMethod(string name,int id)
        {
            Console.WriteLine(name+" i s "+id);
        }*/
        static void Main(string[] args)
        {
            /*  Test test = new Test();
              test.MyMethod("nitin", 34);
              test.MyMethod("suraj", 14);
              Console.WriteLine(test);*/
            int[] arr = { 10, 30, 40, 30, 50, 60, 80, 98 };
            int max = arr[0];
            for(int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }

    }
}
