using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Category = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStok = 3;

            // ya da bunu bu sekilde de olusturabiliriz

            Product product2 = new Product { Id = 2, Category = 5, UnitsInStok = 5, 
                ProductName = "Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            


        }
    }
}
