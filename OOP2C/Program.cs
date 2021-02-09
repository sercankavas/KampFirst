using System;

namespace OOP2C
{
    class Program
    {
        static void Main(string[] args)
        {
            IndiviuelCustomer customer1 = new IndiviuelCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Sercan";
            customer1.Surname = "Kavas";
            customer1.IdNo = "36334030";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "234567";
            customer2.CompanyName = "Smartly";
            customer2.TaxNumber = "54321";

            Customer customer3 = new IndiviuelCustomer();
            Customer customer4 = new CorporateCustomer();//Polymorphizm

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);// hepsini de parametre olarak yazabilirm cunku customer kendi childrenlari olan individuel ve corporate i refere edebilir icinde

            //gercek ve tuzel musteri olabilir. o yuzden iki class olusturacam. gercek ve tuzel diye
            //customer class i bir entity dir yani varliktir(icinde metod degil ozellik barindirir), ama customerManager bir operasyon classidir(methodlar vardir).
        }
    }
}
