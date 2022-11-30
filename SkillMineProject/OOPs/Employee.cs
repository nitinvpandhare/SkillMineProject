using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.OOPs
{
    class Employee
    {
        string ename;
        string ecompanyName;
        int eid;
        string edesignation;
        int salary;
        
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.ename = "CodeLogic";
            emp.ecompanyName = "SkillMine";
            emp.eid = 1434;
            emp.edesignation = "Associeat Software Engineer";
            emp.salary = 38965;

            Console.Write(emp.ename + " \n"+ emp.ecompanyName+" \n"+emp.eid+" \n"+ emp.edesignation+" \n"+emp.salary + " \n");
        }
    }
}
