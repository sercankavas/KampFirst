using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //ProductManager olan basliklarda urun ile alakali operasyonlar var demektir
    {
        public void Add(Product product)//-->encapsulation bu. parametre olarak bir urun cinsinden verdik,yani tek tek ad,fiyat, id
                    // filan demek yerine urunu tum ozellikleriyle iceren product classi cinsinden bi parameter veriyoruz. 
        {
            Console.WriteLine(product.ProductName + " added.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated.");

        }

        public int Topla(int sayi1, int sayi2) // bana topla fonksiyonunun degeri lazim ve 
            //ben bunu biyerde kullanacaksam void yerine tur deger kullanirim
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)  //voidi emir kipiyle yapilacak islerde kullanirim. methodun degerini kullanamam
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
