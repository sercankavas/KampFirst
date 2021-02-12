using StarbucksCRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksCRM.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer) //virtual yapinca ben bunun her dedigini yapmak zorunda degilim extend ettigim classlarda.
            // bunu yapmamin sebebi firmalarin biri mernis dogrulamasi istiyo digeri istemiyor. ama bi yandan da save metodlari ortak. 
        {
            Console.WriteLine("Saved to database: "+customer.FirstName);
        }
    }
}
