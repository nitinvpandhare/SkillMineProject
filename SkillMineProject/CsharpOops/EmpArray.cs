using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.CsharpOops
{
    public class S
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public double Percentage { get; set; }
    }
    public class E
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
   /* class EmpArray
    {  
        static void Main(string[] args)
        {
            //Student list using property

            S[] StuList = new S[]
            {
                new S{Sid=104,Sname="nitin",Percentage=76.90},
                new S{Sid=106,Sname="sopan",Percentage=67.89},
                 new S{Sid=104,Sname="nitin",Percentage=76.90},
                new S{Sid=106,Sname="sopan",Percentage=67.89},

            };

            foreach (S item in StuList)
            {
                Console.WriteLine($"{item.Sid} {item.Sname} {item.Percentage}");
            }

            Console.WriteLine("--------------------------");

            //Employee list using property

            E[] EmList = new E[]
            {
                new E{Id=101,Name="Suraj",Salary=7600},
                new E{Id=102,Name="ajay",Salary=4500},
                new E{Id=103,Name="Nitin",Salary=3000},
            };

            foreach (E item in EmList)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Salary}");
            }


            Console.WriteLine("-----------------------");
            //student list using constructor

            Stu[] stuList = new Stu[]
            {
                new Stu(21,"nitin",67.90),
                new Stu(22,"ajay",87.90),
                new Stu(23,"pratik",76.00),

            };
            foreach (Stu s in stuList)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------------------------");

            EmArray[] emlist = new EmArray[]
            {
                new EmArray(41,"alokha",56789,"Logiguide"),
                new EmArray(42,"ankita",56789,"upcode"),
                new EmArray(43,"rupaum",56789,"uplear"),
                new EmArray(44,"suraj",56789,"bitmind"),
                new EmArray(45,"akshay",56789,"codelogic"),
            };

            foreach (EmArray item in emlist)
            {
                Console.WriteLine(item);
            }
        }
    }*/

    class Stu
    {
        private int sid;
        private string sname;
        private double percentage;

        public Stu(int sid, string sname, double percentage)
        {
            this.sid = sid;
            this.sname = sname;
            this.percentage = percentage;
        }

        public override string ToString()
        {
            return $"{sid} {sname} {percentage}";
        }
    }

    class EmArray
    {
        private int eid;
        private string ename;
        private double esalary;
        private string ecompany;

        public EmArray(int eid, string ename, double esalary, string ecompany)
        {
            this.eid = eid;
            this.ename = ename;
            this.esalary = esalary;
            this.ecompany = ecompany;
        }

        public override string ToString()
        {
            return $"{eid} {ename} {esalary} {ecompany}";
        }
    }
}
