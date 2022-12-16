using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.GenericCollections
{
    class ProductList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Id}  {Name}  {Price}";
        }
    }
    class Emp
    {
        
        public String Name { get; set; }
        public double Salary { get; set; }
        public string Designation { get; set; }

        public override string ToString()
        {
            return $"{Name}  {Salary}  {Designation}";
        }
    }

    class GenericC
    {
        static void Main(string[] args)
        {
            //ProductList
            List<ProductList> productlist = new List<ProductList>();
            productlist.Add(new ProductList { Id = 1, Name = "Computer", Price = 20000.00 });
            productlist.Add(new ProductList { Id = 2, Name = "mouse", Price = 200.90 });
            productlist.Add(new ProductList { Id = 3, Name = "cpu", Price = 1500.34 });
            productlist.Add(new ProductList { Id = 4, Name = "keyboared", Price = 207.00 });
            productlist.Add(new ProductList { Id = 5, Name = "connectors", Price = 50 });

            Console.WriteLine("ProductList count "+productlist.Count);

            foreach (ProductList pl in productlist)
            {
                Console.WriteLine(pl);
            }
            Console.WriteLine("-----------------------------------");
            //Stack
            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(20);
            s.Push(80);
            s.Push(90);
            s.Push(70);
            s.Push(60);

            Console.WriteLine("Peek element in stak "+s.Peek());

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------pop elemnet--------------");
            s.Pop();
            s.Pop();
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------");

            //Queue
            Queue<string> q = new Queue<string>();
            q.Enqueue("Satara");
            q.Enqueue("Solapur");
            q.Enqueue("Sangli");
            q.Enqueue("Surat");
            q.Enqueue("pune");

            Console.WriteLine("peek element in queue ="+q.Peek());
            foreach (var item in q)
            {
                Console.WriteLine( item);
            }

            Console.WriteLine("------------Dequeue element---------");
            q.Dequeue();
            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");
            //Dictionary
            Dictionary<int, Emp> emplist = new Dictionary<int, Emp>();
            emplist.Add(1, new Emp { Name = "ajay", Salary = 200, Designation = "SD" });
            emplist.Add(2, new Emp { Name = "Suraj", Salary = 300, Designation = "TE" });
            emplist.Add(7, new Emp { Name = "Sum", Salary = 500, Designation = "TMT" });
            emplist.Add(3, new Emp { Name = "Arc", Salary = 400, Designation = "SSD" });
            emplist.Add(5, new Emp { Name = "Arc", Salary = 400, Designation = "SSD" });

            foreach (var item in emplist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------Removed Employee------------");
            emplist.Remove(2);
            foreach (var item in emplist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");


            //SortedList
            SortedList<int, double> stlist = new SortedList<int, double>();
            stlist.Add(2, 87.89);
            stlist.Add(4, 67.67);
            stlist.Add(1, 75.67);
            stlist.Add(5, 45.89);
            stlist.Add(3, 80.34);

            Console.WriteLine("Student Count in sortedlist = "+stlist.Count);
            foreach (var stl in stlist)
            {
                Console.WriteLine(stl);
            }
            Console.WriteLine("---------Removed Student----------");
            stlist.Remove(4);
            stlist.Remove(1);

            foreach (var stl in stlist)
            {
                Console.WriteLine(stl);
            }

        }
    }
}
