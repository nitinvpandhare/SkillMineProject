using System;
using System.Collections.Generic;
using System.Text;
using static SkillMineProject.CsharpOops.Employee5;

namespace SkillMineProject.CsharpOops
{
    //use here enum keyword
    public enum Dept { HR = 100, Admin, Sales, Development, Testing }
    public class Employee5
    {
        
        protected int empid;
        protected string empname;
        protected double basic, hra, da, pf, gross;
        private Dept dept;

        public Employee5(int empid, string empname, double basic, Dept dept)
        {
            this.empid = empid;
            this.empname = empname;
            this.basic = basic;
            this.dept = dept;
        }

        public virtual void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da) - pf;
        }

        public override string ToString()
        {
            return $"Employee id->{empid}, name->{empname}, & gross salary of employee->{gross}, Dept{dept}";
        }  

   
        public double GetGrossSalary()
        {
            return gross;
        }       

    }

   /* public class SalesManger:Employee5
    {
        private double comm;
        private double bonus;
        public SalesManger(int empid, string empname, double basic, double comm, double bonus):base(empid, empname, basic)
        {
            this.comm = comm;
            this.bonus = bonus;
        }
        public override void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da + comm + bonus) - pf;
        }
        public override string ToString()
        {
            return $"Employee id-->{empid}, name-->{empname} & gross salary of SalesManager-->{gross}, Dept{Dept}";
        }

    }*/
}

