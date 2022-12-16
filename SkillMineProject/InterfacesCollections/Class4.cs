using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.InterfacesCollections
{
   /* public class Check : IComparer
    {
        public int Compare(object x, object y)
        {
            Emplr e1 = (Emplr)x;
            Emplr e4 = (Emplr)y;
            if (e1.Salary > e4.Salary)
            {
                return 1;
            }
            else if (e1.Salary < e4.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }*/

    public class Emplr: IComparable

    {
        int id;
        string name;
        double salary;
        public Emplr(int id,string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public int CompareTo(object obj)
        {
            Emplr e4 = (Emplr)obj;
            if (this.salary > e4.salary)
            {
                return 1;
            }
            else if (this.salary < e4.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }   

        public override string ToString()
        {
            return $"{id} {name} {salary}";
        }
    }

    public class Team:IEnumerable

    {
        private Emplr[] emplrs;
        public Team()
        {
            emplrs = new Emplr[5];
            emplrs[1] = new Emplr(1, "ganesh", 1000);
            emplrs[2] = new Emplr(1, "nitin", 2000);
            emplrs[3] = new Emplr(1, "suraj", 700);
            emplrs[4] = new Emplr(1, "ananda", 400);
        }

        public IEnumerator GetEnumerator()
        {
            return emplrs.GetEnumerator();
        }
    }
    class Class4
    {
        static void Main(string[] args)
        {
            Team team = new Team();

            foreach (Emplr eps in team)
            {
                Console.WriteLine(eps);
            }

           Emplr emplrs1 = new Emplr(1, "ganesh", 4000);
            Emplr emplrs2 = new Emplr(1, "nitin", 2000);
            Emplr emplrs3 = new Emplr(1, "suraj", 700);
            Emplr emplrs4 = new Emplr(1, "ananda", 4000);

            int res = emplrs1.CompareTo(emplrs4);

            if(res == 1)
            {
                Console.WriteLine("ananda has more salary than ganesh");
            }
            else if (res == -1)
            {
                Console.WriteLine("ananda has less salary than ganesh");
            }
            else
            {
                Console.WriteLine("ananda and ganesh has same salary");
            }
        }
    }
}
