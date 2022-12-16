using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.CsharpOops
{
    interface IPayable
    {
        string Pay();
    }
    public interface IOrder
    {
        string Display();
    }
    public interface ICustomer
    {
        string Display();
    }
    public class Transaction : IOrder, ICustomer
    {
        // explicit implementaion of interface
        string IOrder.Display()
        {
            return "order details";
        }
        string ICustomer.Display()
        {
            return "customer details";
        }
    }

   /* static void Main(string[] args)
    {
        IOrder order = new Transaction();
        Console.WriteLine(order.Display());

        ICustomer customer = new Transaction();
        Console.WriteLine(customer.Display());

        *//*Customer c1 = new Customer();
        Console.WriteLine(c1.Pay());*//*
    }
*/


}
