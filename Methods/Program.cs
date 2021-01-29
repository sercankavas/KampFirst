using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pro1 = new Product();
            pro1.Name = "Elma";
            pro1.Price = 15;
            pro1.Description = "Amasya elmasi";


            Product pro2 = new Product();
            pro2.Name = "Karpuz";
            pro2.Price = 11;
            pro2.Description = "Diayrbakir karpuzu";

            Product[] pros = new Product[] {pro1,pro2};

            foreach (var pro in pros)
            {
                Console.WriteLine(pro.Name);
                Console.WriteLine(pro.Price);
                Console.WriteLine(pro.Description);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("-----Methods-----------");

            BasketManager basketmanager = new BasketManager();
            basketmanager.Add(pro1);
            basketmanager.Add(pro2);

            basketmanager.Add2("Armut", "Sari Armut", 12,8);
            basketmanager.Add2("Elma", "Sari elma", 12,8);
            basketmanager.Add2("Karpuz", "Diyarbakir", 12,8);

            
        }
    }
}
