using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.CsharpOops
{
    public class Employee4
    {
        protected int empid;
        protected string name;
        protected double salary;
        protected static int count = 0;

        public Employee4(string name, double salary)
        {
            count++;
            empid = count;
            this.name = name;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"Employee ->{empid}->{name}->{salary}";
        }
    }

    public class VisitorEmployee : Employee4
    {
        private int visitorhr;
        private double visitorsalary;

        public VisitorEmployee(string name, double salary, int visitorhr, double visitorsalary):base(name, salary)
        {
            this.visitorhr = visitorhr;
            this.visitorsalary = visitorsalary;
        }
        public override string ToString()
        {
            return $"Employee ->{empid} ->{name} ->{salary} visitorhr-->{visitorhr} visitsalary-->{visitorsalary}";
        }
    }
}



/*public string Print()
   {
       return $"Employee id->{empid}, name->{empname}, & gross salary of emp->{gross}";
   }*/

// or
/*string data=empl.Print();
Console.WriteLine(data);*/