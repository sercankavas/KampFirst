using System;

namespace AmazonProd
{
    class Program
    {
        static void Main(string[] args)
        {
            Products pro1 = new Products();
            Products pro2 = new Products();
            Products pro3 = new Products();

            pro1.prodName = "Damacana Pompasi";
            pro1.salesFigures = 1220;

            pro2.prodName = "Celik Termos";
            pro2.salesFigures = 1076;

            pro3.prodName = "Su aritma filtresi";
            pro3.salesFigures = 223;

            Products[] pros = new Products[] { pro1, pro2, pro3 };

            foreach (var item in pros)
            {
                Console.WriteLine(item.prodName + ": " + item.salesFigures);
            }


        }
        
        class Products
        {
            public string prodName { get; set; }
            public int salesFigures { get; set; }
        }
    }
}
