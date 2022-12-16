using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.OOPs
{
    class StudentDetailsOf
    {
        int id;
        string name;
        double marks;

        public void AcceptDetails(int sid, string sname, double smarks)
        {
            id = sid;
            name = sname;
            marks = smarks;
        }
        public void display()
        {
            Console.WriteLine(id +" " +name+" "+marks);
        }
        static void Main(string[] args)
        {
            StudentDetailsOf stud = new StudentDetailsOf();
            stud.AcceptDetails(1434, "Roha", 73.26);
            stud.display();
        }
    }
}
