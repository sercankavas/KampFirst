using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            string categoryName = "Kategori";
            int numberOfStudent = 32000;
            bool systemAcceptance = false;

            double dolarYesterday = 7.35;
            double dolarToday = 7.45;

            if (dolarYesterday>dolarToday)
            {
                Console.WriteLine("Azalis ikonu");
            }
            else if (dolarToday>dolarYesterday)
            {
                Console.WriteLine("Artis ikonu");

            }
            else
            {
                Console.WriteLine("degismedi ikonu");

            }

            if (systemAcceptance==true)
            {
                Console.WriteLine("User system button");
            }
            else
            {
                Console.WriteLine("Login button");
            }

            
            Console.WriteLine(categoryName);
            Console.ReadLine();
        }
    }
}
