using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NecessityCredit : ICreditBaseManager
    {
        public void Count()
        {
            Console.WriteLine("Necessity credit is accounted");
        }
    }
}
