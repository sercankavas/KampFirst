using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Gratla.Added to the basket: "+ product.Name);
        }

        public void Add2(string prodName,string proType,int price,int storageNum)
        {
            Console.WriteLine("Gratla.Added to the basket: " + prodName);
        }
    }
}
