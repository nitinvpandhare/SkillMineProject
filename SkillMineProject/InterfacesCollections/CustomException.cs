using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.InterfacesCollections
{
    public class NmaesException : Exception
    {
        public NmaesException(string message) : base(message)
        {

        }
    }
    public class MarksException : Exception
    {
        public MarksException(string message) : base(message)
        {

        }
    }

    public class Stud
    {
        private int marks;
        private string names;
        public  void AcceptNames(string names)
        {
            if(string.IsNullOrEmpty(names))
            {
                throw new NmaesException("name is required");
            }
            else
            {
                this.names = names;
            }
        }
        public void AcceptMarks(int marks)
        {
            if (marks > 100)
            {
                throw new MarksException("Marks can not be greater than 100");
            }
            else
            {
                this.marks = marks;
            }
        }
    }
    public class CustomException
    {

        static void Main(string[] args)
        {
            Stud sm = new Stud();
            try
            {
                sm.AcceptMarks(101);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Stud sn = new Stud();
            try
            {
                sn.AcceptNames("nitin");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }

}
