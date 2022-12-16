using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ExtensionMethod
{
    class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quntity { get; set; }
        public double Price { get; set; }
    }
    class ExMethods
    {
        static void Main(string[] args)
        {

            //Book
            Books[] booklist = new Books[]
            {
                new Books{Id=201,Name="RadheSham",Price=745},
                new Books{Id=202,Name="Gokula",Price=987},
                new Books{Id=204,Name="Marathi",Price=200},
            };

            foreach (Books B in booklist)
            {
                Console.WriteLine($"{B.Id} {B.Name} {B.Price}");
            }

            Console.WriteLine("----------------------------------");
            //Product

            Product[] proList = new Product[]
            {
                new Product{Id=11,Name="Mouse",Quntity=56,Price=200},
                new Product{Id=12,Name="Tv",Quntity=10,Price=200},
                new Product{Id=13,Name="SetupBox",Quntity=10,Price=200},
                new Product{Id=14,Name="Mobile",Quntity=26,Price=200},
                new Product{Id=15,Name="Charger",Quntity=50,Price=200},
            };

            foreach (Product item in proList)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Quntity} {item.Price}");
            }

           
        }
    }
}
