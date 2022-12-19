using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.GenericCollections
{
    class ProductL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Id}  {Name}  {Price}";
        }
    }
    class Product0
    {
       

        static void Main(string[] args)
        {
            List<ProductL> l = new List<ProductL>();
            l.Add(new ProductL { Id = 1, Name = "Comp", Price = 3000.00 });
            l.Add(new ProductL { Id = 2, Name = "Mouse", Price = 1000 });
            l.Add(new ProductL { Id = 3, Name = "BT", Price = 1500 });
            l.Add(new ProductL { Id = 4, Name = "mobile", Price = 5000 });

            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");

            foreach (var item in l)
            {
                if (item.Price < 2000)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
