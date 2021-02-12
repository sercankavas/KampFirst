using StarbucksCRM.Abstract;
using StarbucksCRM.Adapters;
using StarbucksCRM.Concrete;
using StarbucksCRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksCRM

    //USER STORY: Starbucks ve Nero firmalari CRM uygulamasi istiyor. Firmlar mustrilerini veri tabanina kaydetmek istiyorlar. 
    //starbucks mernis dogrulamasi istiyor. Nero istemiyor.
    //Starbucks musterileri icin her kahve aliminda yildiz kazandirmak istiyor.
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customer = new NeroCustomerManager(new MernisServiceAdapter());
            customer.Save(new Customer { DateOfBirth = new DateTime(1986, 11, 15), FirstName = "Sercan", LastName = "Kavas", NationalityId = "3633403026" });
            Console.ReadLine();
        }
    }
}
