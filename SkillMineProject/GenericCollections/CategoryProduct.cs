using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.GenericCollections
{
    public enum ProductType { Mobile, Furniture, Bottol}
    public class Productdetails
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
    public class Categorys
    {
        public int CatNo { get; set; }
       // public string CatName { get; set; }
        public ProductType ProductType;
        public List<Productdetails> plist = new List<Productdetails>();
    }
   
    class CategoryProduct
    {
        static void Main(string[] args)
        {
            List<Categorys> clist = new List<Categorys>()
            {
                new Categorys
                {
                    CatNo=76,
                    ProductType=ProductType.Mobile,
                    plist =
                    {
                        new Productdetails{ProductId=34, ProductName="Samsung", Price=41999},
                        new Productdetails{ ProductId=54, ProductName="Vivo", Price=21999},
                        new Productdetails{ ProductId=78, ProductName="iphone", Price=36799 }
                    }
                },
                new Categorys
                {
                    CatNo=1010,
                    ProductType=ProductType.Bottol,
                    plist =
                    {
                        new Productdetails{ ProductId=112, ProductName="thermax", Price=999},
                        new Productdetails{ ProductId=146, ProductName="oxyGrannd", Price=99},
                    }
                },
                new Categorys
                {
                    CatNo=1234,
                    ProductType=ProductType.Furniture,
                    plist =
                    {
                        new Productdetails{ ProductId=77, ProductName="Sofa", Price=25000},
                        new Productdetails{ ProductId=987, ProductName="study Table", Price=999},
                        new Productdetails{ ProductId=456, ProductName="chair", Price=499}
                    }
                }
            };
            foreach (Categorys ca in clist)
            {
                Console.WriteLine($"{ca.CatNo} {ca.ProductType}");
                foreach (var pl in ca.plist)
                {
                    Console.WriteLine($"\t {pl.ProductId} {pl.ProductName} {pl.Price}");
                }
            }
        }
    }
}
