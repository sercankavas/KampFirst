using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void Apply(ICreditBaseManager creditBaseManager)
        {
            //kredi basvurusu
            //------------COK ONEMLI--------
            //eger BOYLE YAPARSAK TUM BASVURULARI MORGAGE KREDILERINE BAGIMLI HALE GETIRIRZ.
            //MorgageCredit morgage = new MorgageCredit();
            // morgage.Count();// BUNU ANLATTIKTAN SONRA METODA INTERFACE ILE PARAMETRE EKLEDI

            creditBaseManager.Count(); // BU YETERLI TUM KREDI CESTILERI ICIN


        }

        public void KrediOnBilgilendirmesiYap(List<ICreditBaseManager> credits)  //ayni veri turunde sinirsiz veriyi tasiyabilecek yapi nedir?-->List
        {
            foreach (var credi in credits)
            {
                credi.Count();
            }
        }
    }
}
