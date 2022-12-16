using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.CsharpOops
{
    public interface IPrintable
    {
        string Print();
    }
    public class Students : IPrintable
    {
        private int rollno;
        private string name;
        private long mobno;
        private double percentage;

        public Students(int rollno, string name, long mobno, double percentage)
        {
            this.rollno = rollno;
            this.name = name;
            this.mobno = mobno;
            this.percentage = percentage;
        }
        
        string IPrintable.Print()
        {
            return $"Sudent Information-->{rollno}-->{name}-->{mobno}-->{percentage}";
        }
    }

    public class Employeev : IPrintable
    {
        private int eid;
        private string ename;
        private long emobno;
        private double esalary;

        public Employeev(int eid, string ename, long emobno, double esalary)
        {
            this.eid = eid;
            this.ename = ename;
            this.emobno = emobno;
            this.esalary = esalary;
        }
        string IPrintable.Print()
        {
            return $"Employeev Inform-->{eid}-->{ename}-->{emobno}-->{esalary}";
        }
    }

    public class Acircle : IPrintable
    {
        private int r;
        private double area;

        public Acircle(int r)
        {
            this.r = r;
            area = 3.14 * r * r;
        }

        string IPrintable.Print()
        {
            return $"Area of Circle -->{area}";
        }
    }
}
