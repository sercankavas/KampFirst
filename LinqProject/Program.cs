using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{ CategoryId=1, CategoryName="Computer"},
                new Category{ CategoryId=2, CategoryName="Phone"}
            };

            List<Product> products = new List<Product> 
            { 
                 new Product{ Id=1, ProdName="Asus", QuantityPerUnit="32 GB RAM", UnitPrice=1500, UnitsInStock=7, CategoryId=1},
                 new Product{ Id=2, ProdName="HP", QuantityPerUnit="128 GB RAM", UnitPrice=2500, UnitsInStock=4, CategoryId=1},
                 new Product{ Id=3, ProdName="Toshiba", QuantityPerUnit="32 GB RAM", UnitPrice=1300, UnitsInStock=7, CategoryId=1},
                 new Product{ Id=4, ProdName="IPhone", QuantityPerUnit="32 GB RAM", UnitPrice=1100, UnitsInStock=7, CategoryId=2},
                 new Product{ Id=5, ProdName="Samsung", QuantityPerUnit="32 GB RAM", UnitPrice=1700, UnitsInStock=7, CategoryId=2}

            };

            Console.WriteLine("AlgoritmikWay--------------");

            foreach (var prod in products)
            {
                if(prod.UnitPrice>1500 && prod.UnitsInStock > 3)
                {
                    Console.WriteLine(prod.ProdName + ":" + prod.UnitPrice);
                }
                
            }

            Console.WriteLine("Linq--------------");

            var result = products.Where(p => p.UnitPrice > 1500 && p.UnitsInStock > 3);

            foreach (var item in result)
            {
                Console.WriteLine(item.ProdName+":"+item.UnitPrice);
            }


            //dk  21
        }

        

        class Product
        {
            public int Id { get; set; }
            public int CategoryId { get; set; }
            public string ProdName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitsInStock { get; set; }
        }

        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }

        }
    }
}
