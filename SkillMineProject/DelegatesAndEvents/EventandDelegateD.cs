using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.DelegatesAndEvents
{
    //delegate declaration
    public delegate void mydel5();
    public class StudEvent
    {
        //event declaration
        public event mydel5 Pass;
        public event mydel5 Fail;
        public void Accept(int mark)
        {
            if (mark >= 35)
            {
                Pass();
            }
            else
            {
                Fail();
            }
        }
    }
    public static class Message
    {
        public static void PassMsg()
        {
            Console.WriteLine("Great ! you are pass");
        }
        public static void FailMsg()
        {
            Console.WriteLine("Sorry ! you are Fail");
        }
    }

    class EventandDelegateD
    {
        /*public static void PassMsg()
        {
            Console.WriteLine("Great ! you are pass");
        }
        public static void FailMsg()
        {
            Console.WriteLine("Sorry ! you are fail");
        }*/

        static void Main(string[] args)
        {
            StudEvent se = new StudEvent();
            se.Pass += new mydel5(Message.PassMsg);
            se.Fail += new mydel5(Message.FailMsg);
            //se.Pass += new mydel5(PassMsg);
            //se.Fail += new mydel5(FailMsg);
            se.Accept(30);
        }
    }
}
