using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.OOPs
{
    class Cars
    {
        int modelNo;
        string name;
        double prize;
        string color;
        

        public void AcceptDetail(int CarmodelNo, string Carname, double Carprize, string Carcolor)
        {
            modelNo = CarmodelNo;
            name = Carname;
            prize = Carprize;
            color = Carcolor;
        }
        public void display()
        {
            Console.WriteLine(modelNo + " " + name + " " + prize + " " + color);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Car-1");
            Cars car1 = new Cars();
            car1.AcceptDetail(43434, "MarutiSuzaki", 810000, "red");
            car1.display();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Car-2");
            Cars car2 = new Cars();
            car2.AcceptDetail(78733, "Brezza", 910000, "WhiteYellow");
            car2.display();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Car-3");
            Cars car3 = new Cars();
            car3.AcceptDetail(87864246, "HondaCity", 1234000, "White");
            car3.display();


        }
    }
}
