using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MerchantCredit : ICreditBaseManager
    {
        public void Count()
        {
            Console.WriteLine("Merchant credit is accounted");
        }
    }
}
